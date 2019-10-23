using System;

namespace NestedIfs
{
    class MainClass
    {

        static string userName;
        static string password;


        public static void Main(string[] args)
        {

            Register();
            Login();

            Console.Read();


        }

        public static void Register()
        {

            Console.WriteLine("Please register by entering a username");
            userName = Console.ReadLine();
            Console.WriteLine("Please entere a password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("---------------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");

            if(userName == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login failed.  Wrong Password. Restart program.");
                }
            }
            else
            {
                Console.WriteLine("Login failed.  Wrong Username. Restart program.");
            }
        }
    }
}
