
using System;

namespace Menushell.View
{
    class AdministratorMainView : ConsoleView
    {
        public AdministratorMainView() : base("administratormainview", "Administrator Main View")
        {

        }

        public void Display()
        {
            var administratorMainView = new AdministratorMainView();
            bool hasNotExit = true;

            do
            {
                Console.Clear();

                Console.WriteLine("[1] Something");
                Console.WriteLine("[2] Exit.");

                var consoleKeyInfo = Console.ReadKey(true);

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("D1");
                        break;

                    case ConsoleKey.D2:
                        hasNotExit = false;
                        break;
                }

            } while (hasNotExit);
        }
    }
}
