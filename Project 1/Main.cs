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
using ExtensionMethods;

namespace Project_1
{
    public partial class Main : Form
    {
        Game1 game;
        Pawn pawn;
        public Main()
        {
            
            game = new Game1();
            Controls.Add(game);
            InitializeComponent();

        }
      
        private void btnExit_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
