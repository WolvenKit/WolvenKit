using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DynamicData;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class SelectionView : IViewFor<SelectionViewModel>
    {
        public SelectionView(IList<string> options, string title, string text, bool allowMultiSelect)
        {
            InitializeComponent();

            ViewModel = new SelectionViewModel(options, title, text) { AllowMultiSelect = allowMultiSelect is true };
            DataContext = ViewModel;

            Owner = Application.Current.MainWindow;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel, x => x.SelectedOptions, x => x.ListDropdown.SelectedItems)
                    .DisposeWith(disposables);
            });
        }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
            {
                return;
            }

            e.Handled = true;
            DialogResult = true;
            Close();
        }

        public SelectionViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (SelectionViewModel)value; }

        private void ListDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ViewModel is not SelectionViewModel vm || sender is not ListBox lb)
            {
                return;
            }

            vm.SelectedOptions.Clear();
            vm.SelectedOptions.AddRange(lb.SelectedItems.OfType<string>());
        }
    }
}