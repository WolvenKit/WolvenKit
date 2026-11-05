using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using System.Windows.Threading;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.UI.Xaml.TreeGrid.Helpers;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for RDTMeshView.xaml
    /// </summary>
    public partial class RDTMeshView : ReactiveUserControl<RDTMeshViewModel>
    {
        private TreeGridNodeContextMenuInfo _currentNode;

        public RDTMeshView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                if (DataContext is RDTMeshViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);

                    // The view model owns the EffectsManager (created in Load, disposed in Dispose).
                    // The view only makes sure one exists; it never disposes it.
                    vm.EnsureEffectsManager();

                    // Subscribe once per activation and unsubscribe on deactivation,
                    // otherwise every tab switch adds another handler.
                    hxViewport.MouseDown3D += vm.MouseDown3D;
                    Disposable
                        .Create(() => hxViewport.MouseDown3D -= vm.MouseDown3D)
                        .DisposeWith(disposables);

                    // Viewport → tree: when the selection changes (e.g. a click in the viewport),
                    // expand the branch that holds it and scroll it into view.
                    vm.PropertyChanged += OnViewModelPropertyChanged;
                    Disposable
                        .Create(() => vm.PropertyChanged -= OnViewModelPropertyChanged)
                        .DisposeWith(disposables);

                    // Modifier flags must not stay "pressed" when the tab is left mid-keypress.
                    Disposable
                        .Create(() => ResetModifierFlags(vm))
                        .DisposeWith(disposables);
                }

                if (ViewModel is { } current && !ReferenceEquals(hxContentVisual.DataContext, DataContext))
                {
                    current.SelectedAppearance?.ModelGroup.RemoveSelf();
                }

                this.OneWayBind(ViewModel,
                        viewModel => viewModel.SelectedAppearance.ModelGroup,
                        view => view.hxContentVisual.ItemsSource)
                    .DisposeWith(disposables);
            });
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != nameof(RDTMeshViewModel.SelectedItem))
            {
                return;
            }

            // Let the tree finish its own update first.
            Dispatcher.BeginInvoke(new Action(RevealSelectedItem), DispatcherPriority.Background);
        }

        /// <summary>
        /// The tree only expands root nodes, so a deeper item has no row yet.
        /// Walk from the tree root to the item, expanding each ancestor, then select and scroll.
        /// </summary>
        private void RevealSelectedItem()
        {
            if (ViewModel?.SelectedItem is not DependencyObject target || NodeTreeGrid.View == null)
            {
                return;
            }

            var chain = new List<DependencyObject>();
            for (var current = target; current != null; current = LogicalTreeHelper.GetParent(current))
            {
                chain.Insert(0, current);
            }

            // View.Nodes is a TreeNodeCollection, ChildNodes is TreeNodes: walk both as TreeNode sequences.
            IEnumerable<TreeNode> nodes = NodeTreeGrid.View.Nodes;
            TreeNode found = null;
            foreach (var item in chain)
            {
                var node = nodes.FirstOrDefault(n => ReferenceEquals(n.Item, item));
                if (node == null)
                {
                    if (found == null)
                    {
                        continue; // still above the tree's root items
                    }

                    return; // branch not in the tree (e.g. filtered out)
                }

                found = node;
                if (ReferenceEquals(item, target))
                {
                    break;
                }

                if (!node.IsExpanded)
                {
                    NodeTreeGrid.ExpandNode(node);
                }

                nodes = node.ChildNodes;
            }

            if (found == null || !ReferenceEquals(found.Item, target))
            {
                return;
            }

            if (!ReferenceEquals(NodeTreeGrid.SelectedItem, target))
            {
                // SetCurrentValue keeps the XAML binding to the view model's SelectedItem intact.
                NodeTreeGrid.SetCurrentValue(Syncfusion.UI.Xaml.Grid.SfGridBase.SelectedItemProperty, target);
            }

            var rowIndex = NodeTreeGrid.ResolveToRowIndex(found);
            if (rowIndex >= 0)
            {
                NodeTreeGrid.ScrollInView(new RowColumnIndex(rowIndex, 0));
            }
        }

        private static void ResetModifierFlags(RDTMeshViewModel vm)
        {
            vm.CtrlKeyPressed = false;
            vm.ShiftKeyPressed = false;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (ViewModel is null)
            {
                return;
            }

            if (e.Key is Key.LeftCtrl or Key.RightCtrl)
            {
                ViewModel.CtrlKeyPressed = true;
            }

            if (e.Key is Key.LeftShift or Key.RightShift)
            {
                ViewModel.ShiftKeyPressed = true;
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (ViewModel is null)
            {
                return;
            }

            if (e.Key is Key.LeftCtrl or Key.RightCtrl)
            {
                ViewModel.CtrlKeyPressed = false;
            }

            if (e.Key is Key.LeftShift or Key.RightShift)
            {
                ViewModel.ShiftKeyPressed = false;
            }
        }

        // KeyUp never arrives if focus leaves while a modifier is held (Alt+Tab, dialog, etc.).
        protected override void OnIsKeyboardFocusWithinChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnIsKeyboardFocusWithinChanged(e);

            if (e.NewValue is false && ViewModel is { } vm)
            {
                ResetModifierFlags(vm);
            }
        }

        private void ReloadModels(object sender, RoutedEventArgs e) => hxViewport.ZoomExtents();

        // Referenced from XAML; intentionally empty.
        private void ComboBoxAdv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        // Referenced from XAML; intentionally empty.
        private void SfTreeGrid_NodeCheckStateChanged(object sender, NodeCheckStateChangedEventArgs e)
        {
        }

        private void CollapseAllChildrenRecursiveMenuItem_OnClick(object sender, RoutedEventArgs e) =>
            _currentNode?.TreeGrid.CollapseAllNodes(_currentNode.TreeNode);

        private void ExpandAllChildrenRecursiveMenuItem_OnClick(object sender, RoutedEventArgs e) =>
            _currentNode?.TreeGrid.ExpandAllNodes(_currentNode.TreeNode);

        private void CopyComponentNameMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            if (_currentNode?.TreeNode is not { } treeNode || treeNode.Item is not IRedMeshComponent comp ||
                comp.Name.GetResolvedText() is not string s)
            {
                return;
            }

            Clipboard.SetDataObject(s);
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

        private static void ChangeStateAllChildren(TreeNodes nodes, bool state, bool recursive)
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
            _currentNode = e.ContextMenuInfo as TreeGridNodeContextMenuInfo;
        }

        private void Viewport3DX_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel?.SelectWorldNode();
        }
    }
}
