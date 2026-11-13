using System;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ReactiveUI;
using Splat;
using WolvenKit.App.Services.Themes;
using WolvenKit.App.ViewModels.HomePage.Pages;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class WelcomePageView : ReactiveUserControl<WelcomePageViewModel>, IThemeAware
    {
        private bool _isStackedLayout;
        private bool _layoutModeInitialized;
        private bool _reskinned;
        private bool _refreshQueued;
        private Window _hostWindow;

        public WelcomePageView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<WelcomePageViewModel>();
            DataContext = ViewModel;

            Loaded += OnLoaded;
            Unloaded += OnUnloaded;
            IsVisibleChanged += OnIsVisibleChanged;

            Locator.Current.GetService<IThemeService>()?.Register(this);
            SizeChanged += (_, _) => UpdateLayoutMode();

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

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            if (_hostWindow is null)
            {
                _hostWindow = Window.GetWindow(this);
                if (_hostWindow is not null)
                {
                    _hostWindow.SizeChanged += OnHostWindowSizeChanged;
                }
            }

            UpdateLayoutMode();
        }

        private void OnUnloaded(object sender, RoutedEventArgs e)
        {
            if (_hostWindow is not null)
            {
                _hostWindow.SizeChanged -= OnHostWindowSizeChanged;
                _hostWindow = null;
            }
        }

        private void OnHostWindowSizeChanged(object sender, SizeChangedEventArgs e) => UpdateLayoutMode();

        /// <summary>
        /// Re-applying the skin re-templates the Syncfusion CardViews of this page, and afterwards they show no
        /// cards, whatever ItemsSource they get. A new page built after the switch is fine (as when the theme was
        /// changed with a project open), so once Home is on screen again the page puts a new instance of itself
        /// in its place. The lists live in the (shared) view model, nothing is lost.
        /// </summary>
        void IThemeAware.OnThemeChanged()
        {
            _reskinned = true;
            if (IsVisible)
            {
                RefreshProjectListsWhenIdle();
            }
        }

        /// <summary>
        /// The lists are filled again whenever the page comes on screen (e.g. Home opened from a project).
        /// Only a few cards: cheap.
        /// </summary>
        private void OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                RefreshProjectListsWhenIdle();
            }
        }

        /// <summary>
        /// One refill per idle: the theme switch and the window coming back both ask for one.
        /// </summary>
        private void RefreshProjectListsWhenIdle()
        {
            if (_refreshQueued)
            {
                return;
            }

            _refreshQueued = true;
            Dispatcher.BeginInvoke(RefreshProjectLists, System.Windows.Threading.DispatcherPriority.ApplicationIdle);
        }

        /// <summary>
        /// Fills the project lists again; the view model hands both CardViews new collections. After a theme
        /// switch, replaces the page instead (see <see cref="IThemeAware.OnThemeChanged"/>).
        /// </summary>
        private void RefreshProjectLists()
        {
            _refreshQueued = false;

            // While the window is hidden for the theme switch it is too early; the window coming back asks again.
            if (ViewModel is null || !IsVisible)
            {
                return;
            }

            if (_reskinned && Parent is ContentControl host)
            {
                _reskinned = false;
                host.SetCurrentValue(ContentControl.ContentProperty, new WelcomePageView());
                Locator.Current.GetService<ILoggerService>()?.Debug("Welcome page: rebuilt after a theme switch.");
                return;
            }

            ViewModel.RefreshProjectLists();

            Locator.Current.GetService<ILoggerService>()?.Debug(
                $"Welcome page: project lists refilled ({ViewModel.FancyPinnedProjects.Count} pinned, {ViewModel.FancyProjects.Count} recent)");
        }

        /// <summary>
        /// Side-by-side: projects and actions each scroll in place.
        /// Stacked (narrow / high UI scale): one page scroll, projects above actions.
        /// Break matches ProjectsResponsiveStyle / MainActionsResponsiveStyle.
        /// </summary>
        private void UpdateLayoutMode()
        {
            if (PageScrollViewer is null
                || ContentRow is null
                || ProjectsScrollViewer is null
                || ActionsScrollViewer is null)
            {
                return;
            }

            var breakWidthResource = TryFindResource("WolvenKitWelcomeActionsColumnBreakWidth")
                ?? Application.Current?.TryFindResource("WolvenKitWelcomeActionsColumnBreakWidth");
            var breakWidth = breakWidthResource is double d ? d : 914d;

            var width = _hostWindow?.ActualWidth ?? ActualWidth;
            if (width <= 0)
            {
                return;
            }

            var stacked = width < breakWidth;
            if (_layoutModeInitialized && stacked == _isStackedLayout)
            {
                return;
            }

            _layoutModeInitialized = true;
            _isStackedLayout = stacked;

            if (stacked)
            {
                ContentRow.SetCurrentValue(RowDefinition.HeightProperty, GridLength.Auto);
                PageScrollViewer.SetCurrentValue(ScrollViewer.VerticalScrollBarVisibilityProperty, ScrollBarVisibility.Auto);
                ProjectsScrollViewer.SetCurrentValue(ScrollViewer.VerticalScrollBarVisibilityProperty, ScrollBarVisibility.Disabled);
                ActionsScrollViewer.SetCurrentValue(ScrollViewer.VerticalScrollBarVisibilityProperty, ScrollBarVisibility.Disabled);

                // Sticky headers only apply to the projects scroller.
                PinnedHeaderTransform?.SetCurrentValue(TranslateTransform.YProperty, 0d);
                RecentHeaderTransform?.SetCurrentValue(TranslateTransform.YProperty, 0d);
            }
            else
            {
                ContentRow.SetCurrentValue(RowDefinition.HeightProperty, new GridLength(1, GridUnitType.Star));
                PageScrollViewer.SetCurrentValue(ScrollViewer.VerticalScrollBarVisibilityProperty, ScrollBarVisibility.Disabled);
                ProjectsScrollViewer.SetCurrentValue(ScrollViewer.VerticalScrollBarVisibilityProperty, ScrollBarVisibility.Auto);
                ActionsScrollViewer.SetCurrentValue(ScrollViewer.VerticalScrollBarVisibilityProperty, ScrollBarVisibility.Auto);
            }
        }

        /// <summary>
        /// CardView marks wheel events handled even when it does not scroll,
        /// so drive the active ScrollViewer explicitly while the pointer is over projects.
        /// </summary>
        private void ProjectsScrollViewer_OnPreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta == 0)
            {
                return;
            }

            // Stacked: page scrolls projects then buttons as one document.
            if (_isStackedLayout)
            {
                PageScrollViewer.ScrollToVerticalOffset(PageScrollViewer.VerticalOffset - e.Delta);
                e.Handled = true;
                return;
            }

            if (sender is not ScrollViewer scrollViewer)
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
            if (_isStackedLayout || ProjectsScrollContent is null || !ProjectsScrollContent.IsLoaded)
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
