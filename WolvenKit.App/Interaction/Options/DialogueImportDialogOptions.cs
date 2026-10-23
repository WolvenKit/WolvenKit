using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.App.Interaction.Options;

/// <summary>
/// Input parameters for <see cref="DialogueImportDialogViewModel"/>
/// </summary>
public class DialogueImportDialogOptions
{
    public DialogueImportDialogOptions(
        string sceneName,
        IEnumerable<ulong> existingLineLocStrings,
        IEnumerable<ulong> existingOptionLocStrings,
        IEnumerable<SceneActorOption> actors)
    {
        SceneName = sceneName;
        ExistingLineLocStrings = existingLineLocStrings.ToHashSet();
        ExistingOptionLocStrings = existingOptionLocStrings.ToHashSet();
        Actors = actors.ToList();
    }

    /// <summary>Named in the dialog title, so it is clear which scene is being imported into.</summary>
    public string SceneName { get; init; }

    /// <summary>Locstring ids already in the screenplay store's lines. Imports matching one are refused.</summary>
    public HashSet<ulong> ExistingLineLocStrings { get; init; }

    /// <inheritdoc cref="ExistingLineLocStrings"/>
    public HashSet<ulong> ExistingOptionLocStrings { get; init; }

    /// <summary>
    /// The scene's cast, in the order it lists them: what each line's speaker and addressee are
    /// matched against, and what the user picks from when a match wants correcting.
    /// </summary>
    public IReadOnlyList<SceneActorOption> Actors { get; init; }
}
