using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Scripting;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Modkit.Scripting;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ScriptManagerViewModel : DialogViewModel
{
    private const string s_scriptExtension = ".wscript";

    private readonly AppViewModel _appViewModel;
    private readonly AppScriptService _scriptService;
    private readonly ISettingsManager _settingsManager;

    
    public ScriptManagerViewModel(AppViewModel appViewModel, AppScriptService scriptService, ISettingsManager settingsManager)
    {
        _appViewModel = appViewModel;
        _scriptService = scriptService;
        _settingsManager = settingsManager;

        GetScriptFiles();
    }

    public ObservableCollection<ScriptViewModel> Scripts { get; } = new();


    public void AddScript(string fileName, ScriptType type)
    {
        if (string.IsNullOrEmpty(fileName))
        {
            return;
        }

        if (!fileName.EndsWith(s_scriptExtension))
        {
            fileName += s_scriptExtension;
        }

        var scriptPath = Path.Combine(ISettingsManager.GetWScriptDir(), fileName);
        if (File.Exists(scriptPath))
        {
            return;
        }

        File.Create(scriptPath).Close();
        GetScriptFiles();
    }

    [RelayCommand]
    private void Ok()
    {
        _appViewModel.CloseModalCommand.Execute(null);
    }

    [RelayCommand]
    private void Cancel() => _appViewModel.CloseModalCommand.Execute(null);

    public void GetScriptFiles()
    {
        _settingsManager.ScriptStatus ??= new();

        Scripts.Clear();

        var files = new List<string>();
        ScanDir(ScriptSource.System, @"Resources\Scripts");
        ScanDir(ScriptSource.User, ISettingsManager.GetWScriptDir());

        var keys = _settingsManager.ScriptStatus.Keys.ToList();
        foreach (var statusKey in keys)
        {
            if (!files.Contains(statusKey))
            {
                _settingsManager.ScriptStatus.Remove(statusKey);
            }
        }

        void ScanDir(ScriptSource scriptSource, string path)
        {
            var generalScriptDir = new ScriptDirectoryViewModel(scriptSource, ScriptType.General, _settingsManager);
            var hookScriptDir = new ScriptDirectoryViewModel(scriptSource, ScriptType.Hook, _settingsManager);
            var uiScriptDir = new ScriptDirectoryViewModel(scriptSource, ScriptType.Ui, _settingsManager);

            foreach (var systemScript in _scriptService.GetScripts(path))
            {
                files.Add(systemScript.Path);

                switch (systemScript.Type)
                {
                    case ScriptType.General:
                        generalScriptDir.Files.Add(new ScriptFileViewModel(_settingsManager, scriptSource, systemScript));
                        break;
                    case ScriptType.Hook:
                        hookScriptDir.Files.Add(new ScriptFileViewModel(_settingsManager, scriptSource, systemScript));
                        break;
                    case ScriptType.Ui:
                        uiScriptDir.Files.Add(new ScriptFileViewModel(_settingsManager, scriptSource, systemScript));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            Scripts.Add(generalScriptDir);
            Scripts.Add(hookScriptDir);
            Scripts.Add(uiScriptDir);
        }
    }

    public async Task OpenFile(ScriptFileViewModel scriptFile)
    {
        if (!File.Exists(scriptFile.Path))
        {
            return;
        }

        var localFilePath = scriptFile.Path;
        if (scriptFile.Source == ScriptSource.System)
        {
            var response = await Interactions.ShowMessageBoxAsync(
                "Trying to open a system file. Should a local copy be created?",
                "Open system file",
                WMessageBoxButtons.YesNo);

            if (response == WMessageBoxResult.No)
            {
                return;
            }

            localFilePath = Path.Combine(ISettingsManager.GetWScriptDir(), Path.GetFileName(scriptFile.Path));
            if (File.Exists(localFilePath))
            {
                response = await Interactions.ShowMessageBoxAsync(
                    "A copy of this file already exists. Overwrite it?",
                    "Overwrite file",
                    WMessageBoxButtons.YesNo);

                if (response == WMessageBoxResult.No)
                {
                    return;
                }
            }

            File.Copy(scriptFile.Path, localFilePath, true);
        }

        await _appViewModel.RequestFileOpen(localFilePath);
        _appViewModel.CloseModalCommand.Execute(null);
    }

    public async Task RunFile(ScriptFile scriptFile)
    {
        if (!File.Exists(scriptFile.Path))
        {
            return;
        }

        var code = File.ReadAllText(scriptFile.Path);

        await _scriptService.ExecuteAsync(code);
    }

    public async Task DeleteFile(ScriptFile scriptFile)
    {
        if (!File.Exists(scriptFile.Path))
        {
            return;
        }

        var response = await Interactions.ShowMessageBoxAsync(
            $"Are you sure you want to delete \"{scriptFile.Name}\"?",
            "Add file",
            WMessageBoxButtons.YesNo);

        if (response == WMessageBoxResult.Yes)
        {
            File.Delete(scriptFile.Path);
            GetScriptFiles();
        }
    }
}