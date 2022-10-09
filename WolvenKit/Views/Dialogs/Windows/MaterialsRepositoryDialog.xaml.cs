using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.RED4.Archive;
using WolvenKit.Views.Shell;

namespace WolvenKit.Views.Dialogs.Windows
{
    /// <summary>
    /// Interaction logic for MaterialsRepositoryDialog.xaml
    /// </summary>
    public partial class MaterialsRepositoryView : IViewFor<MaterialsRepositoryViewModel>
    {

        public MaterialsRepositoryView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<MaterialsRepositoryViewModel>();
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                this.BindCommand(ViewModel, x => x.GenerateMaterialRepoCommand, x => x.GenerateMaterialsButton)
                   .DisposeWith(disposables);
                this.BindCommand(ViewModel, x => x.UnbundleGameCommand, x => x.UnbundleGameButton)
                   .DisposeWith(disposables);
                this.BindCommand(ViewModel, x => x.OpenMaterialRepositoryCommand, x => x.OpenMaterialRepositoryButton)
                   .DisposeWith(disposables);

                this.Bind(ViewModel, x => x.MaterialsDepotPath, x => x.MaterialsTextBox.Text)
                   .DisposeWith(disposables);

                this.Bind(ViewModel, x => x.UncookExtension, x => x.MaterialExtensionCombobox.SelectedItem)
                   .DisposeWith(disposables);
                this.OneWayBind(ViewModel, x => x.UncookExtensions, x => x.MaterialExtensionCombobox.ItemsSource)
                  .DisposeWith(disposables);
            });
        }

        public MaterialsRepositoryViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (MaterialsRepositoryViewModel)value; }

        private void MaterialsButton_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var dialog = new CommonOpenFileDialog { IsFolderPicker = true };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ViewModel.MaterialsDepotPath = dialog.FileName;

                var settingsManager = Locator.Current.GetService<ISettingsManager>();
                settingsManager.MaterialRepositoryPath = dialog.FileName;
                settingsManager.Save();
            }
        }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }
    }
}
