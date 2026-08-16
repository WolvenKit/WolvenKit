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

    /// <summary>The scene these tests import into: two cast members and a player actor.</summary>
    private static DialogueImportDialogViewModel ViewModel(
        IEnumerable<ulong>? existingLines = null,
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
    public void LeavesAChoiceOptionWithoutActorsToSet()
    {
        var viewModel = ViewModel();

        viewModel.LoadPayload(ThreeLines);

        Assert.IsFalse(viewModel.Entries[2].CanSetActors);
        Assert.AreEqual("New choice option", viewModel.Entries[2].Status);
    }

    [TestMethod]
    public void LocksALineTheSceneAlreadyCarries()
    {
        var viewModel = ViewModel(existingLines: [1002UL]);

        viewModel.LoadPayload(ThreeLines);

        Assert.IsTrue(viewModel.Entries[1].IsDuplicate);
        Assert.IsFalse(viewModel.Entries[1].CanImport);
        Assert.IsFalse(viewModel.Entries[1].IsSelected);
        Assert.AreEqual("Already in scene", viewModel.Entries[1].Status);
        Assert.AreEqual(1, viewModel.DuplicateCount);
        Assert.AreEqual(2, viewModel.SelectedCount);
    }

    [TestMethod]
    public void ChecksAnOptionAgainstTheOptionsHalfOfTheStore()
    {
        // The two halves of the screenplay store number and key themselves independently, so a
        // locstring in one says nothing about the other.
        var viewModel = ViewModel(existingLines: [1003UL], existingOptions: [1001UL]);

        viewModel.LoadPayload(ThreeLines);

        Assert.IsFalse(viewModel.Entries[0].IsDuplicate, "a line is not an option");
        Assert.IsFalse(viewModel.Entries[2].IsDuplicate, "an option is not a line");
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
    public void NeverHandsBackALineTheSceneAlreadyCarries()
    {
        var viewModel = ViewModel(existingLines: [1001UL]);
        viewModel.LoadPayload(ThreeLines);

        // Even asked for outright: a duplicate is filtered on the way out as well as locked in the
        // list, so a payload swapped out from under the selection cannot smuggle one in.
        viewModel.Entries[0].IsSelected = true;

        Assert.IsFalse(viewModel.GetLinesToImport().Any(selection => selection.Line.LocStringId == 1001UL));
    }

    [TestMethod]
    public void SelectsAndDeselectsEverythingItIsAllowedTo()
    {
        var viewModel = ViewModel(existingLines: [1001UL]);
        viewModel.LoadPayload(ThreeLines);

        viewModel.SelectNoneCommand.Execute(null);

        Assert.AreEqual(0, viewModel.SelectedCount);
        Assert.IsFalse(viewModel.CanImport);

        viewModel.SelectAllCommand.Execute(null);

        Assert.AreEqual(2, viewModel.SelectedCount, "the duplicate stays out of it");
        Assert.IsFalse(viewModel.Entries[0].IsSelected);
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
}
