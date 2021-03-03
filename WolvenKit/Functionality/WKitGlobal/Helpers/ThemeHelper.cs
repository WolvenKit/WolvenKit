using ControlzEx.Theming;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace WolvenKit.Functionality.WKitGlobal.Helpers
{
    public static class ThemeHelper
    {
        // Setup theming defaults.
        public static void InitializeThemeHelper() 
        {
            HandyControl.Themes.ThemeManager.Current.SetCurrentValue(HandyControl.Themes.ThemeManager.ApplicationThemeProperty, HandyControl.Themes.ApplicationTheme.Dark);
            HandyControl.Themes.ThemeResources tr = new HandyControl.Themes.ThemeResources();
            tr.AccentColor = HandyControl.Tools.ResourceHelper.GetResource<Brush>("MahApps.Brushes.Accent3");
        }


        // Global List of userthemes.
        public static ObservableCollection<WkitTheme> UserThemes = new ObservableCollection<WkitTheme>();

        // Save user theme
        public static void SaveUserTheme(WkitTheme theme)
        {
            if (!UserThemes.Contains(theme))
            {
                UserThemes.Add(theme);
            }
        }

        // Load user theme
        public static void LoadUserTheme(string theme)
        {
            
        }







        public static void LoadUserThemeTemp(string ColorHex) // Not used , keep for now
        {
            //string CustomName = "Custom" + ColorHex.ToString();
            //var color = new SolidColorBrush((Color)ColorConverter.ConvertFromString(ColorHex));
            //ThemeManager.Current.AddTheme(new Theme("CustomName", "CustomName", "Dark", "Red", (Color)ColorConverter.ConvertFromString(ColorHex), color, true, false));
            //ThemeManager.Current.AddTheme(RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark", Colors.Red));
            //ThemeManager.Current.ChangeTheme(Application.Current, "CustomName");
            //Orc.Theming.ThemeManager.Current.SynchronizeTheme();
            //ThemeManager.Current.SyncTheme();
        }

    }


    public class WkitTheme { public string ThemeID; public string ThemeHexColor; public WkitTheme(string id, string hex) { ThemeID = id; ThemeHexColor = hex; } }
}

