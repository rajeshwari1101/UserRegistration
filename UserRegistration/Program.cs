using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To User Registration===========");
            //Creating object od class
            UserRegistration registration = new UserRegistration();
            registration.FirstName();
            registration.LastName();
            registration.EmailId();
            registration.MobileNumber();
            registration.Password();
            Console.ReadKey();
        }

    }
}