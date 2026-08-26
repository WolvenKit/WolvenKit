using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.App.Helpers;
using WolvenKit.RED4.Types;

namespace WolvenKit.UnitTests.App.Helpers;

/// <summary>
/// Laying an imported conversation out as a section node. The timing is what these are about: the
/// game plays a section for exactly as long as its sectionDuration says and cuts whatever is still
/// running, and it plays every event whose start time has come - so lines that all start at 0 are
/// everybody talking at once.
/// </summary>
[TestClass]
public class SceneSectionBuilderTests
{
    private static SectionDialogueLine Line(
        uint screenplayLineId = 1,
        uint durationMs = 2_000,
        uint? startTimeMs = null,
        uint? speaker = null,
        uint? addressee = null,
        string text = "",
        string voContext = "",
        string voExpression = "") =>
        new()
        {
            ScreenplayLineId = screenplayLineId,
            DurationMs = durationMs,
            StartTimeMs = startTimeMs,
            SpeakerActorId = speaker,
            AddresseeActorId = addressee,
            Text = text,
            VoContext = voContext,
            VoExpression = voExpression
        };

    private static List<scnDialogLineEvent> EventsOf(scnSectionNode node) =>
        node.Events.Select(handle => (scnDialogLineEvent)handle.Chunk!).ToList();

    private static uint[] StartTimesOf(scnSectionNode node) =>
        EventsOf(node).Select(sceneEvent => (uint)sceneEvent.StartTime).ToArray();

    [TestMethod]
    public void BringsEachLineInWhenTheExportSaysItDoes()
    {
        // The gaps are the export's own: the 1000ms before the third line is where a line of the
        // original conversation was passed over, and putting the lines back end to end would close
        // it up and lose the pacing.
        var section = SceneSectionBuilder.Build(
            [
                Line(screenplayLineId: 1, startTimeMs: 0, durationMs: 1_988),
                Line(screenplayLineId: 257, startTimeMs: 1_988, durationMs: 1_186),
                Line(screenplayLineId: 513, startTimeMs: 4_174, durationMs: 2_438)
            ]);

        CollectionAssert.AreEqual(new uint[] { 0, 1_988, 4_174 }, StartTimesOf(section.Node));

        CollectionAssert.AreEqual(
            new uint[] { 1_988, 1_186, 2_438 },
            EventsOf(section.Node).Select(sceneEvent => (uint)sceneEvent.Duration).ToArray());

        Assert.AreEqual(3, section.PlacedByExportCount);
    }

    [TestMethod]
    public void EndsTheSectionWhereItsLastLineDoes()
    {
        var section = SceneSectionBuilder.Build(
            [
                Line(startTimeMs: 0, durationMs: 1_988),
                Line(startTimeMs: 9_992, durationMs: 2_052)
            ]);

        // A section that ends before its last event truncates that line, which is what the editor's
        // own timeline flags as "section duration too short".
        Assert.AreEqual(12_044U, (uint)section.Node.SectionDuration.Stu);
        Assert.AreEqual((uint)section.Node.SectionDuration.Stu, section.DurationMs);
    }

    [TestMethod]
    public void ReachesPastALineThatStartsEarlierButRunsLonger()
    {
        // Lines are free to overlap - one character talking over another - so the last one to start
        // is not always the last one to finish.
        var section = SceneSectionBuilder.Build(
            [
                Line(startTimeMs: 0, durationMs: 10_000),
                Line(startTimeMs: 1_000, durationMs: 1_000)
            ]);

        Assert.AreEqual(10_000U, section.DurationMs);
    }

    [TestMethod]
    public void BringsAnUnplacedLineInAsTheOneBeforeItEnds()
    {
        // What an export written before the exporter timed its own conversations gives: lengths but
        // no layout, so the section makes one.
        var section = SceneSectionBuilder.Build(
            [
                Line(durationMs: 2_000),
                Line(durationMs: 1_500),
                Line(durationMs: 3_000)
            ]);

        CollectionAssert.AreEqual(new uint[] { 0, 2_000, 3_500 }, StartTimesOf(section.Node));
        Assert.AreEqual(6_500U, section.DurationMs);
        Assert.AreEqual(0, section.PlacedByExportCount);
    }

    [TestMethod]
    public void CarriesOnFromAPlacedLineWhenTheNextOneIsNotPlaced()
    {
        var section = SceneSectionBuilder.Build(
            [
                Line(startTimeMs: 5_000, durationMs: 1_000),
                Line(durationMs: 2_000),
                Line(startTimeMs: 20_000, durationMs: 1_000)
            ]);

        CollectionAssert.AreEqual(new uint[] { 5_000, 6_000, 20_000 }, StartTimesOf(section.Node));
        Assert.AreEqual(2, section.PlacedByExportCount);
    }

    [TestMethod]
    public void BindsEachEventToTheScreenplayLineItPlays()
    {
        var section = SceneSectionBuilder.Build([Line(screenplayLineId: 1), Line(screenplayLineId: 257)]);

        CollectionAssert.AreEqual(
            new uint[] { 1, 257 },
            EventsOf(section.Node).Select(sceneEvent => (uint)sceneEvent.ScreenplayLineId.Id).ToArray());
    }

    [TestMethod]
    public void GivesEveryEventAnIdOfItsOwn()
    {
        var section = SceneSectionBuilder.Build(
            [Line(screenplayLineId: 1), Line(screenplayLineId: 257), Line(screenplayLineId: 513)]);

        var ids = EventsOf(section.Node).Select(sceneEvent => (ulong)sceneEvent.Id.Id).ToList();

        Assert.AreEqual(3, ids.Distinct().Count());
        CollectionAssert.DoesNotContain(ids, (ulong)long.MaxValue, "the unassigned default is not an id");
    }

    [TestMethod]
    public void NamesEveryActorInTheSectionOnce()
    {
        // V talking to Judy, then Judy back to V: two actors, however many lines they trade.
        var section = SceneSectionBuilder.Build(
            [
                Line(speaker: 0, addressee: 2),
                Line(speaker: 2, addressee: 0),
                Line(speaker: 1, addressee: 2)
            ]);

        CollectionAssert.AreEqual(
            new uint[] { 0, 2, 1 },
            section.Node.ActorBehaviors.Select(behavior => (uint)behavior.ActorId.Id).ToArray());

        Assert.AreEqual(3, section.ActorCount);

        Assert.IsTrue(section.Node.ActorBehaviors.All(behavior =>
            (Enums.scnSectionInternalsActorBehaviorMode)behavior.BehaviorMode ==
            Enums.scnSectionInternalsActorBehaviorMode.OnlyIfAlive));
    }

    [TestMethod]
    public void LeavesUnassignedLinesOutOfTheCast()
    {
        var section = SceneSectionBuilder.Build(
            [
                Line(speaker: null, addressee: null),
                Line(speaker: SceneActorOption.NoActorId, addressee: SceneActorOption.NoActorId),
                Line(speaker: 4)
            ]);

        // uint.MaxValue is what an unassigned line carries, not an actor to tell the section about.
        CollectionAssert.AreEqual(
            new uint[] { 4 },
            section.Node.ActorBehaviors.Select(behavior => (uint)behavior.ActorId.Id).ToArray());
    }

    [TestMethod]
    public void GivesTheSectionItsStandardOutputs()
    {
        var section = SceneSectionBuilder.Build([Line()]);

        // OnEnd first, OnCancel second: the node wrapper labels its outputs by position.
        CollectionAssert.AreEqual(
            new ushort[] { 0, 1 },
            section.Node.OutputSockets.Select(socket => (ushort)socket.Stamp.Name).ToArray());

        Assert.IsTrue(section.Node.OutputSockets.All(socket => socket.Stamp.Ordinal == 0));
    }

    [TestMethod]
    public void TakesTheVoiceoverParametersTheExportNamed()
    {
        var section = SceneSectionBuilder.Build(
            [
                Line(voContext: "Vo_Context_Community", voExpression: "Vo_Expression_Phone"),
                Line(voContext: "Vo_Context_Whatever", voExpression: "")
            ]);

        var events = EventsOf(section.Node);

        Assert.AreEqual(
            Enums.locVoiceoverContext.Vo_Context_Community,
            (Enums.locVoiceoverContext)events[0].VoParams.VoContext);
        Assert.AreEqual(
            Enums.locVoiceoverExpression.Vo_Expression_Phone,
            (Enums.locVoiceoverExpression)events[0].VoParams.VoExpression);

        // A name the game does not know is left off rather than guessed at, which leaves the same
        // default the scene editor's own Add Dialogue writes.
        Assert.AreEqual(
            Enums.locVoiceoverContext.Vo_Context_Quest,
            (Enums.locVoiceoverContext)events[1].VoParams.VoContext);
        Assert.AreEqual(
            Enums.locVoiceoverExpression.Vo_Expression_Spoken,
            (Enums.locVoiceoverExpression)events[1].VoParams.VoExpression);
    }

    [TestMethod]
    public void EstimatesTheLengthOfALineTheExportDidNotTime()
    {
        var section = SceneSectionBuilder.Build(
            [
                Line(durationMs: 0, text: "Welcome to Night City."),
                Line(durationMs: 2_000, text: "Timed already.")
            ]);

        var events = EventsOf(section.Node);

        Assert.AreEqual(1, section.EstimatedDurationCount);
        Assert.AreEqual(2_000U, (uint)events[1].Duration, "a timed line is left as timed");

        Assert.AreEqual(SceneSectionBuilder.EstimateDuration("Welcome to Night City."), (uint)events[0].Duration);
        Assert.IsTrue((uint)events[0].Duration >= SceneSectionBuilder.MinLineDurationMs);
    }

    [TestMethod]
    public void KeepsEveryLineOnScreenLongEnoughToRead()
    {
        var section = SceneSectionBuilder.Build([Line(durationMs: 1), Line(durationMs: 0, text: "Hm.")]);

        Assert.IsTrue(EventsOf(section.Node).All(sceneEvent =>
            sceneEvent.Duration >= SceneSectionBuilder.MinLineDurationMs));
    }

    [TestMethod]
    public void CapsAGuessMadeFromAWallOfText()
    {
        var wall = new string('x', 100_000);

        var section = SceneSectionBuilder.Build([Line(durationMs: 0, text: wall)]);

        Assert.AreEqual(
            SceneSectionBuilder.MaxEstimatedDurationMs, (uint)EventsOf(section.Node)[0].Duration);
    }

    [TestMethod]
    public void BelievesALengthTheExportStatedPastWhatAGuessIsCappedAt()
    {
        // A monologue the export actually timed at 90 seconds is 90 seconds. Cutting it to the cap
        // a guess is held to would truncate it, and quietly - it is not an estimated line, so
        // nothing would tell the user to go and check it.
        const uint ninetySeconds = 90_000;

        var section = SceneSectionBuilder.Build([Line(durationMs: ninetySeconds)]);

        Assert.AreEqual(ninetySeconds, (uint)EventsOf(section.Node)[0].Duration);
        Assert.AreEqual(ninetySeconds, section.DurationMs);
        Assert.AreEqual(0, section.EstimatedDurationCount);
    }

    [TestMethod]
    public void CapsALengthNoRecordingWouldRunTo()
    {
        var section = SceneSectionBuilder.Build([Line(durationMs: 10 * 60_000)]);

        Assert.AreEqual(SceneSectionBuilder.MaxLineDurationMs, (uint)EventsOf(section.Node)[0].Duration);
    }

    [TestMethod]
    public void BuildsAnEmptySectionFromNoLines()
    {
        var section = SceneSectionBuilder.Build([]);

        Assert.AreEqual(0, section.EventCount);
        Assert.AreEqual(0, section.ActorCount);
        Assert.AreEqual(0U, section.DurationMs);
        Assert.AreEqual(0U, (uint)section.Node.SectionDuration.Stu);
        Assert.AreEqual(2, section.Node.OutputSockets.Count);
    }

    [TestMethod]
    public void NamesTheSectionAfterTheConversationItCameFrom()
    {
        Assert.AreEqual("showcase", SceneSectionBuilder.GetNotablePointName("Showcase"));
        Assert.AreEqual("ripperdoc_intro", SceneSectionBuilder.GetNotablePointName("Ripperdoc Intro"));
        Assert.AreEqual("q000_wakeup", SceneSectionBuilder.GetNotablePointName(" q000 - wakeup! "));
        Assert.AreEqual("imported_dialogue", SceneSectionBuilder.GetNotablePointName(""));
        Assert.AreEqual("imported_dialogue", SceneSectionBuilder.GetNotablePointName(null));
        Assert.AreEqual("imported_dialogue", SceneSectionBuilder.GetNotablePointName("---"));
    }
}
