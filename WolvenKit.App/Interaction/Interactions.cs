using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.App.Interaction;

public static class Interactions
{
    // wrappers
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

    // wrappers
    public static async Task<string> ShowInputBoxAsync(string title, string originalName)
    {
        string result = "";
        DispatcherHelper.RunOnMainThread(() => result = AskForTextInput(""));
        return await Task.FromResult(result);
    }

    // wrappers
    public static async Task<string> ShowRenameBoxAsync(string originalName)
    {
        string result = "";
        DispatcherHelper.RunOnMainThread(() => result = Rename(originalName));
        return await Task.FromResult(result);
    }



    // classic popups
    public static Func<(string, string, WMessageBoxImage, WMessageBoxButtons), WMessageBoxResult> ShowConfirmation { get; set; } 
        = _ => throw new NotImplementedException();

    public static Func<IEnumerable<string>, bool> DeleteFiles { get; set; } = _ => throw new NotImplementedException();

    public static Func<string, string> Rename { get; set; } = _ => throw new NotImplementedException();
    public static Func<string, Tuple<string, bool>> RenameAndRefactor { get; set; } = _ => throw new NotImplementedException();

    public static Func<(string, List<string>), List<string>> ShowDeleteFilesList { get; set; } = _ => throw new NotImplementedException();

    public static Func<(string, Dictionary<string, List<string>>), bool> ShowBrokenReferencesList { get; set; } =
        _ => throw new NotImplementedException();

    public static Func<string, string> AskForTextInput { get; set; } = _ => throw new NotImplementedException();

    //custom views
    public static Func<bool> ShowFirstTimeSetup { get; set; } = () => throw new NotImplementedException();
    public static Func<bool> ShowLaunchProfilesView { get; set; } = () => throw new NotImplementedException();
    public static Func<bool> ShowMaterialRepositoryView { get; set; } = () => throw new NotImplementedException();

    public static Func<(IEnumerable<IDisplayable>?, IEnumerable<IDisplayable>?), IEnumerable<IDisplayable>> ShowCollectionView { get; set; } 
        = _ => throw new NotImplementedException();

    public static Func<string?, string?> ShowSelectSaveView { get; set; } =
        (string? currentSaveGame) => throw new NotImplementedException();
}
