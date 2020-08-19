using ExtensionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



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
            this.Anchor = ((System.Windows.Forms.AnchorStyles)(
                (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom| System.Windows.Forms.AnchorStyles.Left)));
            this.AutoSize = true;
            this.SuspendLayout();

            this.Location = new Point(50, 291);
            this.Name = "Game Board";
            this.Size = new System.Drawing.Size(670, 670);
            this.TabIndex = 0;


            gameMap = new Map();
            foreach (User user in Program.users)
            {
                Player player = new Player(user.Username);
                players.Add(player);
            }
            Controls.Add(gameMap);
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
            
            this.Anchor = ((AnchorStyles)(
                (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right)));
            this.Image = Properties.Resources.Map;
            this.Location = new Point(0, 0);
            this.Name = "Map";       
            this.Size = new Size(670, 670);
            this.MaximumSize = new Size(1500, 1500);
            this.MinimumSize = new Size(200, 200);
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
                new Point(0,0),
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
                new Point(0,0),
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
                new Point(0,0),
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
    class RedBase : Base
    {
        public RedBase() 
        {
            MessageBox.Show("Created a Red Base");
            //Add values
            baseColor = eBase.Red;
            BeginWaypoint = new Point[] {
                new Point(0,0),
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


        public Pawn(Point position, eBase color)
        {
            this.steps = 0;
            this.Location = position;
            this.color = color;
            switch (color)
            {
                case eBase.Red: this.Image = Properties.Resources.RedPawn;break;
                case eBase.Green: this.Image = Properties.Resources.GreenPawn; break;
                case eBase.Yellow: this.Image = Properties.Resources.YellowPawn; break;
                case eBase.Blue: this.Image = Properties.Resources.BluePawn; break;
               
            }

            this.Anchor = ((AnchorStyles)(
               (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right)));
        }
        int Position;
        public void setPosition(int position)
        {
            Position = position;
            this.Location = Map.outerRingMap[Position];
        }

        int steps;
        public void SetLocation(Point location, Size mapSize) 
        { 
            location.TransformPoint(new Size(670, 670),  mapSize);
            Location = location; 
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
                MessageBox.Show(typeof(BlueBase).ToString());
               

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
