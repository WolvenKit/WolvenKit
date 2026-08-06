using System;
using System.Linq;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.HomePage.Pages;
using WolvenKit.Functionality.Helpers;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class WelcomePageView : ReactiveUserControl<WelcomePageViewModel>
    {
        public WelcomePageView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<WelcomePageViewModel>();
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel, vm => vm.SelectedPinnedOrder, v => v.PinnedOrder.SelectedValue);
                this.Bind(ViewModel, vm => vm.SelectedRecentOrder, v => v.RecentOrder.SelectedValue);
                this.Bind(ViewModel, vm => vm.PinnedFilter, v => v.PinnedFilter.Text);
                this.Bind(ViewModel, vm => vm.RecentFilter, v => v.RecentFilter.Text);

                this.BindCommand(
                    ViewModel,
                    vm => vm.OpenLinkCommand,
                    v => v.DiscordLinkButton,
                    vm => vm.DiscordLink);
                this.BindCommand(
                    ViewModel,
                    vm => vm.OpenLinkCommand,
                    v => v.YoutubeLinkButton,
                    vm => vm.YoutubeLink);
                //Twitter Link Not Used
                //this.BindCommand(
                //this.ViewModel,
                //vm => vm.OpenLinkCommand,
                //v => v.TwitterLinkButton,
                //vm => vm.TwitterLink);
                this.BindCommand(
                    ViewModel,
                    vm => vm.OpenLinkCommand,
                    v => v.OpenCollectiveLinkButton,
                    vm => vm.OpenCollectiveLink);
                this.BindCommand(
                    ViewModel,
                    vm => vm.OpenLinkCommand,
                    v => v.PatreonLinkButton,
                    vm => vm.PatreonLink);


                this.BindCommand(ViewModel,
                        viewModel => viewModel.NewProjectCommand,
                        view => view.NewProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.OpenProjectCommand,
                        view => view.OpenProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.CloseHomePageCommand,
                        view => view.ContinueWithoutProjectButton)
                    .DisposeWith(disposables);



            });

        }

        // Dynamically fills the "Move to existing group" submenu with the existing
        // groups when the context menu opens. Done in code-behind because command
        // bindings inside WPF submenus do not travel well across popups.
        private void ProjectContextMenu_Opened(object sender, RoutedEventArgs e)
        {
            if (sender is not ContextMenu contextMenu)
            {
                return;
            }

            if (contextMenu.PlacementTarget is not FrameworkElement element ||
                element.DataContext is not WelcomePageViewModel.FancyProjectObject project ||
                ViewModel is null)
            {
                return;
            }

            var parent = contextMenu.Items
                .OfType<MenuItem>()
                .FirstOrDefault(m => (m.Tag as string) == "MoveToGroupParent");
            if (parent is null)
            {
                return;
            }

            parent.Items.Clear();

            // Disabled (greyed out) when no group exists yet.
            parent.IsEnabled = ViewModel.AvailableGroups.Count > 0;

            foreach (var groupName in ViewModel.AvailableGroups)
            {
                var name = groupName; // local capture for the closure
                var item = new MenuItem { Header = name };
                item.Click += (_, _) => ViewModel.MoveProjectToGroup(project, name);
                parent.Items.Add(item);
            }
        }
    }
}
