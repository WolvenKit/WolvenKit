//https://github.com/SyncfusionExamples/working-with-wpf-docking-manager-and-mvvm

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Models.Docking;
using WolvenKit.ViewModels.Editor;
using WolvenKit.ViewModels.Shell;
using DockState = WolvenKit.Models.Docking.DockState;

namespace WolvenKit.Views.Shell
{
    /// <summary>
    /// Interaction logic for DockingAdapter.xaml
    /// </summary>
    public partial class DockingAdapter : UserControl
    {
        private readonly WorkSpaceViewModel viewModel;


        public DockingAdapter()
        {
            InitializeComponent();
            PART_DockingManager.Loaded += PART_DockingManager_Loaded;
            PART_DockingManager.CloseButtonClick += PART_DockingManagerOnCloseButtonClick;
            PART_DockingManager.DockStateChanging += PART_DockingManagerOnDockStateChanging;

            viewModel = DataContext as WorkSpaceViewModel;
        }

        private void PART_DockingManagerOnDockStateChanging(FrameworkElement sender, DockStateChangingEventArgs e)
        {
            if (e.SourceElement is ContentControl {Content: PaneViewModel vm})
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
            if (e.TargetItem is ContentControl { Content: DocumentViewModel vm })
            {
                vm.CloseCommand.SafeExecute();
            }
        }

        private void PART_DockingManager_Loaded(object sender, RoutedEventArgs e)
        {
            ((DocumentContainer)PART_DockingManager.DocContainer).SetCurrentValue(
                DocumentContainer.AddTabDocumentAtLastProperty, true);
            PART_DockingManager.LoadDockState();
            // update the vms
            foreach (FrameworkElement frameworkElement in PART_DockingManager.Children)
            {
                if (frameworkElement is ContentControl contentControl)
                {
                    if (contentControl.Content is PaneViewModel vm)
                    {
                        try
                        {
                            vm.State = DockingManager.GetState(contentControl).ToDockState();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                            throw;
                        }
                    }
                }
            }
        }

        public IDockElement ActiveDocument
        {
            get => (IDockElement)GetValue(ActiveDocumentProperty);
            set => SetValue(ActiveDocumentProperty, value);
        }

        // Using a DependencyProperty as the backing store for ActiveDocument.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ActiveDocumentProperty =
            DependencyProperty.Register(nameof(ActiveDocument), typeof(IDockElement), typeof(DockingAdapter), new PropertyMetadata(null, new PropertyChangedCallback(OnActiveDocumentChanged)));

        public IList ItemsSource
        {
            get => (IList)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        // Using a DependencyProperty as the backing store for ItemsSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(nameof(ItemsSource), typeof(IList), typeof(DockingAdapter), new PropertyMetadata(null));

        private static void OnActiveDocumentChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            var adapter = sender as DockingAdapter;
            if (adapter == null)
            {
                return;
            }

            foreach (FrameworkElement element in adapter.PART_DockingManager.Children)
            {
                if (element is not ContentControl)
                {
                    continue;
                }

                var control = element as ContentControl;
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
                            var _ = dockElement.ObservableForProperty(x => x.State).Subscribe(OnStateUpdated);

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

            try
            {
                var dockstate = DockingManager.GetState(control).ToDockState();
            
            if (dockstate != newstate)
            {
                switch (newstate)
                {
                    case DockState.Hidden:
                        DockingManager.SetState(control, Syncfusion.Windows.Tools.Controls.DockState.Hidden);
                        break;
                    case DockState.Dock:
                        DockingManager.SetState(control, Syncfusion.Windows.Tools.Controls.DockState.Dock);
                        break;
                    case DockState.Float:
                        DockingManager.SetState(control, Syncfusion.Windows.Tools.Controls.DockState.Float);
                        break;
                    case DockState.AutoHidden:
                        DockingManager.SetState(control, Syncfusion.Windows.Tools.Controls.DockState.AutoHidden);
                        break;
                    case DockState.Document:
                        DockingManager.SetState(control, Syncfusion.Windows.Tools.Controls.DockState.Document);
                        break;
                    default:
                        DockingManager.SetState(control, Syncfusion.Windows.Tools.Controls.DockState.Dock);
                        break;
                }


            }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
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
            if (StaticReferences.GlobalShell != null)
            {
                if (e.NewValue is ContentControl content)
                {
                    if (((IDockElement) content.Content).State == DockState.Document)
                    {
                        SetCurrentValue(ActiveDocumentProperty, (IDockElement) content.Content);
                    }
                }
            }
        }
    }
}
