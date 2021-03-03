using System.Collections.ObjectModel;
using System.Windows.Media;

namespace WolvenKit.Functionality.WKitGlobal.Helpers
{
    public static class ThemeHelper
    {
        #region Fields

        // Global List of userthemes.
        public static ObservableCollection<WkitTheme> UserThemes = new ObservableCollection<WkitTheme>();

        #endregion Fields



        #region Methods

        // Setup theming defaults.
        public static void InitializeThemeHelper()
        {
            HandyControl.Themes.ThemeManager.Current.SetCurrentValue(HandyControl.Themes.ThemeManager.ApplicationThemeProperty, HandyControl.Themes.ApplicationTheme.Dark);
            var tr = new HandyControl.Themes.ThemeResources
            {
                AccentColor = HandyControl.Tools.ResourceHelper.GetResource<Brush>("MahApps.Brushes.Accent3")
            };
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

        // Save user theme
        public static void SaveUserTheme(WkitTheme theme)
        {
            if (!UserThemes.Contains(theme))
            {
                UserThemes.Add(theme);
            }
        }

        #endregion Methods
    }

    public class WkitTheme
    {
        #region Fields

        public string ThemeHexColor;
        public string ThemeID;

        #endregion Fields

        #region Constructors

        public WkitTheme(string id, string hex)
        {
            ThemeID = id;
            ThemeHexColor = hex;
        }

        #endregion Constructors
    }
}
