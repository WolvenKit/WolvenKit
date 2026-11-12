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

                    // Sectors hold a lot of transparent geometry: depth peeling multiplies the
                    // draw calls (8 passes) and the UI thread has no time left for the mouse.
                    SetOitMode(IsSectorPreview(vm) ? "SinglePassWeighted" : "DepthPeeling");

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
        /// (cached ones are reused), frame it and save &lt;file&gt;_&lt;appearance&gt;.png with the
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

            if (appearances.Count > 1)
            {
                var picked = PickAppearances(appearances.Select(a => a.Name).ToList());
                if (picked == null)
                {
                    return;
                }

                appearances = appearances.Where(a => picked.Contains(a.Name)).ToList();
                if (appearances.Count == 0)
                {
                    return;
                }
            }

            var folder = vm.PickPreviewIconFolder(appearances.Select(a => a.Name).ToList());
            if (folder == null)
            {
                return;
            }

            _savingIcons = true;
            var original = vm.SelectedAppearance;
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
                    FrameObject();
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
        /// Small checklist of appearances for the icon batch: all ticked, with All / None.
        /// Null if cancelled. Built in code, it is only used here.
        /// </summary>
        private HashSet<string> PickAppearances(IReadOnlyList<string> names)
        {
            var boxes = names.Select(n => new CheckBox { Content = n, IsChecked = true, Margin = new Thickness(4, 2, 4, 2) }).ToList();
            var list = new StackPanel();
            foreach (var box in boxes)
            {
                list.Children.Add(box);
            }

            var window = new System.Windows.Window
            {
                Title = "Save Appearance Icons",
                Width = 380,
                Height = Math.Min(560, 150 + 26 * names.Count),
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

            var buttons = new DockPanel { LastChildFill = false, Margin = new Thickness(4) };
            var all = MakeButton("All", () => boxes.ForEach(b => b.SetCurrentValue(System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, true)));
            var none = MakeButton("None", () => boxes.ForEach(b => b.SetCurrentValue(System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, false)));
            var cancel = MakeButton("Cancel", () => window.DialogResult = false, isCancel: true);
            var ok = MakeButton("Save", () => window.DialogResult = true, isDefault: true);
            DockPanel.SetDock(all, Dock.Left);
            DockPanel.SetDock(none, Dock.Left);
            DockPanel.SetDock(cancel, Dock.Right);
            DockPanel.SetDock(ok, Dock.Right);
            buttons.Children.Add(all);
            buttons.Children.Add(none);
            buttons.Children.Add(cancel);
            buttons.Children.Add(ok);

            var root = new DockPanel { Margin = new Thickness(6) };
            var header = new TextBlock { Text = "Appearances to save:", Margin = new Thickness(4, 2, 4, 6) };
            DockPanel.SetDock(header, Dock.Top);
            DockPanel.SetDock(buttons, Dock.Bottom);
            root.Children.Add(header);
            root.Children.Add(buttons);
            root.Children.Add(new ScrollViewer { Content = list, VerticalScrollBarVisibility = ScrollBarVisibility.Auto });
            window.Content = root;

            if (window.ShowDialog() != true)
            {
                return null;
            }

            return boxes.Where(b => b.IsChecked == true).Select(b => (string)b.Content).ToHashSet();
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
