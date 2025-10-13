using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared
{
    public delegate void InputDel(State state, string msg);
    public delegate void UpdateUIDel(State state);
    public delegate void ValidateLoginInfoDel(string cred);
    public delegate void LoginResultDel(State state);

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

            LoginModel lModel = new LoginModel();
            LoginController lController = new LoginController();
            LoginView lView = new LoginView();

            lModel.loginResult = lController.HandleLoginResult;
            lController.validateLoginInfo = lModel.HandleValidateLoginInfo;
            lController.updateUI = lView.HandleUpdateUI;
            lView.input = lController.HandleInput;

            Application.Run(lView);
        }
    }
}
