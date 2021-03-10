using System.Windows;
using WolvenKit.Views.HomePage.Pages;

namespace WolvenKit.Views.HomePage.Pages
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
