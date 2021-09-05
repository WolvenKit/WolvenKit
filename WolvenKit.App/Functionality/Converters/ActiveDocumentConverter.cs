using System;
using System.Windows.Data;
using WolvenKit.ViewModels.Documents;

namespace WolvenKit.Functionality.Converters
{
    public class ActiveDocumentConverter : IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is DocumentViewModel)
            {
                return value;
            }

            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is DocumentViewModel)
            {
                return value;
            }

            return Binding.DoNothing;
        }

        #endregion Methods
    }
}
