using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Core.Routing;
using Microsoft.Msagl.Layout.Layered;
using Newtonsoft.Json;
using Nodify;
using ReactiveUI;
using Syncfusion.UI.Xaml.TreeView;
using WolvenKit.Common.Conversion;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Documents;
using WolvenKit.ViewModels.Shell;

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

                this.OneWayBind(ViewModel,
                       viewmodel => viewmodel.Chunks,
                       view => view.RedTreeView.ItemsSource)
                   .DisposeWith(disposables);
                this.Bind(ViewModel,
                      viewmodel => viewmodel.SelectedChunk,
                      view => view.RedTreeView.SelectedItem)
                  .DisposeWith(disposables);
                this.OneWayBind(ViewModel,
                      viewmodel => viewmodel.SelectedChunk,
                      view => view.CustomPG.DataContext)
                  .DisposeWith(disposables);
                this.OneWayBind(ViewModel,
                      viewmodel => viewmodel.SelectedChunk,
                      view => view.CustomPG.ViewModel)
                  .DisposeWith(disposables);

                LayoutNodes();

                ViewModel.Nodes.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
                {
                    LayoutNodes();
                };

                ViewModel.References.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) =>
                {
                    LayoutNodes();
                };

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

        public void LayoutNodes()
        {
            var graph = new GeometryGraph();
            var msaglNodes = new Dictionary<int, Microsoft.Msagl.Core.Layout.Node>();
            var socketNodeLookup = new Dictionary<int, int>();
            foreach (var item in Editor.GetItemHost().Children)
            {
                if (item is ItemContainer ic)
                {
                    if (ic.DataContext is INodeViewModel nvm)
                    {
                        var msaglNode = new Microsoft.Msagl.Core.Layout.Node(
                        CurveFactory.CreateRectangle(ic.ActualWidth, ic.ActualHeight, new Microsoft.Msagl.Core.Geometry.Point()))
                        {
                            UserData = nvm.GetHashCode()
                        };
                        msaglNodes.Add(nvm.GetHashCode(), msaglNode);
                        graph.Nodes.Add(msaglNode);
                        if (nvm is CNameWrapper cnw)
                        {
                            socketNodeLookup[cnw.Socket.GetHashCode()] = nvm.GetHashCode();
                        }
                        else if (nvm is ChunkViewModel cvm)
                        {
                            if (cvm.Socket != null)
                            {
                                socketNodeLookup[cvm.Socket.GetHashCode()] = nvm.GetHashCode();
                            }
                            foreach (var reference in cvm.References)
                            {
                                socketNodeLookup[reference.GetHashCode()] = nvm.GetHashCode();
                            }
                        }
                    }
                }
            }

            foreach (var reference in ViewModel.References)
            {
                if (socketNodeLookup.ContainsKey(reference.Output.GetHashCode()) &&
                    socketNodeLookup.ContainsKey(reference.Input.GetHashCode()))
                {
                    var source = socketNodeLookup[reference.Output.GetHashCode()];
                    var dest = socketNodeLookup[reference.Input.GetHashCode()];
                    graph.Edges.Add(new Edge(msaglNodes[source], msaglNodes[dest]));
                }
            }

            var settings = new SugiyamaLayoutSettings
            {
                Transformation = PlaneTransformation.Rotation(Math.PI / 2),
                EdgeRoutingSettings = { EdgeRoutingMode = EdgeRoutingMode.Spline }
            };
            var layout = new LayeredLayout(graph, settings);
            try
            {
                layout.Run();

                foreach (var item in Editor.GetItemHost().Children)
                {
                    if (item is ItemContainer ic)
                    {
                        if (ic.DataContext is INodeViewModel nvm && msaglNodes.ContainsKey(nvm.GetHashCode()))
                        {
                            var node = msaglNodes[nvm.GetHashCode()];
                            nvm.Location = new System.Windows.Point(
                                node.Center.X - graph.BoundingBox.Center.X - ic.ActualWidth / 2,
                                node.Center.Y - graph.BoundingBox.Center.Y - ic.ActualHeight / 2);
                        }
                    }
                }

                Editor.BringIntoView(new System.Windows.Point(0, 0));
            }
            catch (InvalidOperationException)
            {

            }
        }

        private void AutolayoutNodes_MenuItem(object sender, RoutedEventArgs e)
        {
            LayoutNodes();
        }
    }
}
