using System;
using System.Collections.Generic;
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
using WolvenKit.ViewModels.Validators;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class AddPropFileDialog : IViewFor<AddPropFileDialogViewModel>
    {
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
            });
        }


        private void ParentFolderSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is not ComboBox comboBox)
            {
                return;
            }

            ParentFolderBox.SetCurrentValue(TextBox.TextProperty, comboBox.Text);
        }

        private void Mesh1SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 0 || e.AddedItems[0] is not KeyValuePair<string, string> kvp ||
                string.IsNullOrEmpty(kvp.Value))
            {
                return;
            }

            Mesh1TextBox.SetCurrentValue(TextBox.TextProperty, kvp.Value);
        }

        private void Mesh2SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 0 || e.AddedItems[0] is not KeyValuePair<string, string> kvp ||
                string.IsNullOrEmpty(kvp.Value))
            {
                return;
            }


            Mesh1TextBox.SetCurrentValue(TextBox.TextProperty, kvp.Value);
        }

        private void Mesh3SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 0 || e.AddedItems[0] is not KeyValuePair<string, string> kvp ||
                string.IsNullOrEmpty(kvp.Value))
            {
                return;
            }

            Mesh3TextBox.SetCurrentValue(TextBox.TextProperty, kvp.Value);
        }

        private void Mesh4SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 0 || e.AddedItems[0] is not KeyValuePair<string, string> kvp ||
                string.IsNullOrEmpty(kvp.Value))
            {
                return;
            }

            Mesh4TextBox.SetCurrentValue(TextBox.TextProperty, kvp.Value);
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
        }


        private void OnHelpButtonClicked(object sender, RoutedEventArgs e)
        {
            var ps = new ProcessStartInfo(WikiLinks.Props) { UseShellExecute = true, Verb = "open" };
            Process.Start(ps);
        }
    }
}
