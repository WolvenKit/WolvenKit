using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;

namespace WolvenKit.Converters
{
    [ValueConversion(typeof(EditorDifficultyLevel), typeof(SolidColorBrush))]
    public sealed class EditorLevelToColorConverter : IValueConverter
    {
        public static readonly EditorLevelToColorConverter Default = new();

        // convert EditorDifficultyLevel to color
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is EditorDifficultyLevel level)
            {
                return level switch
                {
                    EditorDifficultyLevel.Easy => (SolidColorBrush)Application.Current.Resources["WolvenKitCyan"],
                    EditorDifficultyLevel.Default => (SolidColorBrush)Application.Current.Resources["WolvenKitYellow"],
                    EditorDifficultyLevel.Advanced => (SolidColorBrush)Application.Current.Resources["WolvenKitRed"],
                    _ => DependencyProperty.UnsetValue,
                };
            }
            return DependencyProperty.UnsetValue;
        }

        // convert color to EditorDifficultyLevel
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is SolidColorBrush color)
            {
                if (color.Color == ((SolidColorBrush)Application.Current.Resources["WolvenKitCyan"]).Color)
                {
                    return EditorDifficultyLevel.Easy;
                }
                else if (color.Color == ((SolidColorBrush)Application.Current.Resources["WolvenKitYellow"]).Color)
                {
                    return EditorDifficultyLevel.Default;
                }
                else if (color.Color == ((SolidColorBrush)Application.Current.Resources["WolvenKitRed"]).Color)
                {
                    return EditorDifficultyLevel.Advanced;
                }
            }
            return DependencyProperty.UnsetValue;
        }
    }
}
