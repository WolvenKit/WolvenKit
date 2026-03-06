using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using ReactiveUI;
using Syncfusion.Windows.Controls.Input;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core;

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
        private static bool s_lastReadAppearancesFromMesh1 = false;
        private static bool s_lastReadAppearancesFromMesh2 = false;
        private static bool s_lastReadAppearancesFromMesh3 = false;
        private static bool s_lastReadAppearancesFromMesh4 = false;

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
                        x => x.MeshFile1,
                        x => x.Mesh1DropdownMenu.dropdown.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.MeshFile1UseAppearances,
                        x => x.MeshFile1UseAppearancesCheckbox.IsChecked)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.MeshFile1ReadFromMesh,
                        x => x.MeshFile1ReadAppearancesCheckbox.IsChecked)
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
                        x => x.MeshFile2ReadFromMesh,
                        x => x.MeshFile2ReadAppearancesCheckbox.IsChecked)
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
                        x => x.MeshFile3ReadFromMesh,
                        x => x.MeshFile3ReadAppearancesCheckbox.IsChecked)
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
                        x => x.MeshFile4ReadFromMesh,
                        x => x.MeshFile4ReadAppearancesCheckbox.IsChecked)
                    .DisposeWith(disposables);


                this.Bind(ViewModel,
                        x => x.MoveMeshesToFolder,
                        x => x.MoveMeshesToFolderCheckbox.IsChecked)
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

                ParentFolderBox.LostFocus += ParentFolder_LostFocus;

                MeshFile1UseAppearancesCheckbox.SetCurrentValue(IsEnabledProperty, false);
                MeshFile2UseAppearancesCheckbox.SetCurrentValue(IsEnabledProperty, false);
                MeshFile3UseAppearancesCheckbox.SetCurrentValue(IsEnabledProperty, false);
                MeshFile4UseAppearancesCheckbox.SetCurrentValue(IsEnabledProperty, false);
                MoveMeshesToFolderCheckbox.SetCurrentValue(IsEnabledProperty, false);

                AppearancesTextBox.LostFocus += AppearancesTextBox_FocusLost;

                LoadDefaultValues();
            });
        }

        private void ParentFolder_LostFocus(object sender, RoutedEventArgs e) => SetMeshSelectionFilters();

        private void AppearancesTextBox_FocusLost(object sender, RoutedEventArgs e) =>
            SetCheckboxStatusWriteMeshAppearances((ViewModel?.Appearances ?? []).Count > 0);


        private void ParentFolderSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is not ComboBox comboBox)
            {
                return;
            }

            ParentFolderBox.SetCurrentValue(TextBox.TextProperty, comboBox.Text);

            Task.Run(() =>
            {
                // wait for binding value to update
                Task.Delay(100).Wait();
                Dispatcher.Invoke(SetMeshSelectionFilters);
            });
        }

        /// <summary>
        /// Set filters for mesh selection dropdowns to parent folder
        /// </summary>
        private void SetMeshSelectionFilters()
        {
            if (ViewModel is null || string.IsNullOrEmpty(ViewModel.ParentFolder))
            {
                return;
            }

            if (string.IsNullOrEmpty(ViewModel.MeshFile1))
            {
                Mesh1DropdownMenu.SetCurrentValue(Editors.FilterableDropdownMenu.FilterTextProperty,
                    ViewModel.ParentFolder);
            }

            if (string.IsNullOrEmpty(ViewModel.MeshFile2))
            {
                Mesh2DropdownMenu.SetCurrentValue(Editors.FilterableDropdownMenu.FilterTextProperty,
                    ViewModel.ParentFolder);
            }

            if (string.IsNullOrEmpty(ViewModel.MeshFile3))
            {
                Mesh3DropdownMenu.SetCurrentValue(Editors.FilterableDropdownMenu.FilterTextProperty,
                    ViewModel.ParentFolder);
            }

            if (string.IsNullOrEmpty(ViewModel.MeshFile4))
            {
                Mesh4DropdownMenu.SetCurrentValue(Editors.FilterableDropdownMenu.FilterTextProperty,
                    ViewModel.ParentFolder);
            }
        }

        private void Mesh1SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newValue = string.Empty;
            if (e.AddedItems.Count > 0 && e.AddedItems[0] is KeyValuePair<string, string> kvp)
            {
                newValue = kvp.Value;
            }

            SetWriteAppearancesCheckboxStatus(Mesh1TextBox, MeshFile1UseAppearancesCheckbox, newValue);
        }

        private void Mesh2SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newValue = string.Empty;
            if (e.AddedItems.Count > 0 && e.AddedItems[0] is KeyValuePair<string, string> kvp)
            {
                newValue = kvp.Value;
            }

            SetWriteAppearancesCheckboxStatus(Mesh2TextBox, MeshFile2UseAppearancesCheckbox, newValue);
        }

        private void Mesh3SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newValue = string.Empty;
            if (e.AddedItems.Count > 0 && e.AddedItems[0] is KeyValuePair<string, string> kvp)
            {
                newValue = kvp.Value;
            }

            SetWriteAppearancesCheckboxStatus(Mesh3TextBox, MeshFile3UseAppearancesCheckbox, newValue);
        }

        private void Mesh4SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newValue = string.Empty;
            if (e.AddedItems.Count > 0 && e.AddedItems[0] is KeyValuePair<string, string> kvp)
            {
                newValue = kvp.Value;
            }

            SetWriteAppearancesCheckboxStatus(Mesh4TextBox, MeshFile4UseAppearancesCheckbox, newValue);
        }

        private void SetWriteAppearancesCheckboxStatus(TextBox textBox, CheckBox useAppearancesCheckbox,
            string newValue)
        {
            textBox.SetCurrentValue(TextBox.TextProperty, newValue);
            var isEnabled = !string.IsNullOrEmpty(newValue);
            useAppearancesCheckbox.SetCurrentValue(IsEnabledProperty, isEnabled);

            if (!isEnabled)
            {
                // do not disable based on a single path - others might be set
                return;
            }

            // if it's set, we enable the "move to folder" checkbox and disable the "read from mesh file" ones
            MoveMeshesToFolderCheckbox.SetCurrentValue(IsEnabledProperty, true);
            SetCheckboxStatusWriteMeshAppearances(false);
        }

        public AddPropFileDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (AddPropFileDialogViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
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
                s_lastReadAppearancesFromMesh1 = false;
                s_lastReadAppearancesFromMesh2 = false;
                s_lastReadAppearancesFromMesh3 = false;
                s_lastReadAppearancesFromMesh4 = false;
                return;
            }

            s_lastMeshFile1 = ViewModel.MeshFile1;
            s_lastMeshFile2 = ViewModel.MeshFile2;
            s_lastMeshFile3 = ViewModel.MeshFile3;
            s_lastMeshFile4 = ViewModel.MeshFile4;
            s_lastMoveMeshFiles = ViewModel.MoveMeshesToFolder;

            s_lastReadAppearancesFromMesh1 = ViewModel.MeshFile1ReadFromMesh;
            s_lastReadAppearancesFromMesh2 = ViewModel.MeshFile2ReadFromMesh;
            s_lastReadAppearancesFromMesh3 = ViewModel.MeshFile3ReadFromMesh;
            s_lastReadAppearancesFromMesh4 = ViewModel.MeshFile4ReadFromMesh;

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
                if (Path.GetDirectoryName(s_lastMeshFile1) is string parent)
                {
                    Mesh1DropdownMenu.SetCurrentValue(Editors.FilterableDropdownMenu.FilterTextProperty, parent);
                }

                Mesh1TextBox.SetCurrentValue(TextBox.TextProperty, s_lastMeshFile1);
            }

            if (!string.IsNullOrEmpty(s_lastMeshFile2))
            {
                if (Path.GetDirectoryName(s_lastMeshFile2) is string parent)
                {
                    Mesh2DropdownMenu.SetCurrentValue(Editors.FilterableDropdownMenu.FilterTextProperty, parent);
                }

                Mesh2TextBox.SetCurrentValue(TextBox.TextProperty, s_lastMeshFile2);
            }

            if (!string.IsNullOrEmpty(s_lastMeshFile3))
            {
                if (Path.GetDirectoryName(s_lastMeshFile3) is string parent)
                {
                    Mesh3DropdownMenu.SetCurrentValue(Editors.FilterableDropdownMenu.FilterTextProperty, parent);
                }

                Mesh3TextBox.SetCurrentValue(TextBox.TextProperty, s_lastMeshFile3);
            }

            if (!string.IsNullOrEmpty(s_lastMeshFile4))
            {
                if (Path.GetDirectoryName(s_lastMeshFile4) is string parent)
                {
                    Mesh4DropdownMenu.SetCurrentValue(Editors.FilterableDropdownMenu.FilterTextProperty, parent);
                }

                Mesh4TextBox.SetCurrentValue(TextBox.TextProperty, s_lastMeshFile4);
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

            MeshFile1ReadAppearancesCheckbox.SetCurrentValue(ToggleButton.IsCheckedProperty,
                s_lastReadAppearancesFromMesh1);
            MeshFile2ReadAppearancesCheckbox.SetCurrentValue(ToggleButton.IsCheckedProperty,
                s_lastReadAppearancesFromMesh2);
            MeshFile3ReadAppearancesCheckbox.SetCurrentValue(ToggleButton.IsCheckedProperty,
                s_lastReadAppearancesFromMesh3);
            MeshFile4ReadAppearancesCheckbox.SetCurrentValue(ToggleButton.IsCheckedProperty,
                s_lastReadAppearancesFromMesh4);

            RememberValuesCheckbox.SetCurrentValue(ToggleButton.IsCheckedProperty, true);
        }

        private void OnReadAppearancesCheckboxChecked(object sender, RoutedEventArgs e)
        {
            if (ViewModel is null)
            {
                return;
            }

            // enable appearance textbox status based on checkbox
            var readFromMeshes = ViewModel.MeshFile1ReadFromMesh || ViewModel.MeshFile2ReadFromMesh ||
                                 ViewModel.MeshFile3ReadFromMesh || ViewModel.MeshFile4ReadFromMesh;

            AppearancesTextBox.SetCurrentValue(IsEnabledProperty, !readFromMeshes);
            SetCheckboxStatusWriteMeshAppearances(!readFromMeshes && (ViewModel.Appearances ?? []).Count > 0);
        }

        private void SetCheckboxStatusWriteMeshAppearances(bool isEnabled)
        {
            MeshFile1UseAppearancesCheckbox.SetCurrentValue(IsEnabledProperty, isEnabled);
            MeshFile2UseAppearancesCheckbox.SetCurrentValue(IsEnabledProperty, isEnabled);
            MeshFile3UseAppearancesCheckbox.SetCurrentValue(IsEnabledProperty, isEnabled);
            MeshFile4UseAppearancesCheckbox.SetCurrentValue(IsEnabledProperty, isEnabled);
        }
    }
}
