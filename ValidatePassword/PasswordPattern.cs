using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidatePassword
{
    class PasswordPattern
    {
        string RegexPass = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";

        public bool validatePassword(string pass)
        {
            return Regex.IsMatch(pass, RegexPass);
        }
    }
}
