using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolve.MarsRover
{
    public class Plateau
    {
        //Plateau devided into grid, lower left Represents 0 0
        private int h = 1;
        private int l = 1;
        public int Height { get { return h; } }
        public int Length { get { return l; } }

        //constructor
        public Plateau(int _h, int _l) {
            h = _h;
            l = _l;
        }
        private List<Rover> _Rovers = new List<Rover>();
        public List<Rover> Rovers { get { return _Rovers; } }

        public void LandRover(Position location)
        {
            if (!Validation(location))
                throw new ArgumentOutOfRangeException("location");

            Rover newRover = new Rover(this, location);
            Rovers.Add(newRover);
        }

        //Should be within 0 0 and 5 5
        private Boolean Validation(Position range)
        {
            if (range.X > Length)
                return false;
            else if (range.Y > Height)
                return false;
            else
                return true;
        }

    }
}
