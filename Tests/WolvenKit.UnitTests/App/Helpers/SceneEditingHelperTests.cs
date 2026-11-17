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
