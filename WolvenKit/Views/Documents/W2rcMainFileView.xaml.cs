using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.ViewModels.Documents;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.Editors;
using WolvenKit.Views.Templates;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for W2rcMainFileView.xaml
    /// </summary>
    public partial class W2rcMainFileView : ReactiveUserControl<W2rcFileViewModel>
    {
        public W2rcMainFileView()
        {
            InitializeComponent();

            //ViewModel = new MainFileViewModel();
            //DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                if (DataContext is W2rcFileViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }

                // ChunksTreeView
                this.OneWayBind(ViewModel,
                       viewmodel => viewmodel.Chunks,
                       view => view.ChunksTreeView.ItemsSource)
                   .DisposeWith(disposables);
                this.Bind(ViewModel,
                      viewmodel => viewmodel.SelectedChunk,
                      view => view.ChunksTreeView.SelectedItem)
                  .DisposeWith(disposables);

                // ImportsListView
                this.OneWayBind(ViewModel,
                       viewmodel => viewmodel.Imports,
                       view => view.ImportsListView.ItemsSource)
                   .DisposeWith(disposables);
                this.Bind(ViewModel,
                      viewmodel => viewmodel.SelectedImport,
                      view => view.ImportsListView.SelectedItem)
                  .DisposeWith(disposables);


                // MainTreeGrid
                //this.OneWayBind(ViewModel,
                //       viewmodel => viewmodel.ChunkProperties,
                //       view => view.MainTreeGrid.ItemsSource)
                //   .DisposeWith(disposables);

                this.OneWayBind(ViewModel,
                       viewmodel => viewmodel.SelectedChunk.Data,
                       view => view.PropertyGrid.SelectedObject)
                   .DisposeWith(disposables);

            });


            //PropertyGrid.CustomEditorCollection = CustomEditorCollection;
            //MainTreeGrid.RequestTreeItems += TreeGrid_RequestTreeItems;
        }

        //public MyEditorCollection CustomEditorCollection { get; set; } = new();

        //private void TreeGrid_RequestTreeItems(object sender, TreeGridRequestTreeItemsEventArgs args)
        //{
        //    if (DataContext is W2rcFileViewModel vm)
        //    {
        //        if (args.ParentItem == null)
        //        {
        //            args.ChildItems = vm.ChunkProperties;
        //        }
        //        else
        //        {
        //            if (args.ParentItem is ChunkPropertyViewModel chunk)
        //            {
        //                args.ChildItems = chunk.Children;
        //            }
        //        }
        //    }

        //    //else
        //    //{
        //    //    EmployeeInfo employee = args.ParentItem as EmployeeInfo;

        //    //    if (employee != null)
        //    //    {
        //    //        args.ChildItems = ViewModel.GetEmployees().Where(x => x.ReportsTo == employee.ID);
        //    //    }
        //    //}
        //}

        private void SetCollapsedAll()
        {
            ChunksView.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            ImportsView.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
        }

        private void HandleTemplateView_OnGoToChunkRequested(object sender, GoToChunkRequestedEventArgs e)
        {
            var target = e.Export;

            if (ViewModel == null || target == null)
            {
                return;
            }

            var chunk = ViewModel.Chunks.FirstOrDefault(x => x.Name.Equals(target.REDName));
            chunk.IsSelected = true;
            ViewModel.SelectedChunk = chunk;
        }

        

        private void ChunksButton_OnClick(object sender, RoutedEventArgs e)
        {
            SetCollapsedAll();
            ChunksView.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        }

        private void ImportsButton_OnClick(object sender, RoutedEventArgs e)
        {
            SetCollapsedAll();
            ImportsView.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        }

        private void PropertyGrid_AutoGeneratingPropertyGridItem(object sender, Syncfusion.Windows.PropertyGrid.AutoGeneratingPropertyGridItemEventArgs e)
        {
            #region hide properties

            //if (e.DisplayName == nameof(IEditableVariable.accessor)
            //    //|| e.DisplayName == nameof(IEditableVariable.ChildrEditableVariables)
            //    //|| e.DisplayName == nameof(IEditableVariable.Cr2wFile)
            //    //|| e.DisplayName == nameof(IEditableVariable.ParentVar)
            //    //|| e.DisplayName == nameof(IEditableVariable.REDFlags)
            //    //|| e.DisplayName == nameof(IEditableVariable.REDName)
            //    //|| e.DisplayName == nameof(IEditableVariable.REDType)
            //    //|| e.DisplayName == nameof(IEditableVariable.REDValue)
            //    //|| e.DisplayName == nameof(IEditableVariable.SerializedProperties)
            //    //|| e.DisplayName == nameof(IEditableVariable.UniqueIdentifier)
            //    //|| e.DisplayName == nameof(IEditableVariable.VarChunkIndex)
            //    //|| e.DisplayName == nameof(IEditableVariable.IsSerialized)
            //    //|| e.DisplayName == nameof(CVariable.cr2w)
            //    //|| e.DisplayName == nameof(CVariable.IsNulled)
            //    //|| e.DisplayName == nameof(CVariable.UnknownCVariables)
            //    //|| e.DisplayName == nameof(CVariable.GottenVarChunkIndex)
            //    )
            //{
            //    e.Cancel = true;                
            //}

            #endregion

            if (e.OriginalSource is PropertyItem { } propertyItem)
            {
                if (propertyItem.PropertyType.IsAssignableTo(typeof(IREDString)))
                {
                    propertyItem.Editor = new PropertyGridEditors.TextEditor();
                    e.ExpandMode = PropertyExpandModes.FlatMode;
                }
                else if (propertyItem.PropertyType.IsAssignableTo(typeof(IREDIntegerType)))
                {
                    propertyItem.Editor = new PropertyGridEditors.IntegerEditor();
                    if (propertyItem.PropertyType == typeof(CFloat))
                    {
                        propertyItem.Editor = new PropertyGridEditors.FloatEditor();
                    }
                    e.ExpandMode = PropertyExpandModes.FlatMode;
                }
                else if (propertyItem.PropertyType.IsAssignableTo(typeof(IREDBool)))
                {
                    propertyItem.Editor = new PropertyGridEditors.BoolEditor();
                    e.ExpandMode = PropertyExpandModes.FlatMode;
                }
                else if (propertyItem.PropertyType.IsAssignableTo(typeof(IREDEnum)))
                {
                    propertyItem.Editor = new PropertyGridEditors.EnumEditor();
                    e.ExpandMode = PropertyExpandModes.FlatMode;
                }
                else if (propertyItem.PropertyType.IsAssignableTo(typeof(IREDChunkPtr)))
                {
                    propertyItem.Editor = new PropertyGridEditors.ChunkPtrEditor();
                    e.ExpandMode = PropertyExpandModes.FlatMode;
                }
                else if (propertyItem.PropertyType.IsAssignableTo(typeof(IREDRef)))
                {
                    propertyItem.Editor = new PropertyGridEditors.RefEditor();
                    e.ExpandMode = PropertyExpandModes.FlatMode;
                }
                else if (propertyItem.PropertyType.IsAssignableTo(typeof(ICurveDataAccessor)))
                {
                    propertyItem.Editor = new PropertyGridEditors.CurveEditor();
                    e.ExpandMode = PropertyExpandModes.FlatMode;
                }
                else if (propertyItem.PropertyType.IsAssignableTo(typeof(IREDColor)))
                {
                    propertyItem.Editor = new PropertyGridEditors.ColorEditor();
                    e.ExpandMode = PropertyExpandModes.FlatMode;
                }
            }


        }

        
    }
}
