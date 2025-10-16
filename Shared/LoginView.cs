using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shared
{
    /// <summary>
    /// LoginView is the GUI layer.
    /// Receives controller instructions via HandleUpdateUI.
    /// Sends user actions to the controller via input delegate.
    /// </summary>
    public partial class LoginView : Form
    {
        public InputDel input; // Delegate to pass user input to controller

        public LoginView()
        {
            InitializeComponent(); // Sets up the UI elements
        }

        // Updates the UI depending on the current state
        public void HandleUpdateUI(State state)
        {
            switch (state)
            {
                case State.START:
                    StatusLb.Text = "Enter Username";
                    PasswordTb.Enabled = false;
                    LoginBtn.Enabled = false;
                    break;

                case State.GOTUSERNAME:
                    StatusLb.Text = "Enter Password";
                    PasswordTb.Enabled = true;
                    break;

                case State.GOTPASSWORD:
                    StatusLb.Text = "Validating";
                    break;

                case State.DECLINED:
                    this.Invoke(new Action(() =>
                    {
                        UserTb.Text = "";
                        PasswordTb.Text = "";
                        StatusLb.Text = "Invalid Creds";
                    }));
                    break;

                case State.SUCCESS:
                    this.Invoke(new Action(() =>
                    {
                        UserTb.Text = "";
                        PasswordTb.Text = "";
                        StatusLb.Text = "Success";
                    }));
                    break;

                default:
                    StatusLb.Text = "Error";
                    break;
            }
        }

        // Event when Login button is clicked
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string user = UserTb.Text;
            string pass = PasswordTb.Text;
            string checkAdmin = Convert.ToString(AdminCb.Checked);
            string msg = user + ":" + pass + ":" + checkAdmin + ":false";

            input(State.SUBMIT, msg);
        }

        // Event when Create User button is clicked
        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            string user = UserTb.Text;
            string pass = PasswordTb.Text;
            string checkAdmin = Convert.ToString(AdminCb.Checked);
            string msg = user + ":" + pass + ":" + checkAdmin + ":true";

            input(State.CREATEUSER, msg);
        }

        // Event when username text changes
        private void UserTb_TextChanged(object sender, EventArgs e)
        {
            input(State.GOTUSERNAME, "");
        }

        // Event when password text changes
        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {
            LoginBtn.Enabled = true;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            input(State.START, ""); // Initialize UI when form is shown
        }
    }
}
