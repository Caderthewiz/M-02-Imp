using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Server
{
    //Refactor to use JSON for credentials storage
    public class CredentialsM
    {
        private List<User> users;
        private string filePath = "credentials.json";

        public CredentialsM() 
        {
            LoadCredentials();
        }

        public bool HandleCredsCheck(string user, string pass, bool checkAdmin, bool createUser) 
        {
            if (createUser) 
            {
                users.Add(new User(user, pass, checkAdmin));
                WriteCredentials();
            }

            foreach (User u in users)
            {
                if (checkAdmin)
                {
                    if (u.Username.Equals(user) && u.Password.Equals(pass) && u.IsAdmin) { return true; }
                }
                else 
                {
                    if (u.Username.Equals(user) && u.Password.Equals(pass)) { return true; }
                }
            }
            return false;
        }

        private void LoadCredentials() 
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
            }
            else
            {
                users = new List<User>();
            }
        }

        private void WriteCredentials()
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
