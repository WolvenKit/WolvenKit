using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ReactiveUI;
using Splat;
using System.Windows.Media;
using Syncfusion.Windows.Controls.Layout;
using Syncfusion.Windows.PropertyGrid;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels;
using System;
using System.Globalization;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class SettingsPageView : ReactiveUserControl<SettingsPageViewModel>
    {
        #region Constructors

        public SettingsPageView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<SettingsPageViewModel>();
            DataContext = ViewModel;
        }

        #endregion Constructors

        #region properties

        public ItemCollection AccordionItems { get; set; }


        #endregion

        private void ExitRestart_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Application.Restart();
            System.Windows.Application.Current.Shutdown();
        }

        private void SettingsPropertygrid_OnAutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
        {
            switch (e.DisplayName)
            {
                case nameof(ReactiveObject.Changed):
                case nameof(ReactiveObject.Changing):
                case nameof(ReactiveObject.ThrownExceptions):
                    e.Cancel = true;
                    break;
            }

            if (e.OriginalSource is PropertyItem { } propertyItem)
            {
                switch (propertyItem.DisplayName)
                {
                    case nameof(ISettingsDto.CP77ExecutablePath):
                        propertyItem.Editor = new Controls.SingleFilePathEditor();
                        break;
                    case nameof(ISettingsManager.MaterialRepositoryPath):
                        propertyItem.Editor = new Controls.SingleFolderPathEditor();
                        break;
                    case nameof(ISettingsDto.ThemeAccentString):
                        propertyItem.Editor = new BrushEditor();
                        break;
                }

                
            }
        }

        internal class BrushEditor : ITypeEditor
        {
            private ColorPickerPalette _editor;

            public void Attach(PropertyViewItem property, PropertyItem info)
            {
                if (info.CanWrite)
                {
                    var binding = new Binding("Value")
                    {
                        Mode = BindingMode.TwoWay,
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true,
                        Converter = new StringColorConverter()
                    };
                    BindingOperations.SetBinding(_editor, ColorPickerPalette.ColorProperty, binding);
                }
                else
                {
                    _editor.SetCurrentValue(UIElement.IsEnabledProperty, false);
                    var binding = new Binding("Value")
                    {
                        Source = info,
                        ValidatesOnExceptions = true,
                        ValidatesOnDataErrors = true
                    };
                    BindingOperations.SetBinding(_editor, ColorPickerPalette.ColorProperty, binding);
                }
            }
            public object Create(PropertyInfo propertyInfo)
            {
                _editor = new ColorPickerPalette();

                return _editor;
            }
            public void Detach(PropertyViewItem property)
            {

            }
        }

        [ValueConversion(typeof(Color), typeof(String))]
        public sealed class StringColorConverter : IValueConverter
        {
            public static readonly StringColorConverter Default = new StringColorConverter();

            // convert color to string
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                if (value is string strValue)
                {
                    try
                    {
                        var color = (Color)ColorConverter.ConvertFromString(strValue);
                        return color;
                    }
                    catch (FormatException)
                    {
                        return DependencyProperty.UnsetValue;
                    }
                }
                return DependencyProperty.UnsetValue;
            }

            // convert string to color or unsetvalue
            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                if (value is Color color)
                {
                    return color.ToString();
                }
                return DependencyProperty.UnsetValue;
            }
        }

    }


    
}
