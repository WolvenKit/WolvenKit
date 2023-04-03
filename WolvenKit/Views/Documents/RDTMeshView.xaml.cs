using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for RDTTextureView.xaml
    /// </summary>
    public partial class RDTMeshView : ReactiveUserControl<RDTMeshViewModel>
    {
        private TreeGridNodeContextMenuInfo _currentNode;

        public RDTMeshView()
        {
            InitializeComponent();

            //hxViewport.DXSceneInitialized += delegate (object sender, EventArgs args)
            //{
            //    if (MainDXViewportView.DXScene == null) // Probably WPF 3D rendering
            //        return;

            //    hxViewport.ZoomExtents();
            //};

            this.WhenActivated(disposables =>
            {
                if (DataContext is RDTMeshViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                    hxViewport.MouseDown3D += vm.MouseDown3D;
                }

                if (!ReferenceEquals(hxContentVisual.DataContext, DataContext))
                {
                    ViewModel.SelectedAppearance?.ModelGroup.RemoveSelf();
                }

                this.OneWayBind(ViewModel,
                        viewModel => viewModel.SelectedAppearance.ModelGroup,
                        view => view.hxContentVisual.ItemsSource)
                    .DisposeWith(disposables);
            });
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            ViewModel.CtrlKeyPressed = true;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            ViewModel.CtrlKeyPressed = false;
        }

        private void HxViewport_MouseDown3D(object sender, RoutedEventArgs e) => throw new System.NotImplementedException();
        private void ReloadModels(object sender, RoutedEventArgs e) => hxViewport.ZoomExtents();//if (ViewModel != null)//    LoadModels(ViewModel.SelectedAppearance);
        private void ComboBoxAdv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (ViewModel != null)
            //    //LoadModels(ViewModel.SelectedAppearance);
            //    ShowAppearance(ViewModel.SelectedAppearance, true);
        }

        private void SfTreeGrid_NodeCheckStateChanged(object sender, Syncfusion.UI.Xaml.TreeGrid.NodeCheckStateChangedEventArgs e)
        {
            //if (ViewModel != null)
            //    ShowAppearance(ViewModel.SelectedAppearance, true);
            ////LoadModels(ViewModel.SelectedAppearance);
        }

        private void CheckAllChildrenMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            if (_currentNode != null)
            {
                ChangeStateAllChildren(_currentNode.TreeNode.ChildNodes, true, false);
            }
        }

        private void CheckAllChildrenRecursiveMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            if (_currentNode != null)
            {
                ChangeStateAllChildren(_currentNode.TreeNode.ChildNodes, true, true);
            }
        }

        private void UncheckAllChildrenMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            if (_currentNode != null)
            {
                ChangeStateAllChildren(_currentNode.TreeNode.ChildNodes, false, false);
            }
        }

        private void UncheckAllChildrenRecursiveMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            if (_currentNode != null)
            {
                ChangeStateAllChildren(_currentNode.TreeNode.ChildNodes, false, true);
            }
        }

        private void ChangeStateAllChildren(TreeNodes nodes, bool state, bool recursive)
        {
            foreach (var node in nodes)
            {
                node.SetCheckedState(state);
                if (recursive && node.HasChildNodes)
                {
                    ChangeStateAllChildren(node.ChildNodes, state, true);
                }
            }
        }

        private void SfTreeGrid_OnTreeGridContextMenuOpening(object sender, TreeGridContextMenuEventArgs e)
        {
            _currentNode = null;
            if (e.ContextMenuInfo is TreeGridNodeContextMenuInfo info)
            {
                _currentNode = info;
            }
        }
    }
}
