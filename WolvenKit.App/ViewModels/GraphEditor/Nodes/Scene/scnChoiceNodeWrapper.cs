using System;
using System.Collections.ObjectModel;
using System.Linq;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnChoiceNodeWrapper : BaseSceneViewModel<scnChoiceNode>
{
    private readonly scnSceneResource _sceneResource;

    public ObservableCollection<string> Options { get; set; } = new();

    public scnChoiceNodeWrapper(scnChoiceNode scnSceneGraphNode, scnSceneResource scnSceneResource) : base(scnSceneGraphNode)
    {
        InputSocketNames.Add(0, "In");
        InputSocketNames.Add(1, "Cancel");
        InputSocketNames.Add(2, "ReactivateGroup");
        InputSocketNames.Add(3, "TimeLimitedFinish");

        OutputSocketNames.Add(0, "Option");
        OutputSocketNames.Add(1, "AnyOption");
        OutputSocketNames.Add(2, "Immediate");
        OutputSocketNames.Add(3, "CancelFwd");
        OutputSocketNames.Add(4, "NoOption");
        OutputSocketNames.Add(5, "WhenDisplayed");
        OutputSocketNames.Add(6, "Reminder");

        _sceneResource = scnSceneResource;

        var notable = _sceneResource
            .NotablePoints
            .First(x => x.NodeId.Id == scnSceneGraphNode.NodeId.Id);

        Title = $"{notable.Name.GetResolvedText()} ({Data.GetType().Name[3..^4]}) [{UniqueId}]";
    }

    internal override void GenerateSockets()
    {
        GetChoices();

        Input.Clear();
        foreach (var (socketNameId, socketName) in InputSocketNames)
        {
            Input.Add(new SceneInputConnectorViewModel(socketName, socketName, UniqueId, socketNameId, 0));
        }

        Output.Clear();
        foreach (var (socketNameId, socketName) in OutputSocketNames)
        {
            var sockets = _castedData.OutputSockets
                .Where(x => x.Stamp.Name == socketNameId)
                .OrderBy(x => (ushort)x.Stamp.Ordinal)
                .ToList();

            if (sockets.Count > 0)
            {
                foreach (var socket in sockets)
                {
                    var title = $"{socketName}_{socket.Stamp.Ordinal}";
                    if (socketNameId == 0 && socket.Stamp.Ordinal < Options.Count)
                    {
                        title += $" {Options[socket.Stamp.Ordinal]}";
                    }

                    Output.Add(new SceneOutputConnectorViewModel(title, title, UniqueId, socket));
                }
            }
            else
            {
                Output.Add(new SceneOutputConnectorViewModel($"{socketName}_0", $"{socketName}_0", UniqueId));
            }
        }
    }

    private void GetChoices()
    {
        Options.Clear();
        foreach (var option in _castedData.Options)
        {
            var screenPlay = _sceneResource
                .ScreenplayStore
                .Options
                .First(x => x.ItemId.Id == option.ScreenplayOptionId.Id);

            var vdEntry = _sceneResource
                .LocStore
                .VdEntries
                .First(x => x.LocstringId.Ruid == screenPlay.LocstringId.Ruid);

            var vpEntry = _sceneResource
                .LocStore
                .VpEntries
                .First(x => x.VariantId.Ruid == vdEntry.VariantId.Ruid);

            Options.Add($"[{vdEntry.LocaleId.ToEnumString()}] {vpEntry.Content}");
        }
    }

    public void AddChoice()
    {
        var random = new Random();

        // VariantId is 4 higher then LocstringId, doesn't seem important
        var cruid = (CRUID)(ulong)random.NextInt64();

        // needs to be 256 higher, if lower the previous text is used, if higher nothing is shown...
        var id = _sceneResource.ScreenplayStore.Options[^1].ItemId.Id + 256;

        _sceneResource.LocStore.VpEntries.Add(new scnlocLocStoreEmbeddedVariantPayloadEntry
        {
            Content = "Choice",
            VariantId = new scnlocVariantId
            {
                Ruid = cruid
            }
        });

        _sceneResource.LocStore.VdEntries.Add(new scnlocLocStoreEmbeddedVariantDescriptorEntry
        {
            LocstringId = new scnlocLocstringId
            {
                Ruid = cruid - 4
            },
            VariantId = new scnlocVariantId
            {
                Ruid = cruid
            },
            VpeIndex = (uint)(_sceneResource.LocStore.VpEntries.Count - 1),
            Signature = new scnlocSignature
            {
                Val = 3 // ???
            }
        });

        _sceneResource.ScreenplayStore.Options.Add(new scnscreenplayChoiceOption
        {
            LocstringId = new scnlocLocstringId
            {
                Ruid = cruid - 4
            },
            ItemId = new scnscreenplayItemId
            {
                Id = id
            },
            Usage = new scnscreenplayOptionUsage
            {
                PlayerGenderMask = new scnGenderMask
                {
                    Mask = 3 // both
                }
            }
        });

        _castedData.Options.Add(new scnChoiceNodeOption
        {
            ScreenplayOptionId = new scnscreenplayItemId()
            {
                Id = id
            }
        });

        var ord = (ushort)(_castedData.OutputSockets.Count - 6);
        _castedData.OutputSockets.Insert(ord, new scnOutputSocket
        {
            Stamp = new scnOutputSocketStamp
            {
                Name = 0,
                Ordinal = ord
            }
        });

        GenerateSockets();
    }
}