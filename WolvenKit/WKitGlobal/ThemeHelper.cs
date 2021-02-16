using ControlzEx.Theming;
using System.Windows;
using System.Windows.Media;

namespace WolvenKit.WKitGlobal
{
    public class ThemeHelper
    {
        public void Themez()
        {




















        }


        public void InitializeThemeHelper()
        {


            HandyControl.Themes.ThemeManager.Current.SetCurrentValue(HandyControl.Themes.ThemeManager.ApplicationThemeProperty, HandyControl.Themes.ApplicationTheme.Dark);
            HandyControl.Themes.ThemeResources tr = new HandyControl.Themes.ThemeResources(); tr.AccentColor = HandyControl.Tools.ResourceHelper.GetResource<Brush>("MahApps.Brushes.Accent3");

            // Orc.Theming.ThemeManager.Current.SynchronizeTheme();
            // ThemeManager.Current.SyncTheme();
        }


        public void LoadUserTheme(string ColorHex)
        {
            string CustomName = "Custom" + ColorHex.ToString();
            var color = new SolidColorBrush((Color)ColorConverter.ConvertFromString(ColorHex));
            ThemeManager.Current.AddTheme(new Theme("CustomName", "CustomName", "Dark", "Red", (Color)ColorConverter.ConvertFromString(ColorHex), color, true, false));
            ThemeManager.Current.AddTheme(RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark", Colors.Red));
            ThemeManager.Current.ChangeTheme(Application.Current, "CustomName");



            Orc.Theming.ThemeManager.Current.SynchronizeTheme();
            ThemeManager.Current.SyncTheme();
        }

    }
}

