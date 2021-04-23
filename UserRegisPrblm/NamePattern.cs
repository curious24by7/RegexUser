using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegisPrblm
{
    class FirstNamePattern
    {
        string regexName = "^[A-Z]{1}[a-z]{2,}$";

        public bool validateName(string firstname)
        {
            return Regex.IsMatch(firstname, regexName);
        }
    }
}
