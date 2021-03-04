using System.Windows;
using WolvenKit.MVVM.Views.Shell.Homepage.Pages.IntegratedToolsPages.CyberCAT;

namespace WolvenKit.MVVM.Views.Shell.HomePage.Pages
{
    public partial class IntegratedToolsPageView
    {
        public IntegratedToolsPageView()
        {
            InitializeComponent();

            GeneralTabItem.Content = new CyberCATPageView();
        }
    }
}
