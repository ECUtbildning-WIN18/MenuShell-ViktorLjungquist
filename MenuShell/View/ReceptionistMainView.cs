using System;

namespace Menushell.View
{
    class ReceptionistMainView : ConsoleView
    {

        public ReceptionistMainView() : base("receptionistmainview", "Receptionst Main View")
        {
 
        }

        public void Display()
        {
            var receptionistMainView = new ReceptionistMainView();
            bool hasNotExit = true;

            do
            {
                Console.Clear();

                Console.WriteLine("[1] Register new customer.");
                Console.WriteLine("[2] Search customer.");
                Console.WriteLine("[3] Exit.");

                var consoleKeyInfo = Console.ReadKey(true);

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.D1:

                        var currentView = new RegisterNewCustomer();
                        
                        currentView.Display();
                        
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine("D2");
                        break;
                    
                    case ConsoleKey.D3:
                        hasNotExit = false;
                        break;
                }

            } while (hasNotExit);
        }
    }
}
