using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsApp1.Controlls
{
    public static class CorrectData
    {
        public static bool IsStrongPassword(string password)
        {
            if (IsPasswordValid(password))
            {
                // Перевірка чи пароль містить хоча б одну цифру, одну велику літеру та один спеціальний символ
                return Regex.IsMatch(password, @"^(?=.*\d)(?=.*[A-Z])(?=.*[!@#$%^&*()_+])[0-9a-zA-Z!@#$%^&*()_+]+$");
            }
            else
            {
                return false;
            }
        }
        private static bool IsPasswordValid(string password)
        {
            // Перевірка довжини пароля
            return password.Length >= 6 && password.Length <= 12;
        }
    }
}
