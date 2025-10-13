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
    /// <summary>
    /// Inherits WebSocketBehavior 
    /// </summary>
    public class ServerModel : WebSocketBehavior
    {
        public ValidateCredsDel validateCreds; // Delegate

        /// <summary>
        /// Overrides OnMessage to parse login request 
        /// </summary>
        /// <param name="e"> Event </param>
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

        /// <summary>
        /// Sends out the Valid or Invalid messages
        /// </summary>
        /// <param name="result"> Is the thing were checking for to see if login correct </param>
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
