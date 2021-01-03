using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using AvalonDock.Layout.Serialization;
using Catel.Data;

namespace WolvenKit.Views
{
	using Commands;
	using ViewModels;
	using Layout.MLib;

	public partial class MainView
    {
        #region fields

        private const string AvalonDockConfigPath = @".\Resources\AvalonDock.Layout.config";


		ICommand _loadLayoutCommand = null;
        ICommand _saveLayoutCommand = null;
        #endregion fields

        public MainView()
        {
            InitializeComponent();

            var path = Path.GetFullPath(AvalonDockConfigPath);
            LayoutLoaded = new LayoutLoader(AvalonDockConfigPath);
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
						XmlLayoutSerializer stringLayoutSerializer;

						// Make sure AvalonDock control is visible at the end of restoring layout
						stringLayoutSerializer = new XmlLayoutSerializer(dockManager);

						////Here I've implemented the LayoutSerializationCallback just to show
						//// a way to feed layout deserialization with content loaded at runtime
						////Actually I could in this case let AvalonDock to attach the contents
						////from current layout using the content ids
						////LayoutSerializationCallback should anyway be handled to attach contents
						////not currently loaded

						//stringLayoutSerializer.LayoutSerializationCallback += (s, e) =>
						//{
						//	try
						//	{
						//		var workSpace = (DataContext as WorkSpaceViewModel);

						//		if (workSpace == null || string.IsNullOrEmpty(e.Model.ContentId))
						//		{
						//			e.Cancel = true;
						//			return;
						//		}

						//		// Is this a tool window layout ? Then, get its viewmodel and connect it to the view
						//		var tool = workSpace.Tools.FirstOrDefault(i => i.ContentId == e.Model.ContentId);
						//		if (tool != null)
						//		{
						//			e.Content = tool;
						//			return;
						//		}

						//		// Its not a tool window -> So, this could refer to a document then
						//		if (!string.IsNullOrWhiteSpace(e.Model.ContentId))
						//		{
						//			try
						//			{
						//				// Do not re-open files that are non-existing
						//				if (System.IO.File.Exists(e.Model.ContentId) == false)
						//				{
						//					e.Cancel = true;
						//					return;
						//				}
						//			}
						//			catch
						//			{
						//				e.Cancel = true;
						//				return;
						//			}

						//			DocumentViewModel vm = new DocumentViewModel(workSpace, e.Model.ContentId, true);

						//			if (vm != null)
						//			{
						//				workSpace.AddFile(vm);
						//				e.Content = vm;
						//				e.Cancel = false;
						//				return;
						//			}

						//			e.Cancel = true;
						//			return;
						//		}

						//		// Not something we could recognize -> So, we won't handle it beyond this point
						//		e.Cancel = true;
						//	}
						//	catch (System.Exception exc)
						//	{
						//		Debug.WriteLine(exc.StackTrace);
						//	}
						//};

						using (var reader = new StringReader(result.XmlContent))   // Read Xml Data from string
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

			App myApp = (App)Application.Current;

			LayoutLoaderResult LoaderResult = await this.LayoutLoaded.GetLayoutString(OnLayoutLoaded_Event);

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
            layoutSerializer.Serialize(AvalonDockConfigPath);
        }

		#endregion
        #endregion methods

	}
}