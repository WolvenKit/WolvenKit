using System;
using System.Globalization;
using System.IO;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core.Exceptions;
using WolvenKit.ViewModels.Validators;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class AddArchiveXlFilesDialog : IViewFor<AddArchiveXlFilesDialogViewModel>
    {
        public AddArchiveXlFilesDialog(bool isControlFiles)
        {
            InitializeComponent();

            ViewModel = new AddArchiveXlFilesDialogViewModel(isControlFiles);
            DataContext = ViewModel;

            Owner = Application.Current.MainWindow;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.DepotPath,
                        x => x.DepotPathTextBox.Text)
                    .DisposeWith(disposables);

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


        private readonly DepotPathValidationRule _depotPathValidationRule = DepotPathValidationRule.Instance;
        private void DepotPath_OnKeyUp(object sender, KeyEventArgs e)
        {
            if (DepotPathTextBox.GetBindingExpression(TextBox.TextProperty) is not BindingExpression bind)
            {
                return;
            }

            var result = _depotPathValidationRule.Validate(DepotPathTextBox.Text, CultureInfo.CurrentCulture);
            if (!result.IsValid)
            {
                Validation.MarkInvalid(bind,
                    new ValidationError(_depotPathValidationRule, bind, result.ErrorContent, null));
            }
            else
            {
                Validation.ClearInvalid(bind);
            }

            SetButtonStatesFromControlValidity(); 
        }

        private readonly ItemNameValidationRule _itemRule = new();
        private void ItemName_OnKeyUp(object sender, KeyEventArgs e)
        {
            var bindingExpression = ItemNameTextBox.GetBindingExpression(TextBox.TextProperty);
            if (bindingExpression == null)
            {
                return;
            }

            var validationResult = _itemRule.Validate(ItemNameTextBox.Text, CultureInfo.CurrentCulture);
            if (!validationResult.IsValid)
            {
                Validation.MarkInvalid(bindingExpression,
                    new ValidationError(_itemRule, bindingExpression, validationResult.ErrorContent, null));
            }
            else
            {
                Validation.ClearInvalid(bindingExpression);
            }

            SetButtonStatesFromControlValidity(); 
        }

        private static bool HasValidationError(Control control) =>
            control.GetBindingExpression(TextBox.TextProperty) is not null && Validation.GetHasError(control);

        private void SetButtonStatesFromControlValidity()
        {
            if (ViewModel is null)
            {
                return;
            }

            ViewModel.IsValid = !HasValidationError(ItemNameTextBox) &&
                                !HasValidationError(DepotPathTextBox);
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

        // Custom filter implementation as klepped from https://stackoverflow.com/a/48211059, thank you Oceans
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
            var combobox = (ComboBox)sender;
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
    }
}