using System;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.HomePage.Pages;

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

        /// <summary>
        /// CardView marks wheel events handled even when it does not scroll,
        /// so drive the projects ScrollViewer explicitly while the pointer is over it.
        /// </summary>
        private void ProjectsScrollViewer_OnPreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (sender is not ScrollViewer scrollViewer || e.Delta == 0)
            {
                return;
            }

            scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - e.Delta);
            e.Handled = true;
        }

        private void ProjectsScrollViewer_OnScrollChanged(object sender, ScrollChangedEventArgs e) =>
            UpdateStickySectionHeaders();

        private void ProjectsScrollContent_OnSizeChanged(object sender, SizeChangedEventArgs e) =>
            UpdateStickySectionHeaders();

        /// <summary>
        /// Sticky section headers: pin to the top of the scroll viewport when scrolling
        /// past them, and to the bottom when they would leave the bottom edge (so a
        /// long Pinned list still keeps the next section title visible). While the
        /// section is on-screen the header stays within the section’s vertical span
        /// for the top stick (doesn’t slide into the next section).
        /// </summary>
        private void UpdateStickySectionHeaders()
        {
            if (ProjectsScrollContent is null || !ProjectsScrollContent.IsLoaded)
            {
                return;
            }

            var offset = ProjectsScrollViewer.VerticalOffset;
            var viewportHeight = ProjectsScrollViewer.ViewportHeight;

            UpdateStickyHeader(PinnedSection, PinnedHeader, PinnedHeaderTransform, offset, viewportHeight);
            UpdateStickyHeader(RecentSection, RecentHeader, RecentHeaderTransform, offset, viewportHeight);
        }

        private void UpdateStickyHeader(
            FrameworkElement section,
            FrameworkElement header,
            TranslateTransform transform,
            double scrollOffset,
            double viewportHeight)
        {
            if (section is null || header is null || transform is null)
            {
                return;
            }

            if (section.Visibility != Visibility.Visible
                || !section.IsLoaded
                || section.ActualHeight <= 0
                || header.ActualHeight <= 0
                || viewportHeight <= 0)
            {
                transform.SetCurrentValue(TranslateTransform.YProperty, 0d);
                return;
            }

            // Layout position of the section within the scroll content (section has no sticky transform).
            Point sectionOrigin;
            try
            {
                sectionOrigin = section.TransformToAncestor(ProjectsScrollContent).Transform(new Point(0, 0));
            }
            catch (InvalidOperationException)
            {
                transform.SetCurrentValue(TranslateTransform.YProperty, 0d);
                return;
            }

            // Natural top of the header content (section top + top margin).
            var sectionTop = sectionOrigin.Y + header.Margin.Top;
            var headerBlockHeight = header.ActualHeight + header.Margin.Top + header.Margin.Bottom;
            // Max downward translation so the header does not leave the bottom of its section.
            var maxStick = Math.Max(0, section.ActualHeight - headerBlockHeight);

            // Viewport range in scroll-content coordinates.
            // Top stick:     headerTop >= scrollOffset              => Y >= scrollOffset - sectionTop
            // Bottom stick:  headerBottom <= scrollOffset + viewport => Y <= scrollOffset + viewport - headerH - sectionTop
            var yMin = scrollOffset - sectionTop;
            var yMax = scrollOffset + viewportHeight - headerBlockHeight - sectionTop;

            double y;
            if (yMin <= yMax)
            {
                // Prefer natural layout (Y = 0); clamp so the header stays fully inside the viewport.
                // Y can be negative (bottom stick pulls an upcoming header up onto the bottom edge)
                // or positive (top stick).
                y = Math.Clamp(0d, yMin, yMax);
            }
            else
            {
                // Header taller than the viewport: keep the top edge pinned when possible.
                y = yMin;
            }

            // Cap downward travel so the header leaves with the end of its section.
            if (y > maxStick)
            {
                y = maxStick;
            }

            transform.SetCurrentValue(TranslateTransform.YProperty, y);
        }
    }
}
