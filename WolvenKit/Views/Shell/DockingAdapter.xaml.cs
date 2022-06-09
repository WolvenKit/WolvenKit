//https://github.com/SyncfusionExamples/working-with-wpf-docking-manager-and-mvvm

using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.Functionality.Layout;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Models;
using WolvenKit.Models.Docking;
using WolvenKit.ViewModels.Documents;
using WolvenKit.ViewModels.Shell;
using WolvenKit.ViewModels.Tools;
using DockState = WolvenKit.Models.Docking.DockState;

namespace WolvenKit.Views.Shell
{
    /// <summary>
    /// Interaction logic for DockingAdapter.xaml
    /// </summary>
    public partial class DockingAdapter : UserControl
    {
        private AppViewModel viewModel;
        public static DockingAdapter G_Dock;
        private bool UsingProjectLayout = false;
        private bool _hadLoadedProject = false;

        private Window _mainWindow;
        private bool _stateChanged;

        public DockingAdapter()
        {
            InitializeComponent();
            G_Dock = this;

            viewModel = DataContext as AppViewModel;
        }

        private void DockingAdapterOnLoaded(object sender, RoutedEventArgs e)
        {
            _mainWindow = Window.GetWindow(this);
            if (_mainWindow != null)
            {
                _mainWindow.Deactivated += OnMainWindowDeactivated;
                _mainWindow.Closing += OnMainWindowClosing;
            }
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

        private void OnMainWindowClosing(object sender, CancelEventArgs e)
        {
            foreach (Window win in Application.Current.Windows)
            {
                if (win is NativeFloatWindow)
                {
                    win.Close();
                }
            }
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

        /// <summary>
        /// fires when a document (but no tool window) gets closed through clicking the close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PART_DockingManagerOnCloseButtonClick(object sender, CloseButtonEventArgs e)
        {
            if (e.TargetItem is ContentControl { Content: DocumentViewModel vm })
            {
                if (vm.IsDirty && MessageBox.Show("Unsaved changes will be lost - are you sure you want to close this file?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                vm.Close.Execute().Subscribe();

                (ItemsSource as IList).Remove(vm);
                viewModel.UpdateTitle();
            }
        }

        private readonly bool DebuggingLayouts = false;

        public void SetLayoutToDefault()
        {
            try
            {
                var reader = XmlReader.Create("DockStatesDefault.xml");
                var Debugging_A = PART_DockingManager.LoadDockState(reader);
                Trace.WriteLine(Debugging_A);
                reader.Close();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        private void PART_DockingManager_Loaded(object sender, RoutedEventArgs e)
        {
            ((DocumentContainer)PART_DockingManager.DocContainer).SetCurrentValue(DocumentContainer.AddTabDocumentAtLastProperty, true);

            // Add setting to persist State or not ? ( Load Default Docking on Startup : Yes/No )
            // if (XSETTINGX){ SetLayoutToDefault();}else{
            var settings = Locator.Current.GetService<ISettingsManager>();
            if (settings != null && !settings.IsHealthy())
            {
                SetLayoutToDefault();
            }
            else
            {
                try
                {
                    var Debugging_A = PART_DockingManager.LoadDockState();
                    Trace.WriteLine(Debugging_A);
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.Message);
                    //SetLayoutToDefault();
                }
            }

            if (DebuggingLayouts)
            {
                var writer = XmlWriter.Create("DockStates.xml");

                PART_DockingManager.SaveDockState(writer);

                writer.Close();
            }
            // update the vms
            foreach (FrameworkElement frameworkElement in PART_DockingManager.Children)
            {
                if (frameworkElement is ContentControl contentControl)
                {
                    if (contentControl.Content is PaneViewModel vm)
                    {
                        vm.State = DockingManager.GetState(contentControl).ToDockState();
                    }
                }
            }

            if (viewModel is null)
            {
                viewModel = DataContext as AppViewModel;
            }

            SizeChanged += Window_SizeChanged;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (!UsingProjectLayout)
            {
                PART_DockingManager.SaveDockState();
            }
        }

        public IDocumentViewModel ActiveDocument
        {
            get => (IDocumentViewModel)GetValue(ActiveDocumentProperty);
            set => SetValue(ActiveDocumentProperty, value);
        }

        // Using a DependencyProperty as the backing store for ActiveDocument.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ActiveDocumentProperty =
            DependencyProperty.Register(nameof(ActiveDocument), typeof(IDocumentViewModel), typeof(DockingAdapter), new PropertyMetadata(null, new PropertyChangedCallback(OnActiveDocumentChanged)));

        public object ItemsSource
        {
            get => GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        // Using a DependencyProperty as the backing store for ItemsSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(nameof(ItemsSource), typeof(object), typeof(DockingAdapter), new PropertyMetadata(null));

        private static void OnActiveDocumentChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            if (sender is not DockingAdapter adapter)
            {
                return;
            }

            foreach (FrameworkElement element in adapter.PART_DockingManager.Children)
            {
                if (element is not ContentControl control)
                {
                    continue;
                }

                if (control.Content != args.NewValue)
                {
                    continue;
                }

                adapter.PART_DockingManager.SetCurrentValue(DockingManager.ActiveWindowProperty, control);

                if (adapter.viewModel != null)
                {
                    adapter.viewModel.UpdateTitle();
                }

                break;
            }
        }
        public void OnActiveProjectChanged()
        {
            if (viewModel is null || viewModel.ActiveProject is null)
            {
                return;
            }

            try
            {
                // need to also handle if files have been modified (probably elsewhere, though)
                if (!_hadLoadedProject && ItemsSource is ObservableCollection<IDockElement> oc)
                {
                    _hadLoadedProject = true;
                    oc.Clear();
                }
                var layoutPath = Path.Combine(viewModel.ActiveProject.ProjectDirectory, "layout.xml");
                if (File.Exists(layoutPath))
                {
                    var reader = XmlReader.Create(layoutPath);
                    var Debugging_A = PART_DockingManager.LoadDockState(reader);
                    Trace.WriteLine(Debugging_A);
                    reader.Close();
                    UsingProjectLayout = true;
                    //PART_DockingManager.SetCurrentValue(DockingManager.PersistStateProperty, false);
                }
            }
            catch (Exception)
            {
                //viewModel.Log(e.Message);
                throw;
            }
        }

        public void SaveLayoutToProject()
        {
            if (viewModel is null || viewModel.ActiveProject is null)
            {
                return;
            }

            var layoutPath = Path.Combine(viewModel.ActiveProject.ProjectDirectory, "layout.xml");
            var writer = XmlWriter.Create(layoutPath);
            PART_DockingManager.SaveDockState(writer);
            writer.Close();
        }

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            if (e.Property.Name == "ItemsSource")
            {
                if (e.OldValue != null)
                {
                    var oldcollection = e.OldValue as INotifyCollectionChanged;
                    oldcollection.CollectionChanged -= CollectionChanged;
                }

                if (e.NewValue != null)
                {
                    ((DocumentContainer)PART_DockingManager.DocContainer).SetCurrentValue(DocumentContainer.AddTabDocumentAtLastProperty, true);
                    var newcollection = e.NewValue as INotifyCollectionChanged;
                    var count = 0;
                    foreach (var item in (IList)e.NewValue)
                    {
                        if (item is IDockElement dockElement)
                        {
                            dockElement
                                .ObservableForProperty(x => x.State)
                                .ObserveOn(RxApp.MainThreadScheduler)
                                .Subscribe(OnStateUpdated);

                            var control = new ContentControl() { Content = item };
                            DockingManager.SetHeader(control, dockElement.Header);
                            DockingManager.SetSideInDockedMode(control, (Syncfusion.Windows.Tools.Controls.DockSide)(int)dockElement.SideInDockedMode);
                            DockingManager.SetState(control, (Syncfusion.Windows.Tools.Controls.DockState)(int)dockElement.State);
                            if (dockElement.State != DockState.Document)
                            {
                                if (count != 0)
                                {
                                    //DockingManager.SetTargetNameInDockedMode(control, "item" + (count - 1).ToString());
                                }
                                control.Name = "item" + count++.ToString();
                            }
                            PART_DockingManager.Children.Add(control);
                        }
                    }
                    newcollection.CollectionChanged += CollectionChanged;
                }
            }
            base.OnPropertyChanged(e);
        }

        private void OnHeaderChanged(IObservedChange<IDockElement, string> headerChange)
        {
            var item = headerChange.Sender;
            var newHeader = headerChange.Value;

            var control = (from ContentControl element in PART_DockingManager.Children
                           where element.Content == item
                           select element).FirstOrDefault();

            var header = DockingManager.GetHeader(control) as string;

            if (header is string headerStr && !headerStr.Equals(newHeader))
            {
                DockingManager.SetHeader(control, newHeader);
            }
        }

        private void OnStateUpdated(IObservedChange<IDockElement, DockState> dockStateChange)
        {
            var item = dockStateChange.Sender;
            var newstate = dockStateChange.Value;

            var control = (from ContentControl element in PART_DockingManager.Children
                           where element.Content == item
                           select element).FirstOrDefault();
            var dockstate = DockingManager.GetState(control).ToDockState();

            if (dockstate != newstate)
            {
                DockingManager.SetState(control, newstate.ToSfDockState());
            }
        }

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.OldItems != null)
            {
                foreach (var item in e.OldItems)
                {
                    var control = (from ContentControl element in PART_DockingManager.Children
                                   where element.Content == item
                                   select element).FirstOrDefault();
                    PART_DockingManager.Children.Remove(control);
                    if (control.Content is IDocumentViewModel document)
                    {

                        if (ActiveDocument == document)
                        {
                            SetCurrentValue(ActiveDocumentProperty, null);
                        }
                    }
                }
            }

            if (e.NewItems != null)
            {
                foreach (var item in e.NewItems)
                {
                    if (item is IDockElement element)
                    {
                        element
                               .ObservableForProperty(x => x.Header)
                               .ObserveOn(RxApp.MainThreadScheduler)
                               .Subscribe(OnHeaderChanged);

                        var control = new ContentControl() { Content = element };
                        DockingManager.SetHeader(control, element.Header);
                        if (element.State == DockState.Document)
                        {
                            DockingManager.SetState(control, Syncfusion.Windows.Tools.Controls.DockState.Document);
                        }
                        PART_DockingManager.Children.Add(control);
                    }
                }
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

        private void PART_DockingManager_ActiveWindowChanged_1(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // set active property
            if (e.OldValue is ContentControl oldValue)
            {
                if (oldValue.Content is IDockElement dockElement)
                {
                    dockElement.IsActive = false;
                }
            }

            if (e.NewValue is ContentControl content)
            {
                if (content.Content is IDockElement dockElement)
                {
                    dockElement.IsActive = true;
                }

                var propertiesViewModel = Locator.Current.GetService<PropertiesViewModel>();
                if (content.Content is ProjectExplorerViewModel pevm)
                {
                    //propertiesViewModel.SetToNullAndResetVisibility();
                    propertiesViewModel.PE_FileInfoVisible = true;
                    propertiesViewModel.AB_FileInfoVisible = false;
                    //propertiesViewModel.PE_SelectedItem = pevm.SelectedItem;
                    _ = propertiesViewModel.ExecuteSelectFile(pevm.SelectedItem);
                }
                else if (content.Content is AssetBrowserViewModel abvm)
                {
                    //propertiesViewModel.SetToNullAndResetVisibility();
                    propertiesViewModel.AB_FileInfoVisible = true;
                    propertiesViewModel.PE_FileInfoVisible = false;
                    //propertiesViewModel.AB_SelectedItem = abvm.RightSelectedItem;
                    _ = propertiesViewModel.ExecuteSelectFile(abvm.RightSelectedItem);
                }

                if (content.Content != null)
                {
                    DiscordHelper.SetDiscordRPCStatus(content.Content as string);
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
                }

            }

            if (viewModel != null)
            {
                viewModel.UpdateTitle();
            }
        }
    }
}
