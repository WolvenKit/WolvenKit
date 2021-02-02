
namespace WolvenKit.Views.HomePage.Pages
{
    public partial class IntegratedToolsPageView
    {
        public IntegratedToolsPageView()
        {
            InitializeComponent();

            GeneralTabItem.Content = new IntegratedToolsPages.CyberCAT.CyberCATPageView();
        }
    }
}
