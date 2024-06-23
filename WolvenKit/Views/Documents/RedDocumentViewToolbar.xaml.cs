using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.ClearScript;
using ReactiveUI;
using Splat;
using WolvenKit.App;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Scripting;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.Modkit.Scripting;
using WolvenKit.Views.Dialogs.Windows;

namespace WolvenKit.Views.Documents
{
    public partial class RedDocumentViewToolbar : ReactiveUserControl<RedDocumentViewToolbarModel>
    {
        private AppScriptService _scriptService;
        private readonly ISettingsManager _settingsManager;
        
        

        public RedDocumentViewToolbar()
        {
            _scriptService = Locator.Current.GetService<AppScriptService>();
            _settingsManager = Locator.Current.GetService<ISettingsManager>();
            InitializeComponent();

            RegisterFileValidationScript();

            DataContext = new RedDocumentViewToolbarModel { CurrentTab = _currentTab };

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

        private ScriptFileViewModel _fileValidationScript;

        private void RegisterFileValidationScript()
        {
            _fileValidationScript = _scriptService.GetScripts(ISettingsManager.GetWScriptDir()).ToList()
                .Where(s => s.Name == "run_FileValidation_on_active_tab")
                .Select(s => new ScriptFileViewModel(_settingsManager, ScriptSource.User, s))
                .FirstOrDefault();

            _fileValidationScript ??= _scriptService.GetScripts(@"Resources\Scripts").ToList()
                .Where(s => s.Name == "run_FileValidation_on_active_tab")
                .Select(s => new ScriptFileViewModel(_settingsManager, ScriptSource.System, s))
                .FirstOrDefault();

            if (_fileValidationScript is null && ViewModel is not null)
            {
                ViewModel.IsFileValidationMenuVisible = false;
            }
        }

        public RedDocumentTabViewModel CurrentTab
        {
            get => _currentTab;
            set
            {
                _currentTab = value;
                ViewModel?.SetCurrentTab(value);
            }
        }

        private async Task RunFileValidation()
        {
            if (_fileValidationScript is null || !File.Exists(_fileValidationScript.Path))
            {
                return;
            }

            var code = await File.ReadAllTextAsync(_fileValidationScript.Path);

            await _scriptService.ExecuteAsync(code);
        }

        private void OnFileValidationClick(object sender, RoutedEventArgs e) =>
            Task.Run(async () => await RunFileValidation()).GetAwaiter().GetResult();

        private void OnConvertLocalMaterialsClick(object sender, RoutedEventArgs e) =>
            ViewModel?.RootChunk?.ConvertPreloadMaterialsCommand.Execute(null);

        private void OnDeleteUnusedMaterialsClick(object sender, RoutedEventArgs e) =>
            ViewModel?.RootChunk?.DeleteUnusedMaterialsCommand.Execute(null);

        private void OnClearAllMaterialsClick(object sender, RoutedEventArgs e) =>
            ViewModel?.RootChunk?.ClearMaterialsCommand.Execute(null);

        private void OnRegenerateMaterialsClick(object sender, RoutedEventArgs e) =>
            ViewModel?.SelectedChunk?.RegenerateAppearanceVisualControllerCommand.Execute(null);

        private void OnGenerateNewCruidClick(object sender, RoutedEventArgs e) =>
            ViewModel?.SelectedChunk?.GenerateCRUIDCommand.Execute(null);

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

        public event EventHandler<EditorDifficultyLevel> EditorDifficultChanged;

        private void OnEditorModeClick(EditorDifficultyLevel level)
        {
            if (ViewModel is null)
            {
                return;
            }

            ViewModel?.SetEditorLevel(level);
            EditorDifficultChanged?.Invoke(this, level);
        }

        private void OnEditorModeClick_Easy(object sender, RoutedEventArgs e) => OnEditorModeClick(EditorDifficultyLevel.Easy);

        private void OnEditorModeClick_Default(object sender, RoutedEventArgs e) => OnEditorModeClick(EditorDifficultyLevel.Default);

        private void OnEditorModeClick_Advanced(object sender, RoutedEventArgs e) => OnEditorModeClick(EditorDifficultyLevel.Advanced);
    }
}