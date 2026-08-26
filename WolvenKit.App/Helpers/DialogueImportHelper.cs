using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WolvenKit.App.Helpers;

/// <summary>
/// One dialogue line handed over by an external tool, e.g. the Dialogue Browser CET mod.
/// Everything but the locstring id is optional: the id is what the scene is keyed on, the rest
/// fills in the screenplay entry or describes the line to the user before they take it.
/// </summary>
public sealed class ImportedDialogueLine
{
    /// <summary>Locstring id the recording is registered under.</summary>
    public ulong LocStringId { get; init; }

    /// <summary>
    /// The one subtitle the scene's locstore gets for this line, picked from the variants below.
    /// A locstore descriptor is keyed on locstring, locale and gender, and the gender it is written
    /// under here is "both" - so one text is all a line can carry.
    /// </summary>
    public string EmbeddedText { get; init; } = "";

    /// <summary>
    /// What female V hears the line as, which is the game's own primary variant: the male one is an
    /// override an export only carries where the wording actually differs.
    /// </summary>
    public string FemaleText { get; init; } = "";

    /// <inheritdoc cref="FemaleText"/>
    public string MaleText { get; init; } = "";

    /// <summary>
    /// Whether the two variants say different things, i.e. the line is worded for the player's
    /// gender. Only <see cref="EmbeddedText"/> reaches the scene, so this is what the import dialog
    /// warns on rather than something it can write out.
    /// </summary>
    public bool HasGenderedText =>
        MaleText.Length > 0 && FemaleText.Length > 0 && MaleText != FemaleText;

    public string Speaker { get; init; } = "";

    /// <summary>Who the line is said to, when the export names them.</summary>
    public string Addressee { get; init; } = "";

    public string FemaleLipsyncAnim { get; init; } = "";

    public string MaleLipsyncAnim { get; init; } = "";

    /// <summary>
    /// How long the recording runs, in milliseconds, or 0 where the export gave no length and a
    /// section has to estimate one.
    /// </summary>
    /// <remarks>
    /// Where an export times each recorded variant, this is the longer of the two: one event plays
    /// whichever V is speaking, and the shorter take would cut the other off.
    /// </remarks>
    public uint DurationMs { get; init; }

    /// <summary>
    /// Where the line starts, in milliseconds from the beginning of the conversation. Null where the
    /// export did not say - an older payload, or a hand-written one - leaving it to whoever lays the
    /// lines out.
    /// </summary>
    public uint? StartTimeMs { get; init; }

    /// <summary>
    /// The <c>locVoiceoverContext</c> the line is recorded under, by name - "Vo_Context_Quest" and
    /// the like. Kept as the export wrote it; whether the game knows the name is checked later.
    /// </summary>
    public string VoContext { get; init; } = "";

    /// <inheritdoc cref="VoContext"/>
    public string VoExpression { get; init; } = "";

    /// <summary>
    /// Where the line falls in the conversation, counting from 1, or 0 where the export did not say.
    /// </summary>
    public int Order { get; init; }

    /// <summary>
    /// Whether the line belongs in the screenplay store's options rather than its lines. A choice
    /// option has no recording behind it, so exports from a conversation are never one.
    /// </summary>
    public bool IsChoiceOption { get; init; }
}

/// <summary>
/// What <see cref="DialogueImportHelper.Parse"/> made of a payload.
/// </summary>
public sealed class DialogueImportPayload
{
    public List<ImportedDialogueLine> Lines { get; init; } = [];

    /// <summary>Name of the conversation the lines were exported from, when it said.</summary>
    public string ConversationName { get; init; } = "";

    /// <summary>Tool and version that wrote the payload, when it said.</summary>
    public string Source { get; init; } = "";

    /// <summary>
    /// The payload format's version, or 0 where the export declared none. See
    /// <see cref="DialogueImportHelper.PayloadVersion"/> for what the versions mean.
    /// </summary>
    public int Version { get; init; }

    /// <summary>Entries that carried no usable locstring id and were dropped.</summary>
    public int SkippedCount { get; init; }

    /// <summary>Why nothing could be read, when nothing could.</summary>
    public string? Error { get; init; }

    public bool IsValid => Error is null && Lines.Count > 0;

    public static DialogueImportPayload Failed(string error) => new() { Error = error };
}

/// <summary>
/// A screenplay line the scene already carries. An import never writes one of these a second time -
/// two entries on one recording cannot be told apart afterwards - but a section can still play the
/// entry that is there, which is how a conversation imported in pieces gets a section.
/// </summary>
public sealed class ExistingSceneLine
{
    /// <summary>Locstring id the entry is keyed on, which an import is matched against.</summary>
    public required ulong LocStringId { get; init; }

    /// <summary>
    /// The entry's item id, which a section's dialogue event points at to play it. Null where the
    /// entry was left on <see cref="SceneEditingHelper.UnassignedScreenplayItemId"/> - the id an
    /// event means "points at nothing" by - in which case the import gives it one.
    /// </summary>
    public required uint? ScreenplayLineId { get; init; }

    /// <summary>
    /// Who the scene has saying it, or null where the entry names nobody. Read off the entry, not
    /// the export: the entry is not being rewritten, so the scene's answer holds.
    /// </summary>
    public uint? SpeakerActorId { get; init; }

    /// <inheritdoc cref="SpeakerActorId"/>
    public uint? AddresseeActorId { get; init; }
}

/// <summary>
/// One of the scene's actors, as the import dialog offers it: what an export's speaker name is
/// matched against, and what the user picks from when the match is not the one they wanted.
/// </summary>
public sealed class SceneActorOption
{
    /// <summary>
    /// The actor id an unset speaker or addressee carries, which is what the scene's own editor
    /// writes for a line nobody is assigned to.
    /// </summary>
    public const uint NoActorId = uint.MaxValue;

    /// <summary>Standing in for "leave this line's actor unset", first in every dropdown.</summary>
    public static readonly SceneActorOption None = new(NoActorId, "");

    public SceneActorOption(uint actorId, string? name, bool isPlayer = false)
    {
        ActorId = actorId;
        Name = name?.Trim() ?? "";
        IsPlayer = isPlayer;
    }

    public uint ActorId { get; }

    public string Name { get; }

    /// <summary>Whether this is one of the scene's player actors rather than one of its cast.</summary>
    public bool IsPlayer { get; }

    public bool IsNone => ActorId == NoActorId;

    /// <summary>
    /// What the dropdown shows. The id is named too: a scene may cast two actors under one name,
    /// or none at all, and the id is the only thing that always tells them apart.
    /// </summary>
    public string DisplayName => IsNone
        ? "(no actor)"
        : string.IsNullOrEmpty(Name) ? $"{ActorId}: (unnamed)" : $"{ActorId}: {Name}";

    public override string ToString() => DisplayName;
}

/// <summary>
/// Turns the speaker and addressee names an export carries into the scene's own actors, so an
/// imported line arrives pointing at whoever says it and whoever it is said to. Built once per
/// import from the scene's cast; a name the scene does not know matches nothing, and the line is
/// left for the user to assign by hand.
/// </summary>
public sealed class DialogueSpeakerResolver
{
    /// <summary>
    /// What an export calls the player. It always means the scene's first player actor, whatever
    /// that actor happens to be named - a scene is free to call them "Player", or nothing at all.
    /// </summary>
    public const string PlayerSpeakerName = "V";

    private readonly Dictionary<string, SceneActorOption> _byName = new(StringComparer.OrdinalIgnoreCase);
    private readonly Dictionary<string, SceneActorOption> _byLooseName = new(StringComparer.OrdinalIgnoreCase);
    private readonly SceneActorOption? _playerActor;

    /// <param name="actors">The scene's cast, player actors included, in the order it lists them.</param>
    public DialogueSpeakerResolver(IEnumerable<SceneActorOption> actors)
    {
        foreach (var actor in actors)
        {
            if (actor.IsNone)
            {
                continue;
            }

            if (_playerActor is null && actor.IsPlayer)
            {
                _playerActor = actor;
            }

            if (string.IsNullOrWhiteSpace(actor.Name))
            {
                continue;
            }

            // The first actor of a name keeps it: a scene that names two actors alike gives nothing
            // to tell which of them was meant.
            _byName.TryAdd(actor.Name, actor);

            var loose = Loosen(actor.Name);

            if (loose.Length > 0)
            {
                _byLooseName.TryAdd(loose, actor);
            }
        }
    }

    /// <summary>The actor the scene knows by this name, or null when it knows none.</summary>
    public SceneActorOption? Resolve(string? name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return null;
        }

        var trimmed = name.Trim();

        if (string.Equals(trimmed, PlayerSpeakerName, StringComparison.OrdinalIgnoreCase))
        {
            return _playerActor;
        }

        if (_byName.TryGetValue(trimmed, out var byName))
        {
            return byName;
        }

        // "Viktor Vektor" against an actor the scene calls "viktor_vektor": an export names a
        // character the way the game's subtitles do, a scene however its author typed it.
        var loose = Loosen(trimmed);

        return loose.Length > 0 && _byLooseName.TryGetValue(loose, out var byLooseName) ? byLooseName : null;
    }

    /// <summary>A name with everything but its letters and digits dropped.</summary>
    private static string Loosen(string name)
    {
        var loose = new StringBuilder(name.Length);

        foreach (var character in name)
        {
            if (char.IsLetterOrDigit(character))
            {
                loose.Append(character);
            }
        }

        return loose.ToString();
    }
}

/// <summary>
/// Reads dialogue lines exported by another tool. The format is the one Dialogue Browser writes
/// (<see cref="PayloadFormat"/>): an object with a <c>lines</c> array, or - for a payload put
/// together by hand - the bare array on its own.
/// </summary>
public static class DialogueImportHelper
{
    public const string PayloadFormat = "wolvenkit.scene.dialogue";

    /// <summary>The payload version this was written against, and what the exporter writes now.</summary>
    public const int PayloadVersion = 2;

    /// <summary>
    /// The version from which <c>duration</c> is milliseconds and a line carries its own
    /// <c>startTime</c>. Version 1 wrote seconds, and the unit cannot be told from the number - 2 is
    /// either two seconds or a fifth of a frame - so only the version says which.
    /// </summary>
    private const int MillisecondTimingVersion = 2;

    /// <summary>
    /// The longest a line's stated length can be and still be believed. No single recording runs
    /// five minutes, so a payload saying it does is writing something other than what it declared.
    /// A length past this reads as "not said" and is estimated from the text instead.
    /// </summary>
    /// <remarks>
    /// The same ceiling as <see cref="SceneSectionBuilder.MaxLineDurationMs"/>, so a length believed
    /// here is one a section plays in full. Move the two together.
    /// </remarks>
    private const double MaxLineDurationMs = 300_000;

    /// <summary>
    /// The latest a line can be said to start. A start time past this would leave a section running
    /// for hours with nothing in it.
    /// </summary>
    private const double MaxStartTimeMs = 3_600_000;

    /// <summary>
    /// Where the Dialogue Browser writes its exports, relative to a Cyberpunk install. Named here
    /// rather than in the file picker so the dialog can tell the user the same path it opens.
    /// </summary>
    public static readonly string ExportDirectoryRelativePath = Path.Combine(
        "bin", "x64", "plugins", "cyber_engine_tweaks", "mods", "DialogueBrowser", "data", "exports");

    /// <summary>The mod's export folder under a given game root.</summary>
    public static string GetExportDirectory(string gameRootDir) =>
        Path.Combine(gameRootDir, ExportDirectoryRelativePath);

    private static readonly JsonSerializerOptions s_options = new()
    {
        PropertyNameCaseInsensitive = true,
        AllowTrailingCommas = true,
        ReadCommentHandling = JsonCommentHandling.Skip
    };

    /// <summary>
    /// Whether a blob of text looks like something worth parsing. Used to decide if the clipboard
    /// is worth reading on its own, without putting an error in front of a user who has something
    /// else entirely on it.
    /// </summary>
    public static bool LooksLikePayload(string? text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return false;
        }

        var trimmed = text.TrimStart();

        return (trimmed.StartsWith('{') || trimmed.StartsWith('[')) &&
               (text.Contains(PayloadFormat, StringComparison.OrdinalIgnoreCase) ||
                text.Contains("locStringId", StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Reads a payload. Never throws: a parse failure comes back as
    /// <see cref="DialogueImportPayload.Error"/>, which is what the dialog puts in front of the
    /// user.
    /// </summary>
    public static DialogueImportPayload Parse(string? json)
    {
        if (string.IsNullOrWhiteSpace(json))
        {
            return DialogueImportPayload.Failed("Nothing to import yet.");
        }

        PayloadDto? payload;

        try
        {
            var trimmed = json.TrimStart();

            payload = trimmed.StartsWith('[')
                ? new PayloadDto { Lines = JsonSerializer.Deserialize<List<LineDto>>(json, s_options) }
                : JsonSerializer.Deserialize<PayloadDto>(json, s_options);
        }
        catch (JsonException ex)
        {
            return DialogueImportPayload.Failed($"That is not valid JSON: {ex.Message}");
        }
        catch (Exception ex)
        {
            return DialogueImportPayload.Failed($"Could not read the import: {ex.Message}");
        }

        if (payload is null)
        {
            return DialogueImportPayload.Failed("Could not read the import.");
        }

        // A payload that names a format has to name this one. One that names none is taken as
        // hand-written and read anyway - the lines either parse or they do not.
        if (!string.IsNullOrEmpty(payload.Format) &&
            !string.Equals(payload.Format, PayloadFormat, StringComparison.OrdinalIgnoreCase))
        {
            return DialogueImportPayload.Failed(
                $"This is a '{payload.Format}' payload - expected '{PayloadFormat}'.");
        }

        if (payload.Lines is null || payload.Lines.Count == 0)
        {
            return DialogueImportPayload.Failed("No dialogue lines in that import.");
        }

        // How to read the lines' timings. Taken once: every line in a payload shares the version.
        var version = ReadVersion(payload.Version);
        var isMillisecondTiming = version >= MillisecondTimingVersion;

        var lines = new List<ImportedDialogueLine>(payload.Lines.Count);
        var skipped = 0;
        var seen = new HashSet<ulong>();

        foreach (var dto in payload.Lines)
        {
            if (dto is null || !TryReadLocStringId(dto.LocStringId, out var locStringId) || locStringId == 0)
            {
                skipped++;
                continue;
            }

            // The same line twice in one conversation is legitimate - a character can repeat
            // themselves - but the scene only ever wants one screenplay entry for it.
            if (!seen.Add(locStringId))
            {
                skipped++;
                continue;
            }

            var text = FirstNonEmpty(dto.Text, dto.FemaleText, dto.MaleText);

            lines.Add(new ImportedDialogueLine
            {
                LocStringId = locStringId,
                EmbeddedText = text,
                FemaleText = dto.FemaleText?.Trim() ?? "",
                MaleText = dto.MaleText?.Trim() ?? "",
                Speaker = dto.Speaker?.Trim() ?? "",
                Addressee = dto.Addressee?.Trim() ?? "",
                FemaleLipsyncAnim = dto.FemaleLipsyncAnim?.Trim() ?? "",
                MaleLipsyncAnim = dto.MaleLipsyncAnim?.Trim() ?? "",
                DurationMs = ReadDurationMs(dto.Duration, isMillisecondTiming),
                StartTimeMs = ReadStartTimeMs(dto.StartTime),
                VoContext = dto.Context?.Trim() ?? "",
                VoExpression = dto.Expression?.Trim() ?? "",
                Order = ReadOrder(dto.Order),
                IsChoiceOption = string.Equals(dto.Kind, "option", StringComparison.OrdinalIgnoreCase)
            });
        }

        if (lines.Count == 0)
        {
            return DialogueImportPayload.Failed("None of those lines carry a usable locstring id.");
        }

        return new DialogueImportPayload
        {
            Lines = SortByConversationOrder(lines),
            ConversationName = payload.Conversation?.Trim() ?? "",
            Source = payload.Source?.Trim() ?? "",
            Version = version,
            SkippedCount = skipped
        };
    }

    /// <summary>
    /// Locstring ids are 64 bit, so an exporter is free to write one as a string to keep it out of
    /// a language's float; both forms are read here.
    /// </summary>
    private static bool TryReadLocStringId(JsonElement element, out ulong value)
    {
        value = 0;

        if (element.ValueKind == JsonValueKind.String)
        {
            return ulong.TryParse(element.GetString()?.Trim(), NumberStyles.Integer,
                CultureInfo.InvariantCulture, out value);
        }

        if (element.ValueKind == JsonValueKind.Number)
        {
            return element.TryGetUInt64(out value);
        }

        return false;
    }

    /// <summary>
    /// A line's length in milliseconds. Written in milliseconds from
    /// <see cref="MillisecondTimingVersion"/> on and in seconds before it, so the same number means
    /// different things by version. Anything that is not a length a line could run - a negative, a
    /// NaN, an hour - reads as "not said".
    /// </summary>
    private static uint ReadDurationMs(JsonElement element, bool isMilliseconds)
    {
        if (!TryReadNumber(element, out var duration))
        {
            return 0;
        }

        var milliseconds = isMilliseconds ? duration : duration * 1000;

        if (milliseconds <= 0 || milliseconds > MaxLineDurationMs)
        {
            return 0;
        }

        return (uint)Math.Round(milliseconds);
    }

    /// <summary>
    /// Where a line starts, in milliseconds from the beginning of the conversation, or null where
    /// the export said nothing. 0 is a start time in its own right, so it cannot mean "not said".
    /// </summary>
    private static uint? ReadStartTimeMs(JsonElement element)
    {
        if (!TryReadNumber(element, out var startTime))
        {
            return null;
        }

        if (double.IsNegative(startTime) || startTime > MaxStartTimeMs)
        {
            return null;
        }

        return (uint)Math.Round(startTime);
    }

    /// <summary>
    /// A number an export may have written as a number or as a string, as it may with a locstring
    /// id. False for anything that is not a number, NaN and infinity among them.
    /// </summary>
    private static bool TryReadNumber(JsonElement element, out double value)
    {
        value = 0;

        bool read;

        if (element.ValueKind == JsonValueKind.Number)
        {
            read = element.TryGetDouble(out value);
        }
        else if (element.ValueKind == JsonValueKind.String)
        {
            read = double.TryParse(element.GetString()?.Trim(), NumberStyles.Float,
                CultureInfo.InvariantCulture, out value);
        }
        else
        {
            return false;
        }

        return read && !double.IsNaN(value) && !double.IsInfinity(value);
    }

    /// <summary>
    /// The format version the payload declared, or 0 where it declared none, which reads as the
    /// oldest.
    /// </summary>
    private static int ReadVersion(JsonElement element) =>
        TryReadNumber(element, out var version) && version > 0 && version < int.MaxValue
            ? (int)version
            : 0;

    /// <summary>Where the export puts the line in its conversation, or 0 where it does not say.</summary>
    private static int ReadOrder(JsonElement element)
    {
        if (element.ValueKind == JsonValueKind.Number)
        {
            return element.TryGetInt32(out var order) && order > 0 ? order : 0;
        }

        if (element.ValueKind == JsonValueKind.String)
        {
            return int.TryParse(element.GetString()?.Trim(), NumberStyles.Integer,
                CultureInfo.InvariantCulture, out var order) && order > 0
                ? order
                : 0;
        }

        return 0;
    }

    /// <summary>
    /// The lines in conversation order, where every one of them says where it falls. A payload
    /// missing even one order is left as written: a partial ordering would move the lines that have
    /// one past the lines that do not.
    /// </summary>
    private static List<ImportedDialogueLine> SortByConversationOrder(List<ImportedDialogueLine> lines) =>
        lines.TrueForAll(line => line.Order > 0)
            ? lines.OrderBy(line => line.Order).ToList()
            : lines;

    private static string FirstNonEmpty(params string?[] values)
    {
        foreach (var value in values)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                return value.Trim();
            }
        }

        return "";
    }

    private sealed class PayloadDto
    {
        public string? Format { get; set; }
        public string? Conversation { get; set; }
        public string? Source { get; set; }
        public JsonElement Version { get; set; }
        public List<LineDto>? Lines { get; set; }
    }

    private sealed class LineDto
    {
        [JsonPropertyName("locStringId")] public JsonElement LocStringId { get; set; }
        public string? Text { get; set; }
        public string? FemaleText { get; set; }
        public string? MaleText { get; set; }
        public string? Speaker { get; set; }
        public string? Addressee { get; set; }
        public string? FemaleLipsyncAnim { get; set; }
        public string? MaleLipsyncAnim { get; set; }
        public string? Kind { get; set; }

        /// <summary>A <see cref="JsonElement"/> for the same reason the locstring id is.</summary>
        public JsonElement Duration { get; set; }

        /// <inheritdoc cref="Duration"/>
        public JsonElement StartTime { get; set; }

        public string? Context { get; set; }
        public string? Expression { get; set; }
        public JsonElement Order { get; set; }
    }
}
