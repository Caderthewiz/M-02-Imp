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

namespace Client
{
    public partial class CLientView : Form
    {
        public HandleInput handleInput;

        public CLientView()
        {
            InitializeComponent();
        }

        public void HandleViewState(State state)
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
                        StatusLb.Text = "Invalid";
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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            String user = UserTb.Text;
            String pass = PasswordTb.Text;
            handleInput(State.SUBMIT, user + ":" + pass);
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            handleInput(State.GOTUSERNAME, "");
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            LoginBtn.Enabled = true;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            handleInput(State.START, "");
        }
    }
}
