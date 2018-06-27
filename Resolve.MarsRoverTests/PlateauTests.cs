using Microsoft.VisualStudio.TestTools.UnitTesting;
using Resolve.MarsRover;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolve.MarsRover.Tests
{
    [TestClass()]
    public class PlateauTests
    {
        
        [TestMethod()]
        public void LandRoverTest()
        {

            Plateau Plateau = new Plateau(5, 5);
            Position _position = new Position(1, 2, Position.Compass.S);

            Plateau.LandRover(_position);
            Rover landedRover = Plateau.Rovers.FirstOrDefault();

            Assert.AreSame(landedRover._Plateau,Plateau);
        }

        [TestMethod()]
        public void lengthandheight()
        {
            int length = 2;
            int height = 2;
            Plateau _Plateau = new Plateau(length, height);
            Assert.AreEqual(_Plateau.Length, length);
            Assert.AreEqual(_Plateau.Height, height);
        }

        [TestMethod()]
        public void MinLength()
        {
            int length = 0;
            int height = 1;
            Plateau _Plateau = new Plateau(length, height);
            Assert.AreEqual(_Plateau.Length, 1);
        }
        [TestMethod()]

        public void MinHeight()
        {
            int length = 1;
            int height = 0;
            Plateau _Plateau = new Plateau(length, height);
            Assert.AreEqual(_Plateau.Height, 1);
        }
        [TestMethod()]
        public void RoverLandPlateau()
        {
            Plateau Plateau = new Plateau(10, 10);
            Position _position = new Position(1, 2, Position.Compass.S);

            Plateau.LandRover(_position);
            Rover landedRover = Plateau.Rovers.FirstOrDefault();

            Assert.IsNotNull(landedRover);
        }
        
        
    }
}
