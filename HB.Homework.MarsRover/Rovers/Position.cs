// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Position.cs" company="HepsiBurada">
//   HepsiBurada
// </copyright>
// <summary>
//   Defines the Position type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HB.Homework.MarsRover.Rovers
{
    /// <summary>
    ///     The position.
    /// </summary>
    public class Position : IPosition
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Position"/> class.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the x.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        ///     Gets or sets the y.
        /// </summary>
        public int Y { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            return string.Format("X : {0}  Y : {1}", this.X, this.Y);
        }

        #endregion
    }
}