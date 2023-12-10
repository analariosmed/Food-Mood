using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Mood
{
    public class User
    {
        private string name;
        private string password;
        private string email;

        public User() { }

        public User (string user, string password)
        {
            this.name = user;
            this.password = password;
            //this.email = email;
        }

        public User(string name, string password, string email) : this(name, password)
        {
            Email = email;
        }

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
    }
}
