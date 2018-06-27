using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Resolve.MarsRover
{
    public class Composer
    {
        private Rover _rover;
        private Plateau _plateau;
        private Position _position;

        public Composer() {
             _plateau = new Plateau(5, 5);
             _position = new Position(1, 1, Position.Compass.N);
             _rover = new Rover(_plateau, _position);
        }
        public string ComposeLocation(string input)
        {
            
        StringBuilder val = new StringBuilder();
            string str = "";
            List<string> _items = _rover.CommandParser(input);
            foreach (var item in _items)
            {
                _rover.Parse(item);
                str = _rover.GetCurrentLocation();
                if (item.ToUpper().Contains('R') || item.ToUpper().Contains('L') || item.ToUpper().Contains('M'))
                {
                    val.AppendLine(str);
                    _plateau.LandRover(_position);
                }
            }
            return val.ToString();
        }
    }
}
