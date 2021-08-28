//https://github.com/SyncfusionExamples/working-with-wpf-docking-manager-and-mvvm

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
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
        private readonly AppViewModel viewModel;
        public static DockingAdapter G_Dock;

        public DockingAdapter()
        {
            InitializeComponent();
            G_Dock = this;

            PART_DockingManager.Loaded += PART_DockingManager_Loaded;
            PART_DockingManager.CloseButtonClick += PART_DockingManagerOnCloseButtonClick;
            PART_DockingManager.DockStateChanging += PART_DockingManagerOnDockStateChanging;
            

            viewModel = DataContext as AppViewModel;
        }

        private void PART_DockingManagerOnDockStateChanging(FrameworkElement sender, DockStateChangingEventArgs e)
        {
            if (e.SourceElement is ContentControl { Content: PaneViewModel vm })
            {
                vm.State = e.TargetState.ToDockState();
            }
        }

        /// <summary>
        /// fires when a document (but no tool window) gets closed through clicking the close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PART_DockingManagerOnCloseButtonClick(object sender, CloseButtonEventArgs e)
        {
            if (e.TargetItem is ContentControl { Content: IDocumentViewModel vm })
            {
                vm.Close.Execute().Subscribe();

                (ItemsSource as IList).Remove(vm);
                
            }
        }

        private bool DebuggingLayouts = false;

        public void SetLayoutToDefault()
        {
            try
            {
                var reader = XmlReader.Create("Config\\Layout\\DockStatesCR2W.xml");
                var Debugging_A = PART_DockingManager.LoadDockState(reader);
                Trace.WriteLine(Debugging_A);
                reader.Close();
            }
            catch (Exception)
            {

            }
            
        }

        private void PART_DockingManager_Loaded(object sender, RoutedEventArgs e)
        {
            ((DocumentContainer)PART_DockingManager.DocContainer).SetCurrentValue(
                DocumentContainer.AddTabDocumentAtLastProperty, true);

            // Add setting to persist State or not ? ( Load Default Docking on Startup : Yes/No )
            // if (XSETTINGX){ SetLayoutToDefault();}else{
            var settings = Locator.Current.GetService<ISettingsManager>();
            if (settings.IsHealthy().Any())
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
                XmlWriter writer = XmlWriter.Create("DockStatesDefault.xml");

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
            get => (object)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        // Using a DependencyProperty as the backing store for ItemsSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(nameof(ItemsSource), typeof(object), typeof(DockingAdapter), new PropertyMetadata(null));

        private static void OnActiveDocumentChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            var adapter = sender as DockingAdapter;
            if (adapter == null)
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
                break;
            }
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
                    foreach (var item in ((IList)e.NewValue))
                    {
                        if (item is IDockElement dockElement)
                        {
                            var _ = dockElement
                                .ObservableForProperty(x => x.State)
                                .ObserveOnDispatcher()
                                .Subscribe(OnStateUpdated);

                            var control = new ContentControl() { Content = item };
                            DockingManager.SetHeader(control, dockElement.Header);
                            if (dockElement.State == DockState.Document)
                            {
                                DockingManager.SetState(control, Syncfusion.Windows.Tools.Controls.DockState.Document);
                            }
                            else
                            {
                                if (count != 0)
                                {
                                    DockingManager.SetTargetNameInDockedMode(control, "item" + (count - 1).ToString());
                                    DockingManager.SetSideInDockedMode(control, DockSide.Bottom);
                                }
                                DockingManager.SetDesiredWidthInDockedMode(control, 220);
                                control.Name = "item" + (count++).ToString();
                            }
                            PART_DockingManager.Children.Add(control);
                        }
                    }
                    newcollection.CollectionChanged += CollectionChanged;
                }
            }
            base.OnPropertyChanged(e);
        }

        private void OnStateUpdated(IObservedChange<IDockElement, DockState> obj)
        {
            var item = obj.Sender;
            var newstate = obj.Value;

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
            var dataTemplate = element.TryFindResource(type) as DataTemplate;
            if (dataTemplate != null)
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


                var header = DockingManager.GetHeader(content);
                var propertiesViewModel = Locator.Current.GetService<PropertiesViewModel>();
                if (!string.IsNullOrEmpty(header as string))
                {
                    DiscordHelper.SetDiscordRPCStatus(header as string);
                }

                switch (header)
                {
                    case "Project Explorer":
                        propertiesViewModel.SetToNullAndResetVisibility();
                        propertiesViewModel.PE_FileInfoVisible = true;
                        break;

                    case "Asset Browser":
                        propertiesViewModel.SetToNullAndResetVisibility();
                        propertiesViewModel.AB_FileInfoVisible = true;
                        break;

                    case "CR2W Editor":
                        // This never happens as CR2W editor is always named after its active document.
                        break;
                    case "Properties":
                        break;
                    case "Log":
                        break;
                    case "Import Export Tool":
                        break;


                    default:

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
                }
                
            }
        }
    }
}
