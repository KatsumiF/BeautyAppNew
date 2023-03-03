using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace CheckStringLib
{
    [TestClass]
    public class CheckStringClass
    {
        /// <summary>
        /// библиотека тестирования полей регистрации
        /// <param name="email"> строка email</param>
        /// <returns>
        /// True - если email корректный
        /// False - если email не корректный
        /// </returns>
        /// </summary>
        [TestMethod]
        public static bool CheckEmail(string email)
        
        {
            string regex = "^[a-zA-Z0-9]\\@[a-zA-Z]+\\.[a-zA-Z]{2,3}$";
            if (Regex.IsMatch(email,regex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// библиотека тестирования номера телефона
        /// <param name="phone"> строка телефона</param>
        /// <returns>
        /// True - если номер корректный
        /// False - если номер не корректный
        /// </returns>
        /// </summary>
        public static bool CheckPhone(string phone)

        {
            string regex = "^[(+7)|(8)\\d{10}$]";
            if (Regex.IsMatch(phone, regex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckOtch(string otch)

        {
            string regex = @"^[а-яА-Я]{2,}$";
            if (Regex.IsMatch(otch, regex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
