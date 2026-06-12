using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
using WolvenKit.Core.Interfaces;
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
            .Where(p => typeof(IRedType).IsAssignableFrom(p) && p is { IsClass: true, IsAbstract: false })
            .Select(x => new TypeDesc(x, x.Name))
            .OrderBy(x => x.TypeName)
        );
        SelectedType = ValidNewTypes.FirstOrDefault()!;
    }

    public RedTypeTemplateDropdownViewModel RedTypeTemplateDropdownViewModel { get; }
    public ObservableCollection<RedTypeTemplateDescriptorManagerExt> Templates { get; } = new();

    [ObservableProperty]
    private TypeDesc _selectedType;
    public ObservableCollection<TypeDesc> ValidNewTypes { get; }

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

        RedBaseClass typeInstance;

        if (RedTypeTemplateDropdownViewModel.SelectedRedTypeTemplate is not null &&
            RedTypeTemplateDropdownViewModel.SelectedRedTypeTemplate.Source != RedTypeTemplateDescriptorExtSource.Raw)
        {
            typeInstance = _templateService.CreateTypeInstance(RedTypeTemplateDropdownViewModel.SelectedRedTypeTemplate) ?? throw new Exception("Failed to create type instance");
        }
        else
        {
            typeInstance = (RedBaseClass?)Activator.CreateInstance(type) ?? throw new Exception("Failed to create type instance");
        }

        _templateService.WriteTemplate(typeInstance, name);

        if (!Templates.Any(t => t.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase) && t.Type == type && t.Source == RedTypeTemplateDescriptorExtSource.User))
        {
            Templates.Add(new RedTypeTemplateDescriptorManagerExt(
                _templateService.UserTemplates.First(t => t.Name == name && t.Type == type),
                RedTypeTemplateDescriptorExtSource.User));
        }
    }

    [RelayCommand]
    private void Ok() => _appViewModel.CloseModalCommand.Execute(null);

    [RelayCommand]
    private void Cancel() => _appViewModel.CloseModalCommand.Execute(null);

    private void LoadTemplates()
    {
        Templates.Clear();
        Templates.AddRange(_templateService.UserTemplates.Select(t => new RedTypeTemplateDescriptorManagerExt(t, RedTypeTemplateDescriptorExtSource.User)));
        Templates.AddRange(_templateService.SystemTemplates.Select(t => new RedTypeTemplateDescriptorManagerExt(t, RedTypeTemplateDescriptorExtSource.System)));
    }

    public async Task EditFile(RedTypeTemplateDescriptorManagerExt templateDesc)
    {
        #region Source Validation

        var desc = templateDesc;

        if (desc.Source == RedTypeTemplateDescriptorExtSource.System)
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

            var systemTemplateData = _templateService.ReadTemplate(desc) ?? throw new Exception($"Failed to read system template `{desc.Name}` of type `{desc.Type.Name}`");
            _templateService.WriteTemplate(systemTemplateData, desc.Name);

            desc = new RedTypeTemplateDescriptorManagerExt(
                _templateService.UserTemplates.First(t => t.Name.Equals(desc.Name, StringComparison.OrdinalIgnoreCase) && t.Type == desc.Type),
                RedTypeTemplateDescriptorExtSource.User);

            if (!Templates.Any(t => t.Name.Equals(desc.Name, StringComparison.OrdinalIgnoreCase) && t.Type == desc.Type && t.Source == RedTypeTemplateDescriptorExtSource.User))
            {
                Templates.Add(desc);
            }
        }

        #endregion

        #region Temp CR2W File Creation

        var tempFile = Path.Combine(Path.GetTempPath(), $"{desc.Name}.{desc.Type.Name}.tempcr2w");

        var tempFileCreated = await Task.Run(() =>
        {
            var data = _templateService.ReadTemplate(desc);
            if (data is null)
            {
                _loggerService.Error($"Failed to read template: {desc.FilePath}");
                return false;
            }

            var cr2W = new CR2WFile
            {
                RootChunk = data
            };

            if (!_cr2wTools.WriteCr2W(cr2W, tempFile))
            {
                _loggerService.Error($"Failed to create temporary file: {tempFile}");
                return false;
            }

            return true;
        });

        if (!tempFileCreated)
        {
            return;
        }

        #endregion

        #region Editing Event Handlers

        _appViewModel.DockedViews.CollectionChanged += OnDockedViewsChanged;
        _appViewModel.RequestFileOpen(tempFile);

        _appViewModel.CloseModalCommand.Execute(null);
        return;

        void OnDockedViewsChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems == null)
            {
                return;
            }

            foreach (var item in e.NewItems.OfType<RedDocumentViewModel>())
            {
                if (item.FilePath == tempFile)
                {
                    item.OnSaveCompleted += OnDocumentSaved;
                    _appViewModel.DockedViews.CollectionChanged -= OnDockedViewsChanged;
                    _appViewModel.DockedViews.CollectionChanged += OnRemoved;
                    break;
                }
                continue;

                void OnRemoved(object? s, NotifyCollectionChangedEventArgs ea)
                {
                    if (ea.OldItems?.Contains(item) != true)
                    {
                        return;
                    }

                    item.OnSaveCompleted -= OnDocumentSaved;
                    _appViewModel.DockedViews.CollectionChanged -= OnRemoved;

                    try
                    {
                        File.Delete(tempFile);
                    }
                    catch
                    {
                        /* ignore */
                    }
                }
            }

            return;

            void OnDocumentSaved(object? docSavedSender, EventArgs docSavedArgs)
            {
                if (docSavedSender is not RedDocumentViewModel doc)
                {
                    return;
                }

                _templateService.WriteTemplate(doc.Cr2wFile.RootChunk, desc.Name);
                _loggerService.Success($"Template '{desc.Name}' of type `{desc.TypeName}` updated.");
            }
        }

        #endregion
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
