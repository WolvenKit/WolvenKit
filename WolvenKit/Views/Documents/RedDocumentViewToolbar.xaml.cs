using System.ComponentModel;
using System.Windows;
using Microsoft.ClearScript;
using ReactiveUI;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.Views.Dialogs.Windows;

namespace WolvenKit.Views.Documents
{
    public partial class RedDocumentViewToolbar : ReactiveUserControl<RedDocumentViewToolbarModel>
    {
        private AppScriptService _appScriptService;

        public RedDocumentViewToolbar()
        {
            _appScriptService = Locator.Current.GetService<AppScriptService>();
            InitializeComponent();

            var model = new RedDocumentViewToolbarModel();
            model.CurrentTab = _currentTab;
            DataContext = model;

            this.WhenActivated(disposables =>
            {
                if (DataContext is not RedDocumentViewToolbarModel vm)
                {
                    return;
                }

                vm.RefreshMenuVisibility();
            });
        }

        private RedDocumentTabViewModel _currentTab;

        public RedDocumentTabViewModel CurrentTab
        {
            get => _currentTab;
            set
            {
                _currentTab = value;
                ViewModel?.SetCurrentTab(value);
            }
        }

        private void RunFileValidation(object sender, RoutedEventArgs e)
        {
            if (ViewModel is { FilePath: string filePath, Cr2WFile: CR2WFile file })
            {
                // TODO this is not working yet
                _appScriptService?.RunFileValidation(filePath, ref file);
            }
        }

        private void OnConvertLocalMaterialsClick(object sender, RoutedEventArgs e) =>
            ViewModel?.RootChunk?.ConvertPreloadMaterialsCommand.Execute(null);

        private void OnDeleteUnusedMaterialsClick(object sender, RoutedEventArgs e) =>
            ViewModel?.RootChunk?.DeleteUnusedMaterialsCommand.Execute(null);

        private void OnClearAllMaterialsClick(object sender, RoutedEventArgs e) =>
            ViewModel?.RootChunk?.ClearMaterialsCommand.Execute(null);

        private void OnGenerateMissingMaterialsClick(object sender, RoutedEventArgs e)
        {
            var dialog = new CreateMaterialsDialog();
            if (ViewModel?.RootChunk is not ChunkViewModel cvm || dialog.ShowDialog() != true)
            {
                return;
            }

            var baseMaterial = dialog.ViewModel?.BaseMaterial ?? "";
            var isLocal = dialog.ViewModel?.IsLocalMaterial ?? true;
            var resolveSubstitutions = dialog.ViewModel?.ResolveSubstitutions ?? false;

            cvm.GenerateMissingMaterials(baseMaterial, isLocal, resolveSubstitutions);

            cvm?.Tab?.Parent.SetIsDirty(true);
        }
    }
}