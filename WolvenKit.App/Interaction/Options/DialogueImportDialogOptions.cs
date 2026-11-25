using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Interaction.Options;

/// <summary>
/// Input parameters for <see cref="DialogueImportDialogViewModel"/>
/// </summary>
public class DialogueImportDialogOptions
{
    /// <param name="sceneName">Scene name displayed in the dialog title.</param>
    /// <param name="existingLines">Existing screenplay dialogue lines.</param>
    /// <param name="existingOptions">Existing screenplay choice options.</param>
    /// <param name="actors">Scene actor choices.</param>
    public DialogueImportDialogOptions(
        string sceneName,
        IEnumerable<scnscreenplayDialogLine> existingLines,
        IEnumerable<scnscreenplayChoiceOption> existingOptions,
        IEnumerable<SceneActorOption> actors)
    {
        SceneName = sceneName;
        Actors = actors.ToList();

        ExistingOptionLocStrings = existingOptions
            .Where(option => option?.LocstringId is not null)
            .Select(option => option.LocstringId.Ruid)
            .ToHashSet();

        var lines = new Dictionary<CRUID, scnscreenplayDialogLine>();

        // The first entry of a locstring keeps it. A store with two is already broken in the way
        // this dialog exists to prevent, and nothing says which was meant.
        foreach (var line in existingLines)
        {
            // Lines without locstring ids cannot be matched to imports.
            if (line?.LocstringId is null)
            {
                continue;
            }

            lines.TryAdd(line.LocstringId.Ruid, line);
        }

        ExistingLines = lines;
    }

    /// <summary>Named in the dialog title, so it is clear which scene is being imported into.</summary>
    public string SceneName { get; init; }

    /// <summary>
    /// Existing screenplay dialogue lines keyed by locstring id.
    /// Matching imports reuse the stored entry.
    /// </summary>
    public IReadOnlyDictionary<CRUID, scnscreenplayDialogLine> ExistingLines { get; init; }

    /// <summary>
    /// Locstring ids already among the screenplay store's choice options. Imports matching one are
    /// refused outright: an option is picked rather than played, so no section can use it either.
    /// </summary>
    public HashSet<CRUID> ExistingOptionLocStrings { get; init; }

    /// <summary>
    /// The scene's cast, in the order it lists them: what each line's speaker and addressee are
    /// matched against, and what the user picks from when a match wants correcting.
    /// </summary>
    public IReadOnlyList<SceneActorOption> Actors { get; init; }
}
