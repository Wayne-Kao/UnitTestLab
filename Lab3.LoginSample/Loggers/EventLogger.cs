using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Lab3.LoginSample.Loggers
{
    public class EventLogger
    {
        public void Save(string content)
        {
            try
            {
                if (!EventLog.SourceExists("MyLogin"))
                {
                    EventLog.CreateEventSource("MyLogin", "LoginLog");
                }

                // Create an EventLog instance and assign its source.
                EventLog myLog = new EventLog();
                myLog.Source = "MyLogin";

                // Write an informational entry to the event log.    
                myLog.WriteEntry(content);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}