using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    /// <summary>
    /// Acts as controller/bridge between model and credential system
    /// </summary>
    public class ServerController
    {
        public CheckCredsDel checkCreds; // Delegate

        public ServerModel LoginService { get; } // Property 

        public ServerController(ServerModel service) 
        {
            LoginService = service;
        }

        /// <summary>
        /// Calls checkCreds and sends response via LoginService
        /// </summary>
        /// <param name="user"> The user </param>
        /// <param name="pass"> The password </param>
        /// <param name="checkAdmin"> check for admin </param>
        /// <param name="createUser"> button to create a new user </param>
        public void HandleValidation(string user, string pass, bool checkAdmin, bool createUser) 
        {
            bool result = checkCreds(user, pass, checkAdmin, createUser);
            LoginService.sendResponse(result);
        }
    }
}
