using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewUserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expressions");
            RegexValidate validateUser = new RegexValidate();
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            bool fNameResult = validateUser.ValidateFirstName(firstName);
            validateUser.PrintResult(fNameResult);
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            bool lNameResult = validateUser.ValidateLastName(lastName);
            validateUser.PrintResult(lNameResult);
            Console.WriteLine("Enter your email id: ");
            string eMailId = Console.ReadLine();
            bool emailResult = validateUser.ValidateEmail(eMailId);
            validateUser.PrintResult(emailResult);
            Console.ReadLine();
        }
    }
}
