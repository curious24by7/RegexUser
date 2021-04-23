using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidatePassword
{
    class PasswordPattern
    {
        string RegexPass = "^([a-z]+[A-Z]+[0-9]+[!@#$%^&*]{1}){8,}$";

        public bool validatePassword(string pass)
        {
            return Regex.IsMatch(pass, RegexPass);
        }
    }
}
