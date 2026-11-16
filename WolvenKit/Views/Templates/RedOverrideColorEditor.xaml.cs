using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Color of a colorScale override of a multilayer template (its v: red, green, blue as floats 0..1): a color
    /// palette that writes the three channels, and their stored values. The channels stay editable one by one
    /// under v, for values the palette can't give (finer than 1/255, above 1).
    /// </summary>
    public partial class RedOverrideColorEditor : UserControl
    {
        private ChunkViewModel _subscribed;

        public RedOverrideColorEditor()
        {
            SelectedColorCommand = new RelayCommand<object>(OnColorPicked);
            InitializeComponent();

            DataContextChanged += (_, _) => Subscribe();
            Loaded += (_, _) => Subscribe();
            Unloaded += (_, _) => Unsubscribe();
        }

        public ICommand SelectedColorCommand { get; }

        private ChunkViewModel Cvm => DataContext as ChunkViewModel;

        /// <summary>The values follow edits made elsewhere (one channel under v, undo): v's swatch is recalculated then.</summary>
        private void Subscribe()
        {
            Unsubscribe();
            if (Cvm is { } cvm)
            {
                cvm.PropertyChanged += OnCvmPropertyChanged;
                _subscribed = cvm;
            }

            UpdateChannels();
        }

        private void Unsubscribe()
        {
            if (_subscribed is not null)
            {
                _subscribed.PropertyChanged -= OnCvmPropertyChanged;
                _subscribed = null;
            }
        }

        private void OnCvmPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ChunkViewModel.PreviewColor))
            {
                UpdateChannels();
            }
        }

        private void UpdateChannels()
        {
            var text = Cvm?.ResolvedData is CArrayFixedSize<CFloat> { Count: >= 3 } v
                ? string.Join("  ", Enumerable.Range(0, 3).Select(i => ((float)v[i]).ToString("0.###", CultureInfo.CurrentCulture)))
                : "";
            ChannelsText.SetCurrentValue(TextBlock.TextProperty, text);
        }

        /// <summary>
        /// Writes the picked color through the channels' own view models, as typing them would: the array, the
        /// file's dirty state and the swatches of v and of the override are updated the usual way.
        /// </summary>
        private void OnColorPicked(object parameter)
        {
            // the palette also reports the color it was given; that is not a change
            if (Cvm is not { } cvm || PickedColor(parameter) is not { } color || cvm.PreviewColor == color)
            {
                return;
            }

            cvm.CalculateProperties();
            byte[] channels = [color.R, color.G, color.B];
            for (var i = 0; i < channels.Length && i < cvm.Properties.Count; i++)
            {
                cvm.Properties[i].Data = (CFloat)(channels[i] / 255f);
            }
        }

        /// <summary>The palette passes an item with a Brush (as in the other color editors); a color or a brush is taken as is.</summary>
        private static Color? PickedColor(object parameter) => parameter switch
        {
            Color color => color,
            SolidColorBrush brush => brush.Color,
            null => null,
            _ => (parameter.GetType().GetProperty("Brush")?.GetValue(parameter) as SolidColorBrush)?.Color,
        };
    }
}
