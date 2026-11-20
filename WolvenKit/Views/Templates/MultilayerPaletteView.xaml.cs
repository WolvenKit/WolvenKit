using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// The colors a layer of a multilayer setup can take: every colorScale override of the layer's template as a
    /// swatch, grouped and ordered like the palette of the Blender add-on (see <see cref="MultilayerPalette"/>).
    /// Clicking a swatch sets the layer's colorScale; the current one is outlined.
    /// </summary>
    public partial class MultilayerPaletteView : UserControl
    {
        private const double SwatchSize = 14;

        /// <summary>Swatches of the grid: fewer per line, so larger.</summary>
        private const double GridSwatchSize = 22;

        /// <summary>Gap in the grid where the next column starts another hue step.</summary>
        private const double HueStepGap = 8;

        /// <summary>Space between the blocks of two groups.</summary>
        private const double GroupGap = 4;

        /// <summary>Open or closed for all layers and files of the session.</summary>
        private static bool s_isExpanded = true;

        /// <summary>Groups as columns (grid) or as rows, when there are no settings to keep it in.</summary>
        private static bool s_gridMode = true;

        /// <summary>
        /// Visibility of the colorScale dropdown above the palette: collapsed while there is a palette to pick from,
        /// unless the settings ask for the dropdown too; visible as the fallback when there isn't.
        /// </summary>
        public static readonly DependencyProperty DropdownVisibilityProperty = DependencyProperty.Register(
            nameof(DropdownVisibility), typeof(Visibility), typeof(MultilayerPaletteView), new PropertyMetadata(Visibility.Visible));

        public Visibility DropdownVisibility
        {
            get => (Visibility)GetValue(DropdownVisibilityProperty);
            set => SetValue(DropdownVisibilityProperty, value);
        }

        private static ISettingsManager Settings => Locator.Current.GetService<ISettingsManager>();

        /// <summary>Grid or rows, kept in the settings (also in the settings page).</summary>
        private static bool GridMode
        {
            get => Settings?.MultilayerPaletteGrid ?? s_gridMode;
            set
            {
                s_gridMode = value;
                if (Settings is { } settings)
                {
                    settings.MultilayerPaletteGrid = value;
                }
            }
        }

        private ChunkViewModel _subscribed;

        /// <summary>Text of the search box: colors whose name doesn't contain it are dimmed.</summary>
        private string _search = "";

        public MultilayerPaletteView()
        {
            InitializeComponent();

            PaletteExpander.SetCurrentValue(Expander.IsExpandedProperty, s_isExpanded);
            PaletteExpander.Expanded += (_, _) => s_isExpanded = true;
            PaletteExpander.Collapsed += (_, _) => s_isExpanded = false;

            // on = Rows
            ModeSwitch.SetCurrentValue(MahApps.Metro.Controls.ToggleSwitch.IsOnProperty, !GridMode);

            DataContextChanged += (_, _) => Subscribe();
            Loaded += (_, _) => Subscribe();
            Unloaded += (_, _) => Unsubscribe();
        }

        private ChunkViewModel Cvm => DataContext as ChunkViewModel;

        private void Subscribe()
        {
            Unsubscribe();
            if (Cvm is { } cvm)
            {
                cvm.PropertyChanged += OnCvmPropertyChanged;
                _subscribed = cvm;
            }

            Rebuild();
        }

        private void Unsubscribe()
        {
            if (_subscribed is not null)
            {
                _subscribed.PropertyChanged -= OnCvmPropertyChanged;
                _subscribed = null;
            }
        }

        // the outline follows a colorScale picked in the dropdown or typed
        private void OnCvmPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ChunkViewModel.Data))
            {
                Rebuild();
            }
        }

        private void ModeSwitch_OnToggled(object sender, RoutedEventArgs e) => SetMode(!ModeSwitch.IsOn);

        private void SetMode(bool grid)
        {
            if (GridMode != grid)
            {
                GridMode = grid;
                Rebuild();
            }
        }

        private void Rebuild()
        {
            RowsPanel.Children.Clear();
            ColumnsPanel.Children.Clear();
            var gridMode = GridMode;
            ModeSwitch.SetCurrentValue(MahApps.Metro.Controls.ToggleSwitch.IsOnProperty, !gridMode);
            GridScroll.SetCurrentValue(VisibilityProperty, gridMode ? Visibility.Visible : Visibility.Collapsed);
            RowsScroll.SetCurrentValue(VisibilityProperty, gridMode ? Visibility.Collapsed : Visibility.Visible);
            // the dropdown is the fallback: shown until there's a palette to pick from
            SetCurrentValue(DropdownVisibilityProperty, Visibility.Visible);

            if (Cvm is not { ParentData: Multilayer_Layer layer } cvm ||
                layer.Material.DepotPath.GetResolvedText() is not { Length: > 0 } template ||
                Locator.Current.GetService<DocumentTools>() is not { } documentTools)
            {
                SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                return;
            }

            SetCurrentValue(VisibilityProperty, Visibility.Visible);

            // no colors because there's no template: say so, instead of an empty palette
            var exists = documentTools.MultilayerTemplateExists(template);
            NotFoundText.SetCurrentValue(TextBlock.TextProperty, exists ? "" : $"Template not found in the project or the game: {template}");
            NotFoundText.SetCurrentValue(VisibilityProperty, exists ? Visibility.Collapsed : Visibility.Visible);

            CopyTemplateButton.SetCurrentValue(VisibilityProperty,
                cvm.CanCopyMultilayerTemplate() ? Visibility.Visible : Visibility.Collapsed);

            PaletteExpander.SetCurrentValue(VisibilityProperty, exists ? Visibility.Visible : Visibility.Collapsed);
            // a template without colors still shows the header row: its copy button is how colors get added
            if (documentTools.GetMultilayerPalette(template) is not { Count: > 0 } colors)
            {
                PaletteExpander.SetCurrentValue(HeaderedContentControl.HeaderProperty, "Palette: no colors");
                return;
            }

            if (Settings is not { ShowColorScaleDropdown: true })
            {
                SetCurrentValue(DropdownVisibilityProperty, Visibility.Collapsed);
            }

            var current = cvm.ResolvedData is CName name ? name.GetResolvedText() : null;
            var rows = MultilayerPalette.GroupIntoRows(colors);
            // with the dropdown hidden the header names the current color
            PaletteExpander.SetCurrentValue(HeaderedContentControl.HeaderProperty,
                $"Palette: {colors.Count} colors in {rows.Count} groups" + (current is { Length: > 0 } ? $"  ·  {current}" : ""));

            if (gridMode)
            {
                BuildGrid(MultilayerPalette.GroupIntoGrid(colors), current);
                return;
            }

            // same width for the groups, so the blocks line up in columns: the most common group size, not the
            // largest, so one group with custom colors doesn't widen every block; its extra colors wrap to a
            // second line inside its own block instead of pushing the next blocks out of line
            var typical = rows
                .GroupBy(row => row.Count)
                .OrderByDescending(g => g.Count())
                .ThenByDescending(g => g.Key)
                .First().Key;
            foreach (var row in rows)
            {
                var panel = new WrapPanel
                {
                    Orientation = Orientation.Horizontal,
                    Width = typical * (SwatchSize + 1),
                    Margin = new Thickness(0, 0, GroupGap, 1),
                };
                foreach (var color in row)
                {
                    panel.Children.Add(CreateSwatch(color, color.Name == current, SwatchSize, s_gridSwatchMargin));
                }

                RowsPanel.Children.Add(panel);
            }
        }

        /// <summary>
        /// One strip of columns, like CDPR's material browser: the color groups side by side in the palette order,
        /// a wider gap between hue steps, and one row per variant suffix, so a row is the same saturation step for
        /// every hue; an empty cell is a variant the group doesn't have. Scrolled so the current color is in view.
        /// </summary>
        private void BuildGrid(MultilayerPaletteGrid grid, string current)
        {
            var currentOffset = -1.0;
            var matchOffset = -1.0;
            var x = 0.0;
            for (var i = 0; i < grid.Columns.Count; i++)
            {
                var gap = i + 1 < grid.Columns.Count && grid.Columns[i + 1].HueStep != grid.Columns[i].HueStep ? HueStepGap : 0;
                var column = new StackPanel
                {
                    Orientation = Orientation.Vertical,
                    Margin = new Thickness(0, 0, gap, 0),
                };
                var cells = grid.Columns[i].Cells;
                for (var row = 0; row < cells.Count; row++)
                {
                    // a gap between the shared rows and the colors of the groups' own below them
                    var margin = row == grid.RowSuffixes.Count && row > 0 ? s_extraRowsMargin : s_gridSwatchMargin;
                    var color = cells[row];
                    if (color is null)
                    {
                        column.Children.Add(CreateEmptyCell(GridSwatchSize, margin));
                        continue;
                    }

                    var isCurrent = color.Name == current;
                    if (isCurrent)
                    {
                        currentOffset = x;
                    }

                    if (matchOffset < 0 && Matches(color))
                    {
                        matchOffset = x;
                    }

                    column.Children.Add(CreateSwatch(color, isCurrent, GridSwatchSize, margin));
                }

                ColumnsPanel.Children.Add(column);
                x += GridSwatchSize + 1 + gap;
            }

            // searching: the first match in view; else the current color
            var offset = Math.Max(0, _search.Length > 0 && matchOffset >= 0 ? matchOffset : currentOffset);
            Dispatcher.InvokeAsync(() =>
                GridScroll.ScrollToHorizontalOffset(Math.Max(0, offset - (GridScroll.ViewportWidth / 2))),
                DispatcherPriority.Loaded);
        }

        // Shift + wheel scrolls the grid sideways; the plain wheel keeps scrolling the panel around it
        private void GridScroll_OnPreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (Keyboard.Modifiers.HasFlag(ModifierKeys.Shift))
            {
                GridScroll.ScrollToHorizontalOffset(GridScroll.HorizontalOffset - e.Delta);
                e.Handled = true;
            }
        }

        /// <summary>1 px between the swatches (both layouts).</summary>
        private static readonly Thickness s_gridSwatchMargin = new(0, 0, 1, 1);

        /// <summary>Above the first color below the shared rows of the grid (custom variants).</summary>
        private static readonly Thickness s_extraRowsMargin = new(0, 6, 1, 1);

        private bool Matches(MultilayerPaletteColor color) =>
            _search.Length == 0 || color.Name.Contains(_search, StringComparison.OrdinalIgnoreCase);

        private void SearchBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            _search = SearchBox.Text.Trim();
            Rebuild();
        }

        private static Border CreateEmptyCell(double size, Thickness margin)
        {
            var cell = new Border
            {
                Width = size,
                Height = size,
                Margin = margin,
                BorderThickness = new Thickness(1),
                Opacity = 0.35,
                SnapsToDevicePixels = true,
                ToolTip = "This group has no color for this row",
            };
            cell.SetResourceReference(Border.BorderBrushProperty, "BorderAlt");
            return cell;
        }

        private Border CreateSwatch(MultilayerPaletteColor color, bool isCurrent, double size = SwatchSize, Thickness? margin = null)
        {
            var brush = new SolidColorBrush(MultilayerPalette.ToColor(color));
            brush.Freeze();

            var swatch = new Border
            {
                Width = size,
                Height = size,
                Margin = margin ?? new Thickness(1),
                Opacity = Matches(color) ? 1 : 0.15,
                Background = brush,
                BorderThickness = new Thickness(isCurrent ? 2 : 1),
                Cursor = Cursors.Hand,
                SnapsToDevicePixels = true,
                Tag = color.Name,
                ToolTip = string.Format(CultureInfo.CurrentCulture, "{0}\n{1:0.###}  {2:0.###}  {3:0.###}", color.Name, color.R, color.G, color.B),
            };
            swatch.SetResourceReference(Border.BorderBrushProperty, isCurrent ? "ContentForeground" : "BorderAlt");
            swatch.MouseLeftButtonUp += Swatch_OnMouseLeftButtonUp;
            return swatch;
        }

        private async void CopyTemplateButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (Cvm is { } cvm)
            {
                await cvm.CopyMultilayerTemplateToProjectCommand.ExecuteAsync(null);
                Rebuild();
            }
        }

        // set as the dropdown does: the layer row, its swatch and the dropdown follow
        private void Swatch_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (sender is FrameworkElement { Tag: string name } && Cvm is { } cvm)
            {
                cvm.Data = (CName)name;
                e.Handled = true;
            }
        }
    }
}
