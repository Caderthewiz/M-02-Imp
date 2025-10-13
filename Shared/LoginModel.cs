using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace Shared
{
    /// <summary>
    /// LoginModel is the data/network layer.
    /// It communicates with the server via WebSocket.
    /// Uses loginResult delegate to notify the controller when the server responds.
    /// </summary>
    public class LoginModel
    {
        private WebSocket ws; // WebSocket for server communication
        public LoginResultDel loginResult; // Delegate to notify login outcome

        public LoginModel()
        {
            ws = ws = new WebSocket(""); // Connect to server (URL should be provided) ... URL?
            ws.OnMessage += MsgFromServer; // Attach message handler
            ws.Connect(); // Connect to server
        }

        // Sends login info to the server for validation
        public void HandleValidateLoginInfo(string msg)
        {
            ws.Send(msg);
        }

        // Handles incoming messages from the server
        public void MsgFromServer(object sender, MessageEventArgs e)
        {
            if (e.Data.Equals("VALID"))
            {
                loginResult(State.SUCCESS); // Notify controller of successful login
            }
            else
            {
                loginResult(State.DECLINED); // Notify controller of failed login
            }
        }
        
        // Closes the WebSocket connection
        public void Close()
        {
            ws.Close();
        }
    }
}
