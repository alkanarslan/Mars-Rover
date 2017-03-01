// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rover.cs" company="HepsiBurada">
//   HepsiBurada
// </copyright>
// <summary>
//   The rover.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HB.Homework.MarsRover.Rovers
{
    using System;
    using System.Threading;
    using HB.Homework.MarsRover.Helper;

    /// <summary>
    ///     The rover.
    /// </summary>
    public class Rover : IRover
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Rover"/> class.
        /// </summary>
        /// <param name="roverPosition">
        /// The rover position.
        /// </param>
        /// <param name="roverCompass">
        /// The rover compass.
        /// </param>
        /// <param name="roverArea">
        /// The rover area.
        /// </param>
        public Rover(IPosition roverPosition, Compass roverCompass, IArea roverArea)
        {
            this.RoverPosition = roverPosition;
            this.RoverCompass = roverCompass;
            this.RoverArea = roverArea;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the rover area.
        /// </summary>
        public IArea RoverArea { get; set; }

        /// <summary>
        ///     Gets or sets the rover compass.
        /// </summary>
        public Compass RoverCompass { get; set; }

        /// <summary>
        ///     Gets or sets the rover position.
        /// </summary>
        public IPosition RoverPosition { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The process.
        /// </summary>
        /// <param name="commands">
        /// The commands.
        /// </param>
        public void Process(string commands)
        {
            foreach (char command in commands)
            {
                switch (command)
                {
                    case 'L':
                        this.Left();
                        break;
                    case 'R':
                        this.Right();
                        break;
                    case 'M':
                        this.Move();
                        break;
                }
            }
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            string stateRoverPosition = string.Format(
              "{0}{1}{2}",
              this.RoverPosition.X,
              this.RoverPosition.Y,
              EnumString.GetStringValue(this.RoverCompass));
            return stateRoverPosition;
        }

        /// <summary>
        /// The state rover position.
        /// </summary>
        private void StateRoverPosition()
        {
            string stateRoverPosition = string.Format(
                " X : {0}  Y : {1}  Direction : {2}",
                this.RoverPosition.X,
                this.RoverPosition.Y,
                EnumString.GetStringValue(this.RoverCompass));
            Console.WriteLine(stateRoverPosition);
        }

        #endregion

        #region Methods

        /// <summary>
        ///     The left.
        /// </summary>
        private void Left()
        {
            this.StateRoverPosition();
            Thread.Sleep(1000);
            this.RoverCompass = (this.RoverCompass - 1) < Compass.N ? Compass.W : this.RoverCompass - 1;
        }

        /// <summary>
        ///     The move.
        /// </summary>
        private void Move()
        {
            switch (this.RoverCompass)
            {
                case Compass.N:
                    this.RoverPosition.Y++;
                    break;
                case Compass.E:
                    this.RoverPosition.X++;
                    break;
                case Compass.S:
                    this.RoverPosition.Y--;
                    break;
                case Compass.W:
                    this.RoverPosition.X--;
                    break;
            }

            this.StateRoverPosition();
            Thread.Sleep(1000);
        }

        /// <summary>
        ///     The right.
        /// </summary>
        private void Right()
        {
            this.StateRoverPosition();
            this.RoverCompass = (this.RoverCompass + 1) > Compass.W ? Compass.N : this.RoverCompass + 1;
        }

        #endregion
    }
}