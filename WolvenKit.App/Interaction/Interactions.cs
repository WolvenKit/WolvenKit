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
        DispatcherHelper.RunOnMainThread(() => result = ShowSaveUnsavedChangesDialog(fileName));
        return await Task.FromResult(result);
    }

    public static WMessageBoxResult ShowSaveDialogue(string fileName)
    {
        var result = WMessageBoxResult.None;
        DispatcherHelper.RunOnMainThread(() => result = ShowSaveUnsavedChangesDialog(fileName));
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
    public static async Task<WMessageBoxResult> ShowPopupWithWeblinkAsync(
        string title,
        string message,
        string hyperlink,
        string buttonText = "Open Wiki",
        WMessageBoxImage image = WMessageBoxImage.Information)
    {
        var result = WMessageBoxResult.None;
        DispatcherHelper.RunOnMainThread(() =>
            result = ShowPopupWithWeblink((title, message, hyperlink, buttonText, image)));
        return await Task.FromResult(result);
    }

    /// <summary>
    /// A classic popup message. For a yes/no question, use <see cref="ShowQuestionYesNo"/>.
    /// </summary>
    /// <returns><see cref="WMessageBoxResult"/> based on button parameters/></returns>
    public static Func<
        (string text, string caption, WMessageBoxImage image, WMessageBoxButtons buttons),
        WMessageBoxResult
    > ShowConfirmation { get; set; } = _ => throw new NotImplementedException();

    /// <summary>
    /// Asks the user whether they want to save unsaved changes.
    /// </summary>
    /// <returns>Yes/No/Cancel</returns>
    public static Func<string, WMessageBoxResult> ShowSaveUnsavedChangesDialog { get; set; }
        = _ => throw new NotImplementedException();

    /// <inheritdoc cref="ShowPopupWithWeblinkAsync"/>
    public static Func<(string, string, string, string, WMessageBoxImage), WMessageBoxResult> ShowPopupWithWeblink
    {
        get;
        set;
    } = _ => throw new NotImplementedException();

    /// <summary>
    /// This calls <see cref="ShowConfirmation"/> with default image and buttons.
    /// </summary>
    /// <returns>true if the user pressed OK, false otherwise</returns>
    public static Func<(string text, string caption), bool> ShowQuestionYesNo { get; set; } =
        _ => throw new NotImplementedException();

    /// <summary>
    /// User warning: "The selected item(s) will be moved to the Recycle Bin"
    /// </summary>
    public static Func<IEnumerable<string>, bool> DeleteFiles { get; set; } = _ => throw new NotImplementedException();

    /// <summary>
    /// Shows a rename dialogue.
    /// </summary>
    /// <param>Pass previous value</param>
    public static Func<string, string> Rename { get; set; } = _ => throw new NotImplementedException();


    /// <summary>
    /// Shows a rename dialogue with an optional refactor checkbox.
    /// </summary>
    /// <param>Pass the current value, and a flag if the checkbox should siplay or not</param>
    public static Func<(string currentPath, bool showCheckbox), Tuple<string, bool>> RenameAndRefactor { get; set; } =
        _ => throw new NotImplementedException();

    /// <summary>
    /// Displays DeleteOrMoveFilesListDialogView. Experimental feature.
    /// </summary>
    public static Func<
        (string title, List<string> files, Cp77Project currentProject),
        (List<string>, string? moveToPath)
    > ShowDeleteOrMoveFilesList { get; set; } = _ => throw new NotImplementedException();

    /// <summary>
    /// Asks user whether to delete or duplicate components by name. Select functionality by flag.
    /// </summary>
    public static Func<(List<string> componentNames, bool isDeleting), DeleteOrDuplicateComponentDialogViewModel?>
        ShowDeleteOrDuplicateComponentDialogue { get; set; } = _ => throw new NotImplementedException();

    /// <summary>
    /// Display dictionary of {relativePath => brokenReferences[]} in a dialogue.
    /// </summary>
    public static Func<(string, IDictionary<string, List<string>>), bool> ShowBrokenReferencesList { get; set; } =
        _ => throw new NotImplementedException();

    /// <summary>
    /// Ask user for text input. Provide second argument to set a default value for input field.
    /// </summary>
    public static Func<(string dialogueTitle, string defaultValue), string> AskForTextInput { get; set; } =
        _ => throw new NotImplementedException();


    /// <summary>
    /// Ask user for folder path. Will enforce validity for path-type arguments and check if directory exists.
    /// </summary>
    public static Func<(string, Cp77Project), string> AskForFolderPathInput { get; set; } = _ => throw new NotImplementedException();

    public static Func<( List<string> options, string? title, string? text, string? helpLink, bool? showInputBar, string
        ? buttonText),
        string> AskForDropdownOption { get; set; } = _ => throw new NotImplementedException();

    //custom views
    public static Func<bool> ShowFirstTimeSetup { get; set; } = () => throw new NotImplementedException();
    public static Func<bool> ShowLaunchProfilesView { get; set; } = () => throw new NotImplementedException();
    public static Func<bool> ShowMaterialRepositoryView { get; set; } = () => throw new NotImplementedException();

    public static Func<(IEnumerable<IDisplayable>? availableItems, IEnumerable<IDisplayable>? selectedItems),
        IEnumerable<IDisplayable>> ShowCollectionView { get; set; } = _ => throw new NotImplementedException();

    public static Func<string?, string?> ShowSelectSaveView { get; set; } =
        (string? currentSaveGame) => throw new NotImplementedException();

    /// <summary>
    /// Shows dialogue to create photo mode files. Complex logic inside dialogue model.
    /// </summary>
    public static Func<(Cp77Project activeProject, ISettingsManager settingsManager), CreatePhotoModeAppViewModel?>
        ShowPhotoModeDialogue { get; set; } = _ => throw new NotImplementedException();


    /// <summary>
    /// Shows script settings overlay
    /// </summary>
    public static Func<ScriptSettingsDictionary, bool> ShowScriptSettingsView { get; set; } = _ => throw new NotImplementedException();

    /// <summary>
    /// Shows dialogue to generate .inkatlas file. Complex logic inside dialogue model.
    /// </summary>
    public static Func<Cp77Project, AddInkatlasDialogViewModel> ShowGenerateInkatlasDialogue { get; set; } =
        _ => throw new NotImplementedException();

    /// <summary>
    /// Shows dialogue to pick from a list of options.
    /// </summary>
    public static Func<(
        Dictionary<string, bool> checklistOptions,
        string title,
        string text,
        string inputFieldLabel,
        string inputFieldDefaultValue
        ), ShowChecklistDialogViewModel> ShowChecklistDialogue { get; set; } = _ => throw new NotImplementedException();

    /// <summary>
    /// Shows dialogue to generate default quest files. Complex logic inside dialogue model.
    /// </summary>
    public static Func<Cp77Project, AddQuestDialogViewModel> ShowGenerateQuestDialogue { get; set; } =
        project => new AddQuestDialogViewModel(project);
}
