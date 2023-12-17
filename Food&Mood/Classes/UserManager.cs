using System;
using System.Collections.Generic;
using System.IO;


namespace Food_Mood.Classes
{
    public static class UserManager
    {
        public static User CurrentUser { get; set; }

        private static List<User> users = new List<User>();
        public static List<User> Users { get { return users; } }

        public static void addUser(User user)
        {
            Users.Add(user);
        }
        //save users to the file
        public static void saveUsers()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string filePath = Path.Combine(baseDirectory, "Resources\\Users.txt");

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (User user in Users)
                {
                    writer.WriteLine(user.Name);
                    writer.WriteLine(user.Password);
                    writer.WriteLine(user.Email);

                }
            }
        }
        //load the users from file to use then on the login feature
        public static void loadUsers()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string filePath = Path.Combine(baseDirectory, "Resources\\Users.txt");

            if (File.Exists(filePath))
            {

                using (var reader = new StreamReader(filePath))
                {
                    do
                    {
                        var name = reader.ReadLine();
                        var password = reader.ReadLine();
                        var email = reader.ReadLine();
                        addUser(new User(name, password, email));
                    } while (!reader.EndOfStream);
                }

            }
        }
    }
}
