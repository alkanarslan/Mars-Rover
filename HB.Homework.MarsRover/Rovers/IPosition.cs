// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPosition.cs" company="HepsiBurada">
//   HepsiBurada
// </copyright>
// <summary>
//   Defines the IPosition type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HB.Homework.MarsRover.Rovers
{
    /// <summary>
    ///     The Position interface.
    /// </summary>
    public interface IPosition
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the X.
        /// </summary>
        int X { get; set; }

        /// <summary>
        ///     Gets or sets the Y.
        /// </summary>
        int Y { get; set; }

        #endregion
    }
}