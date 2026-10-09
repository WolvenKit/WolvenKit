using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Templates
{
    /// <summary>Edits a depot path stored as a 64-bit hash.</summary>
    public partial class DisplayAsResourcePathEditor : UserControl, INotifyPropertyChanged
    {
        private const string hexadecimalFormat = "X";

        /// <summary>Identifies the <see cref="RedNumber"/> dependency property.</summary>
        public static readonly DependencyProperty RedNumberProperty = DependencyProperty.Register(
            nameof(RedNumber),
            typeof(IRedPrimitive<ulong>),
            typeof(DisplayAsResourcePathEditor),
            new PropertyMetadata(default(IRedPrimitive<ulong>), OnRedNumberChanged));

        private readonly ISettingsManager _settingsManager;

        public DisplayAsResourcePathEditor()
        {
            InitializeComponent();
            _settingsManager = Locator.Current.GetService<ISettingsManager>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>Gets or sets the depot path hash.</summary>
        public IRedPrimitive<ulong> RedNumber
        {
            get => (IRedPrimitive<ulong>)GetValue(RedNumberProperty);
            set => SetValue(RedNumberProperty, value);
        }

        /// <summary>Gets or sets the depot path represented by <see cref="RedNumber"/>.</summary>
        public string DepotPath
        {
            get => GetResourcePath().GetResolvedText() ?? string.Empty;
            set => SetResourcePath(string.IsNullOrWhiteSpace(value) ? ResourcePath.Empty : (ResourcePath)value.Trim());
        }

        /// <summary>Gets or sets the formatted hash.</summary>
        public string Hash
        {
            get
            {
                var hash = GetResourcePath().GetRedHash();
                return _settingsManager.ShowResourcePathAsHex ? hash.ToString(hexadecimalFormat) : hash.ToString();
            }
            set
            {
                if (TryParseHash(value, out var hash))
                {
                    SetResourcePath(hash);
                }
            }
        }

        private static void OnRedNumberChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not DisplayAsResourcePathEditor view)
            {
                return;
            }

            view.OnPropertyChanged(nameof(DepotPath));
            view.OnPropertyChanged(nameof(Hash));
        }

        private ResourcePath GetResourcePath() => RedNumber is CUInt64 hash ? (ulong)hash : ResourcePath.Empty;

        private void SetResourcePath(ResourcePath resourcePath) =>
            SetCurrentValue(RedNumberProperty, (CUInt64)(ulong)resourcePath);

        private bool TryParseHash(string text, out ulong hash) =>
            _settingsManager.ShowResourcePathAsHex
                ? ulong.TryParse(text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out hash)
                : ulong.TryParse(text, out hash);

        private void HashBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var text = HashBox.Text.Remove(HashBox.SelectionStart, HashBox.SelectionLength).Insert(HashBox.CaretIndex, e.Text);
            e.Handled = !TryParseHash(text, out _);
        }

        private void HashBox_OnPasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetData(typeof(string)) is not string pastedText)
            {
                e.CancelCommand();
                return;
            }

            var text = HashBox.Text.Remove(HashBox.SelectionStart, HashBox.SelectionLength).Insert(HashBox.CaretIndex, pastedText);
            if (!TryParseHash(text, out _))
            {
                e.CancelCommand();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
