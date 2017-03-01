// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRover.cs" company="HepsiBurada">
//   HepsiBurada
// </copyright>
// <summary>
//   Defines the IRover type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HB.Homework.MarsRover.Rovers
{
    /// <summary>
    ///     The Rover interface.
    /// </summary>
    public interface IRover
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the rover area.
        /// </summary>
        IArea RoverArea { get; set; }

        /// <summary>
        ///     Gets or sets the rover compass.
        /// </summary>
        Compass RoverCompass { get; set; }

        /// <summary>
        ///     Gets or sets the rover position.
        /// </summary>
        IPosition RoverPosition { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The process.
        /// </summary>
        /// <param name="commands">
        /// The commands.
        /// </param>
        void Process(string commands);

        #endregion
    }
}