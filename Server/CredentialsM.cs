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

    /// <summary>
    /// Stores credentials (List<User>) and reads/writes JSON
    /// </summary>
    public class CredentialsM
    {
        private List<User> users;
        private string filePath = "credentials.json";

        public CredentialsM() 
        {
            LoadCredentials();
        }

        /// <summary>
        /// Main method for handling login and user creation
        /// </summary>
        /// <param name="user"> user to be added to list </param>
        /// <param name="pass"> the password to be added to list </param>
        /// <param name="checkAdmin"> bool check for if admin </param>
        /// <param name="createUser"> creates a user instead of logging in </param>
        /// <returns> It either checks if a user’s credentials are valid or creates a new user </returns>
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

        /// <summary>
        /// Loads the list of users from a JSON file (credentials.json) when the app starts
        /// </summary>
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

        /// <summary>
        /// Saves the current users list to credentials.json
        /// </summary>
        private void WriteCredentials()
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
