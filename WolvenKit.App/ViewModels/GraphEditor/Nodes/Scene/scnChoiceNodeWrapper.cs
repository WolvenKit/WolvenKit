﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnChoiceNodeWrapper : BaseSceneViewModel<scnChoiceNode>
{
    private readonly scnSceneResource _sceneResource;

    public ObservableCollection<string> Options { get; set; } = new();

    public scnChoiceNodeWrapper(scnChoiceNode scnSceneGraphNode, scnSceneResource scnSceneResource) : base(scnSceneGraphNode)
    {
        _sceneResource = scnSceneResource;

        /*var notable = _sceneResource
            .NotablePoints
            .FirstOrDefault(x => x.NodeId.Id == scnSceneGraphNode.NodeId.Id);

        if (notable != null)
        {
            Title = $"[{UniqueId}] {notable.Name.GetResolvedText()} ({Data.GetType().Name[3..^4]})";
        }*/

        Title += NodeProperties.SetNameFromNotablePoints(scnSceneGraphNode.NodeId.Id, scnSceneResource);
    }

    internal override void GenerateSockets()
    {
        GetChoices();

        Input.Clear();
        Input.Add(new SceneInputConnectorViewModel("In", "In", UniqueId, 0));

        Output.Clear();
        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            var title = $"Out{i}";
            if (i < Options.Count)
            {
                title = Options[i];
            }

            Output.Add(new SceneOutputConnectorViewModel($"Out{i}", title, UniqueId, _castedData.OutputSockets[i]));
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
                .FirstOrDefault(x => x.LocstringId.Ruid == screenPlay.LocstringId.Ruid);

            if (vdEntry != null)
            {
                var vpEntry = _sceneResource
                    .LocStore
                    .VpEntries
                    .FirstOrDefault(x => x.VariantId.Ruid == vdEntry.VariantId.Ruid);

                if (vpEntry != null)
                {
                    Options.Add($"[{vdEntry.LocaleId.ToEnumString()}] {vpEntry.Content}");
                }
            }
            else
            {
                Options.Add($"Out{Options.Count} [{option.ScreenplayOptionId.Id}]");
            }
        }

        Options.Add("AnyOption");
        Options.Add("Immediate");
        Options.Add("CancelFwd");
        Options.Add("NoOption");
        Options.Add("WhenDisplayed");
        Options.Add("Reminder");
    }

    public void AddChoice()
    {
        var random = new Random();

        // VariantId is 4 higher then LocstringId, doesn't seem important
        var cruid = (CRUID)random.NextCRUID();

        // first id is always 2, don't know why
        var id = (CUInt32)2;
        if (_sceneResource.ScreenplayStore.Options.Count > 0)
        {
            // needs to be 256 higher, if lower the previous text is used, if higher nothing is shown...
            id = _sceneResource.ScreenplayStore.Options[^1].ItemId.Id + 256;
        }

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