using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.App.Helpers;

namespace WolvenKit.UnitTests.App.Helpers;

/// <summary>
/// The payload contract between the Scene Editor's dialogue import and whoever writes an export -
/// the Dialogue Browser CET mod writes one from its conversation panel. The JSON in these tests is
/// shaped exactly as that exporter writes it: keys sorted, locstring ids as strings.
/// </summary>
[TestClass]
public class DialogueImportHelperTests
{
    private const string ConversationExport = """
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
        var payload = DialogueImportHelper.Parse(ConversationExport);

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
        var line = DialogueImportHelper.Parse(ConversationExport).Lines[0];

        Assert.AreEqual(45896283497UL, line.LocStringId);
        Assert.AreEqual("Wakey wakey, choom.", line.Text);
        Assert.AreEqual("Viktor Vektor", line.Speaker);
        Assert.AreEqual("V", line.Addressee);
        Assert.AreEqual("f_1A95FA94452C5000", line.FemaleLipsyncAnim);
        Assert.AreEqual("", line.MaleLipsyncAnim);
        Assert.IsFalse(line.IsChoiceOption);
    }

    [TestMethod]
    public void LeavesTheAddresseeEmptyWhenTheExportDoesNotNameOne()
    {
        Assert.AreEqual("", DialogueImportHelper.Parse(ConversationExport).Lines[1].Addressee);
    }

    [TestMethod]
    public void ReadsTheLipsyncNameOfEitherRecordedVariant()
    {
        var line = DialogueImportHelper.Parse(ConversationExport).Lines[1];

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
        Assert.AreEqual("Only the female take was written.", payload.Lines[0].Text);
    }

    [TestMethod]
    public void ReadsALocStringIdWrittenAsANumber()
    {
        var payload = DialogueImportHelper.Parse("""
            { "lines": [ { "locStringId": 45896283497, "text": "Numbered." } ] }
            """);

        Assert.IsTrue(payload.IsValid);
        Assert.AreEqual(45896283497UL, payload.Lines[0].LocStringId);
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
        Assert.AreEqual(77UL, payload.Lines.Single().LocStringId);
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
