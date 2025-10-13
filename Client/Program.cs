using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public delegate void HandleInput(State state, string msg);

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

            ClientModel cm = new ClientModel();
            ClientController cc = new ClientController();
            CLientView cv = new CLientView();



            Application.Run(cv);
        }
    }
}
