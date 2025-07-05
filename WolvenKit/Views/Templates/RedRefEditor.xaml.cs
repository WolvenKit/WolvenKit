using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using HandyControl.Tools.Extension;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.Modkit.Resources;
using WolvenKit.RED4.Types;

public enum FileScope
{
    GameOrMod,
    OtherMod,
    NotFound,
    NotFoundWarning,
    InvalidSubstitution,
    Unknown
}

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedRefEditor.xaml
    /// </summary>
    public partial class RedRefEditor : INotifyPropertyChanged
    {
        private readonly ISettingsManager _settingsManager;
        private readonly IAppArchiveManager _archiveManager;

        // We need this to update after onPaste
        private readonly DispatcherTimer _updateTimer;

        public IEnumerable<InternalEnums.EImportFlags> EnumValues => Enum.GetValues(typeof(InternalEnums.EImportFlags)).Cast<InternalEnums.EImportFlags>();

        public RedRefEditor()
        {
            InitializeComponent();
            _settingsManager = Locator.Current.GetService<ISettingsManager>();
            _archiveManager = Locator.Current.GetService<IAppArchiveManager>();

            FlagsComboBox.SelectionChanged += FlagsComboBox_OnSelectionChanged;

            // Set a timer to trigger a validity check 500 ms after init
            _updateTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(500)
            };
            _updateTimer.Tick += OnUpdateTimerTick;
        }

        public IRedRef RedRef
        {
            get => (IRedRef)GetValue(RedRefProperty);
            set => SetValue(RedRefProperty, value);
        }

        /// <summary>Identifies the <see cref="RedRef"/> dependency property.</summary>
        public static readonly DependencyProperty RedRefProperty = DependencyProperty.Register(
            nameof(RedRef), typeof(IRedRef), typeof(RedRefEditor), new PropertyMetadata(null, OnRedRefChanged));

        private static void OnRedRefChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not RedRefEditor { RedRef: not null } view)
            {
                return;
            }

            view.OnPropertyChanged(nameof(RedRef));
        }

        public FileScope Scope
        {
            get => (FileScope)GetValue(ScopeProperty);
            set => SetValue(ScopeProperty, value);
        }

        /// <summary>Identifies the <see cref="Scope"/> dependency property.</summary>
        public static readonly DependencyProperty ScopeProperty = DependencyProperty.Register(
            nameof(Scope),
            typeof(FileScope),
            typeof(RedRefEditor),
            new PropertyMetadata(default(FileScope), OnScopeChanged)
        );

        private static void OnScopeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is RedRefEditor { RedRef: not null } view)
            {
                view.OnPropertyChanged(nameof(Scope));
            }
        }


        public string DepotPath
        {
            get => RedRef?.DepotPath ?? ResourcePath.Empty;
            set
            {
                if (RedRef is null)
                {
                    return;
                }
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    SetValue(RedRefProperty, (IRedRef)RedTypeManager.CreateRedType(RedRef.RedType, (ResourcePath)value, RedRef.Flags));
                }
                else
                {
                    SetValue(RedRefProperty, (IRedRef)RedTypeManager.CreateRedType(RedRef.RedType, ResourcePath.Empty, InternalEnums.EImportFlags.Default));
                }
            }
        }

        public string Hash
        {
            get
            {
                var numericHash = RedRef?.DepotPath.GetRedHash() ?? 0; 
                if (_settingsManager.ShowResourcePathAsHex)
                {
                    return numericHash.ToString("X");
                }

                return numericHash.ToString();

            }
            set
            {
                if (RedRef is null)
                {
                    return;
                }
                if (_settingsManager.ShowResourcePathAsHex)
                {
                    SetValue(RedRefProperty, (IRedRef)RedTypeManager.CreateRedType(RedRef.RedType, (ResourcePath)ulong.Parse(value, NumberStyles.HexNumber), RedRef.Flags));
                }
                else
                {
                    SetValue(RedRefProperty, (IRedRef)RedTypeManager.CreateRedType(RedRef.RedType, (ResourcePath)ulong.Parse(value), RedRef.Flags));
                }
            }
        }

        public string TypeName => RedRef?.RedType ?? nameof(RedDummy);

        private void HashBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var full = HashBox.Text.Remove(HashBox.SelectionStart, HashBox.SelectionLength).Insert(HashBox.CaretIndex, e.Text);

            if (_settingsManager.ShowResourcePathAsHex)
            {
                e.Handled = !ulong.TryParse(full, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out _);
            }
            else
            {
                e.Handled = !ulong.TryParse(full, out _);
            }
        }

        private void HashBox_OnPasting(object sender, DataObjectPastingEventArgs e)
        {
            if (!e.DataObject.GetDataPresent(typeof(string)))
            {
                e.CancelCommand();
                return;
            }

            var text = (string)e.DataObject.GetData(typeof(string));
            var full = HashBox.Text.Remove(HashBox.SelectionStart, HashBox.SelectionLength).Insert(HashBox.CaretIndex, text!);

            if ((!_settingsManager.ShowResourcePathAsHex || ulong.TryParse(full, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out _))
                && (_settingsManager.ShowResourcePathAsHex || ulong.TryParse(full, out _)))
            {
                return;
            }

            e.CancelCommand();
        }

        private void FlagsComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is not ComboBox { SelectedItem: InternalEnums.EImportFlags flags })
            {
                return;
            }

            if (RedRef != null && RedRef.Flags != flags)
            {
                SetCurrentValue(RedRefProperty, (IRedRef)RedTypeManager.CreateRedType(RedRef.RedType, RedRef.DepotPath, flags));
            }
        }

        /// <summary>Identifies the <see cref="TextBoxToolTip"/> dependency property.</summary>
        public static readonly DependencyProperty TextBoxToolTipProperty = DependencyProperty.Register(
            nameof(TextBoxToolTip), typeof(string), typeof(RedRefEditor), new PropertyMetadata(default(string)));

        public string TextBoxToolTip
        {
            get => (string)GetValue(TextBoxToolTipProperty);
            set => SetValue(TextBoxToolTipProperty, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            if (propertyName != nameof(RedRef))
            {
                return;
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TypeName)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DepotPath)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Hash)));
        }

        private void RefreshValidityAndTooltip(object sender, RoutedEventArgs e)
        {
            if (_settingsManager?.UseValidatingEditor != true || RedRef?.DepotPath == ResourcePath.Empty ||
                RedRef?.DepotPath.GetResolvedText() is not string filePath || filePath.Trim().IsNullOrEmpty())
            {
                SetCurrentValue(ScopeProperty, FileScope.Unknown);
                SetCurrentValue(TextBoxToolTipProperty, "Not validating this resource path");
                return;
            }

            var hasArchiveXlMatch = false;
            if (ArchiveXlHelper.HasSubstitution(filePath))
            {
                if (ArchiveXlHelper.GetValuesForInvalidSubstitution(filePath) is string invalidSubstitutions)
                {
                    SetCurrentValue(ScopeProperty, FileScope.InvalidSubstitution);
                    SetCurrentValue(TextBoxToolTipProperty, invalidSubstitutions);
                    return;
                }

                if (App.Helpers.ArchiveXlHelper.GetFirstExistingPath(filePath) is null)
                {
                    SetCurrentValue(ScopeProperty, FileScope.NotFoundWarning);
                    SetCurrentValue(TextBoxToolTipProperty, "Substitution couldn't be resolved (ignore this if everything works)");
                    return;
                }

                hasArchiveXlMatch = true;
            }

            if (hasArchiveXlMatch || _archiveManager?.GetGameFile(RedRef.DepotPath, false, true) is not null)
            {
                SetCurrentValue(ScopeProperty, FileScope.GameOrMod);
                SetCurrentValue(TextBoxToolTipProperty, "Valid depot path (game or same mod)");
                return;
            }

            if (_archiveManager?.GetGameFile(RedRef.DepotPath, true, false) is not null)
            {
                SetCurrentValue(ScopeProperty, FileScope.OtherMod);
                SetCurrentValue(TextBoxToolTipProperty, "Valid depot path (another mod)");
                return;
            }

            SetCurrentValue(ScopeProperty, FileScope.NotFound);
            SetCurrentValue(TextBoxToolTipProperty, "Invalid depot path (not found)");
        }

        private object _updateSender;

        public void TrimmingTextbox_OnTextUpdate(object sender, EventArgs e)
        {
            _updateSender = sender;
            _updateTimer.Stop();
            _updateTimer.Start();
        }


        private void OnUpdateTimerTick(object sender, EventArgs e)
        {
            _updateTimer.Stop();
            RefreshValidityAndTooltip(_updateSender, new RoutedEventArgs());
        }

        public void TrimmingTextbox_OnKeyUp(object sender, EventArgs e)
        {
            if (e is not KeyEventArgs { Key: Key.Enter or Key.Tab })
            {
                return;
            }

            RefreshValidityAndTooltip(sender, new RoutedEventArgs());
        }
    }
}
