using static WolvenKit.RED4.Types.Enums;
// ReSharper disable InconsistentNaming
// ReSharper disable RedundantTypeArgumentsOfMethod

namespace WolvenKit.RED4.Types;

public class scnbExternalLayer : IMaterial
{
    [Ordinal(0)]
    [RED("scenePath")]
    public CString ScenePath
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(1)]
    [RED("layerName")]
    public CString LayerName
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(2)]
    [RED("layerEvents")]
    public CArray<scnbExternalLayerEventData> LayerEvents
    {
        get => GetPropertyValue<CArray<scnbExternalLayerEventData>>();
        set => SetPropertyValue<CArray<scnbExternalLayerEventData>>(value);
    }
}

public class scnbExternalLayerEventData : RedBaseClass
{
    [Ordinal(0)]
    [RED("nodeId")]
    public scnNodeId NodeId
    {
        get => GetPropertyValue<scnNodeId>();
        set => SetPropertyValue<scnNodeId>(value);
    }

    [Ordinal(1)]
    [RED("parentTrackId")]
    public toolsSceneTrackID ParentTrackId
    {
        get => GetPropertyValue<toolsSceneTrackID>();
        set => SetPropertyValue<toolsSceneTrackID>(value);
    }

    [Ordinal(2)]
    [RED("trackName")]
    public CString TrackName
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(3)]
    [RED("event")]
    public CHandle<toolsEventDescriptor> Event
    {
        get => GetPropertyValue<CHandle<toolsEventDescriptor>>();
        set => SetPropertyValue<CHandle<toolsEventDescriptor>>(value);
    }
}

public class scnbPerformerInScene_NodeType : questSpawnManagerNodeType
{
    [Ordinal(1)]
    [RED("performer")]
    public CRUID Performer
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }

    [Ordinal(2)]
    [RED("performerAcquisitionPlanType")]
    public CEnum<scnbPerformerAcquisitionPlanType> PerformerAcquisitionPlanType
    {
        get => GetPropertyValue<CEnum<scnbPerformerAcquisitionPlanType>>();
        set => SetPropertyValue<CEnum<scnbPerformerAcquisitionPlanType>>(value);
    }

    [Ordinal(3)]
    [RED("reference")]
    public NodeRef Reference
    {
        get => GetPropertyValue<NodeRef>();
        set => SetPropertyValue<NodeRef>(value);
    }

    [Ordinal(4)]
    [RED("entryName")]
    public CName EntryName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(5)]
    [RED("template")]
    public CResourceReference<communityCommunityTemplate> Template
    {
        get => GetPropertyValue<CResourceReference<communityCommunityTemplate>>();
        set => SetPropertyValue<CResourceReference<communityCommunityTemplate>>(value);
    }

    [Ordinal(6)]
    [RED("phaseName")]
    public CName PhaseName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }
}

public class scnbScreenplayLineUsage : RedBaseClass
{
    [Ordinal(0)]
    [RED("playerGenderMask")]
    public scnbGenderMask PlayerGenderMask
    {
        get => GetPropertyValue<scnbGenderMask>();
        set => SetPropertyValue<scnbGenderMask>(value);
    }
}

public class scnbVoicetagId : RedBaseClass
{
    [Ordinal(0)]
    [RED("id")]
    public CRUID Id
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }
}

public class scnbgraphSectionNode : toolsIGraphNodeDescriptor
{
    [Ordinal(0)]
    [RED("id")]
    public CUInt64 Id
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [Ordinal(1)]
    [RED("position")]
    public Point Position
    {
        get => GetPropertyValue<Point>();
        set => SetPropertyValue<Point>(value);
    }

    [Ordinal(2)]
    [RED("caption")]
    public CString Caption
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(3)]
    [RED("sockets")]
    public CArray<CHandle<toolsSocketDescription>> Sockets
    {
        get => GetPropertyValue<CArray<CHandle<toolsSocketDescription>>>();
        set => SetPropertyValue<CArray<CHandle<toolsSocketDescription>>>(value);
    }

    [Ordinal(4)]
    [RED("sceneNodeId")]
    public scnNodeId SceneNodeId
    {
        get => GetPropertyValue<scnNodeId>();
        set => SetPropertyValue<scnNodeId>(value);
    }

    [Ordinal(5)]
    [RED("titleFixedSize")]
    public Point TitleFixedSize
    {
        get => GetPropertyValue<Point>();
        set => SetPropertyValue<Point>(value);
    }
}

public class scnbeventsVFXBraindanceEventDescriptor : toolsEventDescriptor
{
    [Ordinal(0)]
    [RED("id")]
    public toolsSceneEventID Id
    {
        get => GetPropertyValue<toolsSceneEventID>();
        set => SetPropertyValue<toolsSceneEventID>(value);
    }

    [Ordinal(1)]
    [RED("trackId")]
    public toolsSceneTrackID TrackId
    {
        get => GetPropertyValue<toolsSceneTrackID>();
        set => SetPropertyValue<toolsSceneTrackID>(value);
    }

    [Ordinal(2)]
    [RED("startTime")]
    public CUInt32 StartTime
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(3)]
    [RED("duration")]
    public CUInt32 Duration
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(4)]
    [RED("internalSceneEventIdsPool")]
    public toolsSceneEventIdsPool InternalSceneEventIdsPool
    {
        get => GetPropertyValue<toolsSceneEventIdsPool>();
        set => SetPropertyValue<toolsSceneEventIdsPool>(value);
    }

    [Ordinal(5)]
    [RED("performer")]
    public CRUID Performer
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }

    [Ordinal(6)]
    [RED("nodeRef")]
    public NodeRef NodeRef
    {
        get => GetPropertyValue<NodeRef>();
        set => SetPropertyValue<NodeRef>(value);
    }

    [Ordinal(7)]
    [RED("effect")]
    public scnbEffectEntry Effect
    {
        get => GetPropertyValue<scnbEffectEntry>();
        set => SetPropertyValue<scnbEffectEntry>(value);
    }

    [Ordinal(8)]
    [RED("effectDesc")]
    public CHandle<entEffectDesc> EffectDesc
    {
        get => GetPropertyValue<CHandle<entEffectDesc>>();
        set => SetPropertyValue<CHandle<entEffectDesc>>(value);
    }

    [Ordinal(9)]
    [RED("endActionBreak")]
    public CBool EndActionBreak
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(10)]
    [RED("fullyRewindable")]
    public CBool FullyRewindable
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(11)]
    [RED("glitchEffect")]
    public scnbEffectEntry GlitchEffect
    {
        get => GetPropertyValue<scnbEffectEntry>();
        set => SetPropertyValue<scnbEffectEntry>(value);
    }
}

public class scnbeventsVFXEventDescriptor : toolsEventDescriptor
{
    [Ordinal(0)]
    [RED("id")]
    public toolsSceneEventID Id
    {
        get => GetPropertyValue<toolsSceneEventID>();
        set => SetPropertyValue<toolsSceneEventID>(value);
    }

    [Ordinal(1)]
    [RED("trackId")]
    public toolsSceneTrackID TrackId
    {
        get => GetPropertyValue<toolsSceneTrackID>();
        set => SetPropertyValue<toolsSceneTrackID>(value);
    }

    [Ordinal(2)]
    [RED("eventsGroupIds")]
    public CArray<scnbSceneEventsGroupID> EventsGroupIds
    {
        get => GetPropertyValue<CArray<scnbSceneEventsGroupID>>();
        set => SetPropertyValue<CArray<scnbSceneEventsGroupID>>(value);
    }

    [Ordinal(3)]
    [RED("startTime")]
    public CUInt32 StartTime
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(4)]
    [RED("mute")]
    public CBool Mute
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(5)]
    [RED("internalSceneEventIdsPool")]
    public toolsSceneEventIdsPool InternalSceneEventIdsPool
    {
        get => GetPropertyValue<toolsSceneEventIdsPool>();
        set => SetPropertyValue<toolsSceneEventIdsPool>(value);
    }

    [Ordinal(6)]
    [RED("performer")]
    public CRUID Performer
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }

    [Ordinal(7)]
    [RED("nodeRef")]
    public NodeRef NodeRef
    {
        get => GetPropertyValue<NodeRef>();
        set => SetPropertyValue<NodeRef>(value);
    }

    [Ordinal(8)]
    [RED("action")]
    public CEnum<scneventsVFXActionType> Action
    {
        get => GetPropertyValue<CEnum<scneventsVFXActionType>>();
        set => SetPropertyValue<CEnum<scneventsVFXActionType>>(value);
    }

    [Ordinal(9)]
    [RED("effect")]
    public scnbEffectEntry Effect
    {
        get => GetPropertyValue<scnbEffectEntry>();
        set => SetPropertyValue<scnbEffectEntry>(value);
    }

    [Ordinal(10)]
    [RED("sequenceShift")]
    public CUInt32 SequenceShift
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(11)]
    [RED("effectDesc")]
    public CHandle<entEffectDesc> EffectDesc
    {
        get => GetPropertyValue<CHandle<entEffectDesc>>();
        set => SetPropertyValue<CHandle<entEffectDesc>>(value);
    }

    [Ordinal(12)]
    [RED("muteSound")]
    public CBool MuteSound
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }
}

public class scnblocSignature : RedBaseClass
{
    [Ordinal(0)]
    [RED("signature")]
    public scnblocSignature Signature
    {
        get => GetPropertyValue<scnblocSignature>();
        set => SetPropertyValue<scnblocSignature>(value);
    }

    [Ordinal(1)]
    [RED("val")]
    public CUInt64 Val
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }
}

public class scnbEffectEntry : RedBaseClass
{
    [Ordinal(0)]
    [RED("effectName")]
    public CName EffectName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(1)]
    [RED("sceneEffectId")]
    public scnbSceneEffectId SceneEffectId
    {
        get => GetPropertyValue<scnbSceneEffectId>();
        set => SetPropertyValue<scnbSceneEffectId>(value);
    }
}

public class scnblocLocstringId : RedBaseClass
{
    [Ordinal(0)]
    [RED("ruid")]
    public CRUID Ruid
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }
}

public class scnbSceneActorData : RedBaseClass
{
    [Ordinal(0)]
    [RED("actorId")]
    public CRUID ActorId
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }

    [Ordinal(1)]
    [RED("voiceTagId")]
    public scnbVoicetagId VoiceTagId
    {
        get => GetPropertyValue<scnbVoicetagId>();
        set => SetPropertyValue<scnbVoicetagId>(value);
    }

    [Ordinal(2)]
    [RED("characterRecordId")]
    public TweakDBID CharacterRecordId
    {
        get => GetPropertyValue<TweakDBID>();
        set => SetPropertyValue<TweakDBID>(value);
    }

    [Ordinal(3)]
    [RED("name")]
    public CString Name
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }
}

public class scnblocVariantId : RedBaseClass
{
    [Ordinal(0)]
    [RED("ruid")]
    public CRUID Ruid
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }
}

public class scnblocVariant : RedBaseClass
{
    [Ordinal(0)]
    [RED("variantId")]
    public scnblocVariantId VariantId
    {
        get => GetPropertyValue<scnblocVariantId>();
        set => SetPropertyValue<scnblocVariantId>(value);
    }

    [Ordinal(1)]
    [RED("locstringId")]
    public scnblocLocstringId LocstringId
    {
        get => GetPropertyValue<scnblocLocstringId>();
        set => SetPropertyValue<scnblocLocstringId>(value);
    }

    [Ordinal(2)]
    [RED("signature")]
    public scnblocSignature Signature
    {
        get => GetPropertyValue<scnblocSignature>();
        set => SetPropertyValue<scnblocSignature>(value);
    }

    [Ordinal(3)]
    [RED("content")]
    public CString Content
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }
}

public class scnbSceneEffectId : RedBaseClass
{
    [Ordinal(0)]
    [RED("id")]
    public CRUID Id
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }
}

public class scnbGenderMask : RedBaseClass
{
    [Ordinal(0)]
    [RED("mask")]
    public CUInt8 Mask
    {
        get => GetPropertyValue<CUInt8>();
        set => SetPropertyValue<CUInt8>(value);
    }
}

public class scnbAudioLayer : ISerializable
{
    [Ordinal(0)]
    [RED("scenePath")]
    public CString ScenePath
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(1)]
    [RED("audioEventNodes")]
    public CArray<scnbAudioLayerNodeData> AudioEventNodes
    {
        get => GetPropertyValue<CArray<scnbAudioLayerNodeData>>();
        set => SetPropertyValue<CArray<scnbAudioLayerNodeData>>(value);
    }
}

public class scnbPresetsDataWrapper : ISerializable
{
    [Ordinal(0)]
    [RED("data")]
    public CArray<toolsSceneRecorderPresetData> Data
    {
        get => GetPropertyValue<CArray<toolsSceneRecorderPresetData>>();
        set => SetPropertyValue<CArray<toolsSceneRecorderPresetData>>(value);
    }
}

public class scnbAudioLayerNodeData : RedBaseClass
{
    [Ordinal(1)]
    [RED("nodeId")]
    public scnNodeId NodeId
    {
        get => GetPropertyValue<scnNodeId>();
        set => SetPropertyValue<scnNodeId>(value);
    }

    [Ordinal(2)]
    [RED("parentTrackId")]
    public toolsSceneTrackID ParentTrackId
    {
        get => GetPropertyValue<toolsSceneTrackID>();
        set => SetPropertyValue<toolsSceneTrackID>(value);
    }

    [Ordinal(3)]
    [RED("audioEvent")]
    public CHandle<toolsAudioEventDescriptor> AudioEvent
    {
        get => GetPropertyValue<CHandle<toolsAudioEventDescriptor>>();
        set => SetPropertyValue<CHandle<toolsAudioEventDescriptor>>(value);
    }
}

public class scnbeventsVFXDurationEventDescriptor : toolsEventDescriptor
{
    [Ordinal(0)]
    [RED("id")]
    public toolsSceneEventID Id
    {
        get => GetPropertyValue<toolsSceneEventID>();
        set => SetPropertyValue<toolsSceneEventID>(value);
    }

    [Ordinal(1)]
    [RED("trackId")]
    public toolsSceneTrackID TrackId
    {
        get => GetPropertyValue<toolsSceneTrackID>();
        set => SetPropertyValue<toolsSceneTrackID>(value);
    }

    [Ordinal(2)]
    [RED("eventsGroupIds")]
    public CArray<scnbSceneEventsGroupID> EventsGroupIds
    {
        get => GetPropertyValue<CArray<scnbSceneEventsGroupID>>();
        set => SetPropertyValue<CArray<scnbSceneEventsGroupID>>(value);
    }

    [Ordinal(3)]
    [RED("startTime")]
    public CUInt32 StartTime
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(4)]
    [RED("duration")]
    public CUInt32 Duration
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(5)]
    [RED("internalSceneEventIdsPool")]
    public toolsSceneEventIdsPool InternalSceneEventIdsPool
    {
        get => GetPropertyValue<toolsSceneEventIdsPool>();
        set => SetPropertyValue<toolsSceneEventIdsPool>(value);
    }

    [Ordinal(6)]
    [RED("performer")]
    public CRUID Performer
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }

    [Ordinal(7)]
    [RED("nodeRef")]
    public NodeRef NodeRef
    {
        get => GetPropertyValue<NodeRef>();
        set => SetPropertyValue<NodeRef>(value);
    }

    [Ordinal(8)]
    [RED("action")]
    public CEnum<scneventsVFXActionType> Action
    {
        get => GetPropertyValue<CEnum<scneventsVFXActionType>>();
        set => SetPropertyValue<CEnum<scneventsVFXActionType>>(value);
    }

    [Ordinal(9)]
    [RED("mute")]
    public CBool Mute
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(10)]
    [RED("effect")]
    public scnbEffectEntry Effect
    {
        get => GetPropertyValue<scnbEffectEntry>();
        set => SetPropertyValue<scnbEffectEntry>(value);
    }

    [Ordinal(11)]
    [RED("effectDesc")]
    public CHandle<entEffectDesc> EffectDesc
    {
        get => GetPropertyValue<CHandle<entEffectDesc>>();
        set => SetPropertyValue<CHandle<entEffectDesc>>(value);
    }

    [Ordinal(12)]
    [RED("endAction")]
    public CEnum<scneventsVFXActionType> EndAction
    {
        get => GetPropertyValue<CEnum<scneventsVFXActionType>>();
        set => SetPropertyValue<CEnum<scneventsVFXActionType>>(value);
    }
}

public class scnbSceneEventsGroupID : RedBaseClass
{
    [Ordinal(0)]
    [RED("id")]
    public CUInt64 Id
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }
}