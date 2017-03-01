// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumHelperAttribute.cs" company="HepsiBurada">
//   HepsiBurada
// </copyright>
// <summary>
//   The enum helper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HB.Homework.MarsRover.Helper
{
    using System;

    /// <summary>
    ///     The enum helper.
    /// </summary>
    public class EnumHelperAttribute : Attribute
    {
        #region Fields

        /// <summary>
        ///     The _value.
        /// </summary>
        private readonly string _value;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumHelperAttribute"/> class.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public EnumHelperAttribute(string value)
        {
            this._value = value;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the value.
        /// </summary>
        public string Value
        {
            get
            {
                return this._value;
            }
        }

        #endregion
    }
}