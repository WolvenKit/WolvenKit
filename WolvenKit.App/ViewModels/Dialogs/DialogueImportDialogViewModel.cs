using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction.Options;
using WolvenKit.RED4.Types;
using Clipboard = System.Windows.Clipboard;

namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// A line the user is taking, with the actors they settled on for it. The names an export carries
/// are only a starting point: the dialog matches them against the scene's cast and the user has the
/// last word, so what comes back out is actor ids, not names.
/// </summary>
public sealed class DialogueImportSelection
{
    public required ImportedDialogueLine Line { get; init; }

    /// <summary>Actor to write as the line's speaker, or null to leave it unset.</summary>
    public scnActorId? Speaker { get; init; }

    /// <inheritdoc cref="Speaker"/>
    public scnActorId? Addressee { get; init; }

    /// <summary>
    /// Existing screenplay entry for this line, or null for a new line.
    /// Section events reuse this entry instead of creating a duplicate.
    /// </summary>
    public scnscreenplayDialogLine? ExistingLine { get; init; }

    /// <summary>Whether an existing screenplay entry was matched.</summary>
    public bool IsAlreadyInScene => ExistingLine is not null;

    /// <summary>
    /// The line as a section plays it. Length and voiceover parameters come off the export; the
    /// actors are the user's answer above.
    /// </summary>
    /// <param name="screenplayLineId">
    /// The item id the line is in the screenplay store under. A section binds to its lines by item
    /// id alone, so this must be the id actually written.
    /// </param>
    public SectionDialogueLine ToSectionLine(scnscreenplayItemId screenplayLineId) => new()
    {
        ScreenplayLineId = screenplayLineId,
        Speaker = Speaker,
        Addressee = Addressee,
        DurationMs = Line.DurationMs,
        StartTimeMs = Line.StartTimeMs,
        Text = Line.EmbeddedText,
        VoContext = Line.VoContext,
        VoExpression = Line.VoExpression
    };
}

/// <summary>
/// One line of an import, with what the scene already knows about it. A line whose locstring id is
/// in the scene cannot be taken again: importing it a second time would leave two screenplay
/// entries pointing at one recording, which is the one thing the scene editor cannot tell apart
/// afterwards.
/// </summary>
public partial class DialogueImportEntryViewModel : ObservableObject
{
    /// <param name="line">Imported line data.</param>
    /// <param name="isDuplicate">Whether the locstring id already exists.</param>
    /// <param name="existingLine">Existing screenplay entry, when matched.</param>
    /// <param name="actorOptions">Available actor choices.</param>
    /// <param name="resolver">Speaker-name resolver.</param>
    public DialogueImportEntryViewModel(
        ImportedDialogueLine line,
        bool isDuplicate,
        scnscreenplayDialogLine? existingLine,
        IReadOnlyList<SceneActorOption> actorOptions,
        DialogueSpeakerResolver resolver)
    {
        Line = line;
        IsDuplicate = isDuplicate;
        ExistingLine = existingLine;
        ActorOptions = actorOptions;

        // A line already in the scene starts unticked: it is only worth taking for a section.
        IsSelected = !isDuplicate;

        if (existingLine is not null)
        {
            // The scene's answer, not the export's: the entry is not being rewritten.
            _speakerActor = FindActor(existingLine.Speaker, actorOptions);
            _addresseeActor = FindActor(existingLine.Addressee, actorOptions);
        }
        else
        {
            // What the export says, matched against the scene's cast. Anything unmatched is left on
            // "no actor", the same as a line added by hand.
            _speakerActor = resolver.Resolve(line.Speaker) ?? SceneActorOption.None;
            _addresseeActor = resolver.Resolve(line.Addressee) ?? SceneActorOption.None;
        }
    }

    public ImportedDialogueLine Line { get; }

    /// <summary>Whether the scene already carries a screenplay entry for this locstring id.</summary>
    public bool IsDuplicate { get; }

    /// <summary>
    /// The entry the scene already carries for this line. Null for a new line, and for a choice
    /// option - nothing plays an option, so there is nothing to do with one the scene has.
    /// </summary>
    public scnscreenplayDialogLine? ExistingLine { get; }

    /// <summary>
    /// Whether taking this line only feeds a section, leaving the screenplay store alone. The scene
    /// already has the entry, and writing it again would put two entries on one recording.
    /// </summary>
    public bool IsSectionOnly => ExistingLine is not null;

    /// <summary>
    /// Whether the entry the scene has carries no item id yet. Taking the line gives it one, since
    /// a section's event has to have something to point at.
    /// </summary>
    public bool NeedsItemId =>
        ExistingLine is not null && !SceneEditingHelper.HasAssignedItemId(ExistingLine.ItemId);

    /// <summary>
    /// Whether the line is the user's to take. A duplicate line is, for a section's sake; a
    /// duplicate choice option is not, since no section plays one.
    /// </summary>
    public bool CanImport => !IsDuplicate || IsSectionOnly;

    [ObservableProperty] private bool _isSelected;

    /// <summary>The scene's cast, shared by every row: one list, one set of dropdown items.</summary>
    public IReadOnlyList<SceneActorOption> ActorOptions { get; }

    [ObservableProperty] private SceneActorOption _speakerActor;

    [ObservableProperty] private SceneActorOption _addresseeActor;

    /// <summary>
    /// Whether this line's actors are the user's to set. The store keeps no speaker for a choice
    /// option, and a line the scene already has is shown as the scene has it, not rewritten.
    /// </summary>
    public bool CanSetActors => !Line.IsChoiceOption && !IsSectionOnly;

    public string LocStringId => Line.LocStringId.ToString();

    /// <summary>What the export called the speaker, kept where the user can check the match.</summary>
    public string SpeakerToolTip => DescribeActor("speaker", Line.Speaker);

    public string AddresseeToolTip => DescribeActor("addressee", Line.Addressee);

    public string Text => string.IsNullOrEmpty(Line.EmbeddedText) ? "(no text)" : Line.EmbeddedText;

    /// <summary>
    /// Whether the line is worded for the player's gender. Worth saying because only one of the two
    /// wordings can be embedded: a locstore descriptor is keyed on locstring, locale and gender, and
    /// the scene editor writes one under "both".
    /// </summary>
    public bool HasGenderedText => Line.HasGenderedText;

    /// <summary>
    /// The line in full, with both wordings where it has two. The column itself is one line high and
    /// trimmed, so this is where a line long enough to be cut off can actually be read.
    /// </summary>
    public string TextToolTip
    {
        get
        {
            if (!HasGenderedText)
            {
                return Text;
            }

            return $"""
                Female V: {Line.FemaleText}
                Male V: {Line.MaleText}

                Only the first is embedded - the scene's locstore keeps one text per line. Leave
                "Embed the text into the scene" off to let the game use its own, which has both.
                """;
        }
    }

    /// <summary>
    /// The lipsync animations, named per recorded variant: the index knows a female name for
    /// nearly every line and a male one for only a few, so which is which has to be said.
    /// </summary>
    public string LipsyncAnimNames
    {
        get
        {
            var names = new List<string>(2);

            if (!string.IsNullOrEmpty(Line.FemaleLipsyncAnim))
            {
                names.Add($"F: {Line.FemaleLipsyncAnim}");
            }

            if (!string.IsNullOrEmpty(Line.MaleLipsyncAnim))
            {
                names.Add($"M: {Line.MaleLipsyncAnim}");
            }

            return names.Count > 0 ? string.Join("  ", names) : "—";
        }
    }

    public string Status => NeedsItemId
        ? "In scene - needs item id"
        : IsSectionOnly
            ? "In scene - section only"
            : IsDuplicate
                ? "Already in scene"
                : Line.IsChoiceOption
                    ? "New choice option"
                    : "New line";

    /// <summary>
    /// What taking this line would do, where the row has no room to say it. Worth explaining for a
    /// line the scene already has, since ticking it looks like an import and is not.
    /// </summary>
    public string StatusToolTip => NeedsItemId
        ? "This line is already in the scene, but its screenplay entry carries no item id. Select it to give the entry an item id."
        : IsSectionOnly
            ? "This line is already in the scene. Select it to append it to a new section."
            : IsDuplicate
                ? "The scene already has this choice option. An option is picked rather than " +
                  "played, so there is nothing a section could do with it either."
                : "This line is not in the scene yet and will be added to the screenplay store.";

    /// <summary>
    /// Where a row's actor came from: the entry the scene has, or the name the export gave.
    /// </summary>
    private string DescribeActor(string role, string exportedName)
    {
        if (IsSectionOnly)
        {
            return $"The scene's own {role} for this line, which the import does not change";
        }

        return string.IsNullOrEmpty(exportedName)
            ? $"The export names no {role} for this line"
            : $"The export names \"{exportedName}\" as the {role}";
    }

    /// <summary>The dropdown entry for an actor id, or "no actor" where there is none.</summary>
    /// <param name="actorId">The actor id to find.</param>
    /// <param name="actorOptions">Available actor choices.</param>
    private static SceneActorOption FindActor(
        scnActorId? actorId, IReadOnlyList<SceneActorOption> actorOptions)
    {
        if (actorId is null || actorId.Id == SceneActorOption.NoActorId)
        {
            return SceneActorOption.None;
        }

        // An id the scene's cast no longer runs to shows as unset: the dropdown can only offer
        // actors the scene has.
        return actorOptions.FirstOrDefault(option => option.ActorId == actorId.Id) ??
               SceneActorOption.None;
    }
}

/// <summary>
/// ViewModel for the dialogue import dialog: takes an export written by another tool (the Dialogue
/// Browser CET mod writes one from its conversation panel), says what is in it, and hands back the
/// lines the user picked.
/// </summary>
public partial class DialogueImportDialogViewModel : DialogViewModel
{
    private readonly IReadOnlyDictionary<CRUID, scnscreenplayDialogLine> _existingLines;
    private readonly HashSet<CRUID> _existingOptionLocStrings;
    private readonly DialogueSpeakerResolver _speakerResolver;

    /// <summary>Where the payload being read came from, named once in the status line.</summary>
    private string _sourceName = "";

    /// <summary>What the list was last built from, which is what makes an edit to the box stale.</summary>
    private string _readJson = "";

    /// <summary>
    /// Whether the list is being rebuilt or set wholesale. The counts are worth one pass at the end
    /// of that rather than one per line, which is what a handler per entry and per collection change
    /// would otherwise cost on every load and every Select all.
    /// </summary>
    private bool _isUpdatingEntries;

    public DialogueImportDialogViewModel(DialogueImportDialogOptions dialogOptions)
    {
        _existingLines = dialogOptions.ExistingLines;
        _existingOptionLocStrings = dialogOptions.ExistingOptionLocStrings;
        _speakerResolver = new DialogueSpeakerResolver(dialogOptions.Actors);

        // "No actor" leads the list: it is what an unmatched line starts on, and what a user takes
        // back to when the scene has nobody for a line.
        ActorOptions = [SceneActorOption.None, .. dialogOptions.Actors];

        Title = string.IsNullOrEmpty(dialogOptions.SceneName)
            ? "Import Dialogue"
            : $"Import Dialogue - {dialogOptions.SceneName}";

        Entries.CollectionChanged += OnEntriesChanged;
    }

    public ObservableCollection<DialogueImportEntryViewModel> Entries { get; } = [];

    /// <summary>The scene's cast as every row's dropdown offers it, "no actor" first.</summary>
    public IReadOnlyList<SceneActorOption> ActorOptions { get; }

    public string Title { get; set; }

    /// <summary>
    /// Where the mod writes its exports, named in the introduction and opened by the file picker.
    /// </summary>
    public string ExportFolderPath { get; } =
        Path.Combine("Cyberpunk 2077", DialogueImportHelper.ExportDirectoryRelativePath);

    /// <summary>
    /// The payload itself. Read when the user asks for it rather than on every keystroke: rebuilding
    /// the list throws away every speaker, addressee and checkbox they have set, so re-reading is
    /// theirs to ask for. The paste and load buttons are that ask; typing in the box is not.
    /// </summary>
    [ObservableProperty] private string _jsonText = "";

    /// <summary>Whether the box holds something other than what the list was built from.</summary>
    [ObservableProperty] private bool _isPayloadStale;

    /// <summary>What the import says about itself: where it came from, and how much of it is new.</summary>
    [ObservableProperty] private string _statusMessage =
        "Paste an export from the Dialogue Browser, or load one from a file.";

    [ObservableProperty] private bool _isStatusError;

    /// <summary>
    /// What the export called the conversation. Names the section node, so it can be found in the
    /// graph afterwards.
    /// </summary>
    [ObservableProperty] private string _conversationName = "";

    /// <summary>
    /// Whether the lines' text is embedded into the scene's locstore. Without it the scene points
    /// at recordings whose subtitles live in the game's own string tables, which is what a scene
    /// referencing existing dialogue wants; with it the text travels with the scene.
    /// </summary>
    [ObservableProperty] private bool _createEmbeddedText = true;

    /// <summary>
    /// Whether the conversation is laid out as a section node as well as written to the screenplay
    /// store. On by default: lines in the store with nothing playing them is half an import. A user
    /// who wants only the store entries unticks it.
    /// </summary>
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CanImport))]
    private bool _createSectionNode = true;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(HasEntries))]
    private int _entryCount;

    /// <summary>Rows the user has ticked, of either kind.</summary>
    [ObservableProperty] private int _selectedCount;

    /// <summary>Ticked rows that will be written to the screenplay store.</summary>
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CanImport))]
    private int _selectedNewCount;

    /// <summary>
    /// Ticked rows the scene already has, which are worth taking only for a section to play.
    /// </summary>
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CanImport))]
    [NotifyPropertyChangedFor(nameof(HasSectionOnlySelection))]
    private int _selectedExistingCount;

    [ObservableProperty] private int _duplicateCount;

    public bool HasEntries => EntryCount > 0;

    /// <summary>Whether the user has taken a line that only a section could use.</summary>
    public bool HasSectionOnlySelection => SelectedExistingCount > 0;

    /// <summary>
    /// Whether there is anything for the import to do. Lines the scene already has count only when a
    /// section is being built.
    /// </summary>
    public bool CanImport => SelectedNewCount > 0 || (CreateSectionNode && SelectedExistingCount > 0);

    partial void OnJsonTextChanged(string value) => IsPayloadStale = value != _readJson;

    /// <summary>Reads what is in the payload box, at the user's asking.</summary>
    [RelayCommand]
    private void ReadPayload() => LoadPayload(JsonText);

    /// <summary>Puts the dialog back where it started, payload box and all.</summary>
    [RelayCommand]
    private void Clear()
    {
        JsonText = "";
        LoadPayload("");
    }

    /// <summary>
    /// Reads a payload into the list. Anything already listed is dropped first: a second paste
    /// replaces an import rather than adding to it.
    /// </summary>
    public void LoadPayload(string? json)
    {
        // Named by whoever handed it over, and only for as long as it is theirs: an edit in the
        // payload box afterwards is nobody's file.
        var sourceName = _sourceName;
        _sourceName = "";

        _readJson = json ?? "";
        IsPayloadStale = JsonText != _readJson;

        // One pass over the counts at the end rather than one per line cleared and one per line
        // added, each of which walks the whole list twice.
        _isUpdatingEntries = true;

        try
        {
            RebuildEntries(json, sourceName);
        }
        finally
        {
            _isUpdatingEntries = false;
        }

        RefreshCounts();
    }

    /// <summary>
    /// The list itself, dropped and built back up. Only ever called with the counts held, which is
    /// what <see cref="LoadPayload"/> is for.
    /// </summary>
    private void RebuildEntries(string? json, string sourceName)
    {
        foreach (var entry in Entries)
        {
            entry.PropertyChanged -= OnEntryPropertyChanged;
        }

        Entries.Clear();

        ConversationName = "";

        if (string.IsNullOrWhiteSpace(json))
        {
            SetStatus("Paste an export from the Dialogue Browser, or load one from a file.", false);
            return;
        }

        var payload = DialogueImportHelper.Parse(json);

        if (!payload.IsValid)
        {
            SetStatus(payload.Error ?? "Could not read the import.", true);
            return;
        }

        ConversationName = payload.ConversationName;

        foreach (var line in payload.Lines)
        {
            // Options are looked up among options and lines among lines: the two halves of the
            // store number themselves apart.
            var existingLine = line.IsChoiceOption ? null : FindExistingLine(line.LocStringId);

            var isDuplicate = line.IsChoiceOption
                ? _existingOptionLocStrings.Contains(line.LocStringId)
                : existingLine is not null;

            var entry = new DialogueImportEntryViewModel(
                line, isDuplicate, existingLine, ActorOptions, _speakerResolver);

            entry.PropertyChanged += OnEntryPropertyChanged;
            Entries.Add(entry);
        }

        SetStatus(DescribePayload(payload, sourceName), false);
    }

    /// <summary>
    /// Takes a payload, named by where it came from. Reads it itself rather than leaving that to
    /// <see cref="JsonText"/> so that handing over the same thing twice still reports itself - the
    /// property only raises a change when the text differs.
    /// </summary>
    public void SetPayload(string json, string sourceName)
    {
        _sourceName = sourceName;
        JsonText = json;
        LoadPayload(json);
    }

    [RelayCommand]
    private void PasteFromClipboard()
    {
        try
        {
            if (!Clipboard.ContainsText())
            {
                SetStatus("There is no text on the clipboard.", true);
                return;
            }

            SetPayload(Clipboard.GetText(), "the clipboard");
        }
        catch (Exception ex)
        {
            SetStatus($"Could not read the clipboard: {ex.Message}", true);
        }
    }

    /// <summary>Reads a payload off disk. The view picks the file; this reads it.</summary>
    public void LoadFile(string path)
    {
        try
        {
            SetPayload(File.ReadAllText(path), Path.GetFileName(path));
        }
        catch (Exception ex)
        {
            SetStatus($"Could not read {Path.GetFileName(path)}: {ex.Message}", true);
        }
    }

    [RelayCommand]
    private void SelectAll() => SetSelection(true);

    [RelayCommand]
    private void SelectNone() => SetSelection(false);

    /// <summary>
    /// The lines the user settled on, in conversation order, each with the actors they left it
    /// pointing at. A line the scene already has comes back flagged, which tells the import to play
    /// it rather than write it again.
    /// </summary>
    /// <remarks>
    /// A duplicate choice option is filtered out here as well as locked in the list, so nothing gets
    /// in by way of a payload swapped out from under the selection.
    /// </remarks>
    public List<DialogueImportSelection> GetLinesToImport() =>
        Entries
            .Where(entry => entry.IsSelected && entry.CanImport)
            .Select(entry => new DialogueImportSelection
            {
                Line = entry.Line,
                Speaker = ActorIdOf(entry.SpeakerActor),
                Addressee = ActorIdOf(entry.AddresseeActor),
                ExistingLine = entry.ExistingLine
            })
            .ToList();

    /// <summary>The entry the scene has for a locstring, or null where it has none.</summary>
    /// <param name="locStringId">The locstring id to look up.</param>
    private scnscreenplayDialogLine? FindExistingLine(CRUID locStringId) =>
        _existingLines.TryGetValue(locStringId, out var existingLine) ? existingLine : null;

    /// <summary>An actor id to write, or null where the user left the line unassigned.</summary>
    /// <param name="option">Selected actor option.</param>
    private static scnActorId? ActorIdOf(SceneActorOption? option) =>
        option is null || option.IsNone ? null : new scnActorId { Id = option.ActorId };

    private void SetSelection(bool isSelected)
    {
        // Recomputing per row would give the same counts, so take them once at the end.
        _isUpdatingEntries = true;

        try
        {
            foreach (var entry in Entries.Where(entry => entry.CanImport))
            {
                entry.IsSelected = isSelected;
            }
        }
        finally
        {
            _isUpdatingEntries = false;
        }

        RefreshCounts();
    }

    private void SetStatus(string message, bool isError)
    {
        StatusMessage = message;
        IsStatusError = isError;
    }

    private static string DescribePayload(DialogueImportPayload payload, string sourceName)
    {
        var message = $"{payload.Lines.Count} line{(payload.Lines.Count == 1 ? "" : "s")}";

        if (!string.IsNullOrEmpty(payload.ConversationName))
        {
            message += $" from \"{payload.ConversationName}\"";
        }

        if (!string.IsNullOrEmpty(payload.Source))
        {
            message += $" ({payload.Source})";
        }

        if (!string.IsNullOrEmpty(sourceName))
        {
            message += $", read from {sourceName}";
        }

        if (payload.SkippedCount > 0)
        {
            message += $". {payload.SkippedCount} entr{(payload.SkippedCount == 1 ? "y" : "ies")} " +
                       "had no usable locstring id and were dropped";
        }

        return message + ".";
    }

    private void RefreshCounts()
    {
        if (_isUpdatingEntries)
        {
            return;
        }

        var duplicates = 0;
        var selectedNew = 0;
        var selectedExisting = 0;

        foreach (var entry in Entries)
        {
            if (entry.IsDuplicate)
            {
                duplicates++;
            }

            if (!entry.IsSelected || !entry.CanImport)
            {
                continue;
            }

            if (entry.IsSectionOnly)
            {
                selectedExisting++;
            }
            else
            {
                selectedNew++;
            }
        }

        EntryCount = Entries.Count;
        DuplicateCount = duplicates;
        SelectedNewCount = selectedNew;
        SelectedExistingCount = selectedExisting;
        SelectedCount = selectedNew + selectedExisting;
    }

    private void OnEntriesChanged(object? sender, NotifyCollectionChangedEventArgs e) => RefreshCounts();

    private void OnEntryPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(DialogueImportEntryViewModel.IsSelected))
        {
            RefreshCounts();
        }
    }
}
