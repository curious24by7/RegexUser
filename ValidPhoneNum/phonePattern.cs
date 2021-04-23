using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidPhoneNum
{
    class phonePattern
    {
        string RegexNum = "^[9]{1}[1]{1}[ ]{1}[0-9]{10}$";

        public bool validatePhoneNumber(string num)
        {
            return Regex.IsMatch(num, RegexNum);
        }
    }
}
