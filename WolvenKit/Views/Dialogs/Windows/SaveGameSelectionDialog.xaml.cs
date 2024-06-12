using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Windows;
using ReactiveUI;
using Splat;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs.Windows
{
    /// <summary>
    /// Interaction logic for SaveGameSelectionDialog.xaml
    /// </summary>
    public partial class SaveGameSelectionDialog : IViewFor<SaveGameSelectionDialogModel>
    {
        public SaveGameSelectionDialog()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<SaveGameSelectionDialogModel>()!;

            DataContext = ViewModel;
        }

        public SaveGameSelectionDialogModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (SaveGameSelectionDialogModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }
    }
}