using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Controls;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using Activator = System.Activator;

namespace WolvenKit.App.ViewModels.Dialogs;

public record TypeDesc(Type Type, string TypeName);

public partial class RedTypeTemplateManagerViewModel : DialogViewModel
{
    private readonly AppViewModel _appViewModel;
    private readonly RedTypeTemplateService _templateService;
    private readonly ILoggerService _loggerService;
    private readonly Cr2WTools _cr2wTools;
    private readonly object _lock = new();


    public RedTypeTemplateManagerViewModel(AppViewModel appViewModel, RedTypeTemplateService templateService, ILoggerService loggerService, Cr2WTools cr2wTools)
    {
        _appViewModel = appViewModel;
        _templateService = templateService;
        _loggerService = loggerService;
        _cr2wTools = cr2wTools;

        RedTypeTemplateDropdownViewModel = new RedTypeTemplateDropdownViewModel(templateService);
        RedTypeTemplateDropdownViewModel.PostRefresh += (_, _) => LoadTemplates();

        ValidNewTypes = new ObservableCollection<TypeDesc>(AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => typeof(IRedType).IsAssignableFrom(p) && p is { IsAbstract: false })
            .Select(x => new TypeDesc(x, x.Name))
            .OrderBy(x => x.TypeName)
        );
        SelectedType = ValidNewTypes.FirstOrDefault()!;
    }

    public RedTypeTemplateDropdownViewModel RedTypeTemplateDropdownViewModel { get; }
    public ObservableCollection<RedTypeTemplateManagerOption> Templates { get; } = new();

    [ObservableProperty]
    private RedTypeTemplateManagerOption? _selectedTemplate;

    [ObservableProperty]
    private TypeDesc _selectedType;
    public ObservableCollection<TypeDesc> ValidNewTypes { get; }

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsTemplateNameValid))]
    private string _templateName = "";

    public bool IsTemplateNameValid => !string.IsNullOrWhiteSpace(TemplateName) && FilepathValidationTools.IsOsFileNameValid(TemplateName.TrimEnd());

    partial void OnSelectedTypeChanged(TypeDesc value)
    {
        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (value is null)
        {
            return;
        }

        RedTypeTemplateDropdownViewModel.RequestedType = value.Type;
    }

    public async Task AddTemplate(Type type, string name)
    {
        if (_templateService.TemplateExists(type, name))
        {
            var response = await Interactions.ShowMessageBoxAsync(
                "A template with this name and type already exists, do you want to overwrite it?",
                "Template already exists",
                WMessageBoxButtons.YesNo);

            if (response == WMessageBoxResult.No)
            {
                return;
            }
        }

        IRedType? typeInstance;

        if (RedTypeTemplateDropdownViewModel.SelectedRedTypeTemplate.Source != RedTypeTemplateSelectionOptionSource.Raw)
        {
            typeInstance =
                _templateService.CreateTypeInstance(RedTypeTemplateDropdownViewModel.SelectedRedTypeTemplate);
        }
        else
        {
            typeInstance = (IRedType?)Activator.CreateInstance(type);
        }

        if (typeInstance is null)
        {
            throw new Exception($"Failed to create instance of type {type.Name}");
        }

        _templateService.WriteTemplate(new RedTypeTemplate { Data = typeInstance }, name);
        var userTemplate = _templateService.ReadTemplate(type, name, TemplateSource.User) ?? throw new Exception($"Failed to read user template `{name}` of type `{type.Name}`");

        if (!Templates.Any(t => t.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase) && t.Type == type && t.Source == RedTypeTemplateSelectionOptionSource.User))
        {
            Templates.Add(new RedTypeTemplateManagerOption(
                _templateService.UserTemplates.First(t => t.Name == name && t.Type == type),
                RedTypeTemplateSelectionOptionSource.User, userTemplate));
        }
    }

    [RelayCommand]
    private void Ok() => Close();

    [RelayCommand]
    private void Cancel() => Close();

    private void LoadTemplates()
    {
        Templates.Clear();
        Templates.AddRange(_templateService
            .UserTemplates.Select(t => new RedTypeTemplateManagerOption(t, RedTypeTemplateSelectionOptionSource.User,
                _templateService.ReadTemplate(t, TemplateSource.User)!)));
        Templates.AddRange(_templateService
            .SystemTemplates.Select(t => new RedTypeTemplateManagerOption(t, RedTypeTemplateSelectionOptionSource.System,
                _templateService.ReadTemplate(t, TemplateSource.System)!)));
    }

    public async Task EditFile(RedTypeTemplateManagerOption templateDesc)
    {
        #region Source Validation

        var desc = templateDesc;

        if (desc.Source == RedTypeTemplateSelectionOptionSource.System)
        {
            var response = await Interactions.ShowMessageBoxAsync(
                "Trying to edit a system template. Should a local copy be created?",
                "Edit system file",
                WMessageBoxButtons.YesNo);

            if (response == WMessageBoxResult.No)
            {
                return;
            }

            if (_templateService.TemplateExists(desc, TemplateSource.User))
            {
                response = await Interactions.ShowMessageBoxAsync(
                    "A local copy of this template already exists. Overwrite it?",
                    "Overwrite template",
                    WMessageBoxButtons.YesNo);

                if (response == WMessageBoxResult.No)
                {
                    return;
                }
            }

            var systemTemplate = _templateService.ReadTemplate(desc) ?? throw new Exception($"Failed to read system template `{desc.Name}` of type `{desc.Type.Name}`");
            _templateService.WriteTemplate(systemTemplate, desc.Name);
            var userTemplate = _templateService.ReadTemplate(desc, TemplateSource.User) ?? throw new Exception($"Failed to read user template `{desc.Name}` of type `{desc.Type.Name}`");

            desc = new RedTypeTemplateManagerOption(
                _templateService.UserTemplates.First(t => t.Name.Equals(desc.Name, StringComparison.OrdinalIgnoreCase) && t.Type == desc.Type),
                RedTypeTemplateSelectionOptionSource.User, userTemplate);

            if (!Templates.Any(t => t.Name.Equals(desc.Name, StringComparison.OrdinalIgnoreCase) && t.Type == desc.Type && t.Source == RedTypeTemplateSelectionOptionSource.User))
            {
                Templates.Add(desc);
            }
        }

        #endregion

        _appViewModel.RequestFileOpen(desc.FilePath);
    }

    public async Task DeleteFile(RedTypeTemplateManagerOption template)
    {
        var response = await Interactions.ShowMessageBoxAsync(
            $"Are you sure you want to delete \"{template.Name}\"?",
            "Delete file",
            WMessageBoxButtons.YesNo);

        if (response == WMessageBoxResult.Yes)
        {
            Templates.Remove(template);
            _templateService.DeleteTemplate(template);
        }
    }

    private void Close()
    {
        SaveModifiedTemplates();
        _appViewModel.CloseModalCommand.Execute(null);
    }

    public void SaveModifiedTemplates()
    {
        lock (_lock)
        {
            foreach (var template in Templates.Where(t => t is
                         { Source: RedTypeTemplateSelectionOptionSource.User, IsDirty: true }))
            {
                _templateService.WriteTemplate(template.Template, template.Name);
                template.IsDirty = false;
            }
        }
    }
}
