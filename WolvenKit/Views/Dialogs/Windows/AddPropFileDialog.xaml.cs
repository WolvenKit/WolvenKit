using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using ReactiveUI;
using Syncfusion.Windows.Controls.Input;
using WolvenKit.App;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core;
using WolvenKit.ViewModels.Validators;
using WolvenKit.Views.Templates;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class AddPropFileDialog : IViewFor<AddPropFileDialogViewModel>
    {
        private static string s_lastParentFolder = string.Empty;
        private static string s_lastMeshFile1 = string.Empty;
        private static string s_lastMeshFile2 = string.Empty;
        private static string s_lastMeshFile3 = string.Empty;
        private static string s_lastMeshFile4 = string.Empty;
        private static string s_lastMeshAppearances = string.Empty;
        private static string s_lastPropName = string.Empty;
        private static bool s_lastMoveMeshFiles = false;
        private static bool s_lastReadAppearancesFromMeshFile = false;

        public AddPropFileDialog(Cp77Project project)
        {
            InitializeComponent();

            ViewModel = new AddPropFileDialogViewModel(project);
            DataContext = ViewModel;

            Owner = Application.Current.MainWindow;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.PropName,
                        x => x.PropNameTextBox.Text)
                    .DisposeWith(disposables);

                // parent folder
                this.Bind(ViewModel,
                        x => x.ParentFolder,
                        x => x.ParentFolderDropdownMenu.dropdown.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.ParentFolder,
                        x => x.ParentFolderBox.Text)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.MeshFile1,
                        x => x.Mesh1DropdownMenu.dropdown.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.MeshFile1UseAppearances,
                        x => x.MeshFile1UseAppearancesCheckbox.IsChecked)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.ProjectFolders,
                        x => x.ParentFolderDropdownMenu.Options)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.ProjectMeshes,
                        x => x.Mesh1DropdownMenu.Options)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.ProjectMeshes,
                        x => x.Mesh2DropdownMenu.Options)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.ProjectMeshes,
                        x => x.Mesh3DropdownMenu.Options)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.ProjectMeshes,
                        x => x.Mesh4DropdownMenu.Options)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.MeshFile2,
                        x => x.Mesh2DropdownMenu.dropdown.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.MeshFile2UseAppearances,
                        x => x.MeshFile2UseAppearancesCheckbox.IsChecked)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.MeshFile3,
                        x => x.Mesh3DropdownMenu.dropdown.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.MeshFile3UseAppearances,
                        x => x.MeshFile3UseAppearancesCheckbox.IsChecked)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.MeshFile4,
                        x => x.Mesh4DropdownMenu.dropdown.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.MeshFile4UseAppearances,
                        x => x.MeshFile4UseAppearancesCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.MoveMeshesToFolder,
                        x => x.MoveMeshesToFolderCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.ReadAppearancesFromMesh,
                        x => x.ReadAppearancesFromMeshCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.CleanupInvalidEntries,
                        x => x.CleanupInvalidEntriesCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.RememberSelection,
                        x => x.RememberValuesCheckbox.IsChecked)
                    .DisposeWith(disposables);

                Mesh1DropdownMenu.dropdown.SelectionChanged += Mesh1SelectionChanged;
                disposables.Add(Disposable.Create(() =>
                    Mesh1DropdownMenu.dropdown.SelectionChanged -= Mesh1SelectionChanged));

                Mesh2DropdownMenu.dropdown.SelectionChanged += Mesh2SelectionChanged;
                disposables.Add(Disposable.Create(() =>
                    Mesh2DropdownMenu.dropdown.SelectionChanged -= Mesh2SelectionChanged));

                Mesh3DropdownMenu.dropdown.SelectionChanged += Mesh3SelectionChanged;
                disposables.Add(Disposable.Create(() =>
                    Mesh3DropdownMenu.dropdown.SelectionChanged -= Mesh3SelectionChanged));

                Mesh4DropdownMenu.dropdown.SelectionChanged += Mesh4SelectionChanged;
                disposables.Add(Disposable.Create(() =>
                    Mesh4DropdownMenu.dropdown.SelectionChanged -= Mesh4SelectionChanged));

                ParentFolderDropdownMenu.dropdown.SelectionChanged += ParentFolderSelectionChanged;
                disposables.Add(Disposable.Create(() =>
                    ParentFolderDropdownMenu.dropdown.SelectionChanged -= ParentFolderSelectionChanged));

                MeshFile1UseAppearancesCheckbox.SetCurrentValue(IsEnabledProperty, false);
                MeshFile2UseAppearancesCheckbox.SetCurrentValue(IsEnabledProperty, false);
                MeshFile3UseAppearancesCheckbox.SetCurrentValue(IsEnabledProperty, false);
                MeshFile4UseAppearancesCheckbox.SetCurrentValue(IsEnabledProperty, false);
                MoveMeshesToFolderCheckbox.SetCurrentValue(IsEnabledProperty, false);

                LoadDefaultValues();
            });
        }


        private void ParentFolderSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is not ComboBox comboBox)
            {
                return;
            }

            ParentFolderBox.SetCurrentValue(TextBox.TextProperty, comboBox.Text);

            if (string.IsNullOrEmpty(Mesh1TextBox.Text))
            {
                Mesh1DropdownMenu.SetCurrentValue(Editors.FilterableDropdownMenu.FilterTextProperty, comboBox.Text);
            }
        }

        private void Mesh1SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newValue = string.Empty;
            if (e.AddedItems.Count > 0 && e.AddedItems[0] is KeyValuePair<string, string> kvp)
            {
                newValue = kvp.Value;
            }

            SetCheckboxStatus(Mesh1TextBox, MeshFile1UseAppearancesCheckbox, newValue);
        }

        private void Mesh2SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newValue = string.Empty;
            if (e.AddedItems.Count > 0 && e.AddedItems[0] is KeyValuePair<string, string> kvp)
            {
                newValue = kvp.Value;
            }

            SetCheckboxStatus(Mesh2TextBox, MeshFile2UseAppearancesCheckbox, newValue);
        }

        private void Mesh3SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newValue = string.Empty;
            if (e.AddedItems.Count > 0 && e.AddedItems[0] is KeyValuePair<string, string> kvp)
            {
                newValue = kvp.Value;
            }

            SetCheckboxStatus(Mesh3TextBox, MeshFile3UseAppearancesCheckbox, newValue);
        }

        private void Mesh4SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newValue = string.Empty;
            if (e.AddedItems.Count > 0 && e.AddedItems[0] is KeyValuePair<string, string> kvp)
            {
                newValue = kvp.Value;
            }

            SetCheckboxStatus(Mesh4TextBox, MeshFile4UseAppearancesCheckbox, newValue);
        }

        private void SetCheckboxStatus(TextBox textBox, CheckBox useAppearancesCheckbox, string newValue)
        {
            textBox.SetCurrentValue(TextBox.TextProperty, newValue);
            var isEnabled = !string.IsNullOrEmpty(newValue);
            useAppearancesCheckbox.SetCurrentValue(IsEnabledProperty, isEnabled);

            // don't disable it though, other mesh file paths might be non-empty
            if (isEnabled)
            {
                MoveMeshesToFolderCheckbox.SetCurrentValue(IsEnabledProperty, true);
            }
        }

        public AddPropFileDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (AddPropFileDialogViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
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
            var combobox = (ComboBox)sender;
            combobox.SetCurrentValue(ComboBox.IsDropDownOpenProperty, !combobox.IsDropDownOpen);
        }


        private void Appearances_FocusLost(object sender, RoutedEventArgs e)
        {
            if (sender is not SfTextBoxExt textBox || ViewModel is not AddPropFileDialogViewModel model)
            {
                return;
            }

            model.Appearances =
                [.. textBox.Text.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)];

            if (model.Appearances.Count > 0 && !model.HasMoveMeshBeenTouched)
            {
                model.MeshFile1UseAppearances = true;
            }
        }

        private void OnHelpButtonClicked(object sender, RoutedEventArgs e)
        {
            var ps = new ProcessStartInfo(WikiLinks.Props) { UseShellExecute = true, Verb = "open" };
            Process.Start(ps);
        }


        private void OnMeshCheckboxChecked(object sender, RoutedEventArgs e)
        {
            if (ViewModel is null)
            {
                return;
            }

            ViewModel.HasMoveMeshBeenTouched = true;
        }

        // Custom event handler for keyDown because why not
        private void OnAppearancesCheckboxKeyDown(object sender, KeyEventArgs e)
        {
            if (sender is not TextBox textbox || e.Key != Key.V ||
                !Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
            {
                return;
            }

            e.Handled = true;
            var clipboardText = Clipboard.GetText().Replace("\n", ", ").Replace("\r", ", ");
            textbox.Text = clipboardText;
        }

        private void OnDialogueFinish(object sender, RoutedEventArgs e)
        {
            if (ViewModel is null || !ViewModel.RememberSelection)
            {
                s_lastMeshFile1 = string.Empty;
                s_lastMeshFile2 = string.Empty;
                s_lastMeshFile3 = string.Empty;
                s_lastMeshFile4 = string.Empty;
                s_lastParentFolder = string.Empty;
                s_lastMeshAppearances = string.Empty;
                s_lastPropName = string.Empty;
                s_lastMoveMeshFiles = false;
                s_lastReadAppearancesFromMeshFile = false;
                return;
            }

            if (ViewModel.MoveMeshesToFolder && !string.IsNullOrEmpty(ViewModel.MeshFile1) &&
                Path.GetDirectoryName(ViewModel.MeshFile1) is string parentDir)
            {
                s_lastMeshFile1 = parentDir;
            }
            else
            {
                s_lastMeshFile1 = ViewModel.MeshFile1;
            }

            s_lastMeshFile2 = ViewModel.MeshFile2;
            s_lastMeshFile3 = ViewModel.MeshFile3;
            s_lastMeshFile4 = ViewModel.MeshFile4;
            s_lastMoveMeshFiles = ViewModel.MoveMeshesToFolder;
            s_lastReadAppearancesFromMeshFile = ViewModel.ReadAppearancesFromMesh;
            s_lastPropName = ViewModel.PropName;

            if (!ViewModel.ProjectFolders.ContainsKey(ViewModel.ParentFolder) &&
                Path.GetDirectoryName(ViewModel.ParentFolder) is string s)
            {
                s_lastParentFolder = s;
            }
            else
            {
                s_lastParentFolder = ViewModel.ParentFolder;
            }

            s_lastMeshAppearances = string.Join(",", ViewModel.Appearances ?? []);
        }

        private void LoadDefaultValues()
        {
            if (ViewModel is null)
            {
                return;
            }

            if (!string.IsNullOrEmpty(s_lastParentFolder))
            {
                ParentFolderDropdownMenu.SetCurrentValue(Editors.FilterableDropdownMenu.FilterTextProperty,
                    s_lastParentFolder);
            }

            if (!string.IsNullOrEmpty(s_lastMeshFile1))
            {
                Mesh1DropdownMenu.SetCurrentValue(Editors.FilterableDropdownMenu.FilterTextProperty, s_lastMeshFile1);
            }

            if (!string.IsNullOrEmpty(s_lastMeshFile2))
            {
                Mesh2DropdownMenu.SetCurrentValue(Editors.FilterableDropdownMenu.FilterTextProperty, s_lastMeshFile2);
            }

            if (!string.IsNullOrEmpty(s_lastMeshFile3))
            {
                Mesh3DropdownMenu.SetCurrentValue(Editors.FilterableDropdownMenu.FilterTextProperty, s_lastMeshFile3);
            }

            if (!string.IsNullOrEmpty(s_lastMeshFile4))
            {
                Mesh4DropdownMenu.SetCurrentValue(Editors.FilterableDropdownMenu.FilterTextProperty, s_lastMeshFile4);
            }

            if (!string.IsNullOrEmpty(s_lastMeshAppearances))
            {
                AppearancesTextBox.SetCurrentValue(TextBox.TextProperty, s_lastMeshAppearances);

                // due to textbox's binding to a list, this doesn't populate properly
                ViewModel.Appearances ??= [];
                ViewModel.Appearances.Clear();
                ViewModel.Appearances.AddRange(s_lastMeshAppearances.Split(",",
                    StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));
            }

            if (!string.IsNullOrEmpty(s_lastPropName))
            {
                PropNameTextBox.SetCurrentValue(TextBox.TextProperty, s_lastPropName);
            }

            if (!string.IsNullOrEmpty(s_lastPropName))
            {
                PropNameTextBox.SetCurrentValue(TextBox.TextProperty, s_lastPropName);
            }

            MoveMeshesToFolderCheckbox.SetCurrentValue(ToggleButton.IsCheckedProperty, s_lastMoveMeshFiles);
            ReadAppearancesFromMeshCheckbox.SetCurrentValue(ToggleButton.IsCheckedProperty,
                s_lastReadAppearancesFromMeshFile);

            RememberValuesCheckbox.SetCurrentValue(ToggleButton.IsCheckedProperty, true);
        }

        private void OnReadAppearancesCheckboxChecked(object sender, RoutedEventArgs e)
        {
            if (sender is not CheckBox box)
            {
                return;
            }

            // enable appearance textbox status based on checkbox
            AppearancesTextBox.SetCurrentValue(IsEnabledProperty, box.IsChecked != true);
        }
    }
}
