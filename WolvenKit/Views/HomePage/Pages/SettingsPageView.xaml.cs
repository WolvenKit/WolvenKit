using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.Controls.Layout;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.ViewModels.HomePage.Pages;

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

            AccordionItems = SfAccordion.Items;
        }

        #endregion Constructors

        #region properties

        public ItemCollection AccordionItems { get; set; }


        #endregion

        #region Methods

        private void TabControlDemo_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // I wanted to add logic that the selected tab item moves to be the first in the row but I am not sure it works with the HC tabcontrol. If someone feels liek testing this later go ahead :D
        }

        #endregion Methods

        private void SfAccordionItem_Unselected(object sender, RoutedEventArgs e)
        {

        }

        private void ExitRestart_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Application.Restart();
            System.Windows.Application.Current.Shutdown();
        }

        private void CP77SettingsPG_OnAutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
        {
            switch (e.DisplayName)
            {
                case nameof(ReactiveObject.Changed):
                case nameof(ReactiveObject.Changing):
                case nameof(ReactiveObject.ThrownExceptions):
                    e.Cancel = true;
                    break;
            }
        }

        private void GeneralSettingsPG_OnAutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
        {
            switch (e.DisplayName)
            {
                case nameof(ReactiveObject.Changed):
                case nameof(ReactiveObject.Changing):
                case nameof(ReactiveObject.ThrownExceptions):
                    e.Cancel = true;
                    break;
            }
        }
    }
}
