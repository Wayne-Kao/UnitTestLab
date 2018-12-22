using Lab3.LoginSample.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.LoginSample.DataAccess
{
    public class CaptchaDao
    {
        public string GetRandom()
        {
            var seed = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            var result = seed.Next(0, 999999).ToString("000000");
            SimpleContent.Captcha = result;
            return result;
        }

        public string GetLastCaptcha()
        {
            if (string.IsNullOrEmpty(SimpleContent.Captcha))
            {
                return GetRandom();
            }
            else
            {
                return SimpleContent.Captcha;
            }
        }
    }
}