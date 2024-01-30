using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Helpers;
using WolvenKit.Modkit.Scripting;

namespace WolvenKit.App.ViewModels.Documents;

public partial class WScriptDocumentViewModel : DocumentViewModel
{
    private readonly AppScriptService _scriptService;

    public WScriptDocumentViewModel(string path, AppScriptService scriptService) : base(path)
    {
        _scriptService = scriptService;

        Extension = "wscript";

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
    private async Task Run() => await _scriptService.ExecuteAsync(Text);

    private bool CanStop() => _scriptService.IsRunning;
    [RelayCommand(CanExecute = nameof(CanStop))]
    private void Stop() => _scriptService.Stop();

    [RelayCommand]
    private void ReloadUI() => _scriptService.RefreshUIScripts();

    #endregion


    private void GenerateCompletionData()
    {
        CompletionData.Clear();

        foreach (var (name, instance) in _scriptService.DefaultHostObject)
        {
            CompletionData.Add(name, new List<(string name, string? desc)>());

            var methods = new Dictionary<string, string?>();
            foreach (var methodInfo in instance.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public))
            {
                if (methodInfo.DeclaringType == typeof(object))
                {
                    continue;
                }

                methods.TryAdd(methodInfo.Name, methodInfo.GetCustomAttribute<DescriptionAttribute>()?.Description);
            }
            methods = methods.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var (methodName, desc) in methods)
            {
                CompletionData[name].Add((methodName, desc));
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
        LastWriteTime = File.GetLastWriteTime(FilePath);

        await Task.CompletedTask;
    }

    public override void SaveAs(object parameter) => throw new NotImplementedException();
    public override bool Reload(bool force)
    {
        if (!File.Exists(FilePath))
        {
            return false;
        }

        if (!force && IsDirty)
        {
            return false;
        }

        Text = File.ReadAllText(FilePath);
        
        SetIsDirty(false);
        LastWriteTime = File.GetLastWriteTime(FilePath);

        return true;
    }

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