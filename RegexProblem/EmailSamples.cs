﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class EmailSamples
    {
        public static string REGEX_VALIDEMAIL = "^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$";

        //public bool validateValidEmail(string validemail)
        //{
        //    return Regex.IsMatch(validemail, REGEX_VALIDEMAIL);
        //}
        public bool ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, REGEX_VALIDEMAIL))
            {
                Console.WriteLine("Email is valid");
                return true;
            }
            else
            {
                Console.WriteLine("Email is invalid");
                return false;
            }
        }
    }
}
