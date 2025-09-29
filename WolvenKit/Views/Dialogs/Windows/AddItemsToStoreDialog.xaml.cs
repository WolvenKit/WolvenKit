using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.ViewModels.Dialogs;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class AddItemsToStoreDialog : IViewFor<AddItemsToStoreDialogViewModel>
    {
        private static string s_lastYamlFile = string.Empty;
        private static string s_lastRedsFile = string.Empty;
        private static readonly List<string> s_lastItemCodes = [];
        private static bool s_rememberValues = false;


        public AddItemsToStoreDialog(Cp77Project project)
        {
            InitializeComponent();

            ViewModel = new AddItemsToStoreDialogViewModel(project, s_rememberValues, s_lastYamlFile, s_lastRedsFile);

            DataContext = ViewModel;

            Owner = Application.Current.MainWindow;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.YamlFiles,
                        x => x.YamlDropdownMenu.Options)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.YamlPath,
                        x => x.YamlDropdownMenu.SelectedOption)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.RedsFiles,
                        x => x.RedsDropdownMenu.Options)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.RedsPath,
                        x => x.RedsDropdownMenu.SelectedOption)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.RememberValues,
                        x => x.RememberValuesCheckbox.IsChecked)
                    .DisposeWith(disposables);


                if (s_rememberValues && s_lastItemCodes.Count > 0)
                {
                    ItemCodesTextBox.SetCurrentValue(TextBox.TextProperty, string.Join("\n", s_lastItemCodes));
                }
            });
        }

        public AddItemsToStoreDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (AddItemsToStoreDialogViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        private void CloseDialogue(bool result)
        {
            SaveDefaultValues();
            DialogResult = result;
            Close();
        }

        private void WizardControl_OnFinish(object _, RoutedEventArgs e) => SaveDefaultValues();

        private void SaveDefaultValues()
        {
            if (ViewModel is not AddItemsToStoreDialogViewModel vm)
            {
                return;
            }

            s_rememberValues = vm.RememberValues;
            s_lastItemCodes.Clear();

            if (!vm.RememberValues)
            {
                s_lastRedsFile = null;
                s_lastYamlFile = null;
                return;
            }

            s_lastRedsFile = vm.RedsPath;
            s_lastYamlFile = vm.YamlPath;
            s_lastItemCodes.AddRange(vm.ItemCodes);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is not TextBox textBox || ViewModel is not { } vm)
            {
                return;
            }

            vm.ItemCodes = ItemCodesRegex().Matches(textBox.Text).Select(m => m.Value).Distinct().ToList();
        }

        [GeneratedRegex(@"Items\.\w+")]
        private partial Regex ItemCodesRegex();
    }
}
