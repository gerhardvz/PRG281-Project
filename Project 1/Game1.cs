using ExtensionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//READ ME!!!! READ ME!!!!
//All Waypoint are Float values ranging from 0 to 1
//in order to calculate position you would multiply it with the Board panel size and convert to int

namespace Project_1.Game
{
    public delegate void MovePawnHandler(int steps);
   public enum eBase { Red =1,Green=2,Yellow=3,Blue=4 };
    
   public class Game1:Panel
    {

        
    public static Map gameMap;
        //List of players - max 4 because of 4 bases
       static List<Player> players = new List<Player>();
      
        //Dice
      public  Game1()
        {
            
            this.Anchor = ((AnchorStyles)(
               (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right)));
            this.BackgroundImage= Properties.Resources.Map;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.SuspendLayout();
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximumSize = new System.Drawing.Size(2500, 2500);
            this.MinimumSize = new System.Drawing.Size(150, 150);
            this.Size = new System.Drawing.Size(670, 670);
            this.Name = "Game Board";

            this.TabIndex = 100;
            this.ResumeLayout(false);
            this.PerformLayout();

            gameMap = new Map();
            
            Controls.Add(gameMap);

            foreach (User user in Program.users)
            {
                Player player = new Player(user.Username);
                foreach (Pawn pawn in player.playerBase.pawns)
                {
                    Controls.Add(pawn);
                    this.Resize += new EventHandler(pawn.PawnReposition);
                }
                    players.Add(player);
            }
            gameMap.SendToBack();
            
            this.Resize += new EventHandler(this.ImResized);
            
            
           
        }
       private void ImResized(object sender, EventArgs e)
        {
            
        }

        public static bool eBaseAvailable(eBase playerbase)
        {
            foreach(Player p in players)
            {
                if(p.baseColor == playerbase)
                {
                    return false;
                }
            }
            return true;

        }

    }
   public class Map:PictureBox
    {
        public Map()
        {
            // 
            // picMap
            // 
            
            this.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
                | AnchorStyles.Left)
                | AnchorStyles.Right)));
            this.Image = Properties.Resources.Map;
            this.Location = new Point(0, 0);
            this.Name = "Map";       
            this.Size = new Size(670, 670);
       
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.TabIndex = 8;
            this.TabStop = false;
        }

        //TODO: Map Values for Pawns
        public static Point[] outerRingMap = new Point[] {
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
    }

    //TODO: Change Point to % value 1 to 100
    //Easier to map on panel than to recalculate it the whole time
    abstract class Base
    {
        public  event MovePawnHandler MovePawn;
        
        public List<Pawn> pawns = new List<Pawn>();
        protected const int MAXPAWNS = 3;
        public eBase baseColor;

        //Position where Base Start is located
        public Point[] BeginWaypoint;
        //Position where Base End is located
        public Point[] EndWaypoint ;
      
        public  void move(int step) {
            MovePawn?.Invoke(step);
        }

        public Base()
        {
      
        }

        //if pawn reaches end link move to next pawn
    }

    //Copy for other 3 bases
    class BlueBase : Base
    {
        public BlueBase()
        {
            MessageBox.Show("Created a Blue Base");
            //Add values
            baseColor = eBase.Blue;
            BeginWaypoint = new Point[] {
                new Point(238,333),
                new Point(0,0),
                new Point(0,0),
                new Point(0,0)
            };
            EndWaypoint = new Point[] {
                new Point(0,0),
                new Point(0,0),
                new Point(0,0),
                new Point(0,0)
            };
            Pawn pawn;
            for (int i = 0; i < MAXPAWNS; i++)
            {
                pawn = new Pawn(this.BeginWaypoint[0], this.baseColor);
                pawns.Add(pawn);
            }
         //   MovePawn = new MovePawnHandler(pawns[0].move);

        }
    }
    class YellowBase : Base
    {
        public YellowBase()  
        {
            MessageBox.Show("Created a Yellow Base");
            //Add values
            baseColor = eBase.Yellow;
            BeginWaypoint = new Point[] {
                new Point(334,236),
                new Point(0,0),
                new Point(0,0),
                new Point(0,0)
            };
            EndWaypoint = new Point[] {
                new Point(0,0),
                new Point(0,0),
                new Point(0,0),
                new Point(0,0)
            };
            Pawn pawn;
            for (int i = 0; i < MAXPAWNS; i++)
            {
                pawn = new Pawn(this.BeginWaypoint[0], this.baseColor);
                pawns.Add(pawn);
            }

        }
    }
    class GreenBase : Base
    {
        public GreenBase()
        {
            MessageBox.Show("Created a Green Base");
            //Add values
            baseColor = eBase.Green;
            BeginWaypoint = new Point[] {
                new Point(437,333), //Begin point
                new Point(345,345),
                new Point(0,0),
                new Point(0,0)
            };
            EndWaypoint = new Point[] {
                new Point(0,0),
                new Point(0,0),
                new Point(0,0),
                new Point(0,0) //Finish Point
            };
            Pawn pawn;
            for (int i = 0; i < MAXPAWNS; i++)
            {
                pawn = new Pawn(this.BeginWaypoint[0], this.baseColor);
                pawns.Add(pawn);
            }

        }
    }
    class RedBase : Base
    {
        public RedBase() 
        {
            MessageBox.Show("Created a Red Base");
            //Add values
            baseColor = eBase.Red;
             BeginWaypoint = new Point[] {
                new Point(334,433),
                new Point(0,0),
                new Point(0,0),
                new Point(0,0)
            };
             EndWaypoint = new Point[] {
                new Point(0,0),
                new Point(0,0),
                new Point(0,0),
                new Point(0,0)
            };

            Pawn pawn;
            for (int i = 0; i < MAXPAWNS; i++)
            {
                pawn = new Pawn(this.BeginWaypoint[0], this.baseColor);
                pawns.Add(pawn);
            }
        }
    }

    //Please note this is not a typing error it is Pawn not PORN!!! 
    //Please do not rename!!!
    class Pawn : PictureBox
    {
        eBase color;
        Point point;

        public Pawn(Point position, eBase color)
        {
           
            this.steps = 0;
            //this.Location = position;
            SetLocation(position, Game1.gameMap.Size);
            point = position;
            this.color = color;
            this.BackColor = Color.Transparent;
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.Size = new Size(30, 30);
            //write Resize override to calculate new position
            
            
            switch (color)
            {
                case eBase.Red: this.Image = Properties.Resources.RedPawn;break;
                case eBase.Green: this.Image = Properties.Resources.GreenPawn; break;
                case eBase.Yellow: this.Image = Properties.Resources.YellowPawn; break;
                case eBase.Blue: this.Image = Properties.Resources.BluePawn; break;
            }
             this.Anchor = ((AnchorStyles)(
               (AnchorStyles.Top |  AnchorStyles.Left )));

        }

        public void PawnReposition(object sender, EventArgs e)
        {
            Game1 parentAsPanel = sender as Game1;
           
            SetLocation(point, parentAsPanel.Size);
           
            

        }
        //current position of the pawn on the map
        int Position;
        public void setPosition(int position)
        {
            Position = position;
            Panel parentAsPanel = Parent as Game1;

            SetLocation(Map.outerRingMap[Position], parentAsPanel.Size);
           // this.Location = Map.outerRingMap[Position];
        }
        //Counting of the steps the pawn did
        int steps;
        public void SetLocation(Point location, Size mapSize) 
        {
            Debug.Write("Converting Point from: "+ location.ToString() + " to: " );
            this.Location = location.TransformPoint(new Size(670, 670),  mapSize);
            Debug.WriteLine(Location.ToString());
            
            
        }

        public  void move(int step)
        {
            if (Position + step > 32)
            {
                Position = Position + step - 32;
                return;
            }
            Position = Position + step;
        }
    }

    class Player
    {
       public String username;
        public eBase baseColor;
        public Base playerBase;

        public Player(String username)
        {
            this.username = username;
            //setting player to random base
            Random random = new Random();
            for (; true;)
            {
                //Get a random value from 1 to 4 (according to eBase)
                eBase tempPlayerbase = (eBase)random.Next(3)+1;
                if (Game1.eBaseAvailable(tempPlayerbase))
                {
                    baseColor = tempPlayerbase;
                    break;
                }
            }
            {
                string sBaseColor = Enum.GetName(typeof(eBase), baseColor);
                
               
                //Dynamically create a Base for the random Base chosen
                Assembly assem = typeof(Base).Assembly;
                playerBase = (Base)assem.CreateInstance("Project_1.Game." + sBaseColor + "Base");
                
            }

        }
       // public Player(String username, eBase baseColor) : base(username)
      //  {
      //      this.baseColor = baseColor;
      //  }

        public Player()
        {
            //setting player to random base
            Random random = new Random();
            for (; true;)
            {
                eBase tempPlayerbase = (eBase)random.Next(3)+1;
                if (Game1.eBaseAvailable(tempPlayerbase)) {
                    baseColor = tempPlayerbase;
                    break;
                }
            }
            { 
                string sBaseColor= Enum.GetName(typeof(eBase), baseColor);
                MessageBox.Show(typeof(BlueBase).ToString());
                Type t = Type.GetType("Project_1.Games."+sBaseColor + "Base");
               playerBase = (Base)Activator.CreateInstance(t);
            }
            
            

        }
    }
    
     

   
}
