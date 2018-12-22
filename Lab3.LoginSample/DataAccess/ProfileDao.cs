using Lab3.LoginSample.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.LoginSample.DataAccess
{
    public class ProfileDao
    {
        public string GetPassword(string account)
        {
            var result = SimpleContent.GetPassword(account);
            return result;
        }
    }
}