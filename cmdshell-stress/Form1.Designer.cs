namespace cmdshell_stress
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnJoinAll = new System.Windows.Forms.Button();
            this.btnKillAll = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnectionStrings = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1131, 800);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSalmon;
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.btnJoinAll);
            this.tabPage1.Controls.Add(this.btnKillAll);
            this.tabPage1.Controls.Add(this.btnExecute);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lstResults);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtConnectionStrings);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1123, 762);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parameters";
            // 
            // btnJoinAll
            // 
            this.btnJoinAll.Location = new System.Drawing.Point(701, 166);
            this.btnJoinAll.Name = "btnJoinAll";
            this.btnJoinAll.Size = new System.Drawing.Size(190, 57);
            this.btnJoinAll.TabIndex = 6;
            this.btnJoinAll.Text = "Join All Threads";
            this.btnJoinAll.UseVisualStyleBackColor = true;
            this.btnJoinAll.Click += new System.EventHandler(this.btnJoinAll_Click);
            // 
            // btnKillAll
            // 
            this.btnKillAll.Location = new System.Drawing.Point(897, 166);
            this.btnKillAll.Name = "btnKillAll";
            this.btnKillAll.Size = new System.Drawing.Size(190, 57);
            this.btnKillAll.TabIndex = 5;
            this.btnKillAll.Text = "Kill All Threads";
            this.btnKillAll.UseVisualStyleBackColor = true;
            this.btnKillAll.Click += new System.EventHandler(this.btnKillAll_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(460, 166);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(190, 57);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Results:";
            // 
            // lstResults
            // 
            this.lstResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResults.FormattingEnabled = true;
            this.lstResults.HorizontalScrollbar = true;
            this.lstResults.ItemHeight = 25;
            this.lstResults.Location = new System.Drawing.Point(36, 275);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(1051, 479);
            this.lstResults.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection strings, one per line:";
            // 
            // txtConnectionStrings
            // 
            this.txtConnectionStrings.Location = new System.Drawing.Point(36, 42);
            this.txtConnectionStrings.Multiline = true;
            this.txtConnectionStrings.Name = "txtConnectionStrings";
            this.txtConnectionStrings.Size = new System.Drawing.Size(1051, 108);
            this.txtConnectionStrings.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(714, 7);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(373, 25);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/krk/cmdshell-stress";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1131, 800);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CMDSHELL STRESS";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnectionStrings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnKillAll;
        private System.Windows.Forms.Button btnJoinAll;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

