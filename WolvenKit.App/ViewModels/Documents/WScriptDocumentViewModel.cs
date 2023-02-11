using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Options;
using WolvenKit.App.Factories;
using WolvenKit.App.Helpers;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.App.ViewModels.Documents;

public partial class WScriptDocumentViewModel : DocumentViewModel
{
    protected readonly ILoggerService _loggerService;
    protected readonly IProjectManager _projectManager;
    protected readonly IArchiveManager _archiveManager;
    protected readonly Red4ParserService _parserService;
    protected readonly IWatcherService _watcherService;
    protected readonly ExtendedScriptService _scriptService;
    protected readonly IPaneViewModelFactory _paneViewModelFactory;

    private readonly Dictionary<string, object> _hostObjects;

    public WScriptDocumentViewModel(string path,
         IProjectManager projectManager,
        ILoggerService loggerService,
        Red4ParserService parserService,
        IWatcherService watcherService,
        IArchiveManager archiveManager,
        ExtendedScriptService scriptService,
        IPaneViewModelFactory paneViewModelFactory) : base(path)
    {
        _projectManager = projectManager;
        _loggerService = loggerService;
        _parserService = parserService;
        _watcherService = watcherService;
        _archiveManager = archiveManager;
        _scriptService = scriptService;
        _paneViewModelFactory = paneViewModelFactory;

        Extension = "wscript";

        _hostObjects = new() { { "wkit", new WKitUIScripting(_paneViewModelFactory, _loggerService, _projectManager, _archiveManager, _parserService, _watcherService) } };
        GenerateCompletionData();

        LoadDocument(path);

        _scriptService.PropertyChanged += _scriptService_PropertyChanged;
        
    }

    private void _scriptService_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if(e.PropertyName == nameof(ScriptService.IsRunning))
        {
            RunCommand.NotifyCanExecuteChanged();
            StopCommand.NotifyCanExecuteChanged();
        }
    }

    #region properties

    [ObservableProperty]
    private string _text = "";
    
    public string Extension { get; }
    
    [ObservableProperty]
    private bool _isReadOnly;
    
    [ObservableProperty]
    private string? _isReadOnlyReason;
    
    public Dictionary<string, List<(string name, string? desc)>> CompletionData { get; } = new();

    [ObservableProperty]
    private bool _isUIScript;
    
    [ObservableProperty]
    private bool _isNormalScript;

    #endregion

    #region commands

    private bool CanRun() => !_scriptService.IsRunning;
    [RelayCommand(CanExecute = nameof(CanRun))]
    private async void Run() => await _scriptService.ExecuteAsync(Text, _hostObjects, ISettingsManager.GetWScriptDir());

    private bool CanStop() => _scriptService.IsRunning;
    [RelayCommand(CanExecute = nameof(CanStop))]
    private void Stop() => _scriptService.Stop();

    [RelayCommand]
    private void ReloadUI() => _scriptService.RefreshUIScripts();

    #endregion


    private void GenerateCompletionData()
    {
        CompletionData.Clear();

        foreach (var (name, instance) in _hostObjects)
        {
            CompletionData.Add(name, new List<(string name, string? desc)>());

            foreach (var methodInfo in instance.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public))
            {
                if (methodInfo.DeclaringType == typeof(object))
                {
                    continue;
                }

                var descAttr = methodInfo.GetCustomAttribute<DescriptionAttribute>();
                if (descAttr != null)
                {
                    CompletionData[name].Add((methodInfo.Name, descAttr.Description));
                }
                else
                {
                    CompletionData[name].Add((methodInfo.Name, null));
                }
            }
        }
    }

    public override async Task Save(object parameter)
    {
        using var fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
        using var bw = new StreamWriter(fs);
        bw.Write(Text);
        bw.Close();

        SetIsDirty(false);
        LoadDocument(FilePath);

        await Task.CompletedTask;
    }

    public override void SaveAs(object parameter) => throw new NotImplementedException();

    private void LoadDocument(string paramFilePath)
    {
        if (!File.Exists(paramFilePath))
        {
            return;
        }

        // Check file attributes and set to read-only if file attributes indicate that
        if ((File.GetAttributes(paramFilePath) & FileAttributes.ReadOnly) != 0)
        {
            IsReadOnly = true;
            IsReadOnlyReason = "This file cannot be edit because another process is currently writing to it.\n" +
                               "Change the file access permissions or save the file in a different location if you want to edit it.";
        }

        FilePath = paramFilePath;
        GetScriptType(Path.GetFileNameWithoutExtension(paramFilePath));

        Text = File.ReadAllText(FilePath);

        _isInitialized = true;
    }

    private void GetScriptType(string fileName)
    {
        IsUIScript = false;
        IsNormalScript = false;

        if (fileName.StartsWith("ui_"))
        {
            IsUIScript = true;
        }
        else
        {
            IsNormalScript = true;
        }
    }
}