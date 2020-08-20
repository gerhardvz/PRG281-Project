using ExtensionMethods;
using Project_1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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
                int count = 0;
                foreach (Pawn pawn in player.playerBase.pawns)
                {
                    pawn.Name = $"{player.username}_Pawn{count++}";
                        Controls.Add(pawn);
                    this.Resize += new EventHandler(pawn.PawnReposition);
                }
                    players.Add(player);
                player.playerBase.pawns[0].move(1);
                player.playerBase.pawns[1].move(1);
            }
            gameMap.SendToBack();
         
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
        public static SizeF[] outerRingMap = new SizeF[] {
            new SizeF((float)0.4611940, (float)0.0597015),
            new SizeF((float)0.53134330, (float)0.0611940),
            new SizeF((float)0.58805970, (float)0.0776119),
            new SizeF((float)0.65373134, (float)0.10746268),
            new SizeF((float)0.70895522, (float)0.14776119),
        };
    }

    //TODO: Change Point to % value 1 to 100
    //Easier to map on panel than to recalculate it the whole time
    abstract class Base
    {
        private int pawnsFinished = 0; 
        public  event MovePawnHandler MovePawn;
        
        public List<Pawn> pawns = new List<Pawn>();
        protected const int MAXPAWNS = 3;
        public eBase baseColor;

        //Position where Base Start is located
        public static SizeF[] BeginWaypoint;
        //Position where Base End is located
        public static SizeF[] EndWaypoint ;
      
        public  void move(int step) {
            MovePawn?.Invoke(step);
        }
        public void PawnAtBase()
        {
            //remove The pawn on the board and increase number of Pawns Finished
            MovePawn -= pawns[pawnsFinished++].move;
            //If not all pawns ar through add next pawn
            if (pawnsFinished < MAXPAWNS)
            {
                MovePawn += pawns[pawnsFinished].move;
            }
        } 
    }

    //Copy for other 3 bases
    class BlueBase : Base
    {
        public BlueBase()
        {
            baseColor = eBase.Blue;

            BeginWaypoint = new SizeF[] {
            new SizeF((float)0.35522388, (float)0.5),
            new SizeF((float)0.5,(float)0.5),
            new SizeF((float)0.5,(float)0.5),
            new SizeF((float)0.5,(float)0.5) };
        EndWaypoint = new SizeF[] {
                new SizeF(0,0),
                new SizeF(0,0),
                new SizeF(0,0),
                new SizeF(0,0)
            };
            Pawn pawn;
            for (int i = 0; i < MAXPAWNS; i++)
            {
                pawn = new Pawn(BeginWaypoint[0], this.baseColor);

                pawns.Add(pawn);
            }
        
        }
    }
    class YellowBase : Base
    {
        public YellowBase()  
        {
            //Add values
            baseColor = eBase.Yellow;
            BeginWaypoint = new SizeF[] {
                new SizeF((float)0.5,(float)0.35223880),
                new SizeF((float)0.5,(float)0.5),
               new SizeF((float)0.5,(float)0.5),
               new SizeF((float)0.5,(float)0.5)
            };
            EndWaypoint = new SizeF[] {
                new SizeF(0,0),
                new SizeF(0,0),
                new SizeF(0,0),
                new SizeF(0,0)
            };
            Pawn pawn;
            for (int i = 0; i < MAXPAWNS; i++)
            {
                pawn = new Pawn(BeginWaypoint[0], this.baseColor);
                pawns.Add(pawn);
            }
        }
    }
    class GreenBase : Base
    {
        public GreenBase()
        {
            //Add values
            baseColor = eBase.Green;
            BeginWaypoint = new SizeF[] {
                new SizeF((float)0.65223880,(float)0.5), //Begin point
                new SizeF(345,345),
                new SizeF((float)0.5,(float)0.5),
                new SizeF((float)0.5,(float)0.5)
            };
            EndWaypoint = new SizeF[] {
                new SizeF(0,0),
                new SizeF(0,0),
                new SizeF(0,0),
                new SizeF(0,0) //Finish Point
            };
            Pawn pawn;
            for (int i = 0; i < MAXPAWNS; i++)
            {
                pawn = new Pawn(BeginWaypoint[0], this.baseColor);
                pawns.Add(pawn);
            }
        }
    }
    class RedBase : Base
    {
        public RedBase() 
        {
            //Add values
            baseColor = eBase.Red;
             BeginWaypoint = new SizeF[] {
                new SizeF((float)0.5,(float)0.64626866),
                new SizeF((float)0.5,(float)0.5),
                new SizeF((float)0.5,(float)0.5),
               new SizeF((float)0.5,(float)0.5)
            };
             EndWaypoint = new SizeF[] {
                new SizeF(0,0),
                new SizeF(0,0),
                new SizeF(0,0),
                new SizeF(0,0)
            };
            Pawn pawn;
            for (int i = 0; i < MAXPAWNS; i++)
            {
                pawn = new Pawn(BeginWaypoint[0], this.baseColor);
                pawns.Add(pawn);
            }
        }
    }

    //Please note this is not a typing error it is Pawn not PORN!!! 
    //Please do not rename!!!
    class Pawn : PictureBox
    {
        eBase color;
        SizeF point;
        //Safe indicated that pawn is on the safe path on the board which is the basecolor path it starts on and ends on
        bool safe = true;
        public Pawn(SizeF position, eBase color)
        {
           
           
            //this.Location = position;
            SetLocation(position);
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
            SetLocation(point);
        }
        //current position of the pawn on the map

        public void SetLocation(SizeF location) 
        {
            //Since the Game Map Stays centered on the screen and the aspect ratio stays the same, the left 
            //and top the offset should be calculated and added to the pawn position. 
            //The Point would also be multiplied with th size of the screen to get the position
           
            Debug.Write("Converting Point from: " + location.ToString() + " to: ");
            Size mapSize = Game1.gameMap.Size;
            if (mapSize.Height == mapSize.Width)
            {
                // Sides are the same so dimentions are the same
               
                this.Location = new Point(Convert.ToInt32(location.Width * mapSize.Width), Convert.ToInt32(location.Height * mapSize.Height));
                //this.Location = location.TransformPoint(new Size(670, 670),  mapSize);
                
            }
            else if (mapSize.Height > mapSize.Width)
            {
                //Aspect ratio stays the same and is square so Width=Height
                //Need to add offset to points in height(y-axis)
                float offset = (mapSize.Height - mapSize.Width)/2;
                //Calculate offset
                this.Location = new Point(Convert.ToInt32(location.Width * mapSize.Width), Convert.ToInt32(offset +(location.Height * mapSize.Width)));

            }
            else if (mapSize.Width > mapSize.Height)
                {
                //Aspect ratio stays the same and is square so Width=Height
                float offset = (mapSize.Width - mapSize.Height) / 2;
                //Need to add offset to points in Width(x-axis)
                this.Location = new Point(Convert.ToInt32(offset+(location.Width * mapSize.Height)), Convert.ToInt32(location.Height * mapSize.Height));

            }
            
            Debug.WriteLine(Location.ToString());

        }
       public  bool flashing =false;
        public void move(int step)
        {
            //Check if Pawn is still on Waypont begin path
            if (safe)
            {
                SizeF[] BaseEnd = null;
                SizeF[] BaseBegin = null;
                switch (color){
                    case eBase.Red: 
                        {
                             BaseEnd = RedBase.EndWaypoint;
                             BaseBegin = RedBase.BeginWaypoint;
                            break; }
                    case eBase.Green: {
                            BaseEnd = GreenBase.EndWaypoint;
                            BaseBegin = GreenBase.BeginWaypoint; 
                            break; }
                    case eBase.Yellow:
                        {
                            BaseEnd = YellowBase.EndWaypoint;
                            BaseBegin = YellowBase.BeginWaypoint;
                            break;
                        }
                    case eBase.Blue:
                        {
                            BaseEnd = BlueBase.EndWaypoint;
                            BaseBegin = BlueBase.BeginWaypoint;
                            break;
                        }
                    
                }
                if (BaseEnd == null || BaseBegin == null)
                {
                    //Raise event Error
                }

                //Repeat for every step pawn has
                for (; step > 0; step--)
                {
                    
                    //Test if Pawn is in end Waypoint List
                    if (Array.IndexOf(BaseEnd, point) != -1)
                    {
                        int pos = Array.IndexOf(BaseEnd, point);
                        
                        point = BaseEnd[++pos];

                    }
                    //Test if Pawn is in OuterRing Waypoint List
                    else if (Array.IndexOf(Map.outerRingMap, point) != -1)
                    {
                        int pos = Array.IndexOf(Map.outerRingMap, point);

                        point = Map.outerRingMap[++pos];
                    }
                    //Pawn has to be in Begin loop 
                    else if (Array.IndexOf(BaseBegin, point) != -1)
                    {
                        int pos = Array.IndexOf(BaseBegin, point);

                        point = BaseBegin[++pos];
                    }
                    else
                    {
                        //Raise event error Map tampering
                        //TODO: Write EVENT
                        continue;
                    }
                    
                    
                }
                SetLocation(point);
                if (PositionClash())
                {
                    //TODO: Create Thread Flash
                    new Thread(FlashPawn).Start();
                    
                    
                    this.Image = Resources.WhitePawn;
                    this.BringToFront();
                }
                else
                {
                    flashing = false;
                    switch (color)
                    {
                        case eBase.Red: { this.Image = Resources.RedPawn; break; }
                        case eBase.Green: { this.Image = Resources.GreenPawn; break; }
                        case eBase.Yellow: { this.Image = Resources.YellowPawn; break; }
                        case eBase.Blue: { this.Image = Resources.BluePawn; break; }
                    }
                }
            }

            
        }

        //Just your normal color flash
        //No nudity Here!!
         void FlashPawn()
        {
            this.flashing = true;
            while (this.flashing)
            {
                this.Image = Resources.WhitePawn;
                Thread.Sleep(1000);
                this.Image = Resources.OrangePawn;
                Thread.Sleep(1000);
                this.Image = Resources.PinkPawn;
                Thread.Sleep(1000);
            }
        }

        //This returns a bool when a Pawn is drawn and another pawn is on that position
        private bool PositionClash()
        {
            foreach (Control ctrl in Parent.Controls)
            {
                bool isPawn = ctrl is Pawn;
                if (this == ctrl|| !(ctrl is Pawn)) { continue; }
                if (ctrl.Location.Equals(this.Location)){
                    Debug.WriteLine("Object Clash between "+this.Name+" and "+ctrl.Name);
                    return true;
                }
            }
            return false;
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
            while(true)
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
