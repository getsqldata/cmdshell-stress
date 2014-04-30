cmdshell-stress
===============

Stress test SQL Server instances for concurrent `xp_cmdshell` execution.

Executes the following command 100 times per connection string. Logs non-zero return values and .NET exceptions.

```
ping -n 15 127.0.0.1 > NUL
```
