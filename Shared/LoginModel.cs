using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace Shared
{
    public class LoginModel
    {
        private WebSocket ws;
        public LoginResultDel loginResult;

        public LoginModel()
        {
            ws = ws = new WebSocket(""); //URL?
            ws.OnMessage += MsgFromServer;
            ws.Connect();
        }

        public void HandleValidateLoginInfo(string msg)
        {
            ws.Send(msg);
        }

        public void MsgFromServer(object sender, MessageEventArgs e)
        {
            if (e.Data.Equals("VALID"))
            {
                loginResult(State.SUCCESS);
            }
            else
            {
                loginResult(State.DECLINED);
            }
        }

        public void Close()
        {
            ws.Close();
        }
    }
}
