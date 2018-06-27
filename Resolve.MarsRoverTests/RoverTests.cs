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
    public class RoverTests
    {

        Rover _testRover;
        private void InitializeRoverBottomLeft()
        {
            Plateau _plateau = new Plateau(10, 10);
            Position landingCoordinates = new Position(1, 1, Position.Compass.N);
            _plateau.LandRover(landingCoordinates);
            _testRover = _plateau.Rovers.FirstOrDefault();
        }

        
        [TestMethod()]
        public void ShouldFaceEast()
        {
            InitializeRoverBottomLeft();
            _testRover._position.Point = Position.Compass.N;

            _testRover.Parse("R");
            Assert.AreEqual(_testRover._position.Point, Position.Compass.E);
        }

        [TestMethod()]
        public void ShouldFaceWest()
        {
            InitializeRoverBottomLeft();
            _testRover._position.Point = Position.Compass.N;

            _testRover.Parse("L");
            Assert.AreEqual(_testRover._position.Point, Position.Compass.W);
        }


        [TestMethod()]
        public void ShouldFaceSouth()
        {
            InitializeRoverBottomLeft();
            _testRover._position.Point = Position.Compass.N;

            _testRover.Parse("LL");
            Assert.AreEqual(_testRover._position.Point, Position.Compass.S);
        }

        [TestMethod()]
        public void ShouldFaceNorth()
        {
            InitializeRoverBottomLeft();
            _testRover._position.Point = Position.Compass.S;

            _testRover.Parse("RR");
            Assert.AreEqual(_testRover._position.Point, Position.Compass.N);
        }


        [TestMethod()]
        public void ShouldMoveUp()
        {
            InitializeRoverBottomLeft();
            _testRover.Parse("M");

            Assert.AreEqual(_testRover._position.X, 1);
            Assert.AreEqual(_testRover._position.Y, 2);
            Assert.AreEqual(_testRover._position.Point, Position.Compass.N);
        }


        [TestMethod()]
        public void ShouldMoveTo33N()
        {
            InitializeRoverBottomLeft();
            _testRover.Parse("MMRMMRMRRM");

            Assert.AreEqual(_testRover._position.X, 3);
            Assert.AreEqual(_testRover._position.Y, 3);
            Assert.AreEqual(_testRover._position.Point, Position.Compass.N);
        }

    }
}
