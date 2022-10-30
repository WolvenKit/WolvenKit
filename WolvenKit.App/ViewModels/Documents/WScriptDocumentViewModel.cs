using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Utils;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.Scripting;

namespace WolvenKit.ViewModels.Documents;

public partial class WScriptDocumentViewModel : DocumentViewModel
{
    private readonly ILoggerService _loggerService;
    private readonly ScriptService _scriptService;

    public WScriptDocumentViewModel(string path) : base(path)
    {
        Document = new TextDocument();
        Extension = "wsc";

        _loggerService = Locator.Current.GetService<ILoggerService>();
        _scriptService = Locator.Current.GetService<ScriptService>();
    }

    [Reactive] public TextDocument Document { get; set; }
    [Reactive] public string Extension { get; set; }
    [Reactive] public bool IsReadOnly { get; set; }
    [Reactive] public string IsReadOnlyReason { get; set; }

    [RelayCommand]
    private void Run()
    {
        _scriptService.Execute(Document.Text, new Dictionary<string, object> {{"wkit", new WKitUIScripting(_loggerService)}});
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
            IsReadOnlyReason = "This file cannot be edit because another process is currently writting to it.\n" +
                               "Change the file access permissions or save the file in a different location if you want to edit it.";
        }

        using (var fs = new FileStream(paramFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
        using (var fr = FileReader.OpenStream(fs, Encoding.UTF8))
        {
            Document = new TextDocument(fr.ReadToEnd());
        }

        FilePath = paramFilePath;

        if (string.IsNullOrEmpty(Document.Text))
        {
            return;
        }
    }
}