using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class PlayserSelect : Form
    {
        public PlayserSelect()
        {
            InitializeComponent();
        }

        

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void MPSelect(object sender, EventArgs e)
        {
            Program.isMultiplayer = true;
            MessageBox.Show("Game is Multiplayer.");
            Console.WriteLine("Game is Multiplayer.");
            Program.gotoLogin();
        }
        private void SPSelect(object sender, EventArgs e)
        {
            Program.isMultiplayer = false;
            MessageBox.Show("Game is Single Player. ");
            Console.WriteLine("Game is Single Player.");
            Program.gotoLogin();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
