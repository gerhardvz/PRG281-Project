﻿using Project_1.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Main : Form
    {
        //TODO: Map Values for Pawns
        Point[] outerRingMap = new Point[] { };
        public Main()
        {
            gameMap = new Map();
            this.Controls.Add(this.gameMap.panel);
            InitializeComponent();
            
            

        }
        private Map gameMap;

   
    }
}
