namespace WolvenKit.Views.HomePage.Pages
{
    public partial class IntegratedToolsPageView
    {
        #region Constructors

        public IntegratedToolsPageView()
        {
            InitializeComponent();

            GeneralTabItem.Content = new CyberCATPageView();
        }

        #endregion Constructors
    }
}
