using System;
using System.Collections.Generic;
using System.IO;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.RED4.Types;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class SelectDropdownEntryWindow : IViewFor<SelectDropdownEntryDialogViewModel>
    {
        public SelectDropdownEntryWindow(List<string> options, string title, string text, bool showInputBar = false)
        {
            InitializeComponent();

            ViewModel = new SelectDropdownEntryDialogViewModel(options, title, text, showInputBar);
            DataContext = ViewModel;

            Owner = Application.Current.MainWindow;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.SelectedOption,
                        x => x.Dropdown.SelectedItem)
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
    }
}