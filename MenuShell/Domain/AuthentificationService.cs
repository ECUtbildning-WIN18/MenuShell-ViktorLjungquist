using System.Collections.Generic;
using System.Linq;
using Menushell.Domain;
using Menushell.View;

namespace Menushell.Interfaces
{
    class AuthentificationService
    {
        public User Authenticate(string username, string password)
        {
            var userLoader = new UserLoader();
            var users = userLoader.LoadUsers();
            return users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
    }
}