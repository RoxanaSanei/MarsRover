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
    public class PositionTests
    {
        [TestMethod()]
        public void PositionTest()
        {
            Position _Position = new Position(1,1,Position.Compass.N);
            Assert.AreEqual(_Position.X,1);
        }

        [TestMethod()]
        public void PositionCantBeNullTest()
        {
            Position _Position = new Position(0,2, Position.Compass.N);
            Assert.AreNotEqual(_Position.X, null);
        }
    }
}