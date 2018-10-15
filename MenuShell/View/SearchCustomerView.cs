using System;

namespace Menushell.View
{
    class SearchCustomerView : ConsoleView
    {
        public SearchCustomerView() : base("searchcustomerview", "Search customer view")
        {
 
        }

        public void Display()
        {
            Console.WriteLine("Search customer...");

            Console.ReadKey();
        }
    }
}
