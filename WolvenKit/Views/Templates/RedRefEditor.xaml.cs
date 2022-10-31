using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Templates;
using YamlDotNet.Core.Tokens;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedRefEditor.xaml
    /// </summary>
    public partial class RedRefEditor : INotifyPropertyChanged
    {
        public IEnumerable<InternalEnums.EImportFlags> EnumValues => Enum.GetValues(typeof(InternalEnums.EImportFlags)).Cast<InternalEnums.EImportFlags>();

        public RedRefEditor()
        {
            InitializeComponent();

            DepotPathEditor.PropertyChanged += DepotPathEditor_OnPropertyChanged;
            FlagsComboBox.SelectionChanged += FlagsComboBox_OnSelectionChanged;
        }


        public IRedRef RedRef
        {
            get => (IRedRef)GetValue(RedRefProperty);
            set => SetValue(RedRefProperty, value);
        }
        public static readonly DependencyProperty RedRefProperty = DependencyProperty.Register(
            nameof(RedRef), typeof(IRedRef), typeof(RedRefEditor), new PropertyMetadata(default(IRedRef)));


        private void DepotPathEditor_OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender is RedCNameEditor depotPathEditor)
            {
                if (RedRef != null && RedRef.DepotPath != depotPathEditor.RedString)
                {
                    SetCurrentValue(RedRefProperty, (IRedRef)RedTypeManager.CreateRedType(RedRef.RedType, depotPathEditor.RedString, RedRef.Flags));
                }
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

        
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
