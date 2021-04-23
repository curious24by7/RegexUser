using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC9Emails
{
    class RegexPattern
    {
        string RegexEmail = "^[a-z0-9A-Z]+([+.-@][a-zA-Z0-9]+)?[@][a-zA-Z0-9]+[.][a-zA-Z]{3}([.][a-zA-Z]{2,2})?$";

        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, RegexEmail);
        }
    }
}
