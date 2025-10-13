using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared
{
    public delegate void InputDel(State state, string msg); // For sending user input to controller
    public delegate void UpdateUIDel(State state);          // For controller to update UI
    public delegate void ValidateLoginInfoDel(string cred); // For controller to send credentials to model
    public delegate void LoginResultDel(State state);       // For model to notify controller of login result

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

            // Instantiate shared MVC components
            LoginModel lModel = new LoginModel();
            LoginController lController = new LoginController();
            LoginView lView = new LoginView();

            // Hook up delegates
            lModel.loginResult = lController.HandleLoginResult;             // Model notifies controller
            lController.validateLoginInfo = lModel.HandleValidateLoginInfo; // Controller sends creds to model
            lController.updateUI = lView.HandleUpdateUI;                    // Controller updates UI
            lView.input = lController.HandleInput;                          // View sends input to controller

            Application.Run(lView); // Start GUI
        }
    }
}
