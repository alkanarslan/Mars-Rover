// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoverTest.cs" company="">
//   
// </copyright>
// <summary>
//   The rover test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HB.Homework.MarsRoverTest
{
    using HB.Homework.MarsRover.Rovers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The rover test.
    /// </summary>
    [TestClass]
    public class RoverTest
    {
        /// <summary>
        /// The sojourner test.
        /// </summary>
        [TestMethod]
        public void SojournerTest()
        {
            var marsArea = new Area(new Position(5, 5));
           
            var sojourner = new Rover(new Position(3, 3), Compass.E, marsArea);
            sojourner.Process("MMRMMRMRRM");
        }

        /// <summary>
        /// The sojourner result test.
        /// </summary>
        [TestMethod]
        public void SojournerResultTest()
        {
            var marsArea = new Area(new Position(5, 5));
            var sojourner = new Rover(new Position(3, 3), Compass.E, marsArea);
            sojourner.Process("MMRMMRMRRM");
            Assert.AreEqual(sojourner.ToString(), "51E");
        }

        /// <summary>
        /// The curiosity test.
        /// </summary>
        [TestMethod]
        public void CuriosityTest()
        {
            var marsArea = new Area(new Position(5, 5));
            var curiosity = new Rover(new Position(1, 2), Compass.N, marsArea);
            curiosity.Process("LMLMLMLMM");

        }

        /// <summary>
        /// The curiosity result test.
        /// </summary>
        [TestMethod]
        public void CuriosityResultTest()
        {
            var marsArea = new Area(new Position(5, 5));
            var curiosity = new Rover(new Position(1, 2), Compass.N, marsArea);
            curiosity.Process("LMLMLMLMM");
            Assert.AreEqual(curiosity.ToString(), "13N");
        }
    }
}
