using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class LoginController
    {
        public ValidateLoginInfoDel validateLoginInfo;
        public UpdateUIDel updateUI;

        public LoginController() { }

        public void HandleInput(State state, string msg)
        {
            switch (state)
            {
                case State.START:
                    updateUI(State.START);
                    break;

                case State.GOTUSERNAME:
                    updateUI(State.GOTUSERNAME);
                    break;

                case State.GOTPASSWORD:
                    updateUI(State.GOTPASSWORD);
                    break;

                case State.SUCCESS:
                    validateLoginInfo(msg);
                    break;

                case State.CREATEUSER:
                    validateLoginInfo(msg);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(state), state, null);
            }
        }

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
