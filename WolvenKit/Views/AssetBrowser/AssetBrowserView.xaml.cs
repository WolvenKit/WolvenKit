
using Catel.Windows;

namespace WolvenKit.Views.AssetBrowser
{
    public partial class AssetBrowserView : DataWindow
    {
        public AssetBrowserView() : base(DataWindowMode.Custom)
        {
            InitializeComponent();
            ControlzEx.Theming.ThemeManager.Current.ChangeTheme(this, "Dark.Red"); //This aint needed was just for testing remove me.

        }
    }
}
