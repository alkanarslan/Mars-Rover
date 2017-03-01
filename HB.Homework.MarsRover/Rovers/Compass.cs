// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Compass.cs" company="HepsiBurada">
//   HepsiBurada
// </copyright>
// <summary>
//   The compass.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HB.Homework.MarsRover.Rovers
{
    using HB.Homework.MarsRover.Helper;

    /// <summary>
    ///     The compass.
    /// </summary>
    public enum Compass
    {
        /// <summary>
        ///     The Cardinal Compass North
        /// </summary>
        [EnumHelper("N")]
        N = 1, 

        /// <summary>
        ///     The Cardinal Compass East
        /// </summary>
        [EnumHelper("E")]
        E = 2, 

        /// <summary>
        ///     The Cardinal Compass South
        /// </summary>
        [EnumHelper("S")]
        S = 3, 

        /// <summary>
        ///     The Cardinal Compass West
        /// </summary>
        [EnumHelper("W")]
        W = 4
    }
}