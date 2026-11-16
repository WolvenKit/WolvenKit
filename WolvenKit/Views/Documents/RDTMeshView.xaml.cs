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

            // The side panel's settings take up to 60 % of the height and scroll beyond it, so the
            // node tree keeps room on short windows.
            SidePanelGrid.SizeChanged += (_, e) => SidePanelScroll.SetCurrentValue(MaxHeightProperty, Math.Max(120, e.NewSize.Height * 0.6));

            NodeTreeGrid.NodeExpanded += NodeTreeGrid_OnNodeToggled;
            NodeTreeGrid.NodeCollapsed += NodeTreeGrid_OnNodeToggled;
            // a new scene (appearance, sector) gets the search that is typed in
            NodeTreeGrid.ItemsSourceChanged += (_, _) =>
                Dispatcher.InvokeAsync(() => ApplyNodeSearch(NodeSearchBox.Text?.Trim()), DispatcherPriority.Background);

            this.WhenActivated(disposables =>
            {
                if (DataContext is RDTMeshViewModel vm)
                {
                    // The node tree is filled once the preview is on screen: a sector has
                    // thousands of nodes, and filling the tree held the first frame back.
                    if (!System.Windows.Data.BindingOperations.IsDataBound(NodeTreeGrid, Syncfusion.UI.Xaml.TreeGrid.SfTreeGrid.ItemsSourceProperty))
                    {
                        _ = Dispatcher.InvokeAsync(() =>
                        {
                            if (!vm.IsObjectPreview)
                            {
                                // A sector's root opens on its type folders (a dozen); the
                                // folders, with up to thousands of nodes, stay closed.
                                // node type column (its funnel picks the kinds of nodes to show)
                                NodeTypeColumn.SetCurrentValue(Syncfusion.UI.Xaml.Grid.GridColumnBase.IsHiddenProperty, false);
                            }

                            NodeTreeGrid.SetBinding(Syncfusion.UI.Xaml.TreeGrid.SfTreeGrid.ItemsSourceProperty,
                                new System.Windows.Data.Binding(nameof(RDTMeshViewModel.SelectedModelGroup))
                                {
                                    Mode = System.Windows.Data.BindingMode.TwoWay
                                });
                        }, DispatcherPriority.ApplicationIdle);
                    }

                    SetCurrentValue(ViewModelProperty, vm);

                    // The view model owns the EffectsManager (created in Load, disposed in Dispose).
                    // The view only makes sure one exists; it never disposes it.
                    vm.EnsureEffectsManager();

                    // Sectors hold a lot of transparent geometry: depth peeling multiplies the
                    // draw calls (8 passes) and the UI thread has no time left for the mouse.
                    SetOitMode(IsSectorPreview(vm) ? "SinglePassWeighted" : "DepthPeeling");

                    // Subscribe once per activation and unsubscribe on deactivation,
                    // otherwise every tab switch adds another handler.
                    hxViewport.MouseDown3D += vm.MouseDown3D;
                    hxViewport.MouseUp3D += vm.MouseUp3D;
                    Disposable
                        .Create(() => hxViewport.MouseUp3D -= vm.MouseUp3D)
                        .DisposeWith(disposables);
                    Disposable
                        .Create(() => hxViewport.MouseDown3D -= vm.MouseDown3D)
                        .DisposeWith(disposables);

                    EventHandler rendered = (_, _) =>
                    {
                        vm.OnViewportRendered();
                        if (vm.ZoomExtentsRequested)
                        {
                            // the sector was built after the view was shown: frame it now
                            vm.ZoomExtentsRequested = false;
                            _ = Dispatcher.InvokeAsync(() => hxViewport.ZoomExtents(), DispatcherPriority.Background);
                        }
                    };
                    hxViewport.OnRendered += rendered;
                    Disposable
                        .Create(() => hxViewport.OnRendered -= rendered)
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
        /// An item the search hides gets a hint next to the search box instead.
        /// </summary>
        private void RevealSelectedItem()
        {
            if (ViewModel?.SelectedItem is not DependencyObject target || NodeTreeGrid.View == null)
            {
                ShowHiddenBySearchHint(false);
                return;
            }

            if (!IsShownBySearch(target))
            {
                ShowHiddenBySearchHint(true);
                return;
            }

            ShowHiddenBySearchHint(false);

            if (ExpandTreePathTo(target) is not { } found)
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

        /// <summary>
        /// Expands the ancestors of <paramref name="target"/> from the tree root down (the item
        /// itself stays as it is); its row, or null when its branch is not in the tree.
        /// </summary>
        private TreeNode ExpandTreePathTo(DependencyObject target)
        {
            var chain = new List<DependencyObject>();
            for (var current = target; current != null; current = LogicalTreeHelper.GetParent(current))
            {
                chain.Insert(0, current);
            }

            // Not the user's own toggles: no branch-wide expanding with a held modifier.
            _togglingNodes = true;
            try
            {
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

                        return null; // branch not in the tree (e.g. filtered out)
                    }

                    found = node;
                    if (ReferenceEquals(item, target))
                    {
                        return node;
                    }

                    if (!node.IsExpanded)
                    {
                        NodeTreeGrid.ExpandNode(node);
                    }

                    nodes = node.ChildNodes;
                }

                return null;
            }
            finally
            {
                _togglingNodes = false;
            }
        }

        private static bool IsSectorPreview(RDTMeshViewModel vm) =>
            vm.Header is WolvenKit.App.Models.MeshViewHeaders.SectorPreview or WolvenKit.App.Models.MeshViewHeaders.AllSectorPreview;

        private void SetOitMode(string mode)
        {
            var property = HelixToolkit.Wpf.SharpDX.Viewport3DX.OITRenderModeProperty;
            if (Enum.TryParse(property.PropertyType, mode, out var value))
            {
                hxViewport.SetCurrentValue(property, value);
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

        // Arrow next to Generate Materials: open its menu on press, so the user can either click
        // an entry or keep the button down, drag onto an entry and release.
        private void GenerateMaterialsMenuButton_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is not Button { ContextMenu: { } menu } button)
            {
                return;
            }

            menu.PlacementTarget = button;
            menu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            menu.DataContext = button.DataContext;
            menu.IsOpen = true;
            e.Handled = true;
        }

        /// <summary>
        /// Save Preview Image: renders the current view over black and over white (the view model
        /// derives the transparency from the difference) and saves it as a PNG.
        /// </summary>
        private async void SavePreviewImage_OnClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is not { } vm)
            {
                return;
            }

            var fileName = vm.PickPreviewImageFile();
            if (fileName == null)
            {
                return;
            }

            vm.SavingImageStatus = "Saving image...";
            vm.SavingImageTotal = 1;
            vm.SavingImageDone = 0;
            vm.IsSavingImageBatch = false;
            vm.IsSavingImage = true;
            try
            {
                await WaitFramesAsync(1); // the cover is up before the preview resizes
                if (await CapturePreviewAsync(vm) is { } shot)
                {
                    await vm.SavePreviewImageAsync(shot.OverBlack, shot.OverWhite, fileName);
                }
            }
            finally
            {
                vm.IsSavingImage = false;
            }
        }

        private void CancelSavingImages_OnClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is { } vm)
            {
                vm.CancelSavingImages = true;
                vm.SavingImageStatus = "Cancelling after the current icon...";
            }
        }

        private bool _savingIcons;

        /// <summary>
        /// Save Appearance Icons: for each picked appearance, select it, generate its materials
        /// (cached ones are reused), frame it and save &lt;prefix&gt;&lt;appearance&gt;&lt;suffix&gt;.png with the
        /// current size, camera angle and projection. The selected appearance is restored after.
        /// </summary>
        private async void SaveAppearanceIcons_OnClick(object sender, RoutedEventArgs e)
        {
            if (_savingIcons || ViewModel is not { } vm || vm.IsLoadingMaterials)
            {
                return;
            }

            var appearances = vm.Appearances.Where(a => a != null).ToList();
            if (appearances.Count == 0)
            {
                vm.ReportPreviewImageError("no appearances to save");
                return;
            }

            // File name (prefix / suffix, remembered per file) and, with several, which appearances.
            var picked = PickAppearances(vm, appearances.Select(a => a.Name).ToList());
            if (picked == null)
            {
                return;
            }

            appearances = appearances.Where(a => picked.Contains(a.Name)).ToList();
            if (appearances.Count == 0)
            {
                return;
            }

            var folder = vm.PickPreviewIconFolder(appearances.Select(a => a.Name).ToList());
            if (folder == null)
            {
                return;
            }

            _savingIcons = true;
            var original = vm.SelectedAppearance;
            // The batch frames every appearance and may switch to a preset's projection and
            // lighting: all of it is put back afterwards, as it was before the batch.
            var originalProjection = vm.PreviewCamera;
            var originalLighting = vm.PreviewLighting;
            var originalView = GetCameraView();
            var saved = 0;
            var failed = new List<string>();
            var cancelled = false;
            vm.CancelSavingImages = false;
            vm.SavingImageTotal = appearances.Count;
            vm.SavingImageDone = 0;
            vm.IsSavingImageBatch = true;
            vm.IsSavingImage = true;
            try
            {
                if (vm.ActiveCameraPreset is { } batchPreset)
                {
                    // The preset's projection and lighting for the whole batch.
                    vm.ApplyCameraPresetSettings(batchPreset);
                    await WaitFramesAsync(2);
                }

                foreach (var appearance in appearances)
                {
                    if (vm.CancelSavingImages)
                    {
                        cancelled = true;
                        break;
                    }

                    vm.SavingImageStatus = $"Saving icons... {vm.SavingImageDone + 1} / {appearances.Count}\n{appearance.Name}";
                    vm.SelectedAppearance = appearance;
                    await WaitFramesAsync(2); // the view swaps the models in
                    await vm.GenerateMaterialsForPreviewImageAsync();
                    // With a camera preset each appearance is shot from the preset's view (sized
                    // to that appearance); without one it is framed from the current direction.
                    if (vm.ActiveCameraPreset is { } iconPreset)
                    {
                        PlaceCameraPreset(iconPreset);
                    }
                    else
                    {
                        FrameObject();
                    }

                    await WaitFramesAsync(2);

                    if (await CapturePreviewAsync(vm) is not { } shot)
                    {
                        failed.Add(appearance.Name);
                        break; // the preview does not render: the rest would fail the same way
                    }

                    if (await vm.SavePreviewImageAsync(shot.OverBlack, shot.OverWhite,
                            vm.GetPreviewIconFileName(folder, appearance.Name), quiet: true))
                    {
                        saved++;
                    }
                    else
                    {
                        failed.Add(appearance.Name);
                    }

                    vm.SavingImageDone++;
                }
            }
            catch (Exception ex)
            {
                vm.ReportPreviewImageError(ex.Message);
            }
            finally
            {
                if (original != null && !ReferenceEquals(vm.SelectedAppearance, original))
                {
                    vm.SelectedAppearance = original;
                }

                try
                {
                    vm.PreviewLighting = originalLighting;
                    // A new projection swaps the camera and frames the object (at Background,
                    // from the combo box); the old view is placed after that, under the cover.
                    vm.PreviewCamera = originalProjection;
                    await WaitFramesAsync(2);
                    if (originalView is { } view)
                    {
                        SetCameraView(view);
                    }
                }
                catch (Exception ex)
                {
                    vm.ReportPreviewImageError($"the view could not be restored: {ex.Message}");
                }

                vm.IsSavingImage = false;
                vm.IsSavingImageBatch = false;
                _savingIcons = false;
            }

            if (cancelled)
            {
                vm.ReportPreviewIconsCancelled(saved, appearances.Count, folder);
                return;
            }

            vm.ReportPreviewIcons(saved, appearances.Count, folder, failed);
        }

        /// <summary>
        /// Dialog of the icon batch: the file name as prefix + appearance + suffix (the prefix
        /// starts as the file's name, focused and selected; both are remembered per file), an
        /// example name, and a checklist of the appearances (all ticked, with All / None) when
        /// there are several. Null if cancelled. Built in code, it is only used here.
        /// </summary>
        private HashSet<string> PickAppearances(RDTMeshViewModel vm, IReadOnlyList<string> names)
        {
            // A TextBlock, not the string: WPF reads the first '_' of a string label as an access key and hides it.
            var boxes = names.Select(n => new CheckBox
            {
                Content = new TextBlock { Text = n },
                Tag = n,
                IsChecked = true,
                Margin = new Thickness(4, 2, 4, 2),
            }).ToList();
            var list = new StackPanel();
            foreach (var box in boxes)
            {
                list.Children.Add(box);
            }

            var parts = vm.GetIconNameParts();
            var prefix = new TextBox { Text = parts.Prefix, MinWidth = 110, VerticalContentAlignment = VerticalAlignment.Center };
            var suffix = new TextBox { Text = parts.Suffix, MinWidth = 60, VerticalContentAlignment = VerticalAlignment.Center };
            var nameRow = new DockPanel { Margin = new Thickness(4, 2, 4, 2) };
            var nameLabel = new TextBlock { Text = "File name:", VerticalAlignment = VerticalAlignment.Center, Margin = new Thickness(0, 0, 6, 0) };
            var appearanceLabel = new TextBlock { Text = "$(appearance)", VerticalAlignment = VerticalAlignment.Center, Margin = new Thickness(4, 0, 4, 0), Opacity = 0.7 };
            var extensionLabel = new TextBlock { Text = ".png", VerticalAlignment = VerticalAlignment.Center, Margin = new Thickness(4, 0, 0, 0), Opacity = 0.7 };
            DockPanel.SetDock(nameLabel, Dock.Left);
            DockPanel.SetDock(extensionLabel, Dock.Right);
            DockPanel.SetDock(suffix, Dock.Right);
            DockPanel.SetDock(appearanceLabel, Dock.Right);
            nameRow.Children.Add(nameLabel);
            nameRow.Children.Add(extensionLabel);
            nameRow.Children.Add(suffix);
            nameRow.Children.Add(appearanceLabel);
            nameRow.Children.Add(prefix);

            var example = new TextBlock { Margin = new Thickness(4, 2, 4, 8), Opacity = 0.7, TextTrimming = TextTrimming.CharacterEllipsis };
            // Ticked appearances that would get the same file name (one icon would overwrite the other).
            var clashWarning = new TextBlock
            {
                Margin = new Thickness(4, 0, 4, 8),
                TextWrapping = TextWrapping.Wrap,
                Foreground = (System.Windows.Media.Brush)FindResource("WolvenKitYellow"),
                Visibility = Visibility.Collapsed,
            };
            var selectedCount = new TextBlock { Margin = new Thickness(4, 2, 4, 6), Opacity = 0.7, HorizontalAlignment = HorizontalAlignment.Right };

            var several = names.Count > 1;
            var window = new System.Windows.Window
            {
                Title = "Save Appearance Icons",
                Width = 420,
                Height = several ? Math.Min(620, 210 + 26 * names.Count) : 170,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Owner = System.Windows.Window.GetWindow(this),
                ResizeMode = ResizeMode.CanResize,
                ShowInTaskbar = false,
            };

            Button MakeButton(string text, Action onClick, bool isDefault = false, bool isCancel = false)
            {
                var b = new Button { Content = text, MinWidth = 70, Margin = new Thickness(4), Padding = new Thickness(8, 2, 8, 2), IsDefault = isDefault, IsCancel = isCancel };
                b.Click += (_, _) => onClick();
                return b;
            }

            var cancel = MakeButton("Cancel", () => window.DialogResult = false, isCancel: true);
            var ok = MakeButton("Save", () => window.DialogResult = true, isDefault: true);

            // Example name, "N of M selected", the name clash warning, and Save only with something ticked.
            void UpdateState()
            {
                var ticked = boxes.Where(b => b.IsChecked == true).Select(b => (string)b.Tag).ToList();
                var shown = ticked.FirstOrDefault() ?? names.FirstOrDefault() ?? "";
                example.SetCurrentValue(TextBlock.TextProperty, "→ " + RDTMeshViewModel.BuildIconFileName(prefix.Text, shown, suffix.Text));
                selectedCount.SetCurrentValue(TextBlock.TextProperty, $"{ticked.Count} of {names.Count} selected");
                ok.SetCurrentValue(IsEnabledProperty, ticked.Count > 0);

                var clashes = RDTMeshViewModel.FindIconFileNameClashes(prefix.Text, ticked, suffix.Text);
                clashWarning.SetCurrentValue(TextBlock.TextProperty, clashes.Count == 0
                    ? ""
                    : "Same file name, only the last one would be kept: " +
                      string.Join("; ", clashes.Select(group =>
                          string.Join(", ", group) + " → " + RDTMeshViewModel.BuildIconFileName(prefix.Text, group[0], suffix.Text))));
                clashWarning.SetCurrentValue(VisibilityProperty, clashes.Count == 0 ? Visibility.Collapsed : Visibility.Visible);
            }

            prefix.TextChanged += (_, _) => UpdateState();
            suffix.TextChanged += (_, _) => UpdateState();
            boxes.ForEach(b =>
            {
                b.Checked += (_, _) => UpdateState();
                b.Unchecked += (_, _) => UpdateState();
            });
            UpdateState();

            var buttons = new DockPanel { LastChildFill = false, Margin = new Thickness(4) };
            if (several)
            {
                var all = MakeButton("All", () => boxes.ForEach(b => b.SetCurrentValue(System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, true)));
                var none = MakeButton("None", () => boxes.ForEach(b => b.SetCurrentValue(System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, false)));
                DockPanel.SetDock(all, Dock.Left);
                DockPanel.SetDock(none, Dock.Left);
                buttons.Children.Add(all);
                buttons.Children.Add(none);
            }

            DockPanel.SetDock(cancel, Dock.Right);
            DockPanel.SetDock(ok, Dock.Right);
            buttons.Children.Add(cancel);
            buttons.Children.Add(ok);

            var top = new StackPanel();
            top.Children.Add(nameRow);
            top.Children.Add(example);
            top.Children.Add(clashWarning);
            if (several)
            {
                var listHeader = new DockPanel();
                DockPanel.SetDock(selectedCount, Dock.Right);
                listHeader.Children.Add(selectedCount);
                listHeader.Children.Add(new TextBlock { Text = "Appearances to save:", Margin = new Thickness(4, 2, 4, 6) });
                top.Children.Add(listHeader);
            }

            var root = new DockPanel { Margin = new Thickness(6) };
            DockPanel.SetDock(top, Dock.Top);
            DockPanel.SetDock(buttons, Dock.Bottom);
            root.Children.Add(top);
            root.Children.Add(buttons);
            root.Children.Add(new ScrollViewer
            {
                Content = list,
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                Visibility = several ? Visibility.Visible : Visibility.Collapsed,
            });
            window.Content = root;

            // Ready to type over the file name.
            window.Loaded += (_, _) =>
            {
                prefix.Focus();
                prefix.SelectAll();
            };

            if (window.ShowDialog() != true)
            {
                return null;
            }

            vm.StoreIconNameParts(prefix.Text, suffix.Text);
            return boxes.Where(b => b.IsChecked == true).Select(b => (string)b.Tag).ToHashSet();
        }

        /// <summary>
        /// Standard camera angles, so icons of different items share one angle. Keeps the
        /// projection, turns the camera and frames the object. Game meshes face +Y in game space,
        /// which the preview's Z-up to Y-up swap (x, z, -y) turns into -Z: so the front is seen
        /// from -Z (Helix's view cube calls that side "B"), and the item's right side is +X.
        /// </summary>
        private void StandardView_OnClick(object sender, RoutedEventArgs e)
        {
            if (sender is not FrameworkElement { Tag: string view } ||
                ViewModel?.Camera is not HelixToolkit.Wpf.SharpDX.ProjectionCamera)
            {
                return;
            }

            var up = new System.Windows.Media.Media3D.Vector3D(0, 1, 0);
            System.Windows.Media.Media3D.Vector3D look;
            switch (view)
            {
                case "Front":
                    look = new(0, 0, 1);
                    break;
                case "Back":
                    look = new(0, 0, -1);
                    break;
                case "Left":
                    look = new(1, 0, 0);
                    break;
                case "Right":
                    look = new(-1, 0, 0);
                    break;
                case "Top":
                    look = new(0, -1, 0);
                    up = new(0, 0, -1);
                    break;
                default:
                    // Three-quarter, slightly from above. Each click goes on around the object:
                    // front-right, front-left, back-left, back-right; any other view restarts it.
                    var corner = _threeQuarterCorner;
                    _threeQuarterCorner = (corner + 1) % ThreeQuarterCorners.Length;
                    var (x, z, label) = ThreeQuarterCorners[corner];
                    look = new(x, -0.35, z);
                    if (sender is Button button)
                    {
                        _threeQuarterButton = button;
                        button.SetCurrentValue(ContentControl.ContentProperty, label);
                    }

                    break;
            }

            if (view != "ThreeQuarter")
            {
                _threeQuarterCorner = 0;
                _threeQuarterButton?.SetCurrentValue(ContentControl.ContentProperty, "3/4");
            }

            FrameObject(look, up);
        }

        private int _threeQuarterCorner;

        // The panel sits in a template, so x:Name gives no field; remembered on its first click.
        private Button _threeQuarterButton;

        /// <summary>Look direction (x, z) and button label of the 3/4 views, in click order.</summary>
        private static readonly (double X, double Z, string Label)[] ThreeQuarterCorners =
        [
            (-0.6, 1, "3/4 FR"),
            (0.6, 1, "3/4 FL"),
            (0.6, -1, "3/4 BL"),
            (-0.6, -1, "3/4 BR"),
        ];

        private void HxViewport_OnCameraChanged(object sender, RoutedEventArgs e) => UpdateFollowLights();

        private void Lighting_OnSelectionChanged(object sender, SelectionChangedEventArgs e) =>
            Dispatcher.BeginInvoke(new Action(UpdateFollowLights), DispatcherPriority.Background);

        /// <summary>
        /// "Icon (follow camera)" lighting: the Icon set placed relative to the camera, so
        /// any angle is lit like the front view. Key from the camera's upper left, fill from the
        /// right, rim from behind the object, a little from above.
        /// </summary>
        private void UpdateFollowLights()
        {
            if (ViewModel is not { UseFollowLighting: true } vm ||
                vm.Camera is not HelixToolkit.Wpf.SharpDX.ProjectionCamera camera)
            {
                return;
            }

            var core = camera.CameraInternal;
            var look = new System.Windows.Media.Media3D.Vector3D(core.LookDirection.X, core.LookDirection.Y, core.LookDirection.Z);
            var up = new System.Windows.Media.Media3D.Vector3D(core.UpDirection.X, core.UpDirection.Y, core.UpDirection.Z);
            if (look.LengthSquared < 1e-12 || up.LengthSquared < 1e-12)
            {
                return;
            }

            look.Normalize();
            var right = System.Windows.Media.Media3D.Vector3D.CrossProduct(look, up);
            if (right.LengthSquared < 1e-12)
            {
                return;
            }

            right.Normalize();
            up = System.Windows.Media.Media3D.Vector3D.CrossProduct(right, look);

            // A light's direction is where its light travels: from its source towards the object.
            // The lights are found by Tag: elements inside the viewport get no generated fields.
            foreach (var light in hxViewport.Items.OfType<HelixToolkit.Wpf.SharpDX.DirectionalLight3D>())
            {
                switch (light.Tag as string)
                {
                    case "FollowKey":
                        SetLightDirection(light, look - 0.7 * up + 0.5 * right);
                        break;
                    case "FollowFill":
                        SetLightDirection(light, look - 0.2 * up - 1.0 * right);
                        break;
                    case "FollowRim":
                        SetLightDirection(light, -look - 0.5 * up);
                        break;
                    case "FollowTop":
                        SetLightDirection(light, -up);
                        break;
                }
            }
        }

        private static void SetLightDirection(HelixToolkit.Wpf.SharpDX.DirectionalLight3D light, System.Windows.Media.Media3D.Vector3D direction)
        {
            direction.Normalize();
            light.SetCurrentValue(HelixToolkit.Wpf.SharpDX.DirectionalLight3D.DirectionProperty, direction);
        }

        /// <summary>A new projection needs a new distance to frame the object.</summary>
        // ---- Camera presets ----

        /// <summary>Centre and radius of the bounding sphere of what is shown; null when empty.</summary>
        private (System.Windows.Media.Media3D.Point3D Center, double Radius)? SceneSphere()
        {
            var bounds = HelixToolkit.Wpf.SharpDX.ViewportExtensions.FindBounds3D(hxViewport);
            if (bounds.IsEmpty || bounds.SizeX + bounds.SizeY + bounds.SizeZ <= 0)
            {
                return null;
            }

            var center = new System.Windows.Media.Media3D.Point3D(
                bounds.X + bounds.SizeX / 2, bounds.Y + bounds.SizeY / 2, bounds.Z + bounds.SizeZ / 2);
            var radius = 0.5 * Math.Sqrt(bounds.SizeX * bounds.SizeX + bounds.SizeY * bounds.SizeY + bounds.SizeZ * bounds.SizeZ);
            return radius > 0 ? (center, radius) : null;
        }

        /// <summary>Saves the current view as a preset, relative to the object's bounding sphere.</summary>
        private void SaveCameraPreset_OnClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is not { } vm ||
                vm.Camera is not HelixToolkit.Wpf.SharpDX.ProjectionCamera camera ||
                SceneSphere() is not { } sphere)
            {
                return;
            }

            var name = WolvenKit.App.Interaction.Interactions.AskForTextInput(
                ("Camera preset name", vm.ActiveCameraPreset?.Name ?? ""))?.Trim();
            if (string.IsNullOrEmpty(name))
            {
                return;
            }

            // The render camera: mouse navigation changes only that one.
            var core = camera.CameraInternal;
            var look = new System.Windows.Media.Media3D.Vector3D(core.LookDirection.X, core.LookDirection.Y, core.LookDirection.Z);
            var up = new System.Windows.Media.Media3D.Vector3D(core.UpDirection.X, core.UpDirection.Y, core.UpDirection.Z);
            if (look.LengthSquared < 1e-12)
            {
                return;
            }

            var target = new System.Windows.Media.Media3D.Point3D(core.Position.X, core.Position.Y, core.Position.Z) + look;
            var distance = look.Length;
            look.Normalize();
            up.Normalize();
            var r = sphere.Radius;

            vm.StoreCameraPreset(new WolvenKit.App.ViewModels.Documents.RDTMeshViewModel.CameraPreset
            {
                Name = name,
                LookX = look.X,
                LookY = look.Y,
                LookZ = look.Z,
                UpX = up.X,
                UpY = up.Y,
                UpZ = up.Z,
                Distance = distance / r,
                TargetX = (target.X - sphere.Center.X) / r,
                TargetY = (target.Y - sphere.Center.Y) / r,
                TargetZ = (target.Z - sphere.Center.Z) / r,
                OrthoWidth = camera is HelixToolkit.Wpf.SharpDX.OrthographicCamera ortho ? ortho.Width / r : 0,
                Projection = vm.PreviewCamera.Label,
                Lighting = vm.PreviewLighting,
            });
        }

        private void ApplyCameraPreset_OnClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is not { ActiveCameraPreset: { } preset } vm)
            {
                return;
            }

            // Projection and lighting first: a new projection swaps the camera and frames the
            // object (at Background); the preset's view is placed after that.
            vm.ApplyCameraPresetSettings(preset);
            Dispatcher.BeginInvoke(new Action(() => PlaceCameraPreset(preset)), DispatcherPriority.ContextIdle);
        }

        private void DeleteCameraPreset_OnClick(object sender, RoutedEventArgs e) => ViewModel?.DeleteSelectedCameraPreset();

        /// <summary>Puts the camera where the preset says, scaled to the object shown now.</summary>
        private void PlaceCameraPreset(WolvenKit.App.ViewModels.Documents.RDTMeshViewModel.CameraPreset preset)
        {
            if (ViewModel?.Camera is not HelixToolkit.Wpf.SharpDX.ProjectionCamera || SceneSphere() is not { } sphere)
            {
                return;
            }

            var r = sphere.Radius;
            var look = new System.Windows.Media.Media3D.Vector3D(preset.LookX, preset.LookY, preset.LookZ);
            var up = new System.Windows.Media.Media3D.Vector3D(preset.UpX, preset.UpY, preset.UpZ);
            if (look.LengthSquared < 1e-12 || up.LengthSquared < 1e-12)
            {
                return;
            }

            look.Normalize();
            up.Normalize();
            var target = sphere.Center + new System.Windows.Media.Media3D.Vector3D(preset.TargetX, preset.TargetY, preset.TargetZ) * r;
            var lookVector = look * (Math.Max(preset.Distance, 1e-3) * r);
            SetCameraView(new CameraView(target - lookVector, lookVector, up, preset.OrthoWidth * r));
        }

        /// <summary>Where the camera is and looks; OrthoWidth is 0 for a perspective camera.</summary>
        private sealed record CameraView(
            System.Windows.Media.Media3D.Point3D Position,
            System.Windows.Media.Media3D.Vector3D LookVector,
            System.Windows.Media.Media3D.Vector3D Up,
            double OrthoWidth);

        /// <summary>The current view, from the render camera (mouse navigation changes only that one); null without a camera.</summary>
        private CameraView GetCameraView()
        {
            if (ViewModel?.Camera is not HelixToolkit.Wpf.SharpDX.ProjectionCamera camera)
            {
                return null;
            }

            var core = camera.CameraInternal;
            return new CameraView(
                new(core.Position.X, core.Position.Y, core.Position.Z),
                new(core.LookDirection.X, core.LookDirection.Y, core.LookDirection.Z),
                new(core.UpDirection.X, core.UpDirection.Y, core.UpDirection.Z),
                camera is HelixToolkit.Wpf.SharpDX.OrthographicCamera ortho ? ortho.Width : 0);
        }

        /// <summary>Puts the view on both the WPF camera and the render camera, so neither keeps an old value.</summary>
        private void SetCameraView(CameraView view)
        {
            if (ViewModel?.Camera is not HelixToolkit.Wpf.SharpDX.ProjectionCamera camera ||
                view.LookVector.LengthSquared < 1e-12 || view.Up.LengthSquared < 1e-12)
            {
                return;
            }

            if (camera is HelixToolkit.Wpf.SharpDX.OrthographicCamera orthographic && view.OrthoWidth > 0)
            {
                orthographic.AnimateWidth(view.OrthoWidth, 0);
            }

            var (position, lookVector, up) = (view.Position, view.LookVector, view.Up);
            camera.AnimateTo(position, lookVector, up, 0);
            camera.CameraInternal.AnimateTo(
                new((float)position.X, (float)position.Y, (float)position.Z),
                new((float)lookVector.X, (float)lookVector.Y, (float)lookVector.Z),
                new((float)up.X, (float)up.Y, (float)up.Z),
                0);
            UpdateFollowLights();
        }

        // ---- Node tree: search ----
        // Keeps the rows whose name, node index or path contains the text, with their parents
        // (the tree's FilterLevel) and everything under them. Up to NodeSearchExpandLimit found
        // rows get their parents opened; a node number that matches exactly one node selects it.

        private const int NodeSearchExpandLimit = 200;

        private DispatcherTimer _nodeSearchTimer;
        private HashSet<object> _nodeSearchMatches;

        /// <summary>The typed text and, when it is a node number ("#0264", "0264", "264"), that number without '#' and leading zeros.</summary>
        private sealed record NodeSearchQuery(string Text, string Number);

        private void NodeSearchBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var empty = string.IsNullOrEmpty(NodeSearchBox.Text);
            NodeSearchClearButton.SetCurrentValue(VisibilityProperty, empty ? Visibility.Collapsed : Visibility.Visible);

            _nodeSearchTimer ??= new DispatcherTimer(TimeSpan.FromMilliseconds(250), DispatcherPriority.Background,
                (_, _) =>
                {
                    _nodeSearchTimer.Stop();
                    ApplyNodeSearch(NodeSearchBox.Text?.Trim());
                }, Dispatcher);
            _nodeSearchTimer.Stop();

            // clearing shows the whole tree at once
            if (empty)
            {
                ApplyNodeSearch(null);
                return;
            }

            _nodeSearchTimer.Start();
        }

        private void NodeSearchBox_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape && !string.IsNullOrEmpty(NodeSearchBox.Text))
            {
                NodeSearchBox.Clear();
                e.Handled = true;
            }
        }

        private void ClearNodeSearch_OnClick(object sender, RoutedEventArgs e)
        {
            NodeSearchBox.Clear();
            NodeSearchBox.Focus();
        }

        /// <summary>Hint link: clears the search, then opens the tree to the selected object.</summary>
        private void ClearNodeSearchAndReveal_OnClick(object sender, RoutedEventArgs e)
        {
            NodeSearchBox.Clear();
            Dispatcher.BeginInvoke(new Action(RevealSelectedItem), DispatcherPriority.Background);
        }

        // Ctrl+F anywhere in the preview: to the search box. Preview: the viewport would take the key first.
        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            base.OnPreviewKeyDown(e);

            if (e.Key == Key.F && Keyboard.Modifiers == ModifierKeys.Control && NodeSearchBox.IsVisible)
            {
                NodeSearchBox.Focus();
                NodeSearchBox.SelectAll();
                e.Handled = true;
            }
        }

        private void ApplyNodeSearch(string text)
        {
            ShowHiddenBySearchHint(false);

            if (NodeTreeGrid.View is not { } view)
            {
                return;
            }

            // A newer search (or clearing) drops what an older one left queued.
            var generation = ++_nodeSearchGeneration;

            if (string.IsNullOrEmpty(text))
            {
                _nodeSearchMatches = null;
                view.Filter = null;
                view.RefreshFilter();
                SetNodeSearchCount(null);
                AfterNodeTreeRefresh(generation, ScrollNodeTreeToTop);
                return;
            }

            var query = new NodeSearchQuery(text, NormalizeNodeNumber(text));
            var matches = new HashSet<object>(ReferenceEqualityComparer.Instance);
            var found = new List<object>();
            var numbered = new List<WolvenKit.App.Models.MeshComponent>();
            if (ViewModel?.SelectedModelGroup is { } roots)
            {
                foreach (var root in roots)
                {
                    CollectNodeSearchMatches(root, query, false, matches, found, numbered);
                }
            }

            _nodeSearchMatches = matches;
            view.Filter = item => _nodeSearchMatches?.Contains(item) != false;
            view.RefreshFilter();
            SetNodeSearchCount(found.Count);

            AfterNodeTreeRefresh(generation, () =>
            {
                ScrollNodeTreeToTop();

                // With a few hundred rows the tree stays usable; beyond that only the count is shown.
                if (found.Count <= NodeSearchExpandLimit)
                {
                    ExpandFoundRows(found);
                }

                // A node number that is exactly one node's index: select it and scroll to it (also
                // past the limit: "1" finds hundreds of nodes, but means node #0001).
                if (numbered is [var exact])
                {
                    if (ViewModel is { } vm && !ReferenceEquals(vm.SelectedItem, exact))
                    {
                        vm.SelectedItem = exact; // the view model's change reveals it in the tree
                    }
                    else
                    {
                        RevealSelectedItem();
                    }
                }
            });
        }

        private int _nodeSearchGeneration;

        /// <summary>
        /// Runs <paramref name="action"/> once the grid has rebuilt its rows for the new filter,
        /// unless another search came first. With expanding, scrolling and selecting in the same
        /// pass as RefreshFilter, a one-digit search hung WolvenKit: the grid showed the root
        /// collapsed over the old rows and threw ArgumentOutOfRangeException ("-1 out of range
        /// 0 to 0") over and over.
        /// </summary>
        private void AfterNodeTreeRefresh(int generation, Action action) =>
            Dispatcher.BeginInvoke(new Action(() =>
            {
                if (generation == _nodeSearchGeneration && NodeTreeGrid.View != null)
                {
                    action();
                }
            }), DispatcherPriority.Background);

        /// <summary>Opens the parents of the found rows; each parent once (hundreds of rows share a few folders and nodes).</summary>
        private void ExpandFoundRows(List<object> found)
        {
            var opened = new HashSet<object>(ReferenceEqualityComparer.Instance);
            foreach (var element in found.OfType<DependencyObject>())
            {
                if (LogicalTreeHelper.GetParent(element) is not { } parent || opened.Contains(parent))
                {
                    continue;
                }

                ExpandTreePathTo(element);
                var current = parent;
                while (current != null && opened.Add(current))
                {
                    current = LogicalTreeHelper.GetParent(current);
                }
            }
        }

        /// <summary>Count next to the search box: "12 found", "Nothing found", hidden without a search.</summary>
        private void SetNodeSearchCount(int? count)
        {
            var text = count switch
            {
                null => "",
                0 => "Nothing found",
                > NodeSearchExpandLimit => $"{count} found, not expanded",
                _ => $"{count} found",
            };

            NodeSearchCount.SetCurrentValue(TextBlock.TextProperty, text);
            NodeSearchCount.SetCurrentValue(VisibilityProperty, count == null ? Visibility.Collapsed : Visibility.Visible);
        }

        /// <summary>
        /// Back to the first row: a new filter left the old scroll offset, and when it was past
        /// the end of the shorter list the tree showed no rows at all.
        /// </summary>
        private void ScrollNodeTreeToTop()
        {
            if (NodeTreeGrid.View is { } view && ((IEnumerable<TreeNode>)view.Nodes).FirstOrDefault() is { } first &&
                NodeTreeGrid.ResolveToRowIndex(first) is var rowIndex and >= 0)
            {
                NodeTreeGrid.ScrollInView(new RowColumnIndex(rowIndex, 0));
            }
        }

        private void ShowHiddenBySearchHint(bool show) =>
            NodeSearchHint.SetCurrentValue(VisibilityProperty, show ? Visibility.Visible : Visibility.Collapsed);

        /// <summary>
        /// Whether the search keeps the element's row: it or something under it was found
        /// (FilterLevel Extended keeps the parents of found rows). True without a search.
        /// </summary>
        private bool IsShownBySearch(object element)
        {
            if (_nodeSearchMatches is not { } matches || matches.Contains(element))
            {
                return true;
            }

            return element is HelixToolkit.Wpf.SharpDX.GroupModel3D group && group.Children.Any(IsShownBySearch);
        }

        /// <summary>
        /// "#0264", "0264" and "264" → "264"; "#0" and "000" → "0". Null when the text is not a
        /// node number (after an optional '#', digits only).
        /// </summary>
        private static string NormalizeNodeNumber(string text)
        {
            var digits = text?.Trim().TrimStart('#');
            if (string.IsNullOrEmpty(digits) || !digits.All(char.IsAsciiDigit))
            {
                return null;
            }

            var number = digits.TrimStart('0');
            return number.Length == 0 ? "0" : number;
        }

        // found: the rows that match by themselves and are not inside another found row, in tree
        // order (what the count shows and whose parents are opened). numbered: the nodes whose
        // index is the typed number, wherever they are (the sector's own name may match too).
        private static void CollectNodeSearchMatches(object element, NodeSearchQuery query, bool underMatch,
            HashSet<object> matches, List<object> found, List<WolvenKit.App.Models.MeshComponent> numbered)
        {
            var self = NodeMatches(element, query);
            if (self && !underMatch)
            {
                found.Add(element);
            }

            if (element is WolvenKit.App.Models.MeshComponent mesh && IsNumber(mesh.WorldNodeIndex, query.Number))
            {
                numbered.Add(mesh);
            }

            var match = underMatch || self;
            if (match)
            {
                matches.Add(element);
            }

            if (element is HelixToolkit.Wpf.SharpDX.GroupModel3D group)
            {
                foreach (var child in group.Children)
                {
                    CollectNodeSearchMatches(child, query, match, matches, found, numbered);
                }
            }
        }

        // "#264" and "0264" find "#0264": the index compared without '#' and leading zeros
        // (a part of a number still finds it through the "#0264" label)
        private static bool IsNumber(string index, string number) =>
            number != null && NormalizeNodeNumber(index) == number;

        private static bool NodeMatches(object element, NodeSearchQuery query)
        {
            var text = query.Text;

            static bool Has(string value, string text) =>
                !string.IsNullOrEmpty(value) && value.Contains(text, StringComparison.OrdinalIgnoreCase);

            return element switch
            {
                WolvenKit.App.Models.MeshComponent mesh =>
                    Has(mesh.Text, text) || Has(mesh.Name, text) || IsNumber(mesh.WorldNodeIndex, query.Number) ||
                    Has(mesh.DepotPath.GetResolvedText(), text) || Has(mesh.WorldNodeType, text),
                // A sector's type folder ("Meshes (264)") is only a container: its name and count
                // would bring in all of its nodes.
                WolvenKit.App.Models.GroupModel3DExt folder when RDTMeshViewModel.IsSectorTypeFolder(folder) => false,
                WolvenKit.App.Models.GroupModel3DExt group => Has(group.Text, text) || Has(group.Name, text),
                WolvenKit.App.Models.SubmeshComponent submesh => Has(submesh.Text, text) || Has(submesh.Name, text),
                HelixToolkit.Wpf.SharpDX.Element3D other => Has(other.Name, text),
                _ => false,
            };
        }

        // ---- Node tree: expand / collapse with modifiers, as in Blender's outliner ----
        // Shift: the node's whole branch. Ctrl: its siblings too. Ctrl+Shift: the siblings' branches.

        private bool _togglingNodes;

        private void NodeTreeGrid_OnNodeToggled(object sender, EventArgs e)
        {
            var node = e switch
            {
                NodeExpandedEventArgs expanded => expanded.Node,
                NodeCollapsedEventArgs collapsed => collapsed.Node,
                _ => null,
            };
            var modifiers = Keyboard.Modifiers;
            // Only the user's own clicks / keys in the tree: a viewport click with Shift opens
            // the tree to the picked mesh and must not open whole branches.
            if (_togglingNodes || node == null ||
                (modifiers & (ModifierKeys.Shift | ModifierKeys.Control)) == 0 ||
                !(NodeTreeGrid.IsMouseOver || NodeTreeGrid.IsKeyboardFocusWithin))
            {
                return;
            }

            // From the event, not node.IsExpanded: the grid raises it before the flag is set.
            var expand = e is NodeExpandedEventArgs;
            var branch = (modifiers & ModifierKeys.Shift) != 0;
            var siblings = (modifiers & ModifierKeys.Control) != 0;

            // Right away: queued on the dispatcher it waited for the 3D view's frames (seconds).
            // The grid echoes these toggles later, in the same direction, so the echoes change nothing.
            ToggleNodes(node, expand, branch, siblings);
        }

        private void ToggleNodes(TreeNode node, bool expand, bool branch, bool siblings)
        {
            _togglingNodes = true;
            try
            {
                // Copied by hand: Syncfusion's node collections throw on CopyTo, which ToList uses.
                var targets = new List<TreeNode>();
                if (siblings)
                {
                    foreach (var sibling in node.ParentNode?.ChildNodes ?? (IEnumerable<TreeNode>)NodeTreeGrid.View.Nodes)
                    {
                        targets.Add(sibling);
                    }
                }
                else
                {
                    targets.Add(node);
                }

                // The clicked node itself was already toggled by the grid.
                if (!branch)
                {
                    targets.Remove(node);
                }

                foreach (var target in targets)
                {
                    if (branch)
                    {
                        if (expand)
                        {
                            NodeTreeGrid.ExpandAllNodes(target);
                        }
                        else
                        {
                            NodeTreeGrid.CollapseAllNodes(target);
                        }
                    }
                    else if (expand && !target.IsExpanded)
                    {
                        NodeTreeGrid.ExpandNode(target);
                    }
                    else if (!expand && target.IsExpanded)
                    {
                        NodeTreeGrid.CollapseNode(target);
                    }
                }
            }
            finally
            {
                _togglingNodes = false;
            }
        }

        private void PreviewCamera_OnSelectionChanged(object sender, SelectionChangedEventArgs e) =>
            Dispatcher.BeginInvoke(new Action(() => FrameObject()), DispatcherPriority.Background);

        /// <summary>
        /// Points the camera along <paramref name="direction"/> (default: where it looks now) at the
        /// centre of everything shown and moves it back until the bounding sphere fits the view.
        /// Replaces ZoomExtents for these buttons: Helix's perspective ZoomExtents (box fit)
        /// put the camera on the wrong side for some directions, which looked like front/back,
        /// left/right and top/bottom being swapped, and zoomed in too close. The result is set on
        /// both the WPF camera and the render camera, so neither keeps an old value.
        /// </summary>
        private void FrameObject(
            System.Windows.Media.Media3D.Vector3D? direction = null,
            System.Windows.Media.Media3D.Vector3D? upDirection = null)
        {
            if (ViewModel?.Camera is not HelixToolkit.Wpf.SharpDX.ProjectionCamera camera)
            {
                return;
            }

            var bounds = HelixToolkit.Wpf.SharpDX.ViewportExtensions.FindBounds3D(hxViewport);
            if (bounds.IsEmpty || bounds.SizeX + bounds.SizeY + bounds.SizeZ <= 0)
            {
                return;
            }

            var center = new System.Windows.Media.Media3D.Point3D(
                bounds.X + bounds.SizeX / 2, bounds.Y + bounds.SizeY / 2, bounds.Z + bounds.SizeZ / 2);
            var radius = 0.5 * Math.Sqrt(bounds.SizeX * bounds.SizeX + bounds.SizeY * bounds.SizeY + bounds.SizeZ * bounds.SizeZ);

            var core = camera.CameraInternal;
            var look = direction ?? new System.Windows.Media.Media3D.Vector3D(core.LookDirection.X, core.LookDirection.Y, core.LookDirection.Z);
            var up = upDirection ?? new System.Windows.Media.Media3D.Vector3D(core.UpDirection.X, core.UpDirection.Y, core.UpDirection.Z);
            if (look.LengthSquared < 1e-12)
            {
                return;
            }

            look.Normalize();
            var aspect = hxViewport.ActualWidth / Math.Max(1.0, hxViewport.ActualHeight);
            double distance;
            if (camera is HelixToolkit.Wpf.SharpDX.PerspectiveCamera perspective)
            {
                // Helix's FieldOfView is horizontal; fit the sphere into the narrower of the two.
                var halfH = perspective.FieldOfView * Math.PI / 360.0;
                var halfV = Math.Atan(Math.Tan(halfH) / aspect);
                distance = radius / Math.Sin(Math.Min(halfH, halfV));
            }
            else
            {
                distance = radius * 3; // orthographic: the distance does not change the size
                if (camera is HelixToolkit.Wpf.SharpDX.OrthographicCamera orthographic)
                {
                    orthographic.AnimateWidth(2 * radius * Math.Max(1.0, aspect), 0);
                }
            }

            var lookVector = look * distance;
            var position = center - lookVector;
            camera.AnimateTo(position, lookVector, up, 0);
            core.AnimateTo(
                new((float)position.X, (float)position.Y, (float)position.Z),
                new((float)lookVector.X, (float)lookVector.Y, (float)lookVector.Z),
                new((float)up.X, (float)up.Y, (float)up.Z),
                0);
        }

        /// <summary>
        /// Renders the current view over black and over white with the axes and the view cube
        /// hidden and the reflection cube map frozen, so reflections do not pick up the changed
        /// background. Null (with an error logged) if the preview does not render.
        /// </summary>
        private async System.Threading.Tasks.Task<(System.IO.MemoryStream OverBlack, System.IO.MemoryStream OverWhite)?> CapturePreviewAsync(
            WolvenKit.App.ViewModels.Documents.RDTMeshViewModel vm)
        {
            var background = hxViewport.BackgroundColor;
            var showAxes = hxViewport.ShowCoordinateSystem;
            var showViewCube = hxViewport.ShowViewCube;
            var dynamicReflection = hxReflection.IsDynamicScene;
            var oitMode = hxViewport.GetValue(HelixToolkit.Wpf.SharpDX.Viewport3DX.OITRenderModeProperty);
            var width = hxViewport.Width;
            var height = hxViewport.Height;
            System.IO.MemoryStream overBlack = null;
            System.IO.MemoryStream overWhite = null;
            try
            {
                // Supersampling: render the viewport larger than it is on screen (it is clipped
                // by the panel meanwhile), so the image is scaled down instead of up.
                var factor = Math.Clamp(vm.PreviewSupersample, 1, 4);
                if (factor > 1 && hxViewport.ActualWidth > 0 && hxViewport.ActualHeight > 0)
                {
                    var limit = 8192.0 / Math.Max(hxViewport.ActualWidth, hxViewport.ActualHeight);
                    var f = Math.Min(factor, limit);
                    hxViewport.SetCurrentValue(FrameworkElement.WidthProperty, Math.Floor(hxViewport.ActualWidth * f));
                    hxViewport.SetCurrentValue(FrameworkElement.HeightProperty, Math.Floor(hxViewport.ActualHeight * f));
                    hxViewport.UpdateLayout();
                    await WaitFramesAsync(2);
                }

                hxViewport.SetCurrentValue(HelixToolkit.Wpf.SharpDX.Viewport3DX.ShowCoordinateSystemProperty, false);
                hxViewport.SetCurrentValue(HelixToolkit.Wpf.SharpDX.Viewport3DX.ShowViewCubeProperty, false);
                SetOitMode("DepthPeeling"); // saved images keep the exact transparency
                (await RenderOnceAsync())?.Dispose(); // reflections settle on the usual background
                hxReflection.SetCurrentValue(HelixToolkit.Wpf.SharpDX.DynamicReflectionMap3D.IsDynamicSceneProperty, false);

                hxViewport.SetCurrentValue(HelixToolkit.Wpf.SharpDX.Viewport3DX.BackgroundColorProperty, System.Windows.Media.Colors.Black);
                overBlack = await RenderOnceAsync();
                hxViewport.SetCurrentValue(HelixToolkit.Wpf.SharpDX.Viewport3DX.BackgroundColorProperty, System.Windows.Media.Colors.White);
                overWhite = await RenderOnceAsync();
            }
            catch (Exception ex)
            {
                overBlack?.Dispose();
                overWhite?.Dispose();
                vm.ReportPreviewImageError(ex.Message);
                return null;
            }
            finally
            {
                hxViewport.SetCurrentValue(FrameworkElement.WidthProperty, width);
                hxViewport.SetCurrentValue(FrameworkElement.HeightProperty, height);
                hxViewport.SetCurrentValue(HelixToolkit.Wpf.SharpDX.Viewport3DX.BackgroundColorProperty, background);
                hxViewport.SetCurrentValue(HelixToolkit.Wpf.SharpDX.Viewport3DX.ShowCoordinateSystemProperty, showAxes);
                hxViewport.SetCurrentValue(HelixToolkit.Wpf.SharpDX.Viewport3DX.ShowViewCubeProperty, showViewCube);
                hxViewport.SetCurrentValue(HelixToolkit.Wpf.SharpDX.Viewport3DX.OITRenderModeProperty, oitMode);
                hxReflection.SetCurrentValue(HelixToolkit.Wpf.SharpDX.DynamicReflectionMap3D.IsDynamicSceneProperty, dynamicReflection);
            }

            if (overBlack == null || overWhite == null)
            {
                overBlack?.Dispose();
                overWhite?.Dispose();
                vm.ReportPreviewImageError("the preview is not rendering (is the tab visible?)");
                return null;
            }

            return (overBlack, overWhite);
        }

        private async System.Threading.Tasks.Task WaitFramesAsync(int frames)
        {
            for (var i = 0; i < frames; i++)
            {
                await Dispatcher.InvokeAsync(() => { }, DispatcherPriority.Render);
                await Dispatcher.InvokeAsync(() => { }, DispatcherPriority.ContextIdle);
            }
        }

        /// <summary>Lets property changes reach the render host, then renders one frame into a BMP stream.</summary>
        private async System.Threading.Tasks.Task<System.IO.MemoryStream> RenderOnceAsync()
        {
            await Dispatcher.InvokeAsync(() => { }, DispatcherPriority.Render);
            return HelixToolkit.SharpDX.Core.IViewportExtensions.RenderToBitmapStream(hxViewport);
        }

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
