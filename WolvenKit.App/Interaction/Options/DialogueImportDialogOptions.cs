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
        IEnumerable<ExistingSceneLine> existingLines,
        IEnumerable<ulong> existingOptionLocStrings,
        IEnumerable<SceneActorOption> actors)
    {
        SceneName = sceneName;
        ExistingOptionLocStrings = existingOptionLocStrings.ToHashSet();
        Actors = actors.ToList();

        var lines = new Dictionary<ulong, ExistingSceneLine>();

        // The first entry of a locstring keeps it. A store with two is already broken in the way
        // this dialog exists to prevent, and nothing says which was meant.
        foreach (var line in existingLines)
        {
            lines.TryAdd(line.LocStringId, line);
        }

        ExistingLines = lines;
    }

    /// <summary>Named in the dialog title, so it is clear which scene is being imported into.</summary>
    public string SceneName { get; init; }

    /// <summary>
    /// The screenplay lines the scene already carries, by locstring id. An import matching one is
    /// never written again, but the user may still take it for a section to play - hence the item
    /// id and actors.
    /// </summary>
    public IReadOnlyDictionary<ulong, ExistingSceneLine> ExistingLines { get; init; }

    /// <summary>
    /// Locstring ids already among the screenplay store's choice options. Imports matching one are
    /// refused outright: an option is picked rather than played, so no section can use it either.
    /// </summary>
    public HashSet<ulong> ExistingOptionLocStrings { get; init; }

    /// <summary>
    /// The scene's cast, in the order it lists them: what each line's speaker and addressee are
    /// matched against, and what the user picks from when a match wants correcting.
    /// </summary>
    public IReadOnlyList<SceneActorOption> Actors { get; init; }
}
