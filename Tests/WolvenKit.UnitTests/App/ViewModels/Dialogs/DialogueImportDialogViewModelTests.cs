using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction.Options;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.UnitTests.App.ViewModels.Dialogs;

/// <summary>
/// The dialogue import dialog: what it makes of a payload, what it refuses, and what it hands back
/// when the user is done with it.
/// </summary>
[TestClass]
public class DialogueImportDialogViewModelTests
{
    private const string ThreeLines = """
        {
          "format": "wolvenkit.scene.dialogue",
          "conversation": "Ripperdoc",
          "source": "DialogueBrowser 1.0.0",
          "lines": [
            {
              "locStringId": "1001",
              "text": "Wakey wakey, choom.",
              "speaker": "Viktor Vektor",
              "addressee": "V",
              "femaleLipsyncAnim": "f_1A95FA94452C5000",
              "kind": "line"
            },
            {
              "locStringId": "1002",
              "text": "You got a plan?",
              "speaker": "V",
              "maleLipsyncAnim": "m_2B95FA94452C5001",
              "kind": "line"
            },
            {
              "locStringId": "1003",
              "text": "Ask about the price.",
              "kind": "option"
            }
          ]
        }
        """;

    /// <summary>One line with everything a version 2 export says about how it is played.</summary>
    private const string TimedLines = """
        {
          "format": "wolvenkit.scene.dialogue",
          "version": 2,
          "conversation": "Ripperdoc",
          "lines": [
            {
              "locStringId": "1001",
              "text": "Welcome to Night City.",
              "speaker": "Viktor Vektor",
              "addressee": "V",
              "context": "Vo_Context_Quest",
              "expression": "Vo_Expression_Spoken",
              "duration": 1988,
              "startTime": 1500,
              "kind": "line"
            }
          ]
        }
        """;

    /// <summary>The scene these tests import into: two cast members and a player actor.</summary>
    private static DialogueImportDialogViewModel ViewModel(
        IEnumerable<ExistingSceneLine>? existingLines = null,
        IEnumerable<ulong>? existingOptions = null) =>
        new(new DialogueImportDialogOptions(
            "q000_ripperdoc",
            existingLines ?? [],
            existingOptions ?? [],
            [
                new SceneActorOption(0, "Viktor Vektor"),
                new SceneActorOption(1, "Jackie Welles"),
                new SceneActorOption(2, "Player", isPlayer: true)
            ]));

    /// <summary>A line the scene already carries, as the screenplay store would report it.</summary>
    private static ExistingSceneLine InScene(
        ulong locStringId,
        uint? screenplayLineId = 4_097,
        uint? speaker = null,
        uint? addressee = null) =>
        new()
        {
            LocStringId = locStringId,
            ScreenplayLineId = screenplayLineId,
            SpeakerActorId = speaker,
            AddresseeActorId = addressee
        };

    [TestMethod]
    public void NamesTheSceneItIsImportingInto()
    {
        Assert.AreEqual("Import Dialogue - q000_ripperdoc", ViewModel().Title);
    }

    [TestMethod]
    public void OffersNoActorAheadOfTheScenesCast()
    {
        var actorOptions = ViewModel().ActorOptions;

        Assert.AreEqual(4, actorOptions.Count);
        Assert.IsTrue(actorOptions[0].IsNone);
        Assert.AreEqual("0: Viktor Vektor", actorOptions[1].DisplayName);
    }

    [TestMethod]
    public void ListsThePayloadsLines()
    {
        var viewModel = ViewModel();

        viewModel.LoadPayload(ThreeLines);

        Assert.AreEqual(3, viewModel.Entries.Count);
        Assert.AreEqual(3, viewModel.EntryCount);
        Assert.AreEqual(3, viewModel.SelectedCount);
        Assert.AreEqual(0, viewModel.DuplicateCount);
        Assert.IsTrue(viewModel.HasEntries);
        Assert.IsTrue(viewModel.CanImport);
        Assert.IsFalse(viewModel.IsStatusError);
        Assert.IsTrue(viewModel.StatusMessage.Contains("Ripperdoc"));
    }

    [TestMethod]
    public void MatchesSpeakerAndAddresseeAgainstTheScenesCast()
    {
        var viewModel = ViewModel();

        viewModel.LoadPayload(ThreeLines);

        // "V" always means the scene's first player actor, whatever it is named.
        Assert.AreEqual(0u, viewModel.Entries[0].SpeakerActor.ActorId);
        Assert.AreEqual(2u, viewModel.Entries[0].AddresseeActor.ActorId);
        Assert.AreEqual(2u, viewModel.Entries[1].SpeakerActor.ActorId);
        Assert.IsTrue(viewModel.Entries[1].AddresseeActor.IsNone);
    }

    [TestMethod]
    public void ShowsBothWordingsOfALineWordedForThePlayersGender()
    {
        var viewModel = ViewModel();

        viewModel.LoadPayload("""
            {
              "lines": [
                {
                  "locStringId": "1",
                  "text": "Got 'nads on you, girl.",
                  "femaleText": "Got 'nads on you, girl.",
                  "maleText": "Got balls on you, boy."
                },
                { "locStringId": "2", "text": "Same either way." }
              ]
            }
            """);

        var gendered = viewModel.Entries[0];

        Assert.IsTrue(gendered.HasGenderedText);
        Assert.AreEqual("Got 'nads on you, girl.", gendered.Text, "the column shows what gets embedded");
        Assert.IsTrue(gendered.TextToolTip.Contains("Got balls on you, boy."), "and the tooltip the other");
        Assert.IsTrue(gendered.TextToolTip.Contains("Only the first is embedded"));

        // An ordinary line says nothing about gender, and its tooltip is just the line.
        Assert.IsFalse(viewModel.Entries[1].HasGenderedText);
        Assert.AreEqual("Same either way.", viewModel.Entries[1].TextToolTip);
    }

    [TestMethod]
    public void LeavesAChoiceOptionWithoutActorsToSet()
    {
        var viewModel = ViewModel();

        viewModel.LoadPayload(ThreeLines);

        Assert.IsFalse(viewModel.Entries[2].CanSetActors);
        Assert.AreEqual("New choice option", viewModel.Entries[2].Status);
    }

    [TestMethod]
    public void OffersALineTheSceneAlreadyCarriesForTheSectionOnly()
    {
        var viewModel = ViewModel(existingLines: [InScene(1002)]);

        viewModel.LoadPayload(ThreeLines);

        var duplicate = viewModel.Entries[1];

        // Takeable, but unticked to begin with: taking it writes nothing, and it is only worth
        // anything to someone laying the whole conversation out as a section.
        Assert.IsTrue(duplicate.IsDuplicate);
        Assert.IsTrue(duplicate.IsSectionOnly);
        Assert.IsTrue(duplicate.CanImport);
        Assert.IsFalse(duplicate.IsSelected);
        Assert.AreEqual("In scene - section only", duplicate.Status);

        Assert.AreEqual(1, viewModel.DuplicateCount);
        Assert.AreEqual(2, viewModel.SelectedCount);
        Assert.AreEqual(2, viewModel.SelectedNewCount);
        Assert.AreEqual(0, viewModel.SelectedExistingCount);
    }

    [TestMethod]
    public void LocksAChoiceOptionTheSceneAlreadyCarries()
    {
        // Nothing plays an option - the player picks it - so there is nothing a section could do
        // with one the scene already has.
        var viewModel = ViewModel(existingOptions: [1003UL]);

        viewModel.LoadPayload(ThreeLines);

        var duplicate = viewModel.Entries[2];

        Assert.IsTrue(duplicate.IsDuplicate);
        Assert.IsFalse(duplicate.IsSectionOnly);
        Assert.IsFalse(duplicate.CanImport);
        Assert.IsFalse(duplicate.IsSelected);
        Assert.AreEqual("Already in scene", duplicate.Status);
    }

    [TestMethod]
    public void ShowsTheScenesOwnActorsOnALineItAlreadyCarries()
    {
        // The export says Viktor speaking to V. The scene says otherwise, and the scene wins: the
        // entry is not being rewritten, so what it says is what will be played.
        var viewModel = ViewModel(existingLines: [InScene(1001, speaker: 1, addressee: 0)]);

        viewModel.LoadPayload(ThreeLines);

        var duplicate = viewModel.Entries[0];

        Assert.AreEqual(1u, duplicate.SpeakerActor.ActorId);
        Assert.AreEqual(0u, duplicate.AddresseeActor.ActorId);
        Assert.IsFalse(duplicate.CanSetActors, "not the import's to change");
        Assert.IsTrue(duplicate.SpeakerToolTip.Contains("does not change"));
    }

    [TestMethod]
    public void ShowsNoActorWhereTheSceneNamesNoneOrOneItNoLongerHas()
    {
        var viewModel = ViewModel(existingLines:
        [
            InScene(1001),
            InScene(1002, speaker: 99)
        ]);

        viewModel.LoadPayload(ThreeLines);

        Assert.IsTrue(viewModel.Entries[0].SpeakerActor.IsNone, "the entry names nobody");
        Assert.IsTrue(viewModel.Entries[1].SpeakerActor.IsNone, "actor 99 is not in this cast");
    }

    [TestMethod]
    public void ChecksAnOptionAgainstTheOptionsHalfOfTheStore()
    {
        // The two halves of the screenplay store number and key themselves independently, so a
        // locstring in one says nothing about the other.
        var viewModel = ViewModel(existingLines: [InScene(1003)], existingOptions: [1001UL]);

        viewModel.LoadPayload(ThreeLines);

        Assert.IsFalse(viewModel.Entries[0].IsDuplicate, "a line is not an option");
        Assert.IsFalse(viewModel.Entries[2].IsDuplicate, "an option is not a line");
    }

    [TestMethod]
    public void HandsBackTheEntryTheSceneAlreadyHasForALineTakenForTheSection()
    {
        var viewModel = ViewModel(existingLines: [InScene(1002, screenplayLineId: 4_097, speaker: 1)]);
        viewModel.LoadPayload(ThreeLines);

        viewModel.Entries[1].IsSelected = true;

        var selections = viewModel.GetLinesToImport();

        // In payload order, so a section plays the conversation as it runs rather than putting the
        // new lines first and the old ones after.
        CollectionAssert.AreEqual(
            new ulong[] { 1001, 1002, 1003 },
            selections.Select(selection => selection.Line.LocStringId).ToArray());

        var reused = selections[1];

        Assert.IsTrue(reused.IsAlreadyInScene);
        Assert.AreEqual(4_097U, reused.ExistingScreenplayLineId);
        Assert.AreEqual(1U, reused.SpeakerActorId, "the scene's speaker, not the export's");

        Assert.IsFalse(selections[0].IsAlreadyInScene);
        Assert.IsNull(selections[0].ExistingScreenplayLineId);
    }

    [TestMethod]
    public void CountsWhatWouldBeWrittenApartFromWhatWouldOnlyBePlayed()
    {
        var viewModel = ViewModel(existingLines: [InScene(1001), InScene(1002)]);
        viewModel.LoadPayload(ThreeLines);

        Assert.AreEqual(1, viewModel.SelectedNewCount, "the choice option is all that is new");
        Assert.AreEqual(0, viewModel.SelectedExistingCount);
        Assert.IsFalse(viewModel.HasSectionOnlySelection);

        viewModel.SelectAllCommand.Execute(null);

        Assert.AreEqual(3, viewModel.SelectedCount);
        Assert.AreEqual(1, viewModel.SelectedNewCount);
        Assert.AreEqual(2, viewModel.SelectedExistingCount);
        Assert.IsTrue(viewModel.HasSectionOnlySelection);
    }

    [TestMethod]
    public void RefusesARunThatWouldLeaveTheSceneExactlyAsItWas()
    {
        // Every line already in the scene: taking them writes nothing, and the section is the only
        // thing that makes taking them worth anything.
        var viewModel = ViewModel(existingLines: [InScene(1001), InScene(1002)], existingOptions: [1003UL]);
        viewModel.LoadPayload(ThreeLines);

        viewModel.SelectAllCommand.Execute(null);

        Assert.AreEqual(2, viewModel.SelectedCount);
        Assert.AreEqual(0, viewModel.SelectedNewCount);
        Assert.IsTrue(viewModel.CanImport, "the section is asked for by default");

        // Turned off, ticking them would write nothing and build nothing, so there is nothing to
        // finish.
        viewModel.CreateSectionNode = false;
        Assert.IsFalse(viewModel.CanImport);

        viewModel.CreateSectionNode = true;
        Assert.IsTrue(viewModel.CanImport);
    }

    [TestMethod]
    public void CountsALineTheSceneAlreadyHasAsTheUserTicksIt()
    {
        // Ticking one row rather than using Select All, which is the other way the counts are
        // reached: the row raises its own change and the totals are taken again.
        var viewModel = ViewModel(existingLines: [InScene(1002)]);
        viewModel.LoadPayload(ThreeLines);

        Assert.AreEqual(0, viewModel.SelectedExistingCount, "it starts unticked");
        Assert.IsFalse(viewModel.HasSectionOnlySelection);
        Assert.AreEqual(2, viewModel.SelectedNewCount, "the other line and the choice option");

        viewModel.Entries[1].IsSelected = true;

        Assert.AreEqual(1, viewModel.SelectedExistingCount);
        Assert.IsTrue(viewModel.HasSectionOnlySelection);
        Assert.AreEqual(2, viewModel.SelectedNewCount, "unchanged - it writes nothing to the store");
        Assert.AreEqual(3, viewModel.SelectedCount);
    }

    [TestMethod]
    public void HandsBackWhatTheUserSettledOn()
    {
        var viewModel = ViewModel();
        viewModel.LoadPayload(ThreeLines);

        viewModel.Entries[1].IsSelected = false;
        viewModel.Entries[0].AddresseeActor = viewModel.ActorOptions.Single(actor => actor.ActorId == 1);

        var imported = viewModel.GetLinesToImport();

        Assert.AreEqual(2, imported.Count);
        Assert.AreEqual(1001UL, imported[0].Line.LocStringId);
        Assert.AreEqual<uint?>(0u, imported[0].SpeakerActorId);
        Assert.AreEqual<uint?>(1u, imported[0].AddresseeActorId, "the user's pick beats the matched name");
        Assert.AreEqual(1003UL, imported[1].Line.LocStringId);
    }

    [TestMethod]
    public void WritesNoActorWhereTheUserLeftOneUnset()
    {
        var viewModel = ViewModel();
        viewModel.LoadPayload(ThreeLines);

        viewModel.Entries[0].SpeakerActor = SceneActorOption.None;

        var imported = viewModel.GetLinesToImport();

        Assert.IsNull(imported[0].SpeakerActorId);
        Assert.AreEqual<uint?>(2u, imported[0].AddresseeActorId);
    }

    [TestMethod]
    public void NeverHandsBackALineTheSceneAlreadyCarriesAsOneToWrite()
    {
        var viewModel = ViewModel(existingLines: [InScene(1001)], existingOptions: [1003UL]);
        viewModel.LoadPayload(ThreeLines);

        // Asked for outright, both of them. The line comes back marked as the scene's own, so the
        // import plays it rather than writing it; the option does not come back at all.
        viewModel.Entries[0].IsSelected = true;
        viewModel.Entries[2].IsSelected = true;

        var selections = viewModel.GetLinesToImport();

        var line = selections.Single(selection => selection.Line.LocStringId == 1001UL);
        Assert.IsTrue(line.IsAlreadyInScene);

        Assert.IsFalse(
            selections.Any(selection => selection.Line.LocStringId == 1003UL),
            "a duplicate option is filtered on the way out as well as locked in the list");

        // Nothing that would be written to the store is one the scene already has.
        Assert.IsFalse(selections.Any(selection => !selection.IsAlreadyInScene && selection.Line.LocStringId == 1001UL));
    }

    [TestMethod]
    public void SelectsAndDeselectsEverythingItIsAllowedTo()
    {
        var viewModel = ViewModel(existingLines: [InScene(1001)], existingOptions: [1003UL]);
        viewModel.LoadPayload(ThreeLines);

        viewModel.SelectNoneCommand.Execute(null);

        Assert.AreEqual(0, viewModel.SelectedCount);
        Assert.IsFalse(viewModel.CanImport);

        viewModel.SelectAllCommand.Execute(null);

        // The duplicate line comes along, for a section's sake; the duplicate option cannot.
        Assert.AreEqual(2, viewModel.SelectedCount);
        Assert.IsTrue(viewModel.Entries[0].IsSelected);
        Assert.IsFalse(viewModel.Entries[2].IsSelected, "no section plays a choice option");
        Assert.IsTrue(viewModel.CanImport);
    }

    [TestMethod]
    public void KeepsTheCountsWithASingleRowsCheckbox()
    {
        var viewModel = ViewModel();
        viewModel.LoadPayload(ThreeLines);

        viewModel.Entries[0].IsSelected = false;

        Assert.AreEqual(2, viewModel.SelectedCount);

        viewModel.Entries[0].IsSelected = true;

        Assert.AreEqual(3, viewModel.SelectedCount);
    }

    [TestMethod]
    public void TypingInThePayloadBoxLeavesTheListAlone()
    {
        // Rebuilding the list throws away every speaker, addressee and checkbox the user has set,
        // so an edit in the box marks it stale rather than doing it out from under them.
        var viewModel = ViewModel();
        viewModel.SetPayload(ThreeLines, "the clipboard");
        viewModel.Entries[0].IsSelected = false;

        Assert.IsFalse(viewModel.IsPayloadStale);

        viewModel.JsonText = ThreeLines + " ";

        Assert.IsTrue(viewModel.IsPayloadStale);
        Assert.AreEqual(3, viewModel.Entries.Count);
        Assert.IsFalse(viewModel.Entries[0].IsSelected, "the user's selection survived the edit");
    }

    [TestMethod]
    public void RereadsThePayloadWhenAskedTo()
    {
        var viewModel = ViewModel();
        viewModel.SetPayload(ThreeLines, "the clipboard");
        viewModel.Entries[0].IsSelected = false;

        viewModel.JsonText = """{ "lines": [ { "locStringId": "9001", "text": "Only this one now." } ] }""";
        viewModel.ReadPayloadCommand.Execute(null);

        Assert.IsFalse(viewModel.IsPayloadStale);
        Assert.AreEqual(1, viewModel.Entries.Count);
        Assert.AreEqual("9001", viewModel.Entries[0].LocStringId);
        Assert.AreEqual(1, viewModel.SelectedCount);
    }

    [TestMethod]
    public void ReplacesAnImportRatherThanAddingToIt()
    {
        var viewModel = ViewModel();

        viewModel.LoadPayload(ThreeLines);
        viewModel.LoadPayload(ThreeLines);

        Assert.AreEqual(3, viewModel.Entries.Count);
        Assert.AreEqual(3, viewModel.SelectedCount);
    }

    [TestMethod]
    public void ClearsBackToWhereItStarted()
    {
        var viewModel = ViewModel();
        viewModel.SetPayload(ThreeLines, "the clipboard");

        viewModel.ClearCommand.Execute(null);

        Assert.AreEqual("", viewModel.JsonText);
        Assert.AreEqual(0, viewModel.Entries.Count);
        Assert.IsFalse(viewModel.HasEntries);
        Assert.IsFalse(viewModel.CanImport);
        Assert.IsFalse(viewModel.IsPayloadStale);
        Assert.IsFalse(viewModel.IsStatusError);
    }

    [TestMethod]
    public void NamesWhereAHandedOverPayloadCameFrom()
    {
        var viewModel = ViewModel();

        viewModel.SetPayload(ThreeLines, "the clipboard");

        Assert.AreEqual(ThreeLines, viewModel.JsonText);
        Assert.AreEqual(3, viewModel.Entries.Count);
        Assert.IsFalse(viewModel.IsPayloadStale);
        Assert.IsTrue(viewModel.StatusMessage.Contains("the clipboard"));
    }

    [TestMethod]
    public void ReportsTheSameFileHandedOverTwice()
    {
        // The text does not change on the second pass, so nothing but an outright read would say so.
        var viewModel = ViewModel();
        viewModel.SetPayload(ThreeLines, "export.json");

        // A read of the same text with nobody behind it - the status stops naming a source.
        viewModel.LoadPayload(ThreeLines);
        Assert.IsFalse(viewModel.StatusMessage.Contains("export.json"));

        viewModel.SetPayload(ThreeLines, "export.json");

        Assert.IsTrue(viewModel.StatusMessage.Contains("export.json"));
        Assert.AreEqual(3, viewModel.Entries.Count);
    }

    [TestMethod]
    public void SaysWhatIsWrongWithAPayloadItCannotRead()
    {
        var viewModel = ViewModel();
        viewModel.LoadPayload(ThreeLines);

        viewModel.LoadPayload("not json at all");

        Assert.IsTrue(viewModel.IsStatusError);
        Assert.AreEqual(0, viewModel.Entries.Count);
        Assert.IsFalse(viewModel.HasEntries);
        Assert.IsFalse(viewModel.CanImport);
    }

    [TestMethod]
    public void TakesAnEntryThatCarriesNoItemIdSoTheImportCanGiveItOne()
    {
        // A line added through the raw chunk editor and never given an item id. The scene has it, so
        // it is not imported again, but it can still be taken: the import gives the entry an id and
        // the section plays it.
        var viewModel = ViewModel(existingLines: [InScene(1001, screenplayLineId: null)]);
        viewModel.LoadPayload(ThreeLines);

        var entry = viewModel.Entries[0];

        Assert.IsTrue(entry.IsDuplicate, "the scene has this locstring");
        Assert.IsTrue(entry.IsSectionOnly, "nothing is written to the store for it");
        Assert.IsTrue(entry.NeedsItemId);
        Assert.IsTrue(entry.CanImport, "so the row is the user's to tick");
        Assert.IsFalse(entry.CanSetActors, "the entry is not being rewritten");
        Assert.AreEqual("In scene - needs item id", entry.Status);

        viewModel.SelectAllCommand.Execute(null);

        Assert.AreEqual(1, viewModel.SelectedExistingCount);
        Assert.IsTrue(viewModel.HasSectionOnlySelection);

        // Handed back saying the scene has it but naming no id, which is what tells the import to
        // give the entry one.
        var selection = viewModel.GetLinesToImport().Single(line => line.Line.LocStringId == 1001);

        Assert.IsTrue(selection.IsAlreadyInScene);
        Assert.IsNull(selection.ExistingScreenplayLineId);
    }

    [TestMethod]
    public void LaysTheConversationOutUnlessTheUserSaysOtherwise()
    {
        // Lines in the store with nothing playing them is half an import, so the section is on and
        // the user unticks it.
        Assert.IsTrue(ViewModel().CreateSectionNode);
    }

    [TestMethod]
    public void HandsBackTheConversationTheExportNamed()
    {
        var viewModel = ViewModel();

        viewModel.LoadPayload(ThreeLines);
        Assert.AreEqual("Ripperdoc", viewModel.ConversationName);

        viewModel.LoadPayload("not json at all");
        Assert.AreEqual("", viewModel.ConversationName, "a payload that would not read names nothing");
    }

    [TestMethod]
    public void CarriesALinesTimingAndActorsThroughToTheSection()
    {
        var viewModel = ViewModel();
        viewModel.LoadPayload(TimedLines);

        var selection = viewModel.GetLinesToImport()[0];
        var sectionLine = selection.ToSectionLine(257);

        Assert.AreEqual(257U, sectionLine.ScreenplayLineId);
        Assert.AreEqual(1_988U, sectionLine.DurationMs);
        Assert.AreEqual(1_500U, sectionLine.StartTimeMs, "where the export placed it in the conversation");
        Assert.AreEqual(0U, sectionLine.SpeakerActorId, "Viktor Vektor, matched against the cast");
        Assert.AreEqual(2U, sectionLine.AddresseeActorId, "V, which is always the first player actor");
        Assert.AreEqual("Vo_Context_Quest", sectionLine.VoContext);
        Assert.AreEqual("Vo_Expression_Spoken", sectionLine.VoExpression);
        Assert.AreEqual("Welcome to Night City.", sectionLine.Text);
    }

}
