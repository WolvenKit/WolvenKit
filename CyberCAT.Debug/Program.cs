// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using CyberCAT.Debug;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Save;
using WolvenKit.RED4.Save.IO;

var hashService = new HashService();
var tweakService = new TweakDBService();

var path = SaveHelper.GetSavePath("Autosave-17");
if (path == null)
{
    return;
}

using var ms = new MemoryStream(File.ReadAllBytes(path));
var reader = new CyberpunkSaveReader(ms);

if (reader.ReadFile(out var save) == EFileReadErrorCodes.NoError)
{
    //foreach (var node in save.Nodes)
    //{
    //    if (node.Name != "inventory")
    //    {
    //        continue;
    //    }
    //
    //    foreach (var child in node.Children)
    //    {
    //        var data = (InventoryHelper.ItemData)child.Value;
    //            Console.WriteLine($"Item:");
    //            Console.WriteLine($"    ItemTdbId: {data.ItemTdbId.ResolvedText ?? data.ItemTdbId.ToString()}");
    //
    //        if (data.Data is InventoryHelper.ModableItemWithQuantityData miwqd)
    //        {
    //            Console.WriteLine($"    TdbId1: {miwqd.TdbId1.ResolvedText ?? miwqd.TdbId1.ToString()}");
    //            Console.WriteLine($"    RootNode:");
    //            Console.WriteLine($"        ItemTdbId:           {miwqd.RootNode.ItemTdbId.ResolvedText ?? miwqd.RootNode.ItemTdbId.ToString()}");
    //            Console.WriteLine($"        AttachmentSlotTdbId: {miwqd.RootNode.AttachmentSlotTdbId.ResolvedText ?? miwqd.RootNode.AttachmentSlotTdbId.ToString()}");
    //            Console.WriteLine($"        TdbId2:              {miwqd.RootNode.TdbId2.ResolvedText ?? miwqd.RootNode.TdbId2.ToString()}");
    //        }
    //        else if (data.Data is InventoryHelper.ModableItemData mid)
    //        {
    //            Console.WriteLine($"    TdbId1: {mid.TdbId1.ResolvedText ?? mid.TdbId1.ToString()}");
    //            Console.WriteLine($"    RootNode:");
    //            Console.WriteLine($"        ItemTdbId:           {mid.RootNode.ItemTdbId.ResolvedText ?? mid.RootNode.ItemTdbId.ToString()}");
    //            Console.WriteLine($"        AttachmentSlotTdbId: {mid.RootNode.AttachmentSlotTdbId.ResolvedText ?? mid.RootNode.AttachmentSlotTdbId.ToString()}");
    //            Console.WriteLine($"        TdbId2:              {mid.RootNode.TdbId2.ResolvedText ?? mid.RootNode.TdbId2.ToString()}");
    //        }
    //    }
    //}

    if (save.Nodes[0].Value is GameSessionDesc desc)
    {
        var t1 = hashService.Get(desc.GameSessionConfig.Hash1);
        var t3 = hashService.Get(desc.GameSessionConfig.Hash3);
    }

    using var ms2 = new MemoryStream();
    var writer = new CyberpunkSaveWriter(ms2);

    var test = writer.WriteFile(save);

    //if (reader.NodeEntries.Count == writer.NodeInfos.Count)
    //{
    //    for (int i = 0; i < reader.NodeEntries.Count; i++)
    //    {
    //        var orgInfo = reader.NodeEntries[i];
    //        var newInfo = writer.NodeInfos[i];
    //
    //        if (orgInfo.Name != newInfo.Name)
    //        {
    //            Debugger.Break();
    //        }
    //
    //        if (orgInfo.NextId != newInfo.NextId)
    //        {
    //            Debugger.Break();
    //        }
    //
    //        if (orgInfo.ChildId != newInfo.ChildId)
    //        {
    //            Debugger.Break();
    //        }
    //
    //        if (orgInfo.Offset != newInfo.Offset)
    //        {
    //            Debugger.Break();
    //        }
    //
    //        if (orgInfo.Size != newInfo.Size)
    //        {
    //            Debugger.Break();
    //        }
    //    }
    //}

    var outPath = SaveHelper.GetSavePath("ManualSave-2094");
    if (outPath != null)
    {
        File.WriteAllBytes(outPath, test);
    }
}
