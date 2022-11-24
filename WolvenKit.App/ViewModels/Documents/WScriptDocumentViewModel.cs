using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Utils;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;

namespace WolvenKit.ViewModels.Documents;

public partial class WScriptDocumentViewModel : DocumentViewModel
{
    private readonly ILoggerService _loggerService;
    private readonly ExtendedScriptService _scriptService;

    private readonly Dictionary<string, object> _hostObjects;

    public WScriptDocumentViewModel(string path) : base(path)
    {
        Document = new TextDocument();
        Extension = "wscript";

        _loggerService = Locator.Current.GetService<ILoggerService>();
        _scriptService = Locator.Current.GetService<ExtendedScriptService>();

        _hostObjects = new() { { "wkit", new WKitUIScripting(_loggerService) } };
        GenerateCompletionData();

        this.WhenAnyValue(x => x._scriptService.IsRunning)
            .Subscribe(_ =>
            {
                RunCommand.NotifyCanExecuteChanged();
                StopCommand.NotifyCanExecuteChanged();
            });
    }

    [Reactive] public TextDocument Document { get; set; }
    public string Extension { get; }
    [Reactive] public bool IsReadOnly { get; set; }
    [Reactive] public string IsReadOnlyReason { get; set; }
    public Dictionary<string, List<(string name, string desc)>> CompletionData { get; } = new();

    [Reactive] public bool IsUIScript { get; set; }
    [Reactive] public bool IsNormalScript { get; set; }

    [RelayCommand(CanExecute = nameof(CanRun))]
    private async void Run()
    {
        var code = Document.Text;

        await _scriptService.ExecuteAsync(code, _hostObjects, ISettingsManager.GetWScriptDir());
    }
    private bool CanRun() => !_scriptService.IsRunning;

    [RelayCommand(CanExecute = nameof(CanStop))]
    private void Stop()
    {
        _scriptService.Stop();
    }
    private bool CanStop() => _scriptService.IsRunning;

    [RelayCommand]
    private void ReloadUI()
    {
        _scriptService.RefreshUIScripts();
    }

    private void GenerateCompletionData()
    {
        CompletionData.Clear();

        foreach (var (name, instance) in _hostObjects)
        {
            CompletionData.Add(name, new List<(string name, string desc)>());

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

    public override Task<bool> OpenFileAsync(string path)
    {
        _isInitialized = false;

        LoadDocument(path);

        ContentId = path;
        FilePath = path;
        _isInitialized = true;

        return Task.FromResult(true);
    }

    public override bool OpenFile(string path)
    {
        _isInitialized = false;

        LoadDocument(path);

        ContentId = path;
        FilePath = path;
        _isInitialized = true;

        return true;
    }

    public override Task OnSave(object parameter)
    {
        using var fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
        using var bw = new StreamWriter(fs);
        bw.Write(Document.Text);

        SetIsDirty(false);

        return Task.CompletedTask;
    }

    private void LoadDocument(string paramFilePath)
    {
        if (!File.Exists(paramFilePath))
        {
            return;
        }

        Document = new TextDocument();

        // Check file attributes and set to read-only if file attributes indicate that
        if ((File.GetAttributes(paramFilePath) & FileAttributes.ReadOnly) != 0)
        {
            IsReadOnly = true;
            IsReadOnlyReason = "This file cannot be edit because another process is currently writing to it.\n" +
                               "Change the file access permissions or save the file in a different location if you want to edit it.";
        }

        using (var fs = new FileStream(paramFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
        using (var fr = FileReader.OpenStream(fs, Encoding.UTF8))
        {
            Document = new TextDocument(fr.ReadToEnd());
        }

        FilePath = paramFilePath;
        GetScriptType(Path.GetFileNameWithoutExtension(paramFilePath));

        if (string.IsNullOrEmpty(Document.Text))
        {
            return;
        }
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