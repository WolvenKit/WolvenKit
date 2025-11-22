using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using ReactiveUI;
using Syncfusion.Windows.Controls.Input;
using WolvenKit.App;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.ViewModels.Validators;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class AddArchiveXlFilesDialog : IViewFor<AddArchiveXlFilesDialogViewModel>
    {
        public AddArchiveXlFilesDialog(Cp77Project currentProject)
        {
            InitializeComponent();

            ViewModel = new AddArchiveXlFilesDialogViewModel(currentProject);
            DataContext = ViewModel;

            Owner = Application.Current.MainWindow;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.ItemName,
                        x => x.ItemNameTextBox.Text)
                    .DisposeWith(disposables);

                ItemSubtypeControl.SetCurrentValue(IsEnabledProperty, false);
                EquipmentExControl.SetCurrentValue(IsEnabledProperty, false);
            });
        }

        public AddArchiveXlFilesDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (AddArchiveXlFilesDialogViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        // Enable/Disable subtype and EqEx type based on selected item type
        private void ItemType_OnChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ViewModel is null || sender is not ComboBox { SelectedItem: EquipmentItemSlot slot })
            {
                ItemSubtypeControl.SetCurrentValue(IsEnabledProperty, false);
                EquipmentExControl.SetCurrentValue(IsEnabledProperty, false);
                return;
            }

            ItemSubtypeControl.SetCurrentValue(IsEnabledProperty, slot != EquipmentItemSlot.None);
            EquipmentExControl.SetCurrentValue(IsEnabledProperty, slot != EquipmentItemSlot.None);

            ViewModel.SetItemSlot(slot);
        }

        // Custom filter implementation as klepped from https://stackoverflow.com/a/48211059, thanks Oceans
        private void ComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            var combobox = (ComboBox)sender;
            if (combobox.Template.FindName("PART_EditableTextBox", combobox) is not TextBox ctb
                || Keyboard.Modifiers.HasFlag(ModifierKeys.Shift)
                || Keyboard.Modifiers.HasFlag(ModifierKeys.Control)
                || Keyboard.Modifiers.HasFlag(ModifierKeys.Alt))
            {
                return;
            }

            var caretPos = ctb.CaretIndex;
            combobox.IsDropDownOpen = true;

            var itemsViewOriginal = (CollectionView)CollectionViewSource.GetDefaultView(combobox.Items);

            itemsViewOriginal.Filter = o =>
                string.IsNullOrEmpty(combobox.Text) || o.ToString()?.StartsWith(combobox.Text, true, null) == true;

            itemsViewOriginal.Refresh();
            ctb.CaretIndex = caretPos;
        }

        private void Combobox_FocusGained(object sender, RoutedEventArgs e) =>
            ((ComboBox)sender).SetCurrentValue(ComboBox.IsDropDownOpenProperty, true);

        private void Combobox_OnClick(object sender, RoutedEventArgs e)
        {
            if (sender is not ComboBox combobox || combobox.IsDropDownOpen)
            {
                return;
            }
            combobox.SetCurrentValue(ComboBox.IsDropDownOpenProperty, !combobox.IsDropDownOpen);
        }

        private void GarmentSupportTag_OnChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is not ComboBox comboBox || ViewModel is not AddArchiveXlFilesDialogViewModel model)
            {
                return;
            }

            if (comboBox.SelectedItem is null || !Enum.TryParse<GarmentSupportTags>(comboBox.SelectedItem.ToString(), out var tag))
            {
                model.GarmentSupportTag = GarmentSupportTags.None;
                return;
            }

            model.GarmentSupportTag = tag;
        }


        private void EquipmentExSlot_OnChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is not ComboBox comboBox || ViewModel is not AddArchiveXlFilesDialogViewModel model)
            {
                return;
            }

            if (comboBox.SelectedItem is null || !Enum.TryParse<EquipmentExSlot>(comboBox.SelectedItem.ToString(), out var tag))
            {
                model.EqExSlot = EquipmentExSlot.None;
                return;
            }

            model.EqExSlot = tag;
        }

        private void SubSlot_OnChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is not ComboBox comboBox || ViewModel is not AddArchiveXlFilesDialogViewModel model)
            {
                return;
            }

            if (comboBox.SelectedItem is null || !Enum.TryParse<EquipmentItemSubSlot>(comboBox.SelectedItem.ToString(), out var tag))
            {
                model.SubSlot = EquipmentItemSubSlot.None;
                return;
            }

            model.SubSlot = tag;
        }

        private void ItemVariants_FocusLost(object sender, RoutedEventArgs e)
        {
            if (sender is not SfTextBoxExt textBox || ViewModel is not AddArchiveXlFilesDialogViewModel model)
            {
                return;
            }

            model.Variants =
                [.. textBox.Text.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)];
        }

        private void HidingTags_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ViewModel is not { } vm)
            {
                return;
            }

            var hidingTags = vm.HidingTags ?? [];

            hidingTags.AddRange(e.AddedItems.OfType<ArchiveXlHidingTags>());

            foreach (var removedItem in e.RemovedItems.OfType<ArchiveXlHidingTags>())
            {
                hidingTags.Remove(removedItem);
            }

            vm.HidingTags = hidingTags.Distinct().ToList();
        }

        private void OnHelpButtonClicked(object sender, RoutedEventArgs e)
        {
            var ps = new ProcessStartInfo(WikiLinks.AddingNewItems) { UseShellExecute = true, Verb = "open" };
            Process.Start(ps);
        }

        private void SecondaryItemVariants_FocusLost(object sender, RoutedEventArgs e)
        {
            if (sender is not SfTextBoxExt textBox || ViewModel is not AddArchiveXlFilesDialogViewModel model)
            {
                return;
            }

            model.SecondaryVariants =
                [.. textBox.Text.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)];
        }

        private void ExistingFiles_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ViewModel is not { } vm)
            {
                return;
            }

            var existingFiles = vm.ExistingFiles ?? [];

            existingFiles.AddRange(e.AddedItems.OfType<string>());

            foreach (var removedItem in e.RemovedItems.OfType<string>())
            {
                existingFiles.Remove(removedItem);
            }

            vm.ExistingFiles = existingFiles.Distinct().ToList();
        }

        private void PrimaryMeshPathDropdown_OnChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ViewModel is null || sender is not ComboBox { SelectedItem: string meshPath })
            {
                return;
            }

            ViewModel.PrimaryAppearanceMesh = meshPath;
        }

        private void SecondaryMeshPathDropdown_OnChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ViewModel is null || sender is not ComboBox { SelectedItem: string meshPath })
            {
                return;
            }

            ViewModel.SecondaryAppearanceMesh = meshPath;
        }
    }
}
