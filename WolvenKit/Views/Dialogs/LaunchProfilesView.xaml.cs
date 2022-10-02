using ReactiveUI;
using Splat;
using System;
using System.IO;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using WolvenKit.Core;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    public partial class LaunchProfilesView : IViewFor<LaunchProfilesViewModel>
    {
        public LaunchProfilesView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<LaunchProfilesViewModel>();
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                this.BindCommand(ViewModel, x => x.NewItemCommand, x => x.ToolbarNewItem)
                   .DisposeWith(disposables);
                this.BindCommand(ViewModel, x => x.DuplicateItemCommand, x => x.ToolbarDuplicateItem)
                   .DisposeWith(disposables);
                this.BindCommand(ViewModel, x => x.DeleteItemCommand, x => x.ToolbarDeleteItem)
                   .DisposeWith(disposables);
                //this.BindCommand(ViewModel, x => x.RenameItemCommand, x => x.ToolbarRenameItem)
                //   .DisposeWith(disposables);

                Observable
                    .FromEventPattern(WizardControl, nameof(Syncfusion.Windows.Tools.Controls.WizardControl.Finish))
                    .Subscribe(_ => ViewModel.OkCommand.Execute().Subscribe())
                    .DisposeWith(disposables);


            });

        }

        public LaunchProfilesViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (LaunchProfilesViewModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        //private void TextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        //{
        //    if (e.Key == System.Windows.Input.Key.Enter)
        //    {
        //        if (sender is TextBox textBox && textBox.DataContext is LaunchProfileViewModel viewModel)
        //        {

        //            ViewModel.SetEditableFalse(viewModel);
        //        }
        //    }
        //}

        private void ProfilePropertyGrid_AutoGeneratingPropertyGridItem(object sender, Syncfusion.Windows.PropertyGrid.AutoGeneratingPropertyGridItemEventArgs e)
        {
            switch (e.DisplayName)
            {
                case nameof(ReactiveObject.Changed):
                case nameof(ReactiveObject.Changing):
                case nameof(ReactiveObject.ThrownExceptions):
                    e.Cancel = true;
                    break;
            }
        }

        //private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        //{
        //    if (sender is TextBox textBox && textBox.DataContext is LaunchProfileViewModel viewModel)
        //    {
        //        ViewModel.SetEditableFalse(viewModel);
        //    }
        //}
    }
}
