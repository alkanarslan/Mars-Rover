// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IArea.cs" company="HepsiBurada">
//   HepsiBurada
// </copyright>
// <summary>
//   Defines the IArea type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HB.Homework.MarsRover.Rovers
{
    /// <summary>
    ///     The Area interface.
    /// </summary>
    public interface IArea
    {
        #region Public Properties

        /// <summary>
        ///     Gets the area position.
        /// </summary>
        Position AreaPosition { get; }

        #endregion
    }
}