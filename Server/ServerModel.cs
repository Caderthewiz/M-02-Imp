using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Server
{
    public class ServerModel : WebSocketBehavior
    {
        public ValidateCredsDel validateCreds;

        protected override void OnMessage(MessageEventArgs e)
        {
            string[] tokens = e.Data.Split(':');
            string user = tokens[0];
            string pass = tokens[1];
            bool checkAdmin = Convert.ToBoolean(tokens[2]);
            bool createUser = Convert.ToBoolean(tokens[3]);

            Console.WriteLine(user + " " + pass + " " + tokens[2] + " " + tokens[3]);

            //Handle credentials CredDel
            validateCreds(user, pass, checkAdmin, createUser);
        }

        public void sendResponse(bool result) 
        {
            if (result)
            {
                Send("VALID");
            }
            else
            {
                Send("INVALID");
            }
        }
    }
}
