using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Layout;
using WolvenKit.Views.GraphEditor;
using DockState = WolvenKit.App.Models.Docking.DockState;

namespace WolvenKit.Views.Shell
{
    //https://github.com/SyncfusionExamples/working-with-wpf-docking-manager-and-mvvm

    /// <summary>
    /// Interaction logic for DockingAdapter.xaml
    /// </summary>
    public partial class DockingAdapter : UserControl, WolvenKit.App.Services.Themes.IThemeAware
    {
        private readonly ILoggerService _logger;

        private AppViewModel _viewModel;
        private Window _mainWindow;
        private bool _stateChanged;
        private bool _isLayoutLoaded;

        private readonly bool _debuggingLayouts = false;

        public DockingAdapter()
        {
            _logger = Locator.Current.GetService<ILoggerService>();

            InitializeComponent();
            G_Dock = this;

            _viewModel = DataContext as AppViewModel ?? Locator.Current.GetService<AppViewModel>();

            if (_viewModel is not null)
            {
                _viewModel.OnAppLoaded += (_, _) => LoadLayoutFromProject();
            }

            if (Locator.Current.GetService<WolvenKit.App.Services.Themes.IThemeService>() is { } themeService)
            {
                themeService.Register(this);
            }
        }

        /// <summary>
        /// The document tab styles are based on Syncfusion styles that were resolved when this view was loaded.
        /// Their templates hold the colors of that time (StaticResource), e.g. the background of a selected tab
        /// whose document is not active. After a theme switch, rebase ours on freshly loaded Syncfusion styles.
        /// </summary>
        void WolvenKit.App.Services.Themes.IThemeAware.OnThemeChanged()
        {
            var fresh = LoadFreshDockingStyles();
            PART_DockingManager.SetCurrentValue(DockingManager.DocumentTabItemStyleProperty,
                Rebase((Style)PART_DockingManager.GetValue(DockingManager.DocumentTabItemStyleProperty), fresh, "SyncfusionDocumentTabItemExtStyle"));
            PART_DockingManager.SetCurrentValue(DockingManager.DocumentTabControlStyleProperty,
                Rebase((Style)PART_DockingManager.GetValue(DockingManager.DocumentTabControlStyleProperty), fresh, "SyncfusionDocumentTabControlExtStyle"));
        }

        private const string SyncfusionDockingStylesUri =
            "pack://application:,,,/Syncfusion.Themes.MaterialDark.WPF;component/DockingManager/DockingManager.xaml";

        /// <summary>
        /// A new instance of Syncfusion's DockingManager styles. Its styles are created on first access, so after
        /// its Brushes.xaml is swapped for the application's (recolored) one they pick up the current theme colors.
        /// The styles already in the application resources keep the colors from when they were first used.
        /// </summary>
        private ResourceDictionary LoadFreshDockingStyles()
        {
            try
            {
                if (FindSyncfusionBrushes(Application.Current.Resources) is not { } brushes)
                {
                    _logger.Debug("Themes: Syncfusion Brushes.xaml not found in the application resources.");
                    return null;
                }

                var fresh = new ResourceDictionary { Source = new Uri(SyncfusionDockingStylesUri, UriKind.Absolute) };
                ReplaceSyncfusionBrushes(fresh, brushes);
                return fresh;
            }
            catch (Exception e)
            {
                _logger.Warning($"Themes: could not load the Syncfusion docking styles: {e.Message}");
                return null;
            }
        }

        private static bool IsSyncfusionBrushes(ResourceDictionary dictionary) =>
            dictionary.Source?.OriginalString.EndsWith("/Common/Brushes.xaml", StringComparison.OrdinalIgnoreCase) == true;

        private static ResourceDictionary FindSyncfusionBrushes(ResourceDictionary dictionary)
        {
            foreach (var merged in dictionary.MergedDictionaries)
            {
                if (IsSyncfusionBrushes(merged))
                {
                    return merged;
                }
                if (FindSyncfusionBrushes(merged) is { } found)
                {
                    return found;
                }
            }
            return null;
        }

        private static void ReplaceSyncfusionBrushes(ResourceDictionary dictionary, ResourceDictionary brushes)
        {
            for (var i = 0; i < dictionary.MergedDictionaries.Count; i++)
            {
                var merged = dictionary.MergedDictionaries[i];
                if (IsSyncfusionBrushes(merged))
                {
                    dictionary.MergedDictionaries[i] = brushes;
                }
                else
                {
                    ReplaceSyncfusionBrushes(merged, brushes);
                }
            }
        }

        /// <summary>A copy of <paramref name="style"/> based on <paramref name="baseKey"/> from <paramref name="fresh"/>.</summary>
        private Style Rebase(Style style, ResourceDictionary fresh, string baseKey)
        {
            if (style is null || fresh?[baseKey] is not Style basedOn)
            {
                _logger.Debug($"Themes: {baseKey} not available, document tab style not rebased.");
                return style;
            }

            try
            {
                var copy = new Style(style.TargetType, basedOn);
                foreach (var setterBase in style.Setters)
                {
                    if (setterBase is Setter setter)
                    {
                        copy.Setters.Add(new Setter(setter.Property, CopyValue(setter.Value), setter.TargetName));
                    }
                }
                _logger.Debug($"Themes: {style.TargetType.Name} style rebased on {baseKey} (new base: {!ReferenceEquals(basedOn, style.BasedOn)}).");
                return copy;
            }
            catch (Exception e)
            {
                _logger.Warning($"Themes: could not rebase the {style.TargetType.Name} style: {e.Message}");
                return style;
            }

            // {DynamicResource} setter values: keep them dynamic in the copy
            static object CopyValue(object value)
            {
                if (value is null || value is DynamicResourceExtension)
                {
                    return value;
                }
                var keyField = value.GetType().GetField("_resourceKey",
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                return keyField?.GetValue(value) is { } key ? new DynamicResourceExtension(key) : value;
            }
        }

        public static DockingAdapter G_Dock;

        public IDocumentViewModel ActiveDocument
        {
            get => (IDocumentViewModel)GetValue(ActiveDocumentProperty);
            set => SetValue(ActiveDocumentProperty, value);
        }

        // Using a DependencyProperty as the backing store for ActiveDocument.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ActiveDocumentProperty = DependencyProperty.Register(
            nameof(ActiveDocument),
            typeof(IDocumentViewModel),
            typeof(DockingAdapter),
            new PropertyMetadata(null, OnActiveDocumentChanged)
        );

        public object ItemsSource
        {
            get => GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        // Using a DependencyProperty as the backing store for ItemsSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(nameof(ItemsSource), typeof(object), typeof(DockingAdapter), new PropertyMetadata(null));


        #region methods

        public void SaveLayout(bool saveAsDefault = false)
        {
            if (ItemsSource == null)
            {
                return;
            }

            if (!saveAsDefault && DataContext is AppViewModel { ActiveProject: { } project })
            {
                SaveLayout(Path.Combine(project.ProjectDirectory, "layout.xml"));
            }
            else
            {
                SaveLayout(Path.Combine(ISettingsManager.GetAppData(), "DockStates.xml"));
            }
        }

        private void SaveLayout(string filePath)
        {
            var tmpPath = Path.ChangeExtension(filePath, ".tmp");
            if (File.Exists(tmpPath))
            {
                File.Delete(tmpPath);
            }

            var writer = XmlWriter.Create(tmpPath);
            PART_DockingManager.SaveDockState(writer);
            writer.Close();

            var size = (new FileInfo(tmpPath)).Length;
            if (size < 1000)
            {
                File.Delete(tmpPath);
                _logger.Info($"Failed to save layout to {filePath}");
            }
            else
            {
                File.Move(tmpPath, filePath, true);
                _logger.Info($"Saved current layout to {filePath}");
            }
        }

        private void LoadLayoutFromProject()
        {
            if (_viewModel?.ActiveProject is null)
            {
                return;
            }

            var projectLayout = Path.Combine(_viewModel.ActiveProject.ProjectDirectory, "layout.xml");
            if (!File.Exists(projectLayout))
            {
                LoadDefaultLayout();
                return;
            }

            try
            {
                if (!LoadLayout(projectLayout, "project"))
                {
                    _logger.Error("Error while loading the project layout. Restoring default layout");
                    LoadDefaultLayout();
                }
            }
            catch
            {
                _logger.Error("Project layout seems to have gotten corrupted. Wolvenkit will now try to delete it...");
                _logger.Error("If that does not work, close Wolvenkit and delete or rename the following files:");
                _logger.Error("(This will reset your settings)");
                _logger.Error(projectLayout);
                _logger.Error(Path.Combine(ISettingsManager.GetAppData(), "DockStates.xml"));
                _logger.Error(Path.Combine(ISettingsManager.GetAppData(), "config.json"));


                File.Delete(projectLayout);
            }
        }

        public void ResetDefaultLayout()
        {
            var appDataLayoutPath = Path.Combine(ISettingsManager.GetAppData(), "DockStates.xml");
            if (!File.Exists(appDataLayoutPath))
            {
                _logger.Info("You don't have a custom default layout");
                return;
            }

            File.Delete(appDataLayoutPath);
            _logger.Success("Your custom default layout was reset");
        }

        public void LoadDefaultLayout()
        {
            if (DataContext is AppViewModel { ActiveProject: { } project })
            {
                File.Delete(Path.Combine(project.ProjectDirectory, "layout.xml"));
            }

            var appDataLayoutPath = Path.Combine(ISettingsManager.GetAppData(), "DockStates.xml");

            if (LoadLayout(appDataLayoutPath, "default"))
            {
                return;
            }

            var systemLayoutPath = Path.GetFullPath("DockStatesDefault.xml");

            File.Copy(systemLayoutPath, appDataLayoutPath, true);

            if (!LoadLayout(appDataLayoutPath, "default"))
            {
                _logger.Error("Can't load system layout. Please re-download WolvenKit");
            }
        }

        private bool LoadLayout(string filePath, string layoutSource = "")
        {
            _logger.Info($"Trying to load {layoutSource} layout from {filePath}...");

            if (DataContext is not AppViewModel appViewModel)
            {
                throw new Exception();
            }

            if (!File.Exists(filePath))
            {
                _logger.Debug($"No {layoutSource} layout found");
                return false;
            }

            try
            {
                PART_DockingManager.BeginInit(); // Begin batch updates

                using (var reader = XmlReader.Create(filePath))
                {

                    var defaultXmlSerializer = DockingManager.CreateDefaultXmlSerializer(typeof(List<DockingParams>));
                    if (!defaultXmlSerializer.CanDeserialize(reader))
                    {
                        _logger.Error($"{layoutSource} layout can't be deserialized");
                        return false;
                    }

                    var dockingParamsList = defaultXmlSerializer.Deserialize(reader) as List<DockingParams>;
                    if (dockingParamsList == null)
                    {
                        _logger.Error($"{layoutSource} layout can't be deserialized");
                        return false;
                    }

                    var newDockedWindows = dockingParamsList.Select(dockingParam => dockingParam.Name).ToList();
                    for (var i = PART_DockingManager.Children.Count - 1; i >= 0; i--)
                    {
                        if (PART_DockingManager.Children[i] is not ContentControl contentControl ||
                            contentControl.Content is not IDockElement dockElement)
                        {
                            throw new Exception($"Can't unload {PART_DockingManager.Children[i].Name}");
                        }

                        if (newDockedWindows.Contains(contentControl.Name))
                        {
                            continue;
                        }

                        appViewModel.DockedViews.Remove(dockElement);
                        PART_DockingManager.Children.Remove(contentControl);
                    }

                    // Check if the panel already exists. If not, try creating it via AddDockedPane.
                    foreach (var dockingParam in dockingParamsList
                                 .Where(dockingParam =>
                                     PART_DockingManager.Children.OfType<FrameworkElement>()
                                         .All(child => child.Name != dockingParam.Name))
                                 .Where(dockingParam => !appViewModel.AddDockedPane(dockingParam.Name)))
                    {
                        _logger.Warning($"ViewModel for \"{dockingParam.Name}\" could not be found!");
                    }
                }

                // Now load layout
                var isSuccess = false;

                using (var reader = XmlReader.Create(filePath))
                {
                    isSuccess = PART_DockingManager.LoadDockState(reader);
                }

                return isSuccess;
            }
            catch (Exception e)
            {
                _logger.Error(e);
            }
            finally
            {
                PART_DockingManager.EndInit(); // End batch updates
            }


            return false;
        }

        /// <summary>The current dock state as XML, e.g. to keep the layout while the color theme is re-applied.</summary>
        public string CaptureDockState()
        {
            using var stringWriter = new StringWriter();
            using (var writer = XmlWriter.Create(stringWriter))
            {
                PART_DockingManager.SaveDockState(writer);
            }
            return stringWriter.ToString();
        }

        /// <summary>Restores a state from <see cref="CaptureDockState"/>. The same panels must still be open.</summary>
        public void RestoreDockState(string dockState)
        {
            try
            {
                PART_DockingManager.BeginInit();
                using var reader = XmlReader.Create(new StringReader(dockState));
                PART_DockingManager.LoadDockState(reader);
            }
            catch (Exception e)
            {
                _logger.Error($"Could not restore the layout: {e.Message}");
            }
            finally
            {
                PART_DockingManager.EndInit();
            }
        }

        public DataTemplate FindDataTemplate(Type type, FrameworkElement element)
        {
            if (element.TryFindResource(type) is DataTemplate dataTemplate)
            {
                return dataTemplate;
            }

            if (type.BaseType != null && type.BaseType != typeof(object))
            {
                dataTemplate = FindDataTemplate(type.BaseType, element);
                if (dataTemplate != null)
                {
                    return dataTemplate;
                }
            }

            foreach (var interfaceType in type.GetInterfaces())
            {
                dataTemplate = FindDataTemplate(interfaceType, element);
                if (dataTemplate != null)
                {
                    return dataTemplate;
                }
            }

            return null;
        }

        private async Task<bool> TryCloseDocumentAsync(DocumentViewModel vm)
        {
            if (!await AppViewModel.CanCloseDocumentAsync(vm))
            {
                return false;
            }

            if (ItemsSource is IList list)
            {
                list.Remove(vm);
            }
            _viewModel.UpdateTitle();

            await _viewModel.CloseDocumentAsync(vm, true);

            return true;
        }

        private bool TryCloseDocument(DocumentViewModel vm)
        {
            if (!AppViewModel.CanCloseDocument(vm))
            {
                return false;
            }

            if (ItemsSource is IList list)
            {
                list.Remove(vm);
            }
            _viewModel.UpdateTitle();

            _viewModel.CloseDocument(vm, true);

            return true;
        }

        #endregion

        #region events

        /// <summary>
        /// fires when a document (but no tool window) gets closed through clicking the close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void PART_DockingManagerOnCloseButtonClick(object sender, CloseButtonEventArgs e)
        {
            if (e.TargetItem is ContentControl { Content: DocumentViewModel vm })
            {
                e.Cancel = !await TryCloseDocumentAsync(vm);
            }
        }

        /// <summary>
        /// fires when a document (but no tool window) gets closed through clicking the close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="keyEventArgs"></param>
        private void PART_DockingManagerOnKeyDown(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.Key == Key.W && Keyboard.Modifiers == ModifierKeys.Control)
            {
                _viewModel.CloseLastActiveDocument();
            }
        }

        /// <summary>
        /// For windows in Float, Dock and AutoHidden state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PART_DockingManager_WindowClosing(object sender, WindowClosingEventArgs e)
        {
            if (e.TargetItem is ContentControl { Content: DocumentViewModel vm })
            {
                e.Cancel = !TryCloseDocument(vm);
            }
        }

        private void PART_DockingManager_Loaded(object sender, RoutedEventArgs e)
        {
            ((DocumentContainer)PART_DockingManager.DocContainer).SetCurrentValue(DocumentContainer.AddTabDocumentAtLastProperty, true);

            // Loaded is raised again when the color theme is re-applied. The layout is already in place then,
            // and loading the default one would replace the project layout.
            if (!_isLayoutLoaded)
            {
                LoadDefaultLayout();
                _isLayoutLoaded = true;
            }

            if (_debuggingLayouts)
            {
                SaveLayout();
            }

            // update the vms
            foreach (FrameworkElement frameworkElement in PART_DockingManager.Children)
            {
                if (frameworkElement is not ContentControl { Content: PaneViewModel vm } contentControl)
                {
                    continue;
                }

                vm.State = DockingManager.GetState(contentControl).ToDockState();

            }

            _viewModel ??= DataContext as AppViewModel;
        }

        private void PART_DockingManagerOnDockStateChanging(FrameworkElement sender, DockStateChangingEventArgs e)
        {
            if (e.SourceElement is ContentControl { Content: PaneViewModel vm })
            {
                vm.State = e.TargetState.ToDockState();
            }
        }

        private void PART_DockingManagerOnDockStateChanged(FrameworkElement sender, DockStateEventArgs e)
        {
            if (e.NewState == Syncfusion.Windows.Tools.Controls.DockState.Float)
            {
                _stateChanged = true;
            }
        }

        private void PART_DockingManager_ActiveWindowChanged_1(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // set active property
            if (e.OldValue is ContentControl oldValue)
            {
                if (oldValue.Content is IDockElement { IsActive: true } dockElement)
                {
                    dockElement.IsActive = false;
                }
            }

            var projectName = _viewModel?.ActiveProject?.ModName ?? string.Empty;


            if (e.NewValue is ContentControl content)
            {
                if (content.Content is IDockElement { IsActive: false } dockElement)
                {
                    dockElement.IsActive = true;
                }

                var propertiesViewModel = Locator.Current.GetService<PropertiesViewModel>();
                switch (content.Content)
                {
                    case ProjectExplorerViewModel { SelectedItem: not null } pevm:
                        //propertiesViewModel.SetToNullAndResetVisibility();
                        propertiesViewModel.PE_FileInfoVisible = true;
                        propertiesViewModel.AB_FileInfoVisible = false;
                        propertiesViewModel.ExecuteSelectFile(pevm.SelectedItem);
                        break;
                    case AssetBrowserViewModel { RightSelectedItem: not null } abvm:
                        //propertiesViewModel.SetToNullAndResetVisibility();
                        propertiesViewModel.AB_FileInfoVisible = true;
                        propertiesViewModel.PE_FileInfoVisible = false;
                        propertiesViewModel.ExecuteSelectFile(abvm.RightSelectedItem);
                        break;
                }

                // DO NOT MERGE THESE SWITCH CASES
                // Both of them have to run
                switch (content.Content)
                {
                    case string s:
                        DiscordHelper.SetDiscordRPCStatus(s, projectName);
                        break;
                    case RedDocumentViewModel rdvm:
                        DiscordHelper.SetDiscordRPCStatus("Working on " + rdvm.Header, projectName);
                        break;
                }

                //if (((IDockElement)content.Content).State == DockState.Document)
                try
                {
                    if (content.Content is IDocumentViewModel document)
                    {
                        SetCurrentValue(ActiveDocumentProperty, document);
                    }
                }
                catch (Exception)
                {
                    // Don't activate it
                }

            }

            if (e is { OldValue: ContentControl, NewValue: null })
            {
                DiscordHelper.SetDiscordRPCStatus("-", projectName);
            }

            _viewModel?.UpdateTitle();
        }

        private async void PART_DockingManager_OnCloseAllTabs(object sender, CloseTabEventArgs e)
        {
            var closeTasks = e.ClosingTabItems.OfType<TabItemExt>()
                .Select(item => item.Content).OfType<ContentPresenter>()
                .Select(contentPresenter => contentPresenter.Content).OfType<ContentControl>()
                .Select(contentControl => contentControl.Content).OfType<DocumentViewModel>()
                .Select(TryCloseDocumentAsync);

            var results = await Task.WhenAll(closeTasks);

            e.Cancel = results.Any(x => !x);
        }

        public bool CloseAll()
        {
            if (_viewModel == null)
            {
                return true;
            }

            var allClosed = true;

            for (var i = _viewModel.DockedViews.Count - 1; i >= 0; i--)
            {
                if (_viewModel.DockedViews[i] is DocumentViewModel doc && !TryCloseDocument(doc))
                {
                    allClosed = false;
                }
            }

            return allClosed;
        }

        private async void PART_DockingManager_OnCloseOtherTabs(object sender, CloseTabEventArgs e)
        {
            var closeTasks = e.ClosingTabItems.OfType<TabItemExt>()
                .Select(item => item.Content).OfType<ContentPresenter>()
                .Select(contentPresenter => contentPresenter.Content).OfType<ContentControl>()
                .Select(contentControl => contentControl.Content).OfType<DocumentViewModel>()
                .Select(TryCloseDocumentAsync);

            var results = await Task.WhenAll(closeTasks);

            e.Cancel = results.Any(x => !x);
        }


        private void DockingAdapterOnLoaded(object sender, RoutedEventArgs e)
        {
            _mainWindow = Window.GetWindow(this);
            if (_mainWindow == null)
            {
                return;
            }

            _mainWindow.Deactivated += OnMainWindowDeactivated;
            _mainWindow.Closing += OnMainWindowClosing;

        }

        private void OnMainWindowDeactivated(object sender, EventArgs e)
        {
            if (_stateChanged)
            {
                foreach (Window win in Application.Current.Windows)
                {
                    if (win is NativeFloatWindow && win.Owner != null)
                    {
                        win.Owner = null;
                    }
                }
            }

            _stateChanged = false;
        }

        private static void OnMainWindowClosing(object sender, CancelEventArgs e) => Application.Current.Windows.OfType<NativeFloatWindow>()
            .ToList().ForEach(win => win.Close());

        private static void OnActiveDocumentChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            if (sender is not DockingAdapter adapter)
            {
                return;
            }

            foreach (FrameworkElement element in adapter.PART_DockingManager.Children)
            {
                if (element is not ContentControl control || control.Content != args.NewValue)
                {
                    continue;
                }

                adapter.PART_DockingManager.SetCurrentValue(DockingManager.ActiveWindowProperty, control);

                adapter._viewModel?.UpdateTitle();

                break;
            }
        }

        public void OnActiveProjectChanged() => LoadLayoutFromProject();

        /// <summary>
        /// This happens on the very first tool window assignments
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            if (e.Property.Name != "ItemsSource")
            {
                base.OnPropertyChanged(e);
                return;
            }

            if (e.OldValue is INotifyCollectionChanged oldCollection)
            {
                oldCollection.CollectionChanged -= CollectionChanged;

                //unsubscribe?
            }

            if (e.NewValue is not INotifyCollectionChanged newCollection)
            {
                base.OnPropertyChanged(e);
                return;
            }

            ((DocumentContainer)PART_DockingManager.DocContainer).SetCurrentValue(DocumentContainer.AddTabDocumentAtLastProperty, true);

            foreach (var item in (IList)newCollection)
            {
                if (item is not IDockElement dockElement)
                {
                    continue;
                }

                // use normal events here?
                dockElement.ObservableForProperty(x => x.State)
                    .ObserveOn(RxApp.MainThreadScheduler)
                    .Subscribe(OnStateUpdated);

                // add control
                var control = new ContentControl() { Content = item };
                DockingManager.SetHeader(control, dockElement.Header);
                // auto-hidden (side) tab text: theme color, so it follows a theme switch
                control.SetResourceReference(DockingManager.SideTabItemForegroundProperty, "ContentForeground");
                DockingManager.SetSideInDockedMode(control,
                    (Syncfusion.Windows.Tools.Controls.DockSide)(int)dockElement.SideInDockedMode);
                DockingManager.SetState(control, dockElement.State.ToSfDockState());
                if (dockElement.State != DockState.Document)
                {
                    control.Name = dockElement.GetType().Name;
                }

                DockingManager.SetCanSerialize(control, dockElement.CanSerialize);

                PART_DockingManager.Children.Add(control);
            }

            newCollection.CollectionChanged += CollectionChanged;

            base.OnPropertyChanged(e);
        }

        /// <summary>
        /// For all programmatically added windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            // remove windows
            if (e.OldItems != null)
            {
                foreach (var item in e.OldItems)
                {
                    // add control
                    var control = (from ContentControl element in PART_DockingManager.Children
                                   where element.Content == item
                                   select element).FirstOrDefault();

                    if (control is not null)
                    {
                        DetachGraphEditorsForClose(control);
                    }

                    PART_DockingManager.Children.Remove(control);

                    // set active document to null
                    if (control?.Content is IDocumentViewModel document && ActiveDocument == document)
                    {
                        SetCurrentValue(ActiveDocumentProperty, null);
                    }

                    // unsubscribe ?
                }
            }

            if (e.NewItems == null)
            {
                return;
            }

            // add windows

            foreach (var item in e.NewItems)
            {
                if (item is not IDockElement element)
                {
                    continue;
                }

                // use normal events here?
                element.ObservableForProperty(x => x.Header)
                    .ObserveOn(RxApp.MainThreadScheduler)
                    .Subscribe(OnHeaderChanged);
                element.ObservableForProperty(x => x.State)
                    .ObserveOn(RxApp.MainThreadScheduler)
                    .Subscribe(OnStateUpdated);

                // add control
                var control = new ContentControl() { Content = element };

                // floating windows need size and positioning
                if (item is FloatingPaneViewModel vm)
                {
                    DockingManager.SetDesiredHeightInFloatingMode(control, vm.Height);
                    DockingManager.SetDesiredWidthInFloatingMode(control, vm.Width);
                    DockingManager.SetFloatingWindowRect(control, new Rect(400, 400, vm.Width, vm.Height));
                }

                DockingManager.SetHeader(control, element.Header);
                // auto-hidden (side) tab text: theme color, so it follows a theme switch
                control.SetResourceReference(DockingManager.SideTabItemForegroundProperty, "ContentForeground");
                DockingManager.SetState(control, element.State.ToSfDockState());
                if (element.State != DockState.Document)
                {
                    control.Name = element.GetType().Name;
                }

                DockingManager.SetCanSerialize(control, element.CanSerialize);

                PART_DockingManager.Children.Add(control);
            }
        }

        private static void DetachGraphEditorsForClose(DependencyObject root)
        {
            foreach (var graphEditor in FindVisualChildren<GraphEditorView>(root))
            {
                graphEditor.PrepareForClose();
            }
        }

        private static IEnumerable<T> FindVisualChildren<T>(DependencyObject root) where T : DependencyObject
        {
            int childCount;
            try
            {
                childCount = VisualTreeHelper.GetChildrenCount(root);
            }
            catch (InvalidOperationException)
            {
                yield break;
            }

            for (var i = 0; i < childCount; i++)
            {
                var child = VisualTreeHelper.GetChild(root, i);
                if (child is T typedChild)
                {
                    yield return typedChild;
                    continue;
                }

                foreach (var descendant in FindVisualChildren<T>(child))
                {
                    yield return descendant;
                }
            }
        }

        private void OnHeaderChanged(IObservedChange<IDockElement, string> headerChange)
        {
            var item = headerChange.Sender;
            var newHeader = headerChange.Value;

            var control = (from ContentControl element in PART_DockingManager.Children
                           where element.Content == item
                           select element).FirstOrDefault();

            if (control is null)
            {
                return;
            }

            var header = DockingManager.GetHeader(control) as string;

            if (header is string headerStr && !headerStr.Equals(newHeader))
            {
                DockingManager.SetHeader(control, newHeader);
            }
        }

        private void OnStateUpdated(IObservedChange<IDockElement, DockState> dockStateChange)
        {
            var item = dockStateChange.Sender;
            var control = (from ContentControl element in PART_DockingManager.Children
                           where element.Content == item
                           select element).FirstOrDefault();

            var newstate = dockStateChange.Value;
            // actually remove and not hide FloatingPaneViewModels
            if (control is { Content: FloatingPaneViewModel vm } && newstate == DockState.Hidden)
            {
                _viewModel.DockedViews.Remove(vm);
                return;
            }

            var dockstate = DockingManager.GetState(control).ToDockState();
            if (dockstate != newstate)
            {
                DockingManager.SetState(control, newstate.ToSfDockState());
            }
        }

        #endregion
    }
}
