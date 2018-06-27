using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolve.MarsRover
{
    public class Rover
    {
        public Plateau _Plateau { get; set; }
        public Position _position { get; set; }
        //Constructor
        public Rover(Plateau _pl, Position _po)
        {
            _Plateau = _pl;
            _position = _po;
        }
        public List<string> CommandParser(string commandString)
        {
            var commands = commandString.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            return commands.ToList();
        }
        public void Parse(string _in)
        {
            foreach (char i in _in)
            {

                RunCommand(i);

            }


        }
        public string GetCurrentLocation() {


            var Item1 = _position.X;
            var Item2 = _position.Y;
            var Item3 = _position.Point;
            var CurrentLocation = new StringBuilder();
            CurrentLocation.AppendFormat("{0} {1} {2}", Item1, Item2, Item3);
            return CurrentLocation.ToString();
            
        }
        private void RunCommand(char input)
        {
            if (input == 'L')
            {
                Left();
            }
            else if (input == 'R')
            {
                Right();
            }
            else if (input == 'M')
            {
                Move();
            }

        }
        private void Left()
        {
            //Rover should rotate 90 degrees to the left

            if (_position.Point == Position.Compass.N)
                _position.Point = Position.Compass.W;
            else
            {
                _position.Point -= 1;
            }
        }
        private void Right()
        {
            //Rover should rotate 90 degrees to the Right
            if (_position.Point == Position.Compass.W)
                _position.Point = Position.Compass.N;
            else
            {
                _position.Point += 1;
            }
        }


        private void Move()
        {
            switch (_position.Point)
            {
                case Position.Compass.N:
                    if (_position.Y < _Plateau.Height)
                        _position.Y += 1;
                    break;
                case Position.Compass.E:
                    if (_position.X < _Plateau.Length)
                        _position.X += 1;
                    break;
                case Position.Compass.S:
                    if (_position.Y > 1)
                        _position.Y -= 1;
                    break;
                case Position.Compass.W:
                    if (_position.X > 1)
                        _position.X -= 1;
                    break;
            }
        }

    }


    }

