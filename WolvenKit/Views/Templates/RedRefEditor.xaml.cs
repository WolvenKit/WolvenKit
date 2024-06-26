using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DynamicData.Kernel;
using HandyControl.Tools.Extension;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
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

        public IEnumerable<InternalEnums.EImportFlags> EnumValues => Enum.GetValues(typeof(InternalEnums.EImportFlags)).Cast<InternalEnums.EImportFlags>();


        public RedRefEditor()
        {
            InitializeComponent();
            _settingsManager = Locator.Current.GetService<ISettingsManager>();
            _archiveManager = Locator.Current.GetService<IAppArchiveManager>();

            FlagsComboBox.SelectionChanged += FlagsComboBox_OnSelectionChanged;
        }


        public IRedRef RedRef
        {
            get => (IRedRef)GetValue(RedRefProperty);
            set => SetValue(RedRefProperty, value);
        }
        public static readonly DependencyProperty RedRefProperty = DependencyProperty.Register(
            nameof(RedRef), typeof(IRedRef), typeof(RedRefEditor), new PropertyMetadata(default(IRedRef), OnRedRefChanged));

        private static void OnRedRefChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not RedRefEditor { RedRef: not null } view)
            {
                return;
            }

            view.OnPropertyChanged(nameof(DepotPath));
            view.OnPropertyChanged(nameof(Hash));
        }

        public FileScope Scope
        {
            get => (FileScope)GetValue(ScopeProperty);
            set => SetValue(ScopeProperty, value);
        }

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
            get => RedRef.DepotPath;
            set
            {
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
                if (_settingsManager.ShowResourcePathAsHex)
                {
                    return RedRef.DepotPath.GetRedHash().ToString("X");
                }
                else
                {
                    return RedRef.DepotPath.GetRedHash().ToString();
                }
            }
            set
            {
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
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                var text = (string)e.DataObject.GetData(typeof(string));
                var full = HashBox.Text.Remove(HashBox.SelectionStart, HashBox.SelectionLength).Insert(HashBox.CaretIndex, text!);

                if (_settingsManager.ShowResourcePathAsHex)
                {
                    if (!ulong.TryParse(full, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out _))
                    {
                        e.CancelCommand();
                    }
                }
                else
                {
                    if (!ulong.TryParse(full, out _))
                    {
                        e.CancelCommand();
                    }
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        private void FlagsComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox { SelectedItem: InternalEnums.EImportFlags flags })
            {
                if (RedRef != null && RedRef.Flags != flags)
                {
                    SetCurrentValue(RedRefProperty, (IRedRef)RedTypeManager.CreateRedType(RedRef.RedType, RedRef.DepotPath, flags));
                }
            }
        }

        public static readonly DependencyProperty TextBoxToolTipProperty = DependencyProperty.Register(
            nameof(TextBoxToolTip), typeof(string), typeof(RedRefEditor), new PropertyMetadata(default(string)));

        public string TextBoxToolTip
        {
            get => TextBoxToolTip;
            set => SetValue(TextBoxToolTipProperty, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void RefreshValidityAndTooltip(object sender, RoutedEventArgs e)
        {
            if (_settingsManager?.UseValidatingEditor != true || RedRef?.DepotPath == ResourcePath.Empty ||
                RedRef?.ToString() is not string filePath ||
                filePath.Trim().IsNullOrEmpty())
            {
                SetCurrentValue(ScopeProperty, FileScope.Unknown);
                SetCurrentValue(TextBoxToolTipProperty, "Not validating this resource path");
                return;
            }


            if (ArchiveXlHelper.GetValuesForInvalidSubstitution(filePath) is string invalidSubstitutions)
            {
                SetCurrentValue(ScopeProperty, FileScope.InvalidSubstitution);
                SetCurrentValue(TextBoxToolTipProperty, invalidSubstitutions);
                return;
            }


            if (!ArchiveXlHelper.HasSubstitution(filePath) &&
                _archiveManager?.GetGameFile(filePath, false, true) is not null)
            {
                SetCurrentValue(ScopeProperty, FileScope.GameOrMod);
                SetCurrentValue(TextBoxToolTipProperty, "Valid depot path (game or mod)");
                return;
            }

            if (!ArchiveXlHelper.HasSubstitution(filePath) &&
                App.Helpers.ArchiveXlHelper.GetFirstExistingPath(filePath) is null)
            {
                SetCurrentValue(ScopeProperty, FileScope.NotFoundWarning);
                SetCurrentValue(TextBoxToolTipProperty, "Substitution couldn't be resolved (ignore this if everything works)");
                return;
            }

            if (_archiveManager?.GetGameFile(filePath, true, false) is not null)
            {
                SetCurrentValue(ScopeProperty, FileScope.OtherMod);
                SetCurrentValue(TextBoxToolTipProperty, "Valid depot path (another mod)");
                return;
            }
            

            SetCurrentValue(ScopeProperty, FileScope.NotFound);
            SetCurrentValue(TextBoxToolTipProperty, "Invalid depot path (not found)");
        }
    }
}
