using System;
using System.Collections.Generic;
using System.Text;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

/// <summary>
/// One line as a section plays it. Built after the line is in the screenplay store, since that is
/// where its item id comes from.
/// </summary>
public sealed class SectionDialogueLine
{
    /// <summary>The screenplay entry the event plays.</summary>
    public required uint ScreenplayLineId { get; init; }

    /// <summary>Who says it, or null if unassigned.</summary>
    public uint? SpeakerActorId { get; init; }

    /// <inheritdoc cref="SpeakerActorId"/>
    public uint? AddresseeActorId { get; init; }

    /// <summary>
    /// How long the recording runs, in milliseconds, or 0 to estimate it from <see cref="Text"/>.
    /// </summary>
    public uint DurationMs { get; init; }

    /// <summary>
    /// When the line starts, in milliseconds from the start of the section, as the export laid the
    /// conversation out. Null to start it as the line before it ends.
    /// </summary>
    public uint? StartTimeMs { get; init; }

    /// <summary>Used only to estimate a duration the export did not give.</summary>
    public string Text { get; init; } = "";

    /// <summary>A <c>locVoiceoverContext</c> by name, e.g. "Vo_Context_Quest". Empty for the default.</summary>
    public string VoContext { get; init; } = "";

    /// <summary>A <c>locVoiceoverExpression</c> by name, e.g. "Vo_Expression_Spoken".</summary>
    public string VoExpression { get; init; } = "";
}

/// <summary>What a section came out as, so the caller need not walk the node again.</summary>
public sealed class BuiltDialogueSection
{
    public required scnSectionNode Node { get; init; }

    /// <summary>Dialogue events written, one per line.</summary>
    public required int EventCount { get; init; }

    /// <summary>Actors the section carries a behavior for, speakers and addressees.</summary>
    public required int ActorCount { get; init; }

    /// <summary>How long the section runs, in milliseconds.</summary>
    public required uint DurationMs { get; init; }

    /// <summary>Lines whose length had to be estimated.</summary>
    public required int EstimatedDurationCount { get; init; }

    /// <summary>
    /// Lines the export gave a start time for, as against ones laid end to end. An older export
    /// places none of them.
    /// </summary>
    public required int PlacedByExportCount { get; init; }
}

/// <summary>
/// Lays a run of dialogue out as a section node: one <c>scnDialogLineEvent</c> per line, over a
/// section long enough to hold them all.
/// </summary>
/// <remarks>
/// The game plays a section for exactly as long as its <c>sectionDuration</c> says and cuts whatever
/// is still running, so a section shorter than its last event truncates that line - the timeline
/// flags this as "section duration too short". Start times come off the export, which keeps the
/// original conversation's pacing. A line the export did not place starts as the one before it ends.
/// <para>
/// Start times are never rebased onto the earliest line the user took, so a section built from the
/// back half of a conversation opens with the lead-in the first half occupied. That is deliberate:
/// closing the gap would move every line against a start nobody chose.
/// </para>
/// </remarks>
public static class SceneSectionBuilder
{
    /// <summary>
    /// The shortest a line is played for, so a one-word line is still on screen long enough to read.
    /// </summary>
    public const uint MinLineDurationMs = 500;

    /// <summary>
    /// The longest an estimate may run. Caps a guess made from a wall of text, which a
    /// subtitle-per-line export occasionally carries.
    /// </summary>
    public const uint MaxEstimatedDurationMs = 60_000;

    /// <summary>
    /// The longest a line is played for at all. A length the export stated is believed up to here
    /// rather than cut to the estimate cap, so a timed monologue is not truncated. Matches the
    /// ceiling <see cref="DialogueImportHelper"/> accepts a stated length at; move the two together.
    /// </summary>
    public const uint MaxLineDurationMs = 300_000;

    /// <summary>
    /// Characters a second to read an untimed line at. Near Cyberpunk's own delivery, and a guess
    /// the user can drag on the timeline afterwards.
    /// </summary>
    private const double EstimatedCharactersPerSecond = 14;

    /// <summary>
    /// Builds the section. The node comes back without a node id - the graph hands one out when it
    /// takes the node.
    /// </summary>
    /// <param name="lines">The lines, in the order the section is to play them.</param>
    public static BuiltDialogueSection Build(IReadOnlyList<SectionDialogueLine> lines)
    {
        ArgumentNullException.ThrowIfNull(lines);

        var random = new Random();

        var section = new scnSectionNode
        {
            // OnEnd first, OnCancel second: the section wrapper reads them by position.
            OutputSockets =
            [
                new scnOutputSocket { Stamp = new scnOutputSocketStamp { Name = 0, Ordinal = 0 } },
                new scnOutputSocket { Stamp = new scnOutputSocketStamp { Name = 1, Ordinal = 0 } }
            ]
        };

        // Speakers and addressees both: the game has no instruction for an actor the section does
        // not name.
        var actorIds = new List<uint>();
        var seenActorIds = new HashSet<uint>();

        // Where an unplaced line starts, and how far the section has to reach. Kept apart because
        // lines may overlap, so the last to start is not always the last to finish.
        uint cursor = 0;
        uint end = 0;
        var estimated = 0;
        var placed = 0;

        foreach (var line in lines)
        {
            var duration = GetLineDuration(line, out var wasEstimated);

            if (wasEstimated)
            {
                estimated++;
            }

            if (line.StartTimeMs is not null)
            {
                placed++;
            }

            var startTime = line.StartTimeMs ?? cursor;

            section.Events.Add(new CHandle<scnSceneEvent>(new scnDialogLineEvent
            {
                Id = new scnSceneEventId { Id = random.NextCRUID() },
                StartTime = startTime,
                Duration = duration,
                ScreenplayLineId = new scnscreenplayItemId { Id = line.ScreenplayLineId },
                VoParams = BuildVoParams(line)
            }));

            cursor = startTime + duration;
            end = Math.Max(end, cursor);

            AddActor(line.SpeakerActorId, actorIds, seenActorIds);
            AddActor(line.AddresseeActorId, actorIds, seenActorIds);
        }

        foreach (var actorId in actorIds)
        {
            section.ActorBehaviors.Add(new scnSectionInternalsActorBehavior
            {
                ActorId = new scnActorId { Id = actorId },
                BehaviorMode = Enums.scnSectionInternalsActorBehaviorMode.OnlyIfAlive
            });
        }

        // Long enough to reach whatever finishes last, which is not always the last line to start.
        section.SectionDuration = new scnSceneTime { Stu = end };

        return new BuiltDialogueSection
        {
            Node = section,
            EventCount = section.Events.Count,
            ActorCount = actorIds.Count,
            DurationMs = end,
            EstimatedDurationCount = estimated,
            PlacedByExportCount = placed
        };
    }

    /// <summary>
    /// How long to play a line for: what the export timed it at, or an estimate from its text.
    /// </summary>
    public static uint GetLineDuration(SectionDialogueLine line, out bool wasEstimated)
    {
        ArgumentNullException.ThrowIfNull(line);

        wasEstimated = line.DurationMs == 0;

        // Capped separately: clamping a stated length to the estimate cap would silently truncate a
        // long line the export timed correctly, and a clamped line is not reported as estimated.
        return wasEstimated
            ? EstimateDuration(line.Text)
            : Math.Clamp(line.DurationMs, MinLineDurationMs, MaxLineDurationMs);
    }

    /// <summary>
    /// What to list the section under in the scene's notable points, which is what the canvas puts
    /// on the node's marker bar. The conversation name, cut down to an identifier.
    /// </summary>
    public static string GetNotablePointName(string? conversationName)
    {
        const string fallback = "imported_dialogue";

        if (string.IsNullOrWhiteSpace(conversationName))
        {
            return fallback;
        }

        var name = new StringBuilder(conversationName.Length);

        foreach (var character in conversationName.Trim().ToLowerInvariant())
        {
            if (char.IsLetterOrDigit(character))
            {
                name.Append(character);
            }
            else if (name.Length > 0 && name[^1] != '_')
            {
                name.Append('_');
            }
        }

        var trimmed = name.ToString().TrimEnd('_');

        return trimmed.Length > 0 ? trimmed : fallback;
    }

    /// <summary>How long text of this length takes to say, in milliseconds.</summary>
    public static uint EstimateDuration(string? text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return MinLineDurationMs;
        }

        var seconds = text.Trim().Length / EstimatedCharactersPerSecond;

        return (uint)Math.Clamp(Math.Round(seconds * 1000), MinLineDurationMs, MaxEstimatedDurationMs);
    }

    /// <summary>
    /// The line's voiceover parameters, as far as the export named them. A name the game does not
    /// know is left off, which leaves the field on the same default Add Dialogue writes.
    /// </summary>
    private static scnDialogLineVoParams BuildVoParams(SectionDialogueLine line)
    {
        var voParams = new scnDialogLineVoParams();

        if (Enum.TryParse<Enums.locVoiceoverContext>(line.VoContext, ignoreCase: true, out var context) &&
            Enum.IsDefined(context))
        {
            voParams.VoContext = context;
        }

        if (Enum.TryParse<Enums.locVoiceoverExpression>(line.VoExpression, ignoreCase: true, out var expression) &&
            Enum.IsDefined(expression))
        {
            voParams.VoExpression = expression;
        }

        return voParams;
    }

    /// <summary>
    /// Notes an actor as being in the section, once. <see cref="SceneActorOption.NoActorId"/> is
    /// the id an unassigned line carries, not an actor, so it is skipped.
    /// </summary>
    private static void AddActor(uint? actorId, List<uint> actorIds, HashSet<uint> seenActorIds)
    {
        if (actorId is not { } id || id == SceneActorOption.NoActorId)
        {
            return;
        }

        if (seenActorIds.Add(id))
        {
            actorIds.Add(id);
        }
    }
}
