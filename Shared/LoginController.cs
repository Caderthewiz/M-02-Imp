using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// LoginController is the logic layer connecting user input from the LoginView to validation in LoginModel
    /// It uses delegates so it doesn’t directly know about the other classes’ implementation
    /// </summary>
    public class LoginController
    {
        // Delegates for updating the UI and validating login info
        public ValidateLoginInfoDel validateLoginInfo;
        public UpdateUIDel updateUI;

        public LoginController() { }

        // Handles user input and routes actions based on current login state
        public void HandleInput(State state, string msg)
        {
            switch (state)
            {
                case State.START:
                    updateUI(State.START); // Update UI to prompt for username
                    break;

                case State.GOTUSERNAME:
                    updateUI(State.GOTUSERNAME); // Update UI to prompt for password
                    break;

                case State.GOTPASSWORD:
                    updateUI(State.GOTPASSWORD); // Update UI to show validating message
                    break;

                case State.SUCCESS:
                    validateLoginInfo(msg); // Send credentials to be validated
                    break;

                case State.CREATEUSER:
                    validateLoginInfo(msg); // Send new user info to create account
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(state), state, null);
            }
        }

        // Handles the result from the login process
        public void HandleLoginResult(State state)
        {
            switch (state)
            {
                case State.SUCCESS:
                    updateUI(State.SUCCESS);
                    break;

                case State.DECLINED:
                    updateUI(State.DECLINED);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(state), state, null);
            }
        }
    }
}
