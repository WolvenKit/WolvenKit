using System;
using System.IO;
using System.Windows;
using WolvenKit.App.Extensions;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Common.Conversion;
using WolvenKit.RED4.CR2W.JSON;

namespace WolvenKit.App.Scripting;

/// <summary>
/// TODO
/// </summary>
public class ScriptDocumentWrapper
{
    private readonly IDocumentViewModel _documentViewModel;
    private readonly AppViewModel _appViewModel;

    public ScriptDocumentWrapper(IDocumentViewModel documentViewModel, AppViewModel appViewModel)
    {
        _documentViewModel = documentViewModel;
        _appViewModel = appViewModel;

        FilePath = _documentViewModel.FilePath;
        FileName = Path.GetFileName(FilePath);
        Extension = Path.GetExtension(FilePath).Replace(".", "");

        if (documentViewModel is DocumentViewModel doc)
        {
            IsDirty = doc.IsDirty;
        }
    }

    public string FilePath { get; }
    public string FileName { get; }
    public string Extension { get; }

    public bool IsDirty { get; set; }

    /// <summary>
    /// Gets the game file
    /// </summary>
    /// <param name="type">The output type of the game file ("cr2w" or "json")</param>
    /// <returns></returns>
    /// <exception cref="NotSupportedException"></exception>
    public object? GetGameFile(string type)
    {
        if (_documentViewModel is not RedDocumentViewModel red)
        {
            return null;
        }

        if (type == "cr2w")
        {
            return red.Cr2wFile;
        }

        if (type == "json")
        {
            var dto = new RedFileDto(red.Cr2wFile);
            return RedJsonSerializer.Serialize(dto);
        }

        throw new NotSupportedException($"Unknown type \"{type}\"");
    }

    /// <summary>
    /// Saves the document
    /// </summary>
    public void Save() => _documentViewModel.SaveCommand.SafeExecute();

    /// <summary>
    /// Closes the document without saving
    /// </summary>
    public void Close() => Application.Current.Dispatcher.Invoke(() => _appViewModel.CloseFile(_documentViewModel));
}