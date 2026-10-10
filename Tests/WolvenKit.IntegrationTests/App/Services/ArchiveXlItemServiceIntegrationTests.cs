using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.App;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Modkit.RED4.Project;
using WolvenKit.App.Services;
using WolvenKit.IntegrationTests.Helpers;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using Xunit;

namespace WolvenKit.IntegrationTests.App.Services;

/// <summary>
/// Covers the root entity / .app generation in <see cref="ArchiveXlItemService"/>, using the real
/// game archives as the template source.
/// </summary>
[Collection(nameof(ArchiveXlItemTestCollection))]
public class ArchiveXlItemServiceIntegrationTests : IDisposable
{
    private const string ForceHairTag = "force_Hair";

    private readonly ArchiveXlItemTestFixture _fixture;
    private readonly Cp77Project _project;
    private readonly string _projectRoot;

    public ArchiveXlItemServiceIntegrationTests(ArchiveXlItemTestFixture fixture)
    {
        _fixture = fixture;
        _project = fixture.CreateTempProject(out _projectRoot);
    }

    #region force_Hair on the root entity

    /// <summary>
    /// This test generates two differently-named items that both want force hair, then counts
    /// the root entities in the project. It asserts there's exactly one and that it contains
    /// both items' appearances... items whose tags agree can share, and splitting them into
    /// separate files means the reuse check isn't recognizing a match it should.
    /// </summary>
    [Fact]
    public void ForceHair_WritesForceHairTagToRootEntity()
    {
        _fixture.ItemService.CreateEquipmentItem(MakeItem("hair_item", forceHair: true));

        var rootEntities = FindRootEntities();
        Assert.Single(rootEntities);

        var tags = ReadVisualTags(rootEntities[0]);
        Assert.Contains(ForceHairTag, tags);
    }

    /// <summary>
    /// This test generates two different items that both want force hair. It asserts they end up
    /// in one root entity holding both appearances, since nothing about them conflicts, because
    /// two items that agree on their tags have no reason to live in separate files.
    /// </summary>
    [Fact]
    public void ForceHair_TwoCompatibleItems_ShareASingleRootEntity()
    {
        _fixture.ItemService.CreateEquipmentItem(MakeItem("first_item", forceHair: true));
        _fixture.ItemService.CreateEquipmentItem(MakeItem("second_item", forceHair: true));

        var rootEntities = FindRootEntities();
        Assert.Single(rootEntities);

        var appearances = ReadEntityAppearanceNames(rootEntities[0]);
        Assert.Contains("first_item_", appearances);
        Assert.Contains("second_item_", appearances);
    }

    /// <summary>
    /// This test generates a force-hair item, then generates the exact same item again with
    /// nothing changed. It asserts the project still has one root entity: the second pass should
    /// recognize the one it just wrote and reuse it, not decide it's unsuitable and fork a new one.
    /// </summary>
    [Fact]
    public void ForceHair_RegeneratingUnchangedItem_DoesNotCreateASecondRootEntity()
    {
        _fixture.ItemService.CreateEquipmentItem(MakeItem("stable_item", forceHair: true));
        var afterFirstPass = FindRootEntities();
        Assert.Single(afterFirstPass);

        // Same item, same settings - the dialog builds a fresh instance each time it is opened.
        _fixture.ItemService.CreateEquipmentItem(MakeItem("stable_item", forceHair: true));

        var afterSecondPass = FindRootEntities();
        Assert.Single(afterSecondPass);
        Assert.Equal(afterFirstPass[0], afterSecondPass[0]);
    }

    /// <summary>
    /// This test puts a root entity carrying the force_Hair tag in the project, then generates
    /// an item that didn't ask for force hair. It asserts that item doesn't get added to that
    /// entity... the tag applies to everything in it, so sharing the tag would silently force
    /// hair onto an item that never asked for it. (This makes sure that can't happen.)
    /// </summary>
    [Fact]
    public void NoForceHair_ItemIsNotAddedToAForceHairRootEntity()
    {
        // Produce a root entity the normal way, then make it a force-hair entity.
        _fixture.ItemService.CreateEquipmentItem(MakeItem("seed_item", forceHair: false));

        var seeded = Assert.Single(FindRootEntities());
        AddVisualTag(seeded, ForceHairTag);
        Assert.Contains(ForceHairTag, ReadVisualTags(seeded));

        _fixture.ItemService.CreateEquipmentItem(MakeItem("plain_item", forceHair: false));

        Assert.DoesNotContain("plain_item_", ReadEntityAppearanceNames(seeded));
    }

    #endregion

    #region .app appearances

    /// <summary>
    /// Generates a hide-in-FPP item with one toggle, then generates the same item a second time..
    /// the way a user would after reopening the dialog to tweak something. It asserts the .app
    /// file still holds the same two appearances afterward rather than a second copy of each.
    /// </summary>
    [Fact]
    public void HideInFpp_RegeneratingDoesNotDuplicateAppAppearances()
    {
        _fixture.ItemService.CreateEquipmentItem(MakeItem("fpp_item", hideInFpp: true, toggles: ["hood"]));

        var appFile = Assert.Single(FindAppFiles());
        var afterFirstPass = ReadAppAppearanceNames(appFile);

        // Sanity check: one appearance per toggle combination, each carrying the tpp suffix.
        Assert.Equal(2, afterFirstPass.Count);
        Assert.All(afterFirstPass, name => Assert.EndsWith("&camera=tpp", name));

        _fixture.ItemService.CreateEquipmentItem(MakeItem("fpp_item", hideInFpp: true, toggles: ["hood"]));

        var afterSecondPass = ReadAppAppearanceNames(appFile);
        Assert.Equal(afterFirstPass.Count, afterSecondPass.Count);
        Assert.Equal(afterSecondPass.Count, afterSecondPass.Distinct().Count());
    }

    /// <summary>
    /// Toggles_AllAppearancesAreWrittenToAppFile generates an item with one toggle,
    /// which should produce two appearances in the .app file — one for the toggle on,
    /// one for it off. It asserts both are actually there with the right names,
    /// rather than the second one overwriting the first.
    /// </summary>
    [Fact]
    public void Toggles_AllAppearancesAreWrittenToAppFile()
    {
        _fixture.ItemService.CreateEquipmentItem(MakeItem("toggle_item", toggles: ["hood"]));

        var appFile = Assert.Single(FindAppFiles());
        var appearances = ReadAppAppearanceNames(appFile);

        Assert.Equal(
            new[] { "toggle_item_hood_off_", "toggle_item_hood_on_" },
            appearances.OrderBy(n => n, StringComparer.Ordinal).ToArray());
    }

    #endregion

    #region helpers

    private static ArchiveXlClothingItem MakeItem(
        string name,
        bool forceHair = false,
        bool hideInFpp = false,
        List<string>? toggles = null) => new()
    {
        ItemName = name,
        Slot = EquipmentItemSlot.Torso_Outer,
        TagsForceHair = forceHair,
        TagsHideInFpp = hideInFpp,
        Variants = ["black", "white"],
        Toggles = toggles ?? [],
    };

    private List<string> FindRootEntities() =>
        Directory.GetFiles(_project.ModDirectory, "*_root_entity.ent", SearchOption.AllDirectories)
            .OrderBy(p => p, StringComparer.Ordinal)
            .ToList();

    private List<string> FindAppFiles() =>
        Directory.GetFiles(_project.ModDirectory, "*.app", SearchOption.AllDirectories)
            .OrderBy(p => p, StringComparer.Ordinal)
            .ToList();

    private entEntityTemplate ReadEntity(string absPath)
    {
        var file = _fixture.Cr2WTools.ReadCr2W(absPath);
        return Assert.IsType<entEntityTemplate>(file.RootChunk);
    }

    private List<string> ReadVisualTags(string absPath) =>
        ReadEntity(absPath).VisualTagsSchema?.Chunk?.VisualTags?.Tags?
            .Select(t => t.GetResolvedText() ?? string.Empty).ToList() ?? [];

    private List<string> ReadEntityAppearanceNames(string absPath) =>
        ReadEntity(absPath).Appearances
            .Select(a => a.Name.GetResolvedText() ?? string.Empty).ToList();

    private List<string> ReadAppAppearanceNames(string absPath)
    {
        var file = _fixture.Cr2WTools.ReadCr2W(absPath);
        var app = Assert.IsType<appearanceAppearanceResource>(file.RootChunk);
        return app.Appearances
            .Select(a => a.Chunk?.Name.GetResolvedText() ?? string.Empty).ToList();
    }

    private void AddVisualTag(string absPath, string tag)
    {
        var file = _fixture.Cr2WTools.ReadCr2W(absPath);
        var entity = Assert.IsType<entEntityTemplate>(file.RootChunk);

        entity.VisualTagsSchema ??= new CHandle<entVisualTagsSchema>(new entVisualTagsSchema());
        entity.VisualTagsSchema.Chunk ??= new entVisualTagsSchema();
        entity.VisualTagsSchema.Chunk.VisualTags ??= new redTagList();
        entity.VisualTagsSchema.Chunk.VisualTags.Tags ??= [];
        entity.VisualTagsSchema.Chunk.VisualTags.Tags.Add(tag);

        _fixture.Cr2WTools.WriteCr2W(file, absPath);
    }

    #endregion

    public void Dispose()
    {
        _fixture.ProjectManager.ActiveProject = null;
        try
        {
            if (Directory.Exists(_projectRoot))
            {
                Directory.Delete(_projectRoot, true);
            }
        }
        catch { /* best effort */ }
    }
}

[CollectionDefinition(nameof(ArchiveXlItemTestCollection))]
public class ArchiveXlItemTestCollection : ICollectionFixture<ArchiveXlItemTestFixture>;
