using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// The colours a layer of a multilayer setup can take: every colorScale override of the layer's template as a
    /// swatch, grouped and ordered like the palette of the Blender add-on (see <see cref="MultilayerPalette"/>).
    /// Clicking a swatch sets the layer's colorScale; the current one is outlined.
    /// </summary>
    public partial class MultilayerPaletteView : UserControl
    {
        private const double SwatchSize = 14;

        /// <summary>Space between the blocks of two groups.</summary>
        private const double GroupGap = 8;

        /// <summary>Open or closed for all layers and files of the session.</summary>
        private static bool s_isExpanded = true;

        private ChunkViewModel _subscribed;

        public MultilayerPaletteView()
        {
            InitializeComponent();

            PaletteExpander.SetCurrentValue(Expander.IsExpandedProperty, s_isExpanded);
            PaletteExpander.Expanded += (_, _) => s_isExpanded = true;
            PaletteExpander.Collapsed += (_, _) => s_isExpanded = false;

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

        private void Rebuild()
        {
            RowsPanel.Children.Clear();

            if (Cvm is not { ParentData: Multilayer_Layer layer } cvm ||
                layer.Material.DepotPath.GetResolvedText() is not { Length: > 0 } template ||
                Locator.Current.GetService<DocumentTools>() is not { } documentTools)
            {
                SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                return;
            }

            SetCurrentValue(VisibilityProperty, Visibility.Visible);
            CopyTemplateButton.SetCurrentValue(VisibilityProperty,
                cvm.CanCopyMultilayerTemplate() ? Visibility.Visible : Visibility.Collapsed);

            if (documentTools.GetMultilayerPalette(template) is not { Count: > 0 } colors)
            {
                PaletteExpander.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                return;
            }

            PaletteExpander.SetCurrentValue(VisibilityProperty, Visibility.Visible);
            var current = cvm.ResolvedData is CName name ? name.GetResolvedText() : null;
            var rows = MultilayerPalette.GroupIntoRows(colors);
            PaletteExpander.SetCurrentValue(HeaderedContentControl.HeaderProperty,
                $"Palette: {colors.Count} colours in {rows.Count} groups");

            // same width for every group, so the blocks line up in columns
            var groupWidth = rows.Max(row => row.Count) * (SwatchSize + 2);
            foreach (var row in rows)
            {
                var panel = new StackPanel
                {
                    Orientation = Orientation.Horizontal,
                    Width = groupWidth,
                    Margin = new Thickness(0, 0, GroupGap, GroupGap / 2),
                };
                foreach (var color in row)
                {
                    panel.Children.Add(CreateSwatch(color, color.Name == current));
                }

                RowsPanel.Children.Add(panel);
            }
        }

        private Border CreateSwatch(MultilayerPaletteColor color, bool isCurrent)
        {
            var brush = new SolidColorBrush(MultilayerPalette.ToColor(color));
            brush.Freeze();

            var swatch = new Border
            {
                Width = SwatchSize,
                Height = SwatchSize,
                Margin = new Thickness(1),
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
