using Project_1.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Main : Form
    {
     
        public Main()
        {
            Game1 game = new Game1();
            //Controls.Add(game);
            InitializeComponent();
            
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
