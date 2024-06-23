using System.Reactive.Disposables;
using System.Windows.Controls;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.Services;
using WolvenKit.Controls;
using WolvenKit.Converters;
using WolvenKit.ViewModels;
using static WolvenKit.Converters.PropertyGridEditors;

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class SettingsPageView : ReactiveUserControl<SettingsPageViewModel>
    {
        public SettingsPageView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<SettingsPageViewModel>();
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                    viewModel => viewModel.Settings,
                    view => view.SettingsPropertygrid.SelectedObject)
                .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                      viewModel => viewModel.MainViewModel.CheckForUpdatesCommand,
                      view => view.CheckForUpdatesButton)
                .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                      viewModel => viewModel.SaveCloseCommand,
                      view => view.SaveCloseButton)
                .DisposeWith(disposables);
            });
        }

        public ItemCollection AccordionItems { get; set; }

        private void SettingsPropertygrid_OnAutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
        {
            switch (e.DisplayName)
            {
                case nameof(ReactiveObject.Changed):
                case nameof(ReactiveObject.Changing):
                case nameof(ReactiveObject.ThrownExceptions):
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
            // Generate special editors for the properties for which default is not ok
            if (e.OriginalSource is not PropertyItem { } propertyItem)
            {
                return;
            }

            switch (propertyItem.DisplayName)
            {
                case nameof(ISettingsDto.CP77ExecutablePath):
                    propertyItem.Editor =
                        new SingleFilePathEditor() { Filters = new PathEditorFilter[] { new("Cyberpunk2077.exe", "*.exe") } };
                    break;
                case nameof(ISettingsManager.MaterialRepositoryPath):
                    propertyItem.Editor = new SingleFolderPathEditor();
                    break;
                case nameof(ISettingsManager.ExtraModDirPath):
                    propertyItem.Editor = new SingleFolderPathEditor();
                    break;
                case nameof(ISettingsManager.DefaultEditorDifficultyLevel):
                    propertyItem.Editor = GetPropertyEditor(propertyItem.GetType());
                    break;
                case nameof(ISettingsDto.ThemeAccentString):
                    propertyItem.Editor = new BrushEditor();
                    break;
                default:
                    break;
            }
        }
    }
}
