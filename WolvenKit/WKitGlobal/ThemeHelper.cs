using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WolvenKit.WKitGlobal
{
    public class ThemeHelper
    {
        public void Themez()
        {
            Orc.Theming.ThemeManager.Current.SynchronizeTheme();
            //  ControlzEx.Theming.ThemeManager.Current.ChangeTheme(Application.Current, "Dark.Green");
            HandyControl.Themes.ThemeManager.Current.SetCurrentValue(HandyControl.Themes.ThemeManager.ApplicationThemeProperty, HandyControl.Themes.ApplicationTheme.Dark);
            HandyControl.Themes.ThemeResources tr = new HandyControl.Themes.ThemeResources(); tr.AccentColor = HandyControl.Tools.ResourceHelper.GetResource<Brush>("MahApps.Brushes.Accent3");
        }

    }
}
