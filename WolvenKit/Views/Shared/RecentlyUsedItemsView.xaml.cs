using ReactiveUI;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.HomePage.Pages;

namespace WolvenKit.Views.Shared
{
    public partial class RecentlyUsedItemsView : ReactiveUserControl<RecentlyUsedItemsViewModel>
    {
        #region Constructors

        public RecentlyUsedItemsView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {

                this.BindCommand(
                    this.ViewModel,
                    vm => vm.OpenLinkCommand,
                    v => v.OpenProjectButton,
                    vm => vm.DiscordLink);
            });

        }

        #endregion Constructors

        #region Methods


        #endregion Methods
    }
}
