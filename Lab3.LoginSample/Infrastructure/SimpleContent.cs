using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.LoginSample.Infrastructure
{
    public static class SimpleContent
    {
        public static Dictionary<string, string> Profiles;
        public static string Captcha;

        static SimpleContent()
        {
            Profiles = new Dictionary<string, string>
            {
                { "wayne", "1234" }
            };
        }

        public static string GetPassword(string key)
        {
            if (Profiles.ContainsKey(key))
            {
                return Profiles[key];
            }
            else
            {
                return null;
            }
        }
    }
}