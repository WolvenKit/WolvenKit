using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Scripting;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Dialogs;

public record TypeDesc(Type Type, string TypeName);

public partial class RedTypeTemplateManagerViewModel : DialogViewModel
{
    private readonly AppViewModel _appViewModel;
    private readonly RedTypeTemplateService _templateService;
    private readonly ISettingsManager _settingsManager;
    private readonly ILoggerService _loggerService;


    public RedTypeTemplateManagerViewModel(AppViewModel appViewModel, RedTypeTemplateService templateService, ISettingsManager settingsManager, ILoggerService loggerService)
    {
        _appViewModel = appViewModel;
        _templateService = templateService;
        _settingsManager = settingsManager;
        _loggerService = loggerService;

        LoadTemplates();

        ValidNewTypes = new ObservableCollection<TypeDesc>(AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => typeof(IRedType).IsAssignableFrom(p) && p is { IsClass: true, IsAbstract: false })
            .Select(x => new TypeDesc(x, x.Name))
            .OrderBy(x => x.TypeName)
        );
        SelectedType = ValidNewTypes.FirstOrDefault()!;
    }

    public ObservableCollection<RedTypeTemplateDescriptorManagerExt> Templates { get; } = new();

    public TypeDesc SelectedType { get; set; }
    public ObservableCollection<TypeDesc> ValidNewTypes { get; }

    public void AddTemplate(Type type, string name)
    {
        var typeInstance = _templateService.CreateTypeInstance(type) ?? throw new Exception("Failed to create type instance");

        _templateService.WriteTemplate(typeInstance, name);
        Templates.Add(new RedTypeTemplateDescriptorManagerExt(
            _templateService.UserTemplates.First(t => t.Name == name && t.Type == type),
            RedTypeTemplateDescriptorExtSource.User));
    }

    [RelayCommand]
    private void Ok() => _appViewModel.CloseModalCommand.Execute(null);

    [RelayCommand]
    private void Cancel() => _appViewModel.CloseModalCommand.Execute(null);

    [RelayCommand]
    private async Task UpdateScripts()
    {
        await _appViewModel.CheckForScriptUpdatesCommand.ExecuteAsync(null);
        LoadTemplates();

        _loggerService.Info("Scripts update complete");
    }

    public void LoadTemplates()
    {
        _templateService.LoadTemplates();
        Templates.Clear();
        Templates.AddRange(_templateService.UserTemplates.Select(t => new RedTypeTemplateDescriptorManagerExt(t, RedTypeTemplateDescriptorExtSource.User)));
        Templates.AddRange(_templateService.SystemTemplates.Select(t => new RedTypeTemplateDescriptorManagerExt(t, RedTypeTemplateDescriptorExtSource.System)));
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

        _appViewModel.RequestFileOpen(localFilePath);
        _appViewModel.CloseModalCommand.Execute(null);
    }

    public async Task EditFile(ScriptFileViewModel scriptFile)
    {
        if (!File.Exists(scriptFile.Path))
        {
            return;
        }
        var code = File.ReadAllText(scriptFile.Path);

        // await _templateService.ExecuteAsync(code);
    }

    public async Task DeleteFile(RedTypeTemplateDescriptorManagerExt templateDescriptor)
    {
        var response = await Interactions.ShowMessageBoxAsync(
            $"Are you sure you want to delete \"{templateDescriptor.Name}\"?",
            "Delete file",
            WMessageBoxButtons.YesNo);

        if (response == WMessageBoxResult.Yes)
        {
            Templates.Remove(templateDescriptor);
            _templateService.DeleteTemplate(templateDescriptor);
        }
    }
}
