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

    public string Text => string.IsNullOrEmpty(Line.Text) ? "(no text)" : Line.Text;

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

    /// <summary>The payload itself. Parsed on every change, so pasting into the box is enough.</summary>
    [ObservableProperty] private string _jsonText = "";

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

    partial void OnJsonTextChanged(string value) => LoadPayload(value);

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

        foreach (var entry in Entries)
        {
            entry.PropertyChanged -= OnEntryPropertyChanged;
        }

        Entries.Clear();

        if (string.IsNullOrWhiteSpace(json))
        {
            SetStatus("Paste an export from the Dialogue Browser, or load one from a file.", false);
            RefreshCounts();
            return;
        }

        var payload = DialogueImportHelper.Parse(json);

        if (!payload.IsValid)
        {
            SetStatus(payload.Error ?? "Could not read the import.", true);
            RefreshCounts();
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

        RefreshCounts();
        SetStatus(DescribePayload(payload, sourceName), false);
    }

    /// <summary>
    /// Takes a payload, named by where it came from. Goes through here rather than through
    /// <see cref="JsonText"/> so that handing over the same thing twice still reports itself - the
    /// property only raises a change when the text differs.
    /// </summary>
    public void SetPayload(string json, string sourceName)
    {
        _sourceName = sourceName;

        if (JsonText == json)
        {
            LoadPayload(json);
            return;
        }

        JsonText = json;
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
        foreach (var entry in Entries.Where(entry => entry.CanImport))
        {
            entry.IsSelected = isSelected;
        }
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
        EntryCount = Entries.Count;
        DuplicateCount = Entries.Count(entry => entry.IsDuplicate);
        SelectedCount = Entries.Count(entry => entry is { IsSelected: true, CanImport: true });
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
