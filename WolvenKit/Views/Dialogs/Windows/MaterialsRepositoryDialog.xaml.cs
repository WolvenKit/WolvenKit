using System;
using System.Reactive.Disposables;
using System.Windows;
using ReactiveUI;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;

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
                this.BindCommand(ViewModel, x => x.MigrateDepotCommand, x => x.MigrateDepotButton)
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
            var dialog = new FolderPicker();

            if (dialog.ShowDialog() == true)
            {
                ViewModel.MaterialsDepotPath = dialog.ResultPath;

                var settingsManager = Locator.Current.GetService<ISettingsManager>();
                settingsManager.MaterialRepositoryPath = dialog.ResultPath;
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
