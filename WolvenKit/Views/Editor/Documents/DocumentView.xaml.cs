using System.Threading.Tasks;
using System.Windows;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Editor;

namespace WolvenKit.Views.Editor
{
    /// <summary>
    /// Interaction logic for TextDocumentView.xaml
    /// </summary>
    public partial class DocumentView
    {
        #region Fields

        private bool _viewInitialized;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Class constructor
        /// </summary>
        public DocumentView()
        {

            InitializeComponent();

            WeakEventManager<FrameworkElement, RoutedEventArgs>
                .AddHandler(this, "Loaded", View_LoadedAsync);

            
        }

        #endregion Constructors

        #region Methods

        private async Task LoadContentAsync()
        {
            _viewInitialized = true;                    // We'll try this only once

            if (DataContext is not IDocumentViewModel vm)
            {
                return;
            }

            try
            {
                var result = await vm.OpenFileWithInitialPathAsync();

                // Poor mans error handling:
                // Attempt to close this document if it appears to be invalid
                if (result == false)
                {
                    vm.CloseCommand.Execute(null);
                }

                NavigationItemChunks.DataContext = ViewModel as DocumentViewModel;
                NavigationItemImports.DataContext = ViewModel as DocumentViewModel;
            }
            catch
            {
            }
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Document View");
            }
        }

        /// <summary>
        /// Initializes the viewmodel and view as soon as the view is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void View_LoadedAsync(object sender, RoutedEventArgs e)
        {
            if (Visibility == Visibility.Visible && _viewInitialized == false)
            {
                await LoadContentAsync();
            }
        }

        #endregion Methods

        private void NavigationItem_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SetCollapsedAll();
            CHUNKSVISIBILITY.SetCurrentValue(VisibilityProperty, Visibility.Visible);

        }


        private void SetCollapsedAll()
        {
            CHUNKSVISIBILITY.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            BUFFERSVISIBILITY.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            IMPORTSVISISBILITY.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            EDITORSVISIBILITY.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);

        }

        private void NavigationItem_MouseLeftButtonDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SetCollapsedAll();
            IMPORTSVISISBILITY.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        }

        private void NavigationItem_MouseLeftButtonDown_2(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SetCollapsedAll();
            BUFFERSVISIBILITY.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        }

        private void NavigationItem_MouseLeftButtonDown_3(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SetCollapsedAll();
            EDITORSVISIBILITY.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        }
    }
}
