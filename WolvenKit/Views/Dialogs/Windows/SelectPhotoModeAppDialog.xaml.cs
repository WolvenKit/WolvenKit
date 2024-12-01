using System.Collections.Generic;
using System.ComponentModel;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Input;
using Microsoft.ClearScript.JavaScript;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Editors;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs.Windows
{
    public partial class SelectPhotoModeAppDialog : IViewFor<SelectPhotoModeAppViewModel>
    {
        public SelectPhotoModeAppDialog()
        {
            InitializeComponent();

            ViewModel = new SelectPhotoModeAppViewModel();
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                        x => x.RenameEntries,
                        x => x.IsPhotomodeCheckbox.IsChecked)
                    .DisposeWith(disposables);
            });
        }

        public SelectPhotoModeAppViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (SelectPhotoModeAppViewModel)value; }

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
    }
}