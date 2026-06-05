using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

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

        var typeInstance = _templateService.CreateTypeInstance(type) ?? throw new Exception("Failed to create type instance");

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

    [RelayCommand]
    public void LoadTemplates()
    {
        _templateService.LoadTemplates();
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

            var localPath = Path.Join(ISettingsManager.GetUserTemplateDir(),$"{desc.Name}.{desc.Type.Name}.json");
            if (File.Exists(localPath))
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

            File.Copy(desc.FilePath, localPath, true);
            await Task.Run(LoadTemplates);
            desc = Templates.First(t => t.Name == desc.Name &&
                                        t.Type == desc.Type &&
                                        t.Source == RedTypeTemplateDescriptorExtSource.User);
        }

        #endregion

        #region Temp CR2W File Creation

        var tempFile = Path.Combine(Path.GetTempPath(), $"{desc.Name}.{desc.Type.Name}.tempcr2w");

        var tempFileCreated = await Task.Run(() =>
        {
            var data = _templateService.ReadTemplate(desc);
            if (data is not RedBaseClass redBase)
            {
                _loggerService.Error("Template data is not a RedBaseClass.");
                return false;
            }
            var cr2w = new CR2WFile
            {
                RootChunk = redBase
            };

            if (!_cr2wTools.WriteCr2W(cr2w, tempFile))
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
