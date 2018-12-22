using Lab3.LoginSample.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.LoginSample.Services
{
    public class AuthenticationService
    {
        public bool IsValid(string account, string password, string captcha)
        {
            // 根據 account 取得密碼'
            var profileDao = new ProfileDao();
            var passwordFromDao = profileDao.GetPassword(account);

            // 取得驗證碼
            var captchaDao = new CaptchaDao();
            var captchaFromDao = captchaDao.GetLastCaptcha();

            return password == passwordFromDao && captcha == captchaFromDao;
        }
    }
}