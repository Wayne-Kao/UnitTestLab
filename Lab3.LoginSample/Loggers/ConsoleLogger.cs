using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Lab3.LoginSample.Loggers
{
    public class ConsoleLogger
    {
        public void Save(string content)
        {
            Debug.WriteLine(content);
        }
    }
}