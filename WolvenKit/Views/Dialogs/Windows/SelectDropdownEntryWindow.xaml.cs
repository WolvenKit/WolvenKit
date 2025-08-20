using System.Collections.Generic;
using System.Diagnostics;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class SelectDropdownEntryWindow : IViewFor<SelectDropdownEntryDialogViewModel>
    {
        public SelectDropdownEntryWindow(List<string> options, string title, string text, bool showInputBar = false) :
            this(options, title, text, "", "", showInputBar)
        {
            // Delegate constructor
        }

        public SelectDropdownEntryWindow(List<string> options, string title, string text,
            string helpLink = "",
            string buttonText = "",
            bool showInputBar = false)
        {
            InitializeComponent();

            ViewModel = new SelectDropdownEntryDialogViewModel(options, title, text, showInputBar)
            {
                HelpLink = helpLink, ButtonText = buttonText,
            };

            DataContext = ViewModel;

            Owner = Application.Current.MainWindow;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.SelectedOption,
                        x => x.Dropdown.SelectedOption)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        x => x.OptionsDict,
                        x => x.Dropdown.Options)
                    .DisposeWith(disposables);
            });
        }


        public SelectDropdownEntryDialogViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (SelectDropdownEntryDialogViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        private void WizardPage_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
            {
                return;
            }

            e.Handled = true;
            DialogResult = true;
            Close();
        }

        private void OnHelpClicked(object sender, RoutedEventArgs e)
        {
            if (ViewModel is not { ShowHelpButton: true, HelpLink: { } helpLink })
            {
                return;
            }

            Process.Start(new ProcessStartInfo { FileName = helpLink, UseShellExecute = true });
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is not { ShowButton: true } viewModel)
            {
                return;
            }

            viewModel.SelectedOption = SelectDropdownEntryDialogViewModel.ButtonClickResult;
            e.Handled = true;
            DialogResult = true;
            Close();
        }

        private void FilterDropdown_OnFocusLost(object sender, RoutedEventArgs e)
        {
            if (ModifierViewStateService.IsShiftBeingHeld && ViewModel?.ShowButton == true)
            {
                ClickButton.Focus();
                return;
            }

            TextBox.Focus();
        }
    }
}
