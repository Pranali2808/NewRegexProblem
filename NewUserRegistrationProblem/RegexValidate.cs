using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NewUserRegistrationProblem
{
    class RegexValidate
    {
        public static string Regex_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        public static string Regex_LastName = "^[A-Z]{1}[a-z]{2,}$";
        public bool ValidateFirstName(string first)
        {
            return Regex.IsMatch(first, Regex_FirstName);
        }
        public bool ValidateLastName(string last)
        {
            return Regex.IsMatch(last, Regex_LastName);
        }
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid.");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
    }
}