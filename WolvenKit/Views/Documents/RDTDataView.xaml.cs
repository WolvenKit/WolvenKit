using System;
using System.Reactive.Disposables;
using System.Windows;
using Microsoft.Extensions.Options;
using ReactiveUI;
using Splat;
using WolvenKit.App;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for RDTDataView.xaml
    /// </summary>
    public partial class RDTDataView : ReactiveUserControl<RDTDataViewModel>
    {
        public RDTDataView()
        {
            InitializeComponent();

            //this.WhenAnyValue(x => x.DataContext).Subscribe(x =>
            //{
            //    if (x is RDTDataViewModel vm)
            //    {
            //        SetCurrentValue(ViewModelProperty, vm);
            //    }
            //});

            //if (ViewModel != null && ViewModel.SelectedChunk == null)
            //{
            //    ViewModel.SelectedChunk = ViewModel.Chunks[0];
            //}

            this.WhenActivated(disposables =>
            {
                var globals = Locator.Current.GetService<IOptions<Globals>>();
                if (globals.Value.ENABLE_NODE_EDITOR)
                {
                    Editor.LayoutNodes();
                }

                //ViewModel.Nodes.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
                //{
                //    LayoutNodes();
                //};

                //ViewModel.References.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
                //{
                //    LayoutNodes();
                //};

                /*if (Globals.ENABLE_NODE_EDITOR)
                {
                    ViewModel.LayoutNodes = () => Editor.LayoutNodes();
                }*/

                //Editor.ItemsUpdated += (object sender, RoutedEventArgs e) =>
                //{
                //    LayoutNodes();
                //};

                //ViewModel.SelectedChunk.IsExpanded = true;

                //this.OneWayBind(ViewModel,
                //       viewmodel => viewmodel.SelectedChunk.PropertyGridData,
                //       view => view.PropertyGrid.SelectedObject)
                //   .DisposeWith(disposables);

                //this.OneWayBind(ViewModel,
                //       viewmodel => viewmodel.SelectedChunk.PropertyGridItems,
                //       view => view.PropertyGrid.Items)
                //   .DisposeWith(disposables);

                //this.OneWayBind(ViewModel,
                //       viewmodel => viewmodel.SelectedChunk,
                //       view => view.CustomPG.DataContext)
                //   .DisposeWith(disposables);

                //this.ViewModel.WhenAnyValue(x => x.SelectedChunk)
                //    .Where(x => x != null)
                //    .Select(x => new ObservableCollection<PropertyGridItem>(x.Properties
                //        .Where(x => x != null)
                //        .Select(x => new PropertyGridItem()
                //        {
                //            PropertyName = x.Name,
                //            Editor = PropertyGridEditors.GetPropertyEditor(x.PropertyType)
                //        }
                //    ))).BindTo(PropertyGrid, x => x.Items);

                //this.BindCommand(ViewModel, vm => vm.ExportChunkCommand, v => v.ExportChunkCommand)
                //    .DisposeWith(disposables);

                //this.OneWayBind(ViewModel,
                //       viewmodel => viewmodel.SelectedChunk.Name,
                //       view => view.PropertyGrid.SelectedPropertyItem.DisplayName)
                //   .DisposeWith(disposables);

            });
            


            //PropertyGrid.CustomEditorCollection = CustomEditorCollection;
            //MainTreeGrid.RequestTreeItems += TreeGrid_RequestTreeItems;
        }

        //public ICommand AddItemToArrayCommand { get; private set; }
        //public ICommand ExportChunkCommand { get; private set; }

        //private void HandleTemplateView_OnGoToChunkRequested(object sender, GoToChunkRequestedEventArgs e)
        //{
        //    var target = e.Export;

        //    if (ViewModel == null || target == null)
        //    {
        //        return;
        //    }

        //    var chunk = ViewModel.Chunks.FirstOrDefault(x => x.Name.Equals(target.REDName));
        //    chunk.IsSelected = true;
        //    ViewModel.SelectedChunk = chunk;
        //}


        private void AutolayoutNodes_MenuItem(object sender, RoutedEventArgs e) => Editor.LayoutNodes();
    }
}
