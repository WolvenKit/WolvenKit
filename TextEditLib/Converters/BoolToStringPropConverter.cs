namespace TextEditLib.Converters
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    /// <summary>
    /// Converts a boolean value into a configurable string value.
    /// </summary>
    [ValueConversion(typeof(bool), typeof(string))]
    public sealed class BoolToStringPropConverter : IValueConverter
    {
        #region constructor

        /// <summary>
        /// Class constructor
        /// </summary>
        public BoolToStringPropConverter()
        {
            // set defaults
            TrueValue = "True";
            FalseValue = "False";
        }

        #endregion constructor

        #region properties

        /// <summary>
        /// Gets/sets the <see cref="Visibility"/> value that is associated
        /// (converted into) with the boolean false value.
        /// </summary>
        public string FalseValue { get; set; }

        /// <summary>
        /// Gets/sets the <see cref="Visibility"/> value that is associated
        /// (converted into) with the boolean true value.
        /// </summary>
        public string TrueValue { get; set; }

        #endregion properties

        #region methods

        /// <summary>
        /// Converts a bool value into <see cref="Visibility"/> as configured in the
        /// <see cref="TrueValue"/> and <see cref="FalseValue"/> properties.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool))
                return null;

            return (bool)value ? TrueValue : FalseValue;
        }

        /// <summary>
        /// Converts a <see cref="Visibility"/> value into bool as configured in the
        /// <see cref="TrueValue"/> and <see cref="FalseValue"/> properties.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Equals(value, TrueValue))
                return true;

            if (Equals(value, FalseValue))
                return false;

            return null;
        }

        #endregion methods
    }
}
