using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Input;
using AvalonDock.Layout.Serialization;
using Catel.Data;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Layout.MLib;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.ViewModels.Shell.Editor;

namespace WolvenKit.MVVM.Views.Shell.Editor
{
    public partial class MainView
    {
        #region fields

        private const string AvalonDockConfigPath = @".\Config\AvalonDock.Layout.config";

        private ICommand _loadLayoutCommand = null;
        private ICommand _saveLayoutCommand = null;

        #endregion fields

        #region Constructors

        public MainView()
        {
            InitializeComponent();

            var path = Path.GetFullPath(AvalonDockConfigPath);
            LayoutLoader = new LayoutLoader(AvalonDockConfigPath);

            StaticReferences.MainView = this;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets an object that loads the AvalonDock Xml layout string
        /// in an aysnchronous background task.
        /// </summary>
        private LayoutLoader LayoutLoader { get; set; }

        #endregion Properties

        #region Methods

        protected override async void OnLoaded(EventArgs e)
        {
            base.OnLoaded(e);


            // Testing Some shit
            await LayoutLoader.LoadLayoutAsync();
            // Loads empty layout?? Causes bug still ? (Not yet?)
            // Load and layout AvalonDock elements when MainWindow has loaded .... False info :kek:
            //
            // Layout shouldn't load directly mhm . . . .   // Load this when project opens ? :D

        }

        protected override void OnViewModelPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnViewModelPropertyChanged(e);

            if (e is not AdvancedPropertyChangedEventArgs property)
            {
                return;
            }

            switch (property.PropertyName)
            {
                case "SaveLayout":
                    OnSaveLayout();
                    break;

                default:
                    break;
            }
        }

        #endregion Methods

        #region methods

        #region LoadLayoutCommand

        public ICommand LoadLayoutCommand
        {
            get
            {
                if (_loadLayoutCommand == null)
                {
                    _loadLayoutCommand = new DelegateCommand<object>(
                        (p) => OnLoadLayoutAsync(p),
                        (p) => CanLoadLayout(p));
                }

                return _loadLayoutCommand;
            }
        }

        private bool CanLoadLayout(object parameter) => LayoutLoader.CanLoadLayout();

        private void OnLayoutLoaded_Event(object sender, LayoutLoadedEventArgs layoutLoadedEvent) => Application.Current.Dispatcher.Invoke(() =>
                                                                                                   {
                                                                                                       try
                                                                                                       {
                                                                                                           // Process the finally block since we have nothing to do here
                                                                                                           var result = layoutLoadedEvent?.Result;
                                                                                                           if (result == null)
                                                                                                           {
                                                                                                               return;
                                                                                                           }

                                                                                                           if (result.LoadwasSuccesful)
                                                                                                           {
                                                                                                               // Make sure AvalonDock control is visible at the end of restoring layout
                                                                                                               var stringLayoutSerializer = new XmlLayoutSerializer(dockManager);

                                                                                                               using var reader = new StringReader(result.XmlContent);
                                                                                                               stringLayoutSerializer.Deserialize(reader);
                                                                                                           }
                                                                                                       }
                                                                                                       catch (Exception exception)
                                                                                                       {
                                                                                                           Debug.WriteLine(exception);
                                                                                                       }
                                                                                                       finally
                                                                                                       {
                                                                                                           // Make sure AvalonDock control is visible at the end of restoring layout
                                                                                                           dockManager.SetCurrentValue(VisibilityProperty, Visibility.Visible);

                                                                                                           // show default tools
                                                                                                           //ServiceLocator.Default.ResolveType<ICommandManager>()
                                                                                                           //    .GetCommand(AppCommands.Application.ShowLog)
                                                                                                           //    .SafeExecute(true);
                                                                                                           //ServiceLocator.Default.ResolveType<ICommandManager>()
                                                                                                           //    .GetCommand(AppCommands.Application.ShowProjectExplorer)
                                                                                                           //    .SafeExecute(true);
                                                                                                       }
                                                                                                   }, System.Windows.Threading.DispatcherPriority.Background);


        // Hijacking this for purposes beyond my knowledge :O
        public async void OnLoadLayoutAsync(object parameter = null)
        {
            if (DataContext is WorkSpaceViewModel wspace)
            {
                wspace.CloseAllDocuments();
            }

            var loaderResult = await LayoutLoader.GetLayoutString(OnLayoutLoaded_Event);

            // Call this even with null to ensure standard initialization takes place
            OnLayoutLoaded_Event(null, loaderResult == null ? null : new LayoutLoadedEventArgs(loaderResult));
        }

        #endregion LoadLayoutCommand

        #region SaveLayoutCommand

        public ICommand SaveLayoutCommand =>
            _saveLayoutCommand ?? (_saveLayoutCommand =
                new DelegateCommand<object>((p) => OnSaveLayout(p), (p) => CanSaveLayout(p)));

        internal void OnSaveLayout(object parameter = null)
        {
            var layoutSerializer = new XmlLayoutSerializer(dockManager);
            layoutSerializer.Serialize(AvalonDockConfigPath);
        }

        private bool CanSaveLayout(object parameter) => true;

        #endregion SaveLayoutCommand

        #endregion methods

        private void UserControl_IsVisibleChanged_1(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible && IsLoaded)
            {
                DiscordHelper.SetDiscordRPCStatus("Main View");
            }
        }
    }
}
