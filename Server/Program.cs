using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp.Server;

namespace Server
{
    public delegate void ValidateCredsDel(string user, string password, bool checkAdmin, bool createUser); // Delegate 
    public delegate bool CheckCredsDel(string user, string password, bool checkAdmin, bool createUser); // Delegate

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

            /*ServerModel sModel = new ServerModel();
            ServerController sController = new ServerController(sModel);
            CredentialsM credentialsM = new CredentialsM();

            sModel.validateCreds = sController.HandleValidation;
            sController.checkCreds = credentialsM.HandleCredsCheck;*/

            var credentialsM = new CredentialsM();

            WebSocketServer wss = new WebSocketServer("ws://127.0.0.1:8080");
            wss.AddWebSocketService<ServerModel>("/login", svc =>
            {
                var controller = new ServerController(svc);
                svc.validateCreds = controller.HandleValidation;
                controller.checkCreds = credentialsM.HandleCredsCheck;
            });
            wss.Start();

            Application.Run(new ServerView());
            wss.Stop();
        }
    }
}
