using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServerController
    {
        public CheckCredsDel checkCreds;

        public ServerModel LoginService { get; }

        public ServerController(ServerModel service) 
        {
            LoginService = service;
        }

        public void HandleValidation(string user, string pass, bool checkAdmin, bool createUser) 
        {
            bool result = checkCreds(user, pass, checkAdmin, createUser);
            LoginService.sendResponse(result);
        }
    }
}
