using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using WolvenKit.Core.Extensions;

namespace WolvenKit.Converters;

/// <summary>
/// Uses an enum's description attribute (see PhotoModeBodyGender)
/// </summary>
/// <example>
///     <ComboBox ItemsSource="{Binding SampleValues}" 
///         SelectedItem="{Binding SelectedValue, Converter={StaticResource enumConverter}}">
///         <ComboBox.ItemTemplate>
///             <DataTemplate>
///                 <TextBlock Text="{Binding Path=., Converter={StaticResource enumConverter}}" />
///             </DataTemplate>
///         </ComboBox.ItemTemplate>
///    </ComboBox>
/// </example>
public class EnumDescriptionConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var enumValue = value as Enum;

        return enumValue?.GetDescriptionFromEnumValue() ?? DependencyProperty.UnsetValue;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => value;
}