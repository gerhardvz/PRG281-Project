using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Project_1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.tbUsername.Clear();
            this.tbPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User(this.tbUsername.Text, this.tbPassword.Text);
            if (user.authenticate() && Program.users.Count < 2)
            {
                Program.users.Add(user);
            }
            else
                {
                    this.lblError.Text = "Invalid Login. Please try again.";
                    this.btnReset_Click(sender, e);
                    return;
                }

            if (Program.isMultiplayer && Program.users.Count<2)
            {
                this.btnReset_Click(sender, e);
                this.lblLoginText.Text = "Player Two Login:";
                this.tbUsername.Focus();

            }
            else
            {
                String result = "";
                foreach (User uuser in Program.users)
                {
                    result += uuser.ToString();
                }
                
                Program.gotoMain();
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
