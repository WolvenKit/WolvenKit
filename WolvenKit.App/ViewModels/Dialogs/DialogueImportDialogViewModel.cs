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
    public uint? SpeakerActorId { get; init; }

    /// <inheritdoc cref="SpeakerActorId"/>
    public uint? AddresseeActorId { get; init; }
}

/// <summary>
/// One line of an import, with what the scene already knows about it. A line whose locstring id is
/// in the scene cannot be taken again: importing it a second time would leave two screenplay
/// entries pointing at one recording, which is the one thing the scene editor cannot tell apart
/// afterwards.
/// </summary>
public partial class DialogueImportEntryViewModel : ObservableObject
{
    public DialogueImportEntryViewModel(
        ImportedDialogueLine line,
        bool isDuplicate,
        IReadOnlyList<SceneActorOption> actorOptions,
        DialogueSpeakerResolver resolver)
    {
        Line = line;
        IsDuplicate = isDuplicate;
        IsSelected = !isDuplicate;
        ActorOptions = actorOptions;

        // What the export says, matched against the scene's cast. Whatever it did not match is left
        // unset for the user to pick, which is the same "no actor" a line added by hand starts with.
        _speakerActor = resolver.Resolve(line.Speaker) ?? SceneActorOption.None;
        _addresseeActor = resolver.Resolve(line.Addressee) ?? SceneActorOption.None;
    }

    public ImportedDialogueLine Line { get; }

    /// <summary>Whether the scene already carries a screenplay entry for this locstring id.</summary>
    public bool IsDuplicate { get; }

    /// <summary>Whether the line is the user's to take. Duplicates never are.</summary>
    public bool CanImport => !IsDuplicate;

    [ObservableProperty] private bool _isSelected;

    /// <summary>The scene's cast, shared by every row: one list, one set of dropdown items.</summary>
    public IReadOnlyList<SceneActorOption> ActorOptions { get; }

    [ObservableProperty] private SceneActorOption _speakerActor;

    [ObservableProperty] private SceneActorOption _addresseeActor;

    /// <summary>
    /// Whether this line has actors to assign at all. A choice option is something the player says
    /// by picking it, and the screenplay store keeps no speaker for one.
    /// </summary>
    public bool CanSetActors => !Line.IsChoiceOption;

    public string LocStringId => Line.LocStringId.ToString();

    /// <summary>What the export called the speaker, kept where the user can check the match.</summary>
    public string SpeakerToolTip => DescribeExportedName("speaker", Line.Speaker);

    public string AddresseeToolTip => DescribeExportedName("addressee", Line.Addressee);

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

    public string Status => IsDuplicate
        ? "Already in scene"
        : Line.IsChoiceOption
            ? "New choice option"
            : "New line";

    private static string DescribeExportedName(string role, string name) =>
        string.IsNullOrEmpty(name)
            ? $"The export names no {role} for this line"
            : $"The export names \"{name}\" as the {role}";
}

/// <summary>
/// ViewModel for the dialogue import dialog: takes an export written by another tool (the Dialogue
/// Browser CET mod writes one from its conversation panel), says what is in it, and hands back the
/// lines the user picked.
/// </summary>
public partial class DialogueImportDialogViewModel : DialogViewModel
{
    private readonly HashSet<ulong> _existingLineLocStrings;
    private readonly HashSet<ulong> _existingOptionLocStrings;
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
        _existingLineLocStrings = dialogOptions.ExistingLineLocStrings;
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
    /// Whether the lines' text is embedded into the scene's locstore. Without it the scene points
    /// at recordings whose subtitles live in the game's own string tables, which is what a scene
    /// referencing existing dialogue wants; with it the text travels with the scene.
    /// </summary>
    [ObservableProperty] private bool _createEmbeddedText = true;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(HasEntries))]
    private int _entryCount;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CanImport))]
    private int _selectedCount;

    [ObservableProperty] private int _duplicateCount;

    public bool HasEntries => EntryCount > 0;

    public bool CanImport => SelectedCount > 0;

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

        foreach (var line in payload.Lines)
        {
            var existing = line.IsChoiceOption ? _existingOptionLocStrings : _existingLineLocStrings;
            var entry = new DialogueImportEntryViewModel(
                line, existing.Contains(line.LocStringId), ActorOptions, _speakerResolver);

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
    /// The lines the user settled on, each with the actors they left it pointing at. Duplicates are
    /// filtered out here as well as being locked in the list, so nothing gets in by way of a payload
    /// swapped out from under the selection.
    /// </summary>
    public List<DialogueImportSelection> GetLinesToImport() =>
        Entries
            .Where(entry => entry.IsSelected && entry.CanImport)
            .Select(entry => new DialogueImportSelection
            {
                Line = entry.Line,
                SpeakerActorId = ActorIdOf(entry.SpeakerActor),
                AddresseeActorId = ActorIdOf(entry.AddresseeActor)
            })
            .ToList();

    /// <summary>An actor id to write, or null where the user left the line unassigned.</summary>
    private static uint? ActorIdOf(SceneActorOption? option) =>
        option is null || option.IsNone ? null : option.ActorId;

    private void SetSelection(bool isSelected)
    {
        // Each row raising its own change would have the counts recomputed once per row; they are
        // the same counts either way, so they are taken once at the end.
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
        var selected = 0;

        foreach (var entry in Entries)
        {
            if (entry.IsDuplicate)
            {
                duplicates++;
            }
            else if (entry.IsSelected)
            {
                selected++;
            }
        }

        EntryCount = Entries.Count;
        DuplicateCount = duplicates;
        SelectedCount = selected;
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
