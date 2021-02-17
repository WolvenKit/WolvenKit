namespace TextEditLib.Converters
{
	using System;
	using System.Globalization;
	using System.Windows;
	using System.Windows.Data;

	[ValueConversion(typeof(object), typeof(Visibility))]
	public class NullToVisibilityConverter : IValueConverter
	{
		#region fields

		#endregion fields

		#region ctors
		/// <summary>
		/// Class constructor
		/// </summary>
		public NullToVisibilityConverter()
		{
			NullValue = Visibility.Collapsed;
			NotNullValue = Visibility.Visible;
		}
		#endregion ctors

		#region properties
		public Visibility NullValue { get; set; }

		public Visibility NotNullValue { get; set; }
		#endregion properties

		#region methods

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
				return NullValue;

			return NotNullValue;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
		#endregion methods
	}
}
