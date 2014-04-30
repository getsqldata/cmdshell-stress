using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cmdshell_stress
{
    public partial class Form1 : Form
    {
        private readonly List<Thread> _threads = new List<Thread>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            // Start a thread for each connection string.
            var connstrs = GetConnectionStrings().ToList();

            LogResult("Connection Strings: " + connstrs.Count);

            foreach (var connstr in connstrs)
            {
                for (int i = 0; i < 100; i++)
                {
                    StartNewThread(connstr);
                }
            }
        }

        private void StartNewThread(object data)
        {
            var t = new Thread(ExecuteOneStressTest);
            _threads.Add(t);
            t.Start(data);
        }

        private void KillAllThreads()
        {
            while (_threads.Count > 0)
            {
                var t = _threads[0];

                if (t.IsAlive)
                {
                    t.IsBackground = true;
                    t.Abort();
                }

                _threads.RemoveAt(0);
            }
        }

        private void JoinAllThreads()
        {
            _threads.All(t =>
            {
                t.Join();
                return true;
            });
        }

        private void ExecuteOneStressTest(object data)
        {
            const string cmdText = "master..xp_cmdshell";
            var connStr = (string)data;

            try
            {
                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    using (var cmd = new SqlCommand(cmdText, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("command_string", "ping -n 15 127.0.0.1 > NUL");

                        var retParam = new SqlParameter("@ret", SqlDbType.Int);
                        retParam.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(retParam);

                        cmd.ExecuteNonQuery();

                        var retInt = Convert.ToInt32(retParam.Value);

                        if (retInt != 0)
                        {
                            string hex = "0x" + retInt.ToString("X");

                            LogResult("ret: " + hex + " - " + connStr);
                        }

                        // success is not logged.
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                LogResult(connStr + " " + ex.ToString());
            }
        }

        private IEnumerable<string> GetConnectionStrings()
        {
            var ret = txtConnectionStrings.Text
                .Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            return ret;
        }

        private void LogResult(string text)
        {
            var logtext = DateTime.Now.ToString("s") + " - " + text;

            if (lstResults.InvokeRequired)
            {
                lstResults.Invoke((MethodInvoker)(() => lstResults.Items.Add(logtext)));
            }
            else
            {
                lstResults.Items.Add(logtext);
            }
        }

        private void btnKillAll_Click(object sender, EventArgs e)
        {
            KillAllThreads();
        }

        private void btnJoinAll_Click(object sender, EventArgs e)
        {
            JoinAllThreads();

            LogResult("All threads finished.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/krk/cmdshell-stress");
        }
    }
}
