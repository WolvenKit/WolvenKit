using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using AvalonDock.Layout.Serialization;
using Catel.Data;
using MLibTest.Models;
using WolvenKit.App.Commands;
using WolvenKit.App.ViewModels;

namespace WolvenKitUI.Views
{
    public partial class MainView
    {
        #region fields
        ICommand _loadLayoutCommand = null;
        ICommand _saveLayoutCommand = null;
        #endregion fields

        public MainView()
        {
            InitializeComponent();

            var path = Path.GetFullPath(@".\Resources\AvalonDock.Layout.config");
            LayoutLoaded = new LayoutLoader(@".\Resources\AvalonDock.Layout.config");
		}

        /// <summary>
        /// Gets an object that loads the AvalonDock Xml layout string
        /// in an aysnchronous background task.
        /// </summary>
        private LayoutLoader LayoutLoaded { get; set; }

		protected override void OnViewModelPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnViewModelPropertyChanged(e);

            if (!(e is AdvancedPropertyChangedEventArgs property))
                return;

            switch (property.PropertyName)
            {
                case "SaveLayout":
                    OnSaveLayout();
                    break;
                default:
                    break;
            }
        }

        protected override async void OnLoaded(EventArgs e)
        {
            base.OnLoaded(e);

            await LayoutLoaded.LoadLayoutAsync();

            // Load and layout AvalonDock elements when MainWindow has loaded
            OnLoadLayoutAsync();

        }

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

		private bool CanLoadLayout(object parameter) => /*((App)Application.Current).*/LayoutLoaded.CanLoadLayout();

        private void OnLayoutLoaded_Event(object sender, LayoutLoadedEventArgs layoutLoadedEvent)
		{

			Application.Current.Dispatcher.Invoke(() =>
			{
				try
				{
					// Process the finally block since we have nothing to do here
					if (layoutLoadedEvent == null)
						return;

					// Process the finally block since we have nothing to do here
					var result = layoutLoadedEvent.Result;
					if (result == null)
						return;

					if (result.LoadwasSuccesful == true)
                    {
                        var stringLayoutSerializer = new XmlLayoutSerializer(dockManager);
                        using (var reader = new StringReader(result.XmlContent))
						{
							stringLayoutSerializer.Deserialize(reader);
						}
                    }
				}
				catch (System.Exception exception)
				{
					Debug.WriteLine(exception);
				}
				finally
				{
					// Make sure AvalonDock control is visible at the end of restoring layout
                    dockManager.SetCurrentValue(VisibilityProperty, Visibility.Visible);
					//loadProgress.Visibility = Visibility.Collapsed;
				}
			}, System.Windows.Threading.DispatcherPriority.Background);
		}

        private async void OnLoadLayoutAsync(object parameter = null)
		{
			if (this.DataContext is WorkSpaceViewModel wspace)
				wspace.CloseAllDocuments();

			//App myApp = (App)Application.Current;

			LayoutLoaderResult LoaderResult = await /*myApp.*/LayoutLoaded.GetLayoutString(OnLayoutLoaded_Event);

			// Call this even with null to ensure standard initialization takes place
			this.OnLayoutLoaded_Event(null, (LoaderResult == null ? null : new LayoutLoadedEventArgs(LoaderResult)));
		}

		#endregion

		#region SaveLayoutCommand
		public ICommand SaveLayoutCommand =>
            _saveLayoutCommand ?? (_saveLayoutCommand =
                new DelegateCommand<object>((p) => OnSaveLayout(p), (p) => CanSaveLayout(p)));

        private bool CanSaveLayout(object parameter) => true;

        private void OnSaveLayout(object parameter = null)
		{
			var layoutSerializer = new XmlLayoutSerializer(dockManager);
			layoutSerializer.Serialize(@".\Resources\AvalonDock.Layout.config");
		}

		#endregion
        #endregion methods

	}
}