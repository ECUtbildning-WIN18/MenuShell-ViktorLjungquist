using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Xml.Linq;
using Menushell.Domain;
using Menushell.Interfaces;

namespace Menushell.View
{
    class LoginView : ConsoleView
    {
        public LoginView() : base("loginview", "Login")
        {

        }

        public User Display()
        {
            bool loginSucceeded = false;

            User user;

            do
            {
                Console.Clear();
                Console.WriteLine("Please login.\n\n");

                Console.Write("Username: ");
                var username = Console.ReadLine();

                Console.Write("Password: ");
                var password = Console.ReadLine();

                var authenticationService = new AuthentificationService();

                user = authenticationService.Authenticate(username, password);

                Console.WriteLine("\nIs this correct? [Y]es [N]o");

                var keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Y)
                {
                    if (user == null)
                    {
                        Console.WriteLine("Wrong! Try again.");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        loginSucceeded = true;
                    }
                }

            } while (!loginSucceeded);

            return user;
        }

        static User Authenticate(string username, string password)
        {
            User user = null;

            var users = LoadUsers();

            return users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }

        static IList<User> LoadUsers()
        {
            var users = new List<User>();
            var doc = XDocument.Load("Users.xml");
            var root = doc.Root;

            foreach (var element in root.Elements())
            {
                var username = element.Attribute("username").Value;
                var password = element.Attribute("password").Value;
                var role = element.Attribute("role").Value;

                // TODO: Chagne this
                users.Add(new User(username, password, Role.Receptionst));
            }
            return users;
        }
    }
}
