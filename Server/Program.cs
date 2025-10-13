using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp.Server;

namespace Server
{
    public delegate void ValidateCredsDel(string user, string password, bool checkAdmin, bool createUser);
    public delegate bool CheckCredsDel(string user, string password, bool checkAdmin, bool createUser);

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ServerModel sModel = new ServerModel();
            ServerController sController = new ServerController(sModel);
            CredentialsM credentialsM = new CredentialsM();

            sModel.validateCreds = sController.HandleValidation;
            sController.checkCreds = credentialsM.HandleCredsCheck;

            WebSocketServer wss = new WebSocketServer("");
            wss.Start();

            Application.Run(new ServerView());
            wss.Stop();
        }
    }
}
