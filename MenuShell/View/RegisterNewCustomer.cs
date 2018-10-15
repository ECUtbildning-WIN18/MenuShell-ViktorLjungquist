using System;

namespace Menushell.View
{
    class RegisterNewCustomer : ConsoleView
    {
        public RegisterNewCustomer() : base("registernewcustomer", "Register new customer")
        {
 
        }


        public void Display()
        {
            bool notSufficientInformation = true;

            do
            {
                Console.Clear();

                Console.WriteLine("First name: ");
                string firstName = Console.ReadLine();

                Console.WriteLine("Last name: ");
                string lastName = Console.ReadLine();

                Console.WriteLine("SSN: ");
                string socialSecurityNumber = Console.ReadLine();

                Console.WriteLine("Is this correct? [Y]es [N]o");


                var consoleKeyInfo = Console.ReadKey(true);

                if (consoleKeyInfo.Key == ConsoleKey.Y)
                {
                    notSufficientInformation = false;
                }
                else
                {
                    Console.WriteLine("Please try again.");
                }

            } while (notSufficientInformation);
        }
    }
}
