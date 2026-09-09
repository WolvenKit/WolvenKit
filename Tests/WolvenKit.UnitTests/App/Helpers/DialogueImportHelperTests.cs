using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.App.Helpers;
using WolvenKit.RED4.Types;

namespace WolvenKit.UnitTests.App.Helpers;

/// <summary>
/// The payload contract between the Scene Editor's dialogue import and whoever writes an export -
/// the Dialogue Browser CET mod writes one from its conversation panel. The JSON in these tests is
/// shaped exactly as that exporter writes it: keys sorted, locstring ids as strings.
/// </summary>
/// <remarks>
/// Two versions of the format are read. Version 2 times its lines in milliseconds and lays the
/// conversation out itself, giving every line a start time; version 1 wrote seconds and left the
/// layout to whoever read it. The unit cannot be told from the number - 2 is either two seconds or
/// a fifth of a frame - so the version is what decides, and both are covered here.
/// </remarks>
[TestClass]
public class DialogueImportHelperTests
{
    /// <summary>
    /// A version 2 export, as the exporter writes one: durations in milliseconds, every line placed
    /// on the conversation's own timeline, and a <c>duration</c> that is already the longer of the
    /// two recorded takes. Its orders skip 3 and 5, and the gaps in its start times are where those
    /// lines were passed over.
    /// </summary>
    private const string ConversationExport = """
        {
          "conversation": "Showcase",
          "conversationId": "conv1787238496_1",
          "exportedAt": 1787748046,
          "format": "wolvenkit.scene.dialogue",
          "lines": [
            {
              "addressee": "Judy",
              "context": "Vo_Context_Quest",
              "duration": 1988,
              "expression": "Vo_Expression_Spoken",
              "femaleDuration": 1800,
              "femaleLipsyncAnim": "f_18BBDCE3DF2FC000",
              "femaleText": "Welcome to Night City.",
              "hasFemale": true,
              "hasMale": true,
              "kind": "line",
              "locStringId": "1782260948815298560",
              "maleDuration": 1988,
              "maleLipsyncAnim": "",
              "maleText": "",
              "order": 1,
              "quest": "base\\quest\\side_quests\\sq026\\phases\\sq026_judys_suicide.questphase",
              "scene": "base/quest/side_quests/sq026/scenes/sq026_01a_suicide.scene",
              "speaker": "V",
              "startTime": 0,
              "subtitlePath": "base/localization/en-us/subtitles/quest/sq026/sq026_01a_suicide.json",
              "text": "Welcome to Night City."
            },
            {
              "addressee": "V",
              "context": "Vo_Context_Quest",
              "duration": 1186,
              "expression": "Vo_Expression_Spoken",
              "femaleDuration": 1186,
              "femaleLipsyncAnim": "f_172460154E29F000",
              "femaleText": "Thanks, V.",
              "hasFemale": true,
              "hasMale": false,
              "kind": "line",
              "locStringId": "1667563406655877120",
              "maleDuration": 0,
              "maleLipsyncAnim": "",
              "maleText": "",
              "order": 2,
              "quest": "base\\quest\\main_quests\\part1\\q103\\phases\\q103_03_ghost_town.questphase",
              "scene": "base/quest/main_quests/part1/q103/scenes/q103_11_tunnel_drive.scene",
              "speaker": "Panam",
              "startTime": 1988,
              "subtitlePath": "base/localization/en-us/subtitles/quest/q103/q103_11_tunnel_drive.json",
              "text": "Thanks, V."
            },
            {
              "addressee": "V",
              "context": "Vo_Context_Quest",
              "duration": 2438,
              "expression": "Vo_Expression_Spoken",
              "femaleDuration": 2438,
              "femaleLipsyncAnim": "",
              "femaleText": "Jesus, you really do look terrible.",
              "hasFemale": true,
              "hasMale": false,
              "kind": "line",
              "locStringId": "1853019730599550976",
              "maleDuration": 0,
              "maleLipsyncAnim": "",
              "maleText": "",
              "order": 4,
              "quest": "base\\quest\\main_quests\\part1\\q115\\phases\\q115_02_ripperdoc.questphase",
              "scene": "base/quest/main_quests/part1/q115/scenes/q115_02d_misty.scene",
              "speaker": "Panam",
              "startTime": 4174,
              "subtitlePath": "base/localization/en-us/subtitles/quest/q115/q115_02d_misty.json",
              "text": "Jesus, you really do look terrible."
            },
            {
              "addressee": "Judy",
              "context": "Vo_Context_Quest",
              "duration": 2880,
              "expression": "Vo_Expression_Spoken",
              "femaleDuration": 2602,
              "femaleLipsyncAnim": "f_14AABCC86A29F000",
              "femaleText": "Just tired, is all...",
              "hasFemale": true,
              "hasMale": true,
              "kind": "line",
              "locStringId": "1489210195759984640",
              "maleDuration": 2880,
              "maleLipsyncAnim": "",
              "maleText": "",
              "order": 6,
              "quest": "base\\quest\\main_quests\\epilogue\\q203\\phase\\q203_penthouse.questphase",
              "scene": "base/quest/main_quests/epilogue/q203/scenes/q203_02c_judy.scene",
              "speaker": "V",
              "startTime": 7112,
              "subtitlePath": "base/localization/en-us/subtitles/quest/q203/q203_02c_judy.json",
              "text": "Just tired, is all..."
            },
            {
              "addressee": "Delamain",
              "context": "Vo_Context_Quest",
              "duration": 2052,
              "expression": "Vo_Expression_Phone",
              "femaleDuration": 2034,
              "femaleLipsyncAnim": "f_1BDEF0F12E29F008",
              "femaleText": "Difficult few weeks.",
              "hasFemale": true,
              "hasMale": true,
              "kind": "line",
              "locStringId": "2008307402506104840",
              "maleDuration": 2052,
              "maleLipsyncAnim": "",
              "maleText": "",
              "order": 7,
              "quest": "base\\quest\\main_quests\\epilogue\\q203\\phase\\q203_av_ride.questphase",
              "scene": "base/quest/main_quests/epilogue/q203/scenes/q203_04_delamain.scene",
              "speaker": "V",
              "startTime": 9992,
              "subtitlePath": "base/localization/en-us/subtitles/quest/q203/q203_04_delamain.json",
              "text": "Difficult few weeks."
            }
          ],
          "source": "DialogueBrowser 1.1.0",
          "version": 2
        }
        """;

    /// <summary>A version 1 export: durations in seconds, no start times.</summary>
    private const string LegacyConversationExport = """
        {
          "conversation": "Ripperdoc",
          "conversationId": "conv1755043200_1",
          "exportedAt": 1755043200,
          "format": "wolvenkit.scene.dialogue",
          "lines": [
            {
              "addressee": "V",
              "context": "Vo_Context_Quest",
              "duration": 2.6,
              "expression": "Vo_Expression_Spoken",
              "femaleLipsyncAnim": "f_1A95FA94452C5000",
              "femaleText": "Wakey wakey, choom.",
              "hasFemale": true,
              "hasMale": false,
              "kind": "line",
              "locStringId": "45896283497",
              "maleLipsyncAnim": "",
              "maleText": "",
              "order": 1,
              "quest": "q000",
              "scene": "base\\quest\\test.scene",
              "speaker": "Viktor Vektor",
              "subtitlePath": "base\\localization\\test.json",
              "text": "Wakey wakey, choom."
            },
            {
              "femaleText": "",
              "hasFemale": false,
              "hasMale": true,
              "kind": "line",
              "locStringId": "45896283498",
              "maleLipsyncAnim": "m_2B95FA94452C5001",
              "maleText": "You got a plan?",
              "order": 2,
              "speaker": "V",
              "text": "You got a plan?"
            }
          ],
          "source": "DialogueBrowser 1.0.0",
          "version": 1
        }
        """;

    [TestMethod]
    public void ParsesAConversationExport()
    {
        var payload = DialogueImportHelper.Parse(LegacyConversationExport);

        Assert.IsTrue(payload.IsValid);
        Assert.IsNull(payload.Error);
        Assert.AreEqual("Ripperdoc", payload.ConversationName);
        Assert.AreEqual("DialogueBrowser 1.0.0", payload.Source);
        Assert.AreEqual(0, payload.SkippedCount);
        Assert.AreEqual(2, payload.Lines.Count);
    }

    [TestMethod]
    public void CarriesEverythingAScreenplayLineNeeds()
    {
        var line = DialogueImportHelper.Parse(LegacyConversationExport).Lines[0];

        Assert.AreEqual(45896283497UL, (ulong)line.LocStringId);
        Assert.AreEqual("Wakey wakey, choom.", line.EmbeddedText);
        Assert.AreEqual("Viktor Vektor", line.Speaker);
        Assert.AreEqual("V", line.Addressee);
        Assert.AreEqual("f_1A95FA94452C5000", line.FemaleLipsyncAnim);
        Assert.AreEqual("", line.MaleLipsyncAnim);
        Assert.IsFalse(line.IsChoiceOption);
    }

    [TestMethod]
    public void SpotsALineWordedForThePlayersGender()
    {
        // Vanilla keeps both wordings against one locstring, told apart by the locstore descriptor's
        // gender signature. Only one of them can be embedded, so the dialog says when there are two.
        var payload = DialogueImportHelper.Parse("""
            {
              "lines": [
                {
                  "locStringId": "1677648457431117824",
                  "text": "Got 'nads on you, girl.",
                  "femaleText": "Got 'nads on you, girl.",
                  "maleText": "Got balls on you, boy."
                },
                {
                  "locStringId": "2",
                  "text": "Same either way.",
                  "femaleText": "Same either way.",
                  "maleText": "Same either way."
                },
                { "locStringId": "3", "text": "Only one take.", "femaleText": "Only one take." }
              ]
            }
            """);

        Assert.IsTrue(payload.Lines[0].HasGenderedText);
        Assert.AreEqual("Got balls on you, boy.", payload.Lines[0].MaleText);

        Assert.IsFalse(payload.Lines[1].HasGenderedText, "the same wording twice is not gendered");
        Assert.IsFalse(payload.Lines[2].HasGenderedText, "one variant cannot differ from the other");
    }

    [TestMethod]
    public void ReadsTheConversationTheExporterLaidOut()
    {
        var payload = DialogueImportHelper.Parse(ConversationExport);

        Assert.IsTrue(payload.IsValid);
        Assert.AreEqual(2, payload.Version);
        Assert.AreEqual("Showcase", payload.ConversationName);
        Assert.AreEqual("DialogueBrowser 1.1.0", payload.Source);
        Assert.AreEqual(5, payload.Lines.Count);

        // Milliseconds as written, no conversion: from version 2 the export times its lines the way
        // a scene's events are timed.
        CollectionAssert.AreEqual(
            new uint[] { 1_988, 1_186, 2_438, 2_880, 2_052 },
            payload.Lines.Select(line => line.DurationMs).ToArray());

        // Where each line comes in, gaps and all - the 1000ms before the third is where a line of
        // the original conversation was passed over.
        CollectionAssert.AreEqual(
            new uint?[] { 0, 1_988, 4_174, 7_112, 9_992 },
            payload.Lines.Select(line => line.StartTimeMs).ToArray());
    }

    [TestMethod]
    public void LaysARealExportOutAsTheConversationRan()
    {
        // The whole way through: the export as the mod writes it, out the other end as a section
        // whose events sit where the original conversation put them.
        var payload = DialogueImportHelper.Parse(ConversationExport);

        var section = SceneSectionBuilder.Build(
            payload.Lines
                .Select((line, index) => new SectionDialogueLine
                {
                    ScreenplayLineId = new scnscreenplayItemId { Id = (uint)(1 + index * 256) },
                    DurationMs = line.DurationMs,
                    StartTimeMs = line.StartTimeMs,
                    Text = line.EmbeddedText
                })
                .ToList());

        var events = section.Node.Events
            .Select(handle => (scnDialogLineEvent)handle.Chunk!)
            .ToList();

        CollectionAssert.AreEqual(
            new uint[] { 0, 1_988, 4_174, 7_112, 9_992 },
            events.Select(sceneEvent => (uint)sceneEvent.StartTime).ToArray());

        CollectionAssert.AreEqual(
            new uint[] { 1, 257, 513, 769, 1_025 },
            events.Select(sceneEvent => (uint)sceneEvent.ScreenplayLineId.Id).ToArray());

        // The last line starts at 9992 and runs 2052, so the section has to reach 12044 to play it
        // through - a shorter one would cut Delamain off mid-sentence.
        Assert.AreEqual(12_044U, section.DurationMs);

        Assert.AreEqual(5, section.PlacedByExportCount, "a version 2 export places every line itself");
        Assert.AreEqual(0, section.EstimatedDurationCount, "and times every line itself");
    }

    [TestMethod]
    public void ReadsAVersionOneLengthAsSeconds()
    {
        var payload = DialogueImportHelper.Parse(LegacyConversationExport);

        Assert.AreEqual(1, payload.Version);

        // 2.6 in a version 1 payload is two and a half seconds. The same number in a version 2 one
        // is a fifth of a frame, so only the version can say which was meant.
        Assert.AreEqual(2_600U, payload.Lines[0].DurationMs);

        Assert.AreEqual(0U, payload.Lines[1].DurationMs, "an export that gave no length gives 0");
    }

    [TestMethod]
    public void LeavesAVersionOneLineUnplaced()
    {
        // Version 1 timed its lines but did not lay them out, so there is nothing to place them by
        // and whoever builds a section has to decide when each one comes in.
        var payload = DialogueImportHelper.Parse(LegacyConversationExport);

        Assert.IsTrue(payload.Lines.TrueForAll(line => line.StartTimeMs is null));
    }

    [TestMethod]
    public void TellsAnUnstatedStartTimeFromAZeroOne()
    {
        var payload = DialogueImportHelper.Parse("""
            {
              "version": 2,
              "lines": [
                { "locStringId": "1", "startTime": 0 },
                { "locStringId": "2" }
              ]
            }
            """);

        // The first line of a conversation starts at 0, so 0 cannot stand in for "not said".
        Assert.AreEqual(0U, payload.Lines[0].StartTimeMs);
        Assert.IsNull(payload.Lines[1].StartTimeMs);
    }

    [TestMethod]
    public void ReadsATimingWrittenAsAString()
    {
        var payload = DialogueImportHelper.Parse("""
            {
              "version": 2,
              "lines": [ { "locStringId": "1", "duration": "1750", "startTime": "500" } ]
            }
            """);

        Assert.AreEqual(1_750U, payload.Lines[0].DurationMs);
        Assert.AreEqual(500U, payload.Lines[0].StartTimeMs);
    }

    [TestMethod]
    public void RefusesALengthNoRecordingCouldHave()
    {
        // Anything unusable reads as "not said", which leaves the section to estimate rather than
        // stretching it to whatever the payload claimed.
        var payload = DialogueImportHelper.Parse("""
            {
              "version": 2,
              "lines": [
                { "locStringId": "1", "duration": -3 },
                { "locStringId": "2", "duration": 0 },
                { "locStringId": "3", "duration": 600000 },
                { "locStringId": "4", "duration": "not a number" },
                { "locStringId": "5" }
              ]
            }
            """);

        foreach (var line in payload.Lines)
        {
            Assert.AreEqual(0U, line.DurationMs, $"locstring {line.LocStringId}");
        }
    }

    [TestMethod]
    public void RefusesAStartTimeNoSectionCouldReach()
    {
        var payload = DialogueImportHelper.Parse("""
            {
              "version": 2,
              "lines": [
                { "locStringId": "1", "startTime": -1 },
                { "locStringId": "2", "startTime": 7200000 },
                { "locStringId": "3", "startTime": "sometime" }
              ]
            }
            """);

        // A section is a scene beat, not an afternoon; an unusable start time leaves the line to be
        // placed rather than stretching the section to reach it.
        Assert.IsTrue(payload.Lines.TrueForAll(line => line.StartTimeMs is null));
    }

    [TestMethod]
    public void ReadsTheVoiceoverContextAndExpression()
    {
        var payload = DialogueImportHelper.Parse(LegacyConversationExport);

        Assert.AreEqual(
            Enums.locVoiceoverContext.Vo_Context_Quest,
            (Enums.locVoiceoverContext)payload.Lines[0].VoContext!.Value);
        Assert.AreEqual(
            Enums.locVoiceoverExpression.Vo_Expression_Spoken,
            (Enums.locVoiceoverExpression)payload.Lines[0].VoExpression!.Value);

        Assert.IsNull(payload.Lines[1].VoContext, "the export named none");
        Assert.IsNull(payload.Lines[1].VoExpression);
    }

    [TestMethod]
    public void ReadsAroundAFieldWrittenAsSomethingElseEntirely()
    {
        // Invalid field shapes should not prevent other fields from being parsed.
        var payload = DialogueImportHelper.Parse("""
            {
              "version": { "major": 2 },
              "lines": [
                {
                  "locStringId": "1",
                  "text": "Still readable.",
                  "duration": { "ms": 1988 },
                  "startTime": [ 1500 ],
                  "order": { },
                  "context": [ "Vo_Context_Quest" ]
                }
              ]
            }
            """);

        Assert.IsTrue(payload.IsValid);
        Assert.AreEqual(0, payload.Version);
        Assert.AreEqual("Still readable.", payload.Lines[0].EmbeddedText);
        Assert.AreEqual(0U, payload.Lines[0].DurationMs);
        Assert.IsNull(payload.Lines[0].StartTimeMs);
        Assert.AreEqual(0, payload.Lines[0].Order);
        Assert.IsNull(payload.Lines[0].VoContext);
    }

    [TestMethod]
    public void RefusesAVoiceoverParameterThatIsNotAnEnumName()
    {
        // Only supported voiceover parameter names are accepted.
        // Numeric strings are refused even where they would map to a declared enum value.
        var payload = DialogueImportHelper.Parse("""
            {
              "lines": [
                { "locStringId": "1", "context": "Vo_Context_Whatever" },
                { "locStringId": "2", "context": "1" },
                { "locStringId": "3", "expression": "7" },
                { "locStringId": "4", "context": "" },
                { "locStringId": "5", "context": 1 },
                { "locStringId": "6", "context": "vo_context_community", "expression": "vo_expression_globaltv" }
              ]
            }
            """);

        Assert.IsNull(payload.Lines[0].VoContext, "not a context the game knows");
        Assert.IsNull(payload.Lines[1].VoContext, "numeric strings are not names");
        Assert.IsNull(payload.Lines[2].VoExpression, "numeric strings are not names");
        Assert.IsNull(payload.Lines[3].VoContext);
        Assert.IsNull(payload.Lines[4].VoContext, "a context is named, not numbered");

        // Voiceover parameter names are matched case-insensitively.
        Assert.AreEqual(
            Enums.locVoiceoverContext.Vo_Context_Community,
            (Enums.locVoiceoverContext)payload.Lines[5].VoContext!.Value);
        Assert.AreEqual(
            Enums.locVoiceoverExpression.Vo_Expression_GlobalTV,
            (Enums.locVoiceoverExpression)payload.Lines[5].VoExpression!.Value);
    }

    [TestMethod]
    public void PutsTheLinesInTheOrderTheConversationSaysThem()
    {
        var payload = DialogueImportHelper.Parse("""
            {
              "lines": [
                { "locStringId": "3", "order": 3 },
                { "locStringId": "1", "order": 1 },
                { "locStringId": "2", "order": 2 }
              ]
            }
            """);

        CollectionAssert.AreEqual(
            new ulong[] { 1, 2, 3 },
            payload.Lines.Select(line => (ulong)line.LocStringId).ToArray());
    }

    [TestMethod]
    public void LeavesTheLinesAloneWhenNotAllOfThemSayWhereTheyFall()
    {
        // Half an ordering would move the lines that have one past the lines that do not, which is
        // worse than the order the export wrote them in.
        var payload = DialogueImportHelper.Parse("""
            {
              "lines": [
                { "locStringId": "3", "order": 3 },
                { "locStringId": "1" },
                { "locStringId": "2", "order": 2 }
              ]
            }
            """);

        CollectionAssert.AreEqual(
            new ulong[] { 3, 1, 2 },
            payload.Lines.Select(line => (ulong)line.LocStringId).ToArray());

        Assert.AreEqual(0, payload.Lines[1].Order);
    }

    [TestMethod]
    public void LeavesTheAddresseeEmptyWhenTheExportDoesNotNameOne()
    {
        Assert.AreEqual("", DialogueImportHelper.Parse(LegacyConversationExport).Lines[1].Addressee);
    }

    [TestMethod]
    public void ReadsTheLipsyncNameOfEitherRecordedVariant()
    {
        var line = DialogueImportHelper.Parse(LegacyConversationExport).Lines[1];

        Assert.AreEqual("", line.FemaleLipsyncAnim);
        Assert.AreEqual("m_2B95FA94452C5001", line.MaleLipsyncAnim);
    }

    [TestMethod]
    public void FallsBackToARecordedVariantWhenThereIsNoDisplayText()
    {
        var payload = DialogueImportHelper.Parse("""
            { "lines": [ { "locStringId": "12345", "femaleText": "Only the female take was written." } ] }
            """);

        Assert.IsTrue(payload.IsValid);
        Assert.AreEqual("Only the female take was written.", payload.Lines[0].EmbeddedText);
    }

    [TestMethod]
    public void ReadsALocStringIdWrittenAsANumber()
    {
        var payload = DialogueImportHelper.Parse("""
            { "lines": [ { "locStringId": 45896283497, "text": "Numbered." } ] }
            """);

        Assert.IsTrue(payload.IsValid);
        Assert.AreEqual(45896283497UL, (ulong)payload.Lines[0].LocStringId);
    }

    [TestMethod]
    public void ReadsABareArrayOfLines()
    {
        var payload = DialogueImportHelper.Parse("""
            [ { "locStringId": "1", "text": "One." }, { "locStringId": "2", "text": "Two." } ]
            """);

        Assert.IsTrue(payload.IsValid);
        Assert.AreEqual(2, payload.Lines.Count);
    }

    [TestMethod]
    public void RoutesChoiceOptionsToTheirOwnHalfOfTheStore()
    {
        var payload = DialogueImportHelper.Parse("""
            { "lines": [ { "locStringId": "1", "kind": "option", "text": "Ask about the price." } ] }
            """);

        Assert.IsTrue(payload.Lines[0].IsChoiceOption);
    }

    [TestMethod]
    public void KeepsOneLinePerLocStringId()
    {
        // A conversation may hold the same line twice - a character can repeat themselves - but the
        // scene only ever wants one screenplay entry pointing at a recording.
        var payload = DialogueImportHelper.Parse("""
            {
              "lines": [
                { "locStringId": "42", "text": "Said once." },
                { "locStringId": "42", "text": "Said again." }
              ]
            }
            """);

        Assert.AreEqual(1, payload.Lines.Count);
        Assert.AreEqual(1, payload.SkippedCount);
    }

    [TestMethod]
    public void DropsLinesWithNoUsableLocStringId()
    {
        var payload = DialogueImportHelper.Parse("""
            {
              "lines": [
                { "locStringId": "", "text": "No id." },
                { "text": "No id at all." },
                { "locStringId": "0", "text": "Zero is not an id." },
                { "locStringId": "77", "text": "Keeps this one." }
              ]
            }
            """);

        Assert.IsTrue(payload.IsValid);
        Assert.AreEqual(1, payload.Lines.Count);
        Assert.AreEqual(77UL, (ulong)payload.Lines.Single().LocStringId);
        Assert.AreEqual(3, payload.SkippedCount);
    }

    [TestMethod]
    public void RefusesAPayloadWrittenForSomethingElse()
    {
        var payload = DialogueImportHelper.Parse("""
            { "format": "some.other.format", "lines": [ { "locStringId": "1" } ] }
            """);

        Assert.IsFalse(payload.IsValid);
        Assert.IsTrue(payload.Error?.Contains(DialogueImportHelper.PayloadFormat) == true);
    }

    [TestMethod]
    public void ReportsMalformedInputRatherThanThrowing()
    {
        foreach (var input in new[] { "", "   ", "not json at all", "{ \"lines\": [", "{}", "{ \"lines\": [] }" })
        {
            var payload = DialogueImportHelper.Parse(input);

            Assert.IsFalse(payload.IsValid, $"'{input}' should not parse");
            Assert.IsNotNull(payload.Error, $"'{input}' should say why");
        }
    }

    [TestMethod]
    public void PointsAtTheModsExportFolderUnderAGameInstall()
    {
        var directory = DialogueImportHelper.GetExportDirectory(@"C:\Games\Cyberpunk 2077");

        Assert.AreEqual(
            @"C:\Games\Cyberpunk 2077\bin\x64\plugins\cyber_engine_tweaks\mods\DialogueBrowser\data\exports",
            directory);
    }

    /// <summary>The scene an import's speaker and addressee names are matched against here.</summary>
    private static DialogueSpeakerResolver Cast() =>
        new([
            new SceneActorOption(0, "Viktor Vektor"),
            new SceneActorOption(1, "takemura_goro"),
            new SceneActorOption(2, ""),
            new SceneActorOption(3, "Player", isPlayer: true)
        ]);

    [TestMethod]
    public void MatchesANameToTheActorTheSceneKnowsByIt()
    {
        Assert.AreEqual<uint?>(0u, Cast().Resolve("Viktor Vektor")?.ActorId);
    }

    [TestMethod]
    public void MatchesANameHoweverItWasTyped()
    {
        // An export names a character the way the game's subtitles do; a scene however its author
        // felt like typing it.
        Assert.AreEqual<uint?>(0u, Cast().Resolve("viktor vektor")?.ActorId);
        Assert.AreEqual<uint?>(0u, Cast().Resolve("  Viktor Vektor  ")?.ActorId);
        Assert.AreEqual<uint?>(1u, Cast().Resolve("Takemura Goro")?.ActorId);
    }

    [TestMethod]
    public void ResolvesVToTheFirstPlayerActor()
    {
        // Whatever the scene calls its player actor, and whatever else it names "V".
        var resolver = new DialogueSpeakerResolver([
            new SceneActorOption(7, "V"),
            new SceneActorOption(3, "Player", isPlayer: true),
            new SceneActorOption(4, "Second V", isPlayer: true)
        ]);

        Assert.AreEqual<uint?>(3u, resolver.Resolve("v")?.ActorId);
    }

    [TestMethod]
    public void MatchesNothingForANameTheSceneDoesNotCast()
    {
        Assert.IsNull(Cast().Resolve("Johnny Silverhand"));
        Assert.IsNull(Cast().Resolve(""));
        Assert.IsNull(Cast().Resolve("   "));
        Assert.IsNull(Cast().Resolve(null));

        // A scene with no player actor has nothing for "V" to mean.
        Assert.IsNull(new DialogueSpeakerResolver([new SceneActorOption(1, "Viktor Vektor")]).Resolve("V"));
    }

    [TestMethod]
    public void KeepsTheFirstActorOfAName()
    {
        var resolver = new DialogueSpeakerResolver([
            new SceneActorOption(4, "Guard"),
            new SceneActorOption(5, "Guard")
        ]);

        Assert.AreEqual<uint?>(4u, resolver.Resolve("Guard")?.ActorId);
    }

    [TestMethod]
    public void NamesEveryActorTheDropdownOffers()
    {
        // The id is always named: a scene may cast two actors alike, or leave one unnamed, and only
        // the id tells those apart in a dropdown.
        Assert.AreEqual("(no actor)", SceneActorOption.None.DisplayName);
        Assert.AreEqual("2: (unnamed)", new SceneActorOption(2, "").DisplayName);
        Assert.AreEqual("1: Viktor Vektor", new SceneActorOption(1, " Viktor Vektor ").DisplayName);
    }

    [TestMethod]
    public void RecognisesWhatIsWorthReadingOffTheClipboard()
    {
        Assert.IsTrue(DialogueImportHelper.LooksLikePayload(ConversationExport));
        Assert.IsTrue(DialogueImportHelper.LooksLikePayload("""[ { "locStringId": "1" } ]"""));

        Assert.IsFalse(DialogueImportHelper.LooksLikePayload(null));
        Assert.IsFalse(DialogueImportHelper.LooksLikePayload(""));
        Assert.IsFalse(DialogueImportHelper.LooksLikePayload("base\\quest\\some\\path.scene"));
        Assert.IsFalse(DialogueImportHelper.LooksLikePayload("""{ "some": "other json" }"""));
    }
}
