// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HB.Homework.MarsRoverDrive
{
    using System;

    using HB.Homework.MarsRover.Rovers;

    /// <summary>
    /// The program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        static void Main(string[] args)
        {
            var marsArea = new Area(new Position(5, 5));
            Curiosity(marsArea);
            Sojourner(marsArea);
            Console.ReadKey();
        }

        /// <summary>
        /// The Mars Rover Curiosity.
        /// </summary>
        /// <param name="marsArea">
        /// The mars area.
        /// </param>
        private static void Curiosity(Area marsArea)
        {
            Console.WriteLine("Mars Rover Curiosity is positioned.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Position : X = 1 Y = 3  Direction = North");
            var curiosity = new Rover(new Position(1, 2), Compass.N, marsArea);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Mars Rover Curiosity Start.");
            System.Threading.Thread.Sleep(1000);
            curiosity.Process("LMLMLMLMM");
            Console.WriteLine("Mars Rover Curiosity Stop. \n");
        }

        /// <summary>
        /// The Mars Rover Sojourner
        /// </summary>
        /// <param name="marsArea">
        /// The mars area.
        /// </param>
        private static void Sojourner(Area marsArea)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Mars Rover Sojourner is positioned.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Position : X = 3 Y = 3  Direction = East");
            var sojourner = new Rover(new Position(3, 3), Compass.E, marsArea);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Mars Rover Sojourner Start.");
            System.Threading.Thread.Sleep(1000);
            sojourner.Process("MMRMMRMRRM");
            Console.WriteLine("Mars Rover Sojourner Stop.");
        }
    }
}
