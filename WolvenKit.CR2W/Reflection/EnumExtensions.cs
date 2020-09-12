using System;
using System.Collections.Generic;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W.Reflection
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Return an enumerable collection of CNames representing the current enum value.
        /// </summary>
        /// <param name="value">The enum value.</param>
        /// <returns>A CName array of all valid values.</returns>
        //public static IEnumerable<CName> ConvertToNames(Enum value)
        //{
        //    var type = value.GetType();
        //    foreach (Enum enumValue in Enum.GetValues(type))
        //    {
        //        if (value.HasFlag(enumValue))
        //        {
        //            yield return Enum.GetName(type, enumValue);
        //        }
        //    }
        //}

        /// <summary>
        /// Convert an enumerable collection of CName values into a Enum value.
        /// </summary>
        /// <param name="enumType">The enum type to convert to.</param>
        /// <param name="names">The collection of CNames</param>
        /// <returns>The Enum value</returns>
        public static object ConvertToEnum(Type enumType, IEnumerable<CName> names)
        {
            if (!enumType.IsEnum)
            {
                throw new ArgumentException();
            }
            try
            {
                var enumString = String.Join<CName>(", ", names);
                return Enum.Parse(enumType, enumString);
            }
            catch
            {
                return Enum.ToObject(enumType, 0);
            }
        }
    }
}