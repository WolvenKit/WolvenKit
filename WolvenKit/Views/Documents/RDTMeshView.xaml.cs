using System;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using Syncfusion.UI.Xaml.TreeGrid;
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
