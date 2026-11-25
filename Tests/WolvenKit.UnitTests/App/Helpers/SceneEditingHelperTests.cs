using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.App.Helpers;
using WolvenKit.RED4.Types;

namespace WolvenKit.UnitTests.App.Helpers;

/// <summary>
/// How a screenplay store hands out its next item id. Graph events bind to their screenplay entry
/// by item id, so an id handed out twice makes a scnDialogLineEvent play the wrong line.
/// </summary>
[TestClass]
public class SceneEditingHelperScreenplayItemIdTests
{
    private const uint Step = SceneEditingHelper.ScreenplayItemIdStep;
    private const uint Unassigned = SceneEditingHelper.UnassignedScreenplayItemId;

    [TestMethod]
    public void StartsEachHalfOfTheStoreWhereTheGameStartsIt()
    {
        Assert.AreEqual(1u, SceneEditingHelper.GetNextScreenplayItemId([], 1));
        Assert.AreEqual(2u, SceneEditingHelper.GetNextScreenplayItemId([], 2));

        Assert.AreEqual(1u, SceneEditingHelper.GetNextDialogLineItemId([]));
        Assert.AreEqual(2u, SceneEditingHelper.GetNextChoiceOptionItemId([]));
    }

    [TestMethod]
    public void CountsAStepUpFromTheHighestIdInUse()
    {
        Assert.AreEqual(257u, SceneEditingHelper.GetNextScreenplayItemId([1], 1));
        Assert.AreEqual(769u, SceneEditingHelper.GetNextScreenplayItemId([1, 257, 513], 1));
    }

    [TestMethod]
    public void CountsFromTheHighestIdWhereverTheStoreKeepsIt()
    {
        // Nothing sorts the array, so a store whose entries were added or reordered through the raw
        // chunk editor can carry its highest id anywhere. Taking the last one would hand out 257 -
        // an id already in use.
        Assert.AreEqual(769u, SceneEditingHelper.GetNextScreenplayItemId([513, 1, 257], 1));
        Assert.AreEqual(770u, SceneEditingHelper.GetNextScreenplayItemId([514, 2, 258], 2));
    }

    [TestMethod]
    public void LeavesTheFirstIdAloneWhenEverythingInTheStoreIsBelowIt()
    {
        Assert.AreEqual(2u, SceneEditingHelper.GetNextScreenplayItemId([0], 2));
    }

    [TestMethod]
    public void PassesOverAnEntryTheRawEditorLeftUnassigned()
    {
        // A screenplay entry added through the raw array editor carries the ctor default. Counting a
        // step up from it wraps a 32 bit uint to 0, which every other unassigned entry answers to.
        Assert.AreEqual(0u, unchecked(Unassigned + Step), "the wrap this guards against");

        Assert.AreEqual(1u, SceneEditingHelper.GetNextScreenplayItemId([Unassigned], 1));
        Assert.AreEqual(513u, SceneEditingHelper.GetNextScreenplayItemId([1, Unassigned, 257], 1));
    }

    [TestMethod]
    public void PassesOverAnyIdTooHighToStepPast()
    {
        Assert.AreEqual(1u, SceneEditingHelper.GetNextScreenplayItemId([uint.MaxValue], 1));
        Assert.AreEqual(uint.MaxValue, SceneEditingHelper.GetNextScreenplayItemId([uint.MaxValue - Step], 1));
    }

    [TestMethod]
    public void ReadsTheIdsOffTheStoreItself()
    {
        var lines = new[]
        {
            new scnscreenplayDialogLine { ItemId = new scnscreenplayItemId { Id = 513 } },
            new scnscreenplayDialogLine { ItemId = new scnscreenplayItemId { Id = 1 } },
            // Added through the raw array editor and never given an id.
            new scnscreenplayDialogLine()
        };

        Assert.AreEqual(769u, SceneEditingHelper.GetNextDialogLineItemId(lines));
    }

    [TestMethod]
    public void ReadsTheIdsOffTheOptionsHalfToo()
    {
        var options = new[]
        {
            new scnscreenplayChoiceOption { ItemId = new scnscreenplayItemId { Id = 2 } },
            new scnscreenplayChoiceOption { ItemId = new scnscreenplayItemId { Id = 514 } }
        };

        Assert.AreEqual(770u, SceneEditingHelper.GetNextChoiceOptionItemId(options));
    }

    [TestMethod]
    public void TakesAStoreThatIsNotThere()
    {
        Assert.AreEqual(1u, SceneEditingHelper.GetNextDialogLineItemId(null));
        Assert.AreEqual(2u, SceneEditingHelper.GetNextChoiceOptionItemId(null));
    }

    [TestMethod]
    public void KeepsTheStepTheGameNumbersBy()
    {
        // Lower and the previous entry's text is used; higher and nothing is shown at all.
        var ids = new uint[16];
        var next = SceneEditingHelper.GetNextDialogLineItemId([]);

        for (var i = 0; i < ids.Length; i++)
        {
            ids[i] = next;
            next = SceneEditingHelper.GetNextScreenplayItemId(ids.Take(i + 1), 1);
        }

        Assert.AreEqual(ids.Length, ids.Distinct().Count());
        CollectionAssert.AreEqual(
            Enumerable.Range(0, ids.Length).Select(i => 1u + ((uint)i * Step)).ToArray(),
            ids);
    }
}

/// <summary>
/// Tests scene lipsync naming, grouping, lipmap entries, and anim-set assignment.
/// </summary>
[TestClass]
public class SceneEditingHelperLipsyncTests
{
    private const ulong hotelFluffLineRuid = 1983789867379531776;
    private const ulong judyVoicetag = 1103967280742240536;
    private const ulong playerVoicetag = 1103967280742240864;
    private const uint noActor = uint.MaxValue;
    private const uint noLipsyncAnimSet = uint.MaxValue;

    [TestMethod]
    public void NamesAnimationsAfterTheRuidInUppercaseHex()
    {
        Assert.AreEqual("f_1B87D65FB22D2000", (string?)SceneEditingHelper.GetFemaleLipsyncAnimationName(hotelFluffLineRuid));
        Assert.AreEqual("m_1B87D65FB22D2000", (string?)SceneEditingHelper.GetMaleLipsyncAnimationName(hotelFluffLineRuid));
    }

    [TestMethod]
    public void PadsShortRuidsToSixteenDigits() =>
        Assert.AreEqual("f_00000000000000AB", (string?)SceneEditingHelper.GetFemaleLipsyncAnimationName(0xAB));

    [TestMethod]
    public void FillsOnlyTheNamesALineLeavesEmpty()
    {
        var unnamed = CreateLine(1, 0, 0x1111);

        var femaleOnly = CreateLine(257, 0, 0x2222);
        femaleOnly.FemaleLipsyncAnimationName = "f_custom";

        var named = CreateLine(513, 0, 0x3333);
        named.FemaleLipsyncAnimationName = "f_kept";
        named.MaleLipsyncAnimationName = "m_kept";

        var withoutRuid = CreateLine(769, 0, 0);

        var scene = new scnSceneResource
        {
            ScreenplayStore = new scnscreenplayStore { Lines = new() { unnamed, femaleOnly, named, withoutRuid } },
        };

        Assert.AreEqual(2, SceneEditingHelper.FillMissingLipsyncAnimationNames(scene));

        Assert.AreEqual("f_0000000000001111", (string?)unnamed.FemaleLipsyncAnimationName);
        Assert.AreEqual("m_0000000000001111", (string?)unnamed.MaleLipsyncAnimationName);
        Assert.AreEqual("f_custom", (string?)femaleOnly.FemaleLipsyncAnimationName);
        Assert.AreEqual("m_0000000000002222", (string?)femaleOnly.MaleLipsyncAnimationName);
        Assert.AreEqual("f_kept", (string?)named.FemaleLipsyncAnimationName);
        Assert.AreEqual("m_kept", (string?)named.MaleLipsyncAnimationName);
        Assert.IsTrue(CName.IsNullOrEmpty(withoutRuid.FemaleLipsyncAnimationName));
        Assert.IsTrue(CName.IsNullOrEmpty(withoutRuid.MaleLipsyncAnimationName));
    }

    [TestMethod]
    public void LeavesTheLinesOfPlayerActorsUnnamed()
    {
        var judyLine = CreateLine(1, 0, 0x1111);
        var playerLine = CreateLine(257, 1, 0x2222);

        var scene = new scnSceneResource
        {
            Actors = new() { CreateActor(0, judyVoicetag, "Judy") },
            PlayerActors = new() { CreatePlayerActor(1) },
            ScreenplayStore = new scnscreenplayStore { Lines = new() { judyLine, playerLine } },
        };

        Assert.AreEqual(1, SceneEditingHelper.FillMissingLipsyncAnimationNames(scene));

        Assert.AreEqual("f_0000000000001111", (string?)judyLine.FemaleLipsyncAnimationName);
        Assert.IsTrue(CName.IsNullOrEmpty(playerLine.FemaleLipsyncAnimationName));
        Assert.IsTrue(CName.IsNullOrEmpty(playerLine.MaleLipsyncAnimationName));
    }

    [TestMethod]
    public void GroupsLinesByTheVoicetagOfTheirSpeaker()
    {
        var playerLine = CreateLine(257, 2, 0x2);
        playerLine.FemaleLipsyncAnimationName = "f_0000000000000002";

        var scene = new scnSceneResource
        {
            Actors = new()
            {
                CreateActor(0, judyVoicetag, "Judy"),
                CreateActor(1, judyVoicetag, "Judy_holocall"),
                CreateActor(3, 0, "Passerby"),
            },
            PlayerActors = new() { CreatePlayerActor(2) },
            ScreenplayStore = new scnscreenplayStore
            {
                Lines = new()
                {
                    CreateLine(1, 0, 0x1),
                    playerLine,
                    CreateLine(513, 1, 0x3),
                    CreateLine(769, 3, 0x4),
                    CreateLine(1025, noActor, 0x5),
                },
            },
        };

        SceneEditingHelper.FillMissingLipsyncAnimationNames(scene);

        var voices = SceneEditingHelper.CollectLipsyncVoices(scene);

        // Player lines are excluded, even when already named.
        Assert.AreEqual(2, voices.Count);

        // Actors with the same voicetag share a voice and anim set.
        Assert.AreEqual(judyVoicetag, (ulong)voices[0].VoicetagId);
        Assert.AreEqual("Judy", (string)voices[0].ActorName);
        CollectionAssert.AreEqual(new ulong[] { 0x1, 0x3 }, voices[0].Lines.Select(line => (ulong)line.LocstringId.Ruid).ToArray());
        Assert.AreEqual(4, voices[0].AnimationNames.Count());

        Assert.IsFalse(voices[1].HasVoicetag);
        Assert.AreEqual("Passerby", (string)voices[1].ActorName);
        Assert.AreEqual(1, voices[1].Lines.Count);
    }

    [TestMethod]
    public void FindsTheEntryOfAScene()
    {
        var mapping = new animLipsyncMapping();
        var entry = CreateEntry(judyVoicetag);
        mapping.SetSceneEntry(7UL, CreateEntry(playerVoicetag));
        mapping.SetSceneEntry(42UL, entry);

        Assert.AreSame(entry, mapping.GetSceneEntry(42UL));
        Assert.IsNull(mapping.GetSceneEntry(99UL));
    }

    [TestMethod]
    public void AppendsASceneTheLipmapDoesNotHaveYet()
    {
        var mapping = new animLipsyncMapping();
        var entry = CreateEntry(judyVoicetag);

        mapping.SetSceneEntry(42UL, entry);

        Assert.AreEqual(1, mapping.ScenePaths.Count);
        Assert.AreEqual(42UL, (ulong)mapping.ScenePaths[0]);
        Assert.AreEqual(1, mapping.ScenePreviewPaths.Count);
        Assert.AreSame(entry, mapping.SceneEntries[0]);
    }

    [TestMethod]
    public void ReplacesOnlyTheScenesOwnEntry()
    {
        var mapping = new animLipsyncMapping();
        var otherScene = CreateEntry(playerVoicetag);
        mapping.SetSceneEntry(7UL, otherScene);
        mapping.SetSceneEntry(42UL, CreateEntry(judyVoicetag));

        var replacement = CreateEntry(judyVoicetag);
        mapping.SetSceneEntry(42UL, replacement);

        Assert.AreEqual(2, mapping.ScenePaths.Count);
        Assert.AreEqual(2, mapping.ScenePreviewPaths.Count);
        Assert.AreEqual(2, mapping.SceneEntries.Count);
        Assert.AreSame(otherScene, mapping.SceneEntries[0]);
        Assert.AreSame(replacement, mapping.SceneEntries[1]);
    }

    [TestMethod]
    public void FillsInThePreviewPathsALipmapLacks()
    {
        var mapping = new animLipsyncMapping
        {
            ScenePaths = new() { 7UL, 8UL },
            SceneEntries = new() { CreateEntry(judyVoicetag), CreateEntry(playerVoicetag) },
        };

        mapping.SetSceneEntry(42UL, CreateEntry(judyVoicetag));

        Assert.AreEqual(3, mapping.ScenePreviewPaths.Count);
        Assert.AreEqual(8UL, (ulong)mapping.ScenePreviewPaths[1]);
    }

    [TestMethod]
    public void RemovesASceneFromAllThreeArrays()
    {
        var mapping = new animLipsyncMapping();
        var keptScene = CreateEntry(playerVoicetag);
        mapping.SetSceneEntry(7UL, keptScene);
        mapping.SetSceneEntry(42UL, CreateEntry(judyVoicetag));

        Assert.IsTrue(mapping.RemoveSceneEntry(42UL));
        Assert.IsFalse(mapping.RemoveSceneEntry(42UL));

        Assert.AreEqual(1, mapping.ScenePaths.Count);
        Assert.AreEqual(1, mapping.ScenePreviewPaths.Count);
        Assert.AreSame(keptScene, mapping.SceneEntries[0]);
    }

    [TestMethod]
    public void PointsOnlyActorsThatSpeakAtTheAnimSetOfTheirVoicetag()
    {
        ResourcePath judyAnimSet = @"mod\my_mod\localization\en-us\lipsync\talk\judy.anims";
        ResourcePath playerAnimSet = @"mod\my_mod\localization\en-us\lipsync\talk\player.anims";

        var judy = CreateActor(0, judyVoicetag, "Judy");
        var holocall = CreateActor(1, judyVoicetag, "Judy_holocall");
        var silentJudy = CreateActor(2, judyVoicetag, "Judy_silent");
        silentJudy.LipsyncAnimSet = new scnLipsyncAnimSetSRRefId { Id = 0 };
        var passerby = CreateActor(3, 0x1234, "Passerby");
        var player = CreatePlayerActor(4);
        player.LipsyncAnimSet = new scnLipsyncAnimSetSRRefId { Id = 1 };

        var scene = new scnSceneResource
        {
            Actors = new() { judy, holocall, silentJudy, passerby },
            PlayerActors = new() { player },
            ScreenplayStore = new scnscreenplayStore
            {
                Lines = new()
                {
                    CreateLine(1, 0, 0x1),
                    CreateLine(257, 4, 0x2),
                    CreateLine(513, 1, 0x3),
                    CreateLine(769, 3, 0x4),
                },
            },
        };

        Assert.IsTrue(SceneEditingHelper.AssignLipsyncAnimSets(scene, new Dictionary<CRUID, ResourcePath>
        {
            [judyVoicetag] = judyAnimSet,
            [playerVoicetag] = playerAnimSet,
        }));

        var lipsyncAnimSets = scene.ResouresReferences.LipsyncAnimSets;
        Assert.AreEqual(1, lipsyncAnimSets.Count);
        Assert.AreEqual((ulong)judyAnimSet, (ulong)lipsyncAnimSets[0].AsyncRefLipsyncAnimSet.DepotPath);

        // Actors with the same voicetag share an entry.
        Assert.AreEqual(0u, (uint)judy.LipsyncAnimSet.Id);
        Assert.AreEqual(0u, (uint)holocall.LipsyncAnimSet.Id);

        // Silent actors and actors without generated anim sets remain unassigned.
        Assert.AreEqual(noLipsyncAnimSet, (uint)silentJudy.LipsyncAnimSet.Id);
        Assert.AreEqual(noLipsyncAnimSet, (uint)passerby.LipsyncAnimSet.Id);

        // Player actors remain unassigned.
        Assert.AreEqual(noLipsyncAnimSet, (uint)player.LipsyncAnimSet.Id);
    }

    [TestMethod]
    public void DropsTheLipsyncAnimSetsTheSceneReferencedBefore()
    {
        ResourcePath vanillaAnimSet = @"base\quest\scenes\lipsync\en\talk\judy.anims";
        ResourcePath judyAnimSet = @"mod\my_mod\localization\en-us\lipsync\talk\judy.anims";

        var judy = CreateActor(0, judyVoicetag, "Judy");
        judy.LipsyncAnimSet = new scnLipsyncAnimSetSRRefId { Id = 1 };

        var scene = new scnSceneResource
        {
            Actors = new() { judy },
            ScreenplayStore = new scnscreenplayStore { Lines = new() { CreateLine(1, 0, 0x1) } },
        };
        scene.ResouresReferences.LipsyncAnimSets.Add(CreateLipsyncAnimSetReference(vanillaAnimSet));
        scene.ResouresReferences.LipsyncAnimSets.Add(CreateLipsyncAnimSetReference(judyAnimSet));

        Assert.IsTrue(SceneEditingHelper.AssignLipsyncAnimSets(scene,
            new Dictionary<CRUID, ResourcePath> { [judyVoicetag] = judyAnimSet }));

        Assert.AreEqual(1, scene.ResouresReferences.LipsyncAnimSets.Count);
        Assert.AreEqual((ulong)judyAnimSet, (ulong)scene.ResouresReferences.LipsyncAnimSets[0].AsyncRefLipsyncAnimSet.DepotPath);
        Assert.AreEqual(0u, (uint)judy.LipsyncAnimSet.Id);
    }

    [TestMethod]
    public void ReportsNoChangeForASceneAlreadyPointedAtItsAnimSets()
    {
        var scene = new scnSceneResource
        {
            Actors = new() { CreateActor(0, judyVoicetag, "Judy") },
            ScreenplayStore = new scnscreenplayStore { Lines = new() { CreateLine(1, 0, 0x1) } },
        };
        var animSetsByVoicetag = new Dictionary<CRUID, ResourcePath>
        {
            [judyVoicetag] = @"mod\my_mod\localization\en-us\lipsync\talk\judy.anims",
        };

        Assert.IsTrue(SceneEditingHelper.AssignLipsyncAnimSets(scene, animSetsByVoicetag));
        Assert.IsFalse(SceneEditingHelper.AssignLipsyncAnimSets(scene, animSetsByVoicetag));
    }

    private static scnscreenplayDialogLine CreateLine(uint itemId, uint speakerId, ulong ruid) => new()
    {
        ItemId = new scnscreenplayItemId { Id = itemId },
        Speaker = new scnActorId { Id = speakerId },
        LocstringId = new scnlocLocstringId { Ruid = ruid },
    };

    private static scnActorDef CreateActor(uint actorId, ulong voicetag, string actorName) => new()
    {
        ActorId = new scnActorId { Id = actorId },
        VoicetagId = new scnVoicetagId { Id = voicetag },
        ActorName = actorName,
    };

    private static scnPlayerActorDef CreatePlayerActor(uint actorId) => new()
    {
        ActorId = new scnActorId { Id = actorId },
        VoicetagId = new scnVoicetagId { Id = playerVoicetag },
        PlayerName = "Player",
    };

    private static animLipsyncMappingSceneEntry CreateEntry(ulong voicetag) => new()
    {
        ActorVoiceTags = new() { voicetag },
    };

    private static scnLipsyncAnimSetSRRef CreateLipsyncAnimSetReference(ResourcePath animSetPath) => new()
    {
        AsyncRefLipsyncAnimSet = new CResourceAsyncReference<animAnimSet>(animSetPath),
    };
}
