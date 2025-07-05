using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Scripting;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.App.Interaction;

public static class Interactions
{
    /// <summary>
    /// Async operation to show a message box
    /// </summary>
    /// <param name="text"></param>
    /// <param name="caption"></param>
    /// <param name="messageBoxButtons"></param>
    /// <param name="image"></param>
    /// <returns></returns>
    public static async Task<WMessageBoxResult> ShowMessageBoxAsync(
        string text,
        string caption,
        WMessageBoxButtons messageBoxButtons = WMessageBoxButtons.OkCancel,
        WMessageBoxImage image = WMessageBoxImage.Question)
    {
        var result = WMessageBoxResult.None;
        DispatcherHelper.RunOnMainThread(() => result = ShowConfirmation((text, caption, image, messageBoxButtons)));
        return await Task.FromResult(result);
    }

    /// <inheritdoc cref="ShowMessageBoxAsync"/>
    /// <returns>the task's result</returns>
    public static WMessageBoxResult ShowMessageBox(
        string text,
        string caption,
        WMessageBoxButtons messageBoxButtons = WMessageBoxButtons.OkCancel,
        WMessageBoxImage image = WMessageBoxImage.Question)
    {
        var result = WMessageBoxResult.None;
        DispatcherHelper.RunOnMainThread(() => result = ShowConfirmation((text, caption, image, messageBoxButtons)));
        return result;
    }

    /// <returns>
    /// <code>
    ///    Yes = Save and close<br/>
    ///     No = Close without saving<br/>
    /// Cancel = Don't close<br/>
    /// </code>
    /// </returns>
    public static async Task<WMessageBoxResult> ShowSaveDialogueAsync(string fileName)
    {
        var result = WMessageBoxResult.None;
        DispatcherHelper.RunOnMainThread(() => result = ShowSaveDialog(fileName));
        return await Task.FromResult(result);
    }

    public static WMessageBoxResult ShowSaveDialogue(string fileName)
    {
        var result = WMessageBoxResult.None;
        DispatcherHelper.RunOnMainThread(() => result = ShowSaveDialog(fileName));
        return result;
    }

    // wrappers
    public static async Task<string> ShowInputBoxAsync(string title, string originalValue)
    {
        var result = "";
        DispatcherHelper.RunOnMainThread(() => result = AskForTextInput((title, originalValue)));
        return await Task.FromResult(result);
    }

    public static async Task<string> ShowRenameBoxAsync(string originalName)
    {
        var result = "";
        DispatcherHelper.RunOnMainThread(() => result = Rename(originalName));
        return await Task.FromResult(result);
    }

    /// <summary>
    /// Shows a message box with an extra button to open a weblink
    /// </summary>
    /// <param name="title">Dialogue title</param>
    /// <param name="message">Dialogue message (auto-wrapping)</param>
    /// <param name="hyperlink">hyperlink URL (no validation)</param>
    /// <param name="buttonText">Optional: Button text (default: Open Wiki)</param>
    /// <param name="image">Optional: Image (default: Information)</param>
    /// <returns>result of the task</returns>
    public static async Task<WMessageBoxResult> ShowPopupWithWeblinkAsync(string title, string message,
        string hyperlink, string buttonText = "Open Wiki", WMessageBoxImage image = WMessageBoxImage.Information)
    {
        var result = WMessageBoxResult.None;
        DispatcherHelper.RunOnMainThread(() =>
            result = ShowPopupWithWeblink((title, message, hyperlink, buttonText, image)));
        return await Task.FromResult(result);
    }

    // classic popups
    public static Func<(string, string, WMessageBoxImage, WMessageBoxButtons), WMessageBoxResult> ShowConfirmation { get; set; } 
        = _ => throw new NotImplementedException();

    public static Func<string, WMessageBoxResult> ShowSaveDialog { get; set; }
        = _ => throw new NotImplementedException();

    /// <inheritdoc cref="ShowPopupWithWeblinkAsync"/>
    public static Func<(string, string, string, string, WMessageBoxImage), WMessageBoxResult> ShowPopupWithWeblink
    {
        get;
        set;
    } = _ => throw new NotImplementedException();

    public static Func<(string, string), bool> ShowQuestionYesNo { get; set; } = _ => throw new NotImplementedException();

    public static Func<IEnumerable<string>, bool> DeleteFiles { get; set; } = _ => throw new NotImplementedException();

    public static Func<string, string> Rename { get; set; } = _ => throw new NotImplementedException();

    public static Func<string, Tuple<string, bool>> RenameAndRefactor { get; set; } = _ => throw new NotImplementedException();

    public static Func<(string, List<string>, Cp77Project), (List<string>, string? moveToPath)> ShowDeleteOrMoveFilesList { get; set; } =
        _ => throw new NotImplementedException();

    public static Func<(List<string>, bool), DeleteOrDuplicateComponentDialogViewModel?>
        ShowDeleteOrDuplicateComponentDialogue { get; set; } =
        _ => throw new NotImplementedException();

    public static Func<(string, IDictionary<string, List<string>>), bool> ShowBrokenReferencesList { get; set; } =
        _ => throw new NotImplementedException();

    public static Func<(string, string), string> AskForTextInput { get; set; } =
        _ => throw new NotImplementedException();

    public static Func<(string, Cp77Project), string> AskForFolderPathInput { get; set; } = _ => throw new NotImplementedException();

    //custom views
    public static Func<bool> ShowFirstTimeSetup { get; set; } = () => throw new NotImplementedException();
    public static Func<bool> ShowLaunchProfilesView { get; set; } = () => throw new NotImplementedException();
    public static Func<bool> ShowMaterialRepositoryView { get; set; } = () => throw new NotImplementedException();

    public static Func<bool> ShowNpvCreationDialogue { get; set; } = () => throw new NotImplementedException();

    public static Func<(IEnumerable<IDisplayable>?, IEnumerable<IDisplayable>?), IEnumerable<IDisplayable>> ShowCollectionView { get; set; } 
        = _ => throw new NotImplementedException();

    public static Func<string?, string?> ShowSelectSaveView { get; set; } =
        (string? currentSaveGame) => throw new NotImplementedException();

    public static Func<(Cp77Project activeProject, ISettingsManager settingsManager), CreatePhotoModeAppViewModel?>
        ShowPhotoModeDialogue { get; set; } = _ => throw new NotImplementedException();

    public static Func<ScriptSettingsDictionary, bool> ShowScriptSettingsView { get; set; } = _ => throw new NotImplementedException();

    public static Func<Cp77Project, AddInkatlasDialogViewModel> ShowGenerateInkatlasDialogue { get; set; } =
        _ => throw new NotImplementedException();
}
