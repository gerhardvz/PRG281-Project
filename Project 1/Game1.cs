using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Project_1.Game
{
    class Game1
    {

        Control.ControlCollection controls;
        Map gameMap;
        private int pawnsPerBase;
        public List<Pawn> pawns = new List<Pawn>();
        Game1(Control.ControlCollection controls)
        {
            this.controls = controls;
            gameMap = new Map();

            foreach(User user in Program.users)
            {
                Base userBase = new Base();
                
            }
        }

    }

    class Base
    {

        public List<Pawn> pawns = new List<Pawn>();
        //Position where Base Start is located
        public Point baseStart;
        //Position where Base End is located
        public Point baseEnd;
        //Position where Base Start joins on outer loop
        public Point OuterJoinStart;
        //Position where Base End joins on outer loop
        public Point OutterJoinEnd;

      public  Base()
        {

        }

    }
    //Please note this is not a typing error it is Pawn not PORN!!! 
    //Please do not rename!!!
    class Pawn:PictureBox {
        //TODO: Implement Set:
        //If Position Reference is >32 {-32} to get possition.

       public Pawn(Base pawnBase){
            this.steps = 0;
            this.Location = pawnBase.baseStart;
            
            
}
        Point Position { get; set; }
        int steps;
        
        

    }

    class Map 
    {
        public Panel panel;
        private PictureBox imgMap;
       
       public Map() 
        {
            this.panel = new Panel();
            this.imgMap = new PictureBox();
            this.panel.SuspendLayout();
            
            ((System.ComponentModel.ISupportInitialize)(this.imgMap)).BeginInit();

            
            this.panel.Controls.Add(this.imgMap);
          
            this.panel.Location = new Point(50, 291);
            this.panel.Name = "Game Board";
            this.panel.Size = new System.Drawing.Size(650, 650);
            this.panel.TabIndex = 0;

            // 
            // picMap
            // 
            this.imgMap.Image = Properties.Resources.Map;
            this.imgMap.Location = new Point(21, 30);
            this.imgMap.Name = "Map";
            this.imgMap.Size = new Size(602, 514);
            this.imgMap.SizeMode = PictureBoxSizeMode.Zoom;
            this.imgMap.TabIndex =8;
            this.imgMap.TabStop = false;

            //
            //Main
            //
            
            ((System.ComponentModel.ISupportInitialize)(this.imgMap)).EndInit();

            this.panel.ResumeLayout(false);
        }

    //TODO: Map Values for Pawns
    Point[] outerRingMap = new Point[] {
            new Point(309, 40),
            new Point(356, 41),
            new Point(394, 52),
            new Point(438, 72),
            new Point(475, 99),
            new Point(309, 40),
            new Point(309, 40),
            new Point(309, 40),
            new Point(309, 40),
            new Point(309, 40)
        };

       
       


        //Position where Base Start is located
        Point baseStart;
        //Position where Base End is located
        Point baseEnd;
        //Position where Base Start joins on outer loop
        Point OuterJoinStart;
        //Position where Base End joins on outer loop
        Point OutterJoinEnd;

    }
    //Please note this is not a typing error it is Pawn not PORN!!! 
    //Please!!!
     

   
}
