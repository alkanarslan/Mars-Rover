// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Area.cs" company="HepsiBurada">
//   HepsiBurada
// </copyright>
// <summary>
//   Defines the Area type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HB.Homework.MarsRover.Rovers
{
    /// <summary>
    ///     The area.
    /// </summary>
    public class Area : IArea
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Area"/> class.
        /// </summary>
        /// <param name="areaPosition">
        /// The area position.
        /// </param>
        public Area(Position areaPosition)
        {
            this.AreaPosition = areaPosition;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the area position.
        /// </summary>
        public Position AreaPosition { get; private set; }

        #endregion
    }
}