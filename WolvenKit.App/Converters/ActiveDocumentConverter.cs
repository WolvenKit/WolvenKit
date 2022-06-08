using System;
using System.Windows.Data;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.App.Converters
{
    public class ActiveDocumentConverter : IValueConverter
    {
        #region Methods

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) => value is DocumentViewModel ? value : Binding.DoNothing;

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) => value is DocumentViewModel ? value : Binding.DoNothing;

        #endregion Methods
    }
}
