using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolve.MarsRover
{
    public class Position
    {
        //Set position parameters:X,Y, Degree
        public int X { get; set; }
        public int Y { get; set; }
        public Compass Point { get; set; }
        public enum Compass
        {
            N = 0,
            E = 1,
            S = 2,
            W = 3
        
    }
        //Constructor
        public Position(int _x, int _y, Compass _p)
        {
            X = _x;
            Y = _y;
            Point = _p;
        }

    }

}
