using System;
using Menushell.Domain;
using Menushell.View;

namespace Menushell
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tabort efter push
            var loginView = new LoginView();
            var receptionistMainView = new ReceptionistMainView();
            var administratiorMainView = new AdministratorMainView();

            var user = loginView.Display();

            if (user.Role == Role.Receptionst)
            {
                receptionistMainView.Display();
            }
            else if (user.Role == Role.Administrator)
            {
                administratiorMainView.Display();
            }
            else if (user.Role == Role.Veterinary)
            {
                //veterinaryMainView.Display();
            }

            //if (result == "1")
            //{
            //    registerNewCustomer.Display();
            //}
            //else if (result == "2")
            //{
            //    searchCustomerView.Display();
            //}
            //else if (result == "3")
            //{
            //    Environment.Exit(0);
            //}
        }
    }
}
