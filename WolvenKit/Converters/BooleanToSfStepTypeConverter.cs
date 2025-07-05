using System;
using System.Globalization;
using System.Windows.Data;
using Syncfusion.UI.Xaml.ProgressBar;

namespace WolvenKit.Converters;
public class BooleanToSfStepTypeConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is bool boolVal)
        {
            return boolVal ? StepStatus.Indeterminate : StepStatus.Active;
        }
        else
        {
            return StepStatus.Inactive;
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
}
