// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumString.cs" company="HepsiBurada">
//   HepsiBurada
// </copyright>
// <summary>
//   The enum string.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HB.Homework.MarsRover.Helper
{
    using System;
    using System.Reflection;

    /// <summary>
    ///     The enum string.
    /// </summary>
    public static class EnumString
    {
        #region Public Methods and Operators

        /// <summary>
        /// The get string value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetStringValue(Enum value)
        {
            string output = null;
            Type type = value.GetType();
            FieldInfo fi = type.GetField(value.ToString());
            var attr = fi.GetCustomAttributes(typeof(EnumHelperAttribute), false) as EnumHelperAttribute[];
            if (attr != null && attr.Length > 0)
            {
                output = attr[0].Value;
            }

            return output;
        }

        #endregion
    }
}