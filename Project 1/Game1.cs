using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Game
{
    class Game1
    {

    }

    class Base
    {
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
        class Pawn {
        //TODO: Implement Set:
        //If Position Reference is >32 {-32} to get possition.
        int Position { get; set; }
        int steps;

    }

    class Map
    {
        //TODO: Map Values for Pawns
        Point[] outerRingMap = new Point[] { };
    }
}
