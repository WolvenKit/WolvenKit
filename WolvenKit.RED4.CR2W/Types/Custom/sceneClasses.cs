using System.IO;
using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class scnbExternalLayer : IMaterial
    {
        private CString _scenePath;
        private CString _layerName;
        private CArray<scnbExternalLayerEventData> _layerEvents;

        [Ordinal(0)]
        [RED("scenePath")]
        public CString ScenePath
        {
            get => GetProperty(ref _scenePath);
            set => SetProperty(ref _scenePath, value);
        }

        [Ordinal(1)]
        [RED("layerName")]
        public CString LayerName
        {
            get => GetProperty(ref _layerName);
            set => SetProperty(ref _layerName, value);
        }

        [Ordinal(2)]
        [RED("layerEvents")]
        public CArray<scnbExternalLayerEventData> LayerEvents
        {
            get => GetProperty(ref _layerEvents);
            set => SetProperty(ref _layerEvents, value);
        }


        public scnbExternalLayer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class scnbExternalLayerEventData : CVariable
    {
        private CString _trackName;
        private scnNodeId _nodeId;
        private toolsSceneTrackID _parentTrackId;
        private CHandle<toolsEventDescriptor> _event;

        [Ordinal(0)]
        [RED("trackName")]
        public CString TrackName
        {
            get => GetProperty(ref _trackName);
            set => SetProperty(ref _trackName, value);
        }

        [Ordinal(1)]
        [RED("nodeId")]
        public scnNodeId NodeId
        {
            get => GetProperty(ref _nodeId);
            set => SetProperty(ref _nodeId, value);
        }

        [Ordinal(2)]
        [RED("parentTrackId")]
        public toolsSceneTrackID ParentTrackId
        {
            get => GetProperty(ref _parentTrackId);
            set => SetProperty(ref _parentTrackId, value);
        }

        [Ordinal(3)]
        [RED("event")]
        public CHandle<toolsEventDescriptor> Event
        {
            get => GetProperty(ref _event);
            set => SetProperty(ref _event, value);
        }


        public scnbExternalLayerEventData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }



    [REDMeta]
    public class scnbPerformerInScene_NodeType : CVariable
    {
        private CEnum<populationSpawnerObjectCtrlAction> _action;
        private CRUID _performer;
        private CEnum<scnbPerformerAcquisitionPlanType> _performerAcquisitionPlanType;
        private NodeRef _reference;
        private CName _entryName;
        private rRef<communityCommunityTemplate> _template;
        private CName _phaseName;

        [Ordinal(0)]
        [RED("action")]
        public CEnum<populationSpawnerObjectCtrlAction> Action
        {
            get => GetProperty(ref _action);
            set => SetProperty(ref _action, value);
        }

        [Ordinal(1)]
        [RED("performer")]
        public CRUID Performer
        {
            get => GetProperty(ref _performer);
            set => SetProperty(ref _performer, value);
        }

        [Ordinal(2)]
        [RED("performerAcquisitionPlanType")]
        public CEnum<scnbPerformerAcquisitionPlanType> PerformerAcquisitionPlanType
        {
            get => GetProperty(ref _performerAcquisitionPlanType);
            set => SetProperty(ref _performerAcquisitionPlanType, value);
        }

        [Ordinal(3)]
        [RED("reference")]
        public NodeRef Reference
        {
            get => GetProperty(ref _reference);
            set => SetProperty(ref _reference, value);
        }

        [Ordinal(4)]
        [RED("entryName")]
        public CName EntryName
        {
            get => GetProperty(ref _entryName);
            set => SetProperty(ref _entryName, value);
        }

        [Ordinal(5)]
        [RED("template")]
        public rRef<communityCommunityTemplate> Template
        {
            get => GetProperty(ref _template);
            set => SetProperty(ref _template, value);
        }

        [Ordinal(6)]
        [RED("phaseName")]
        public CName PhaseName
        {
            get => GetProperty(ref _phaseName);
            set => SetProperty(ref _phaseName, value);
        }

        public scnbPerformerInScene_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class scnbScreenplayLineUsage : CVariable
    {
        private scnbGenderMask _playerGenderMask;

        [Ordinal(0)]
        [RED("playerGenderMask")]
        public scnbGenderMask PlayerGenderMask
        {
            get => GetProperty(ref _playerGenderMask);
            set => SetProperty(ref _playerGenderMask, value);
        }

        public scnbScreenplayLineUsage(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class scnbVoicetagId : CVariable
    {
        private CRUID _id;

        [Ordinal(0)]
        [RED("id")]
        public CRUID Id
        {
            get => GetProperty(ref _id);
            set => SetProperty(ref _id, value);
        }

        public scnbVoicetagId(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class scnbgraphSectionNode : CVariable
    {
        private CUInt64 _id;
        private Point _position;
        private CString _caption;
        private CArray<CHandle<toolsSocketDescription>> _sockets;
        private scnNodeId _sceneNodeId;
        private Point _titleFixedSize;

        [Ordinal(0)]
        [RED("id")]
        public CUInt64 Id
        {
            get => GetProperty(ref _id);
            set => SetProperty(ref _id, value);
        }

        [Ordinal(1)]
        [RED("position")]
        public Point Position
        {
            get => GetProperty(ref _position);
            set => SetProperty(ref _position, value);
        }

        [Ordinal(2)]
        [RED("caption")]
        public CString Caption
        {
            get => GetProperty(ref _caption);
            set => SetProperty(ref _caption, value);
        }

        [Ordinal(3)]
        [RED("sockets")]
        public CArray<CHandle<toolsSocketDescription>> Sockets
        {
            get => GetProperty(ref _sockets);
            set => SetProperty(ref _sockets, value);
        }

        [Ordinal(4)]
        [RED("sceneNodeId")]
        public scnNodeId SceneNodeId
        {
            get => GetProperty(ref _sceneNodeId);
            set => SetProperty(ref _sceneNodeId, value);
        }

        [Ordinal(5)]
        [RED("titleFixedSize")]
        public Point TitleFixedSize
        {
            get => GetProperty(ref _titleFixedSize);
            set => SetProperty(ref _titleFixedSize, value);
        }

        public scnbgraphSectionNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    
    [REDMeta]
	public class scnbeventsVFXBraindanceEventDescriptor : CVariable
	{
        private toolsSceneEventID _id;
        private toolsSceneTrackID _trackId;
        private CUInt32 _startTime;
        private CUInt32 _duration;
        private toolsSceneEventIdsPool _internalSceneEventIdsPool;
        private CRUID _performer;
        private NodeRef _nodeRef;
        private scnbEffectEntry _effect;
        private CHandle<entEffectDesc> _effectDesc;
        private CBool _endActionBreak;
        private CBool _fullyRewindable;
        private scnbEffectEntry _glitchEffect;

        [Ordinal(0)]
        [RED("id")]
        public toolsSceneEventID Id
        {
            get => GetProperty(ref _id);
            set => SetProperty(ref _id, value);
        }

        [Ordinal(1)]
        [RED("trackId")]
        public toolsSceneTrackID TrackId
        {
            get => GetProperty(ref _trackId);
            set => SetProperty(ref _trackId, value);
        }

        [Ordinal(2)]
        [RED("startTime")]
        public CUInt32 StartTime
        {
            get => GetProperty(ref _startTime);
            set => SetProperty(ref _startTime, value);
        }

        [Ordinal(3)]
        [RED("duration")]
        public CUInt32 Duration
        {
            get => GetProperty(ref _duration);
            set => SetProperty(ref _duration, value);
        }

        [Ordinal(4)]
        [RED("internalSceneEventIdsPool")]
        public toolsSceneEventIdsPool InternalSceneEventIdsPool
        {
            get => GetProperty(ref _internalSceneEventIdsPool);
            set => SetProperty(ref _internalSceneEventIdsPool, value);
        }

        [Ordinal(5)]
        [RED("performer")]
        public CRUID Performer
        {
            get => GetProperty(ref _performer);
            set => SetProperty(ref _performer, value);
        }

        [Ordinal(6)]
        [RED("nodeRef")]
        public NodeRef NodeRef
        {
            get => GetProperty(ref _nodeRef);
            set => SetProperty(ref _nodeRef, value);
        }

        [Ordinal(7)]
        [RED("effect")]
        public scnbEffectEntry Effect
        {
            get => GetProperty(ref _effect);
            set => SetProperty(ref _effect, value);
        }

        [Ordinal(8)]
        [RED("effectDesc")]
        public CHandle<entEffectDesc> EffectDesc
        {
            get => GetProperty(ref _effectDesc);
            set => SetProperty(ref _effectDesc, value);
        }

        [Ordinal(9)]
        [RED("endActionBreak")]
        public CBool EndActionBreak
        {
            get => GetProperty(ref _endActionBreak);
            set => SetProperty(ref _endActionBreak, value);
        }

        [Ordinal(10)]
        [RED("fullyRewindable")]
        public CBool FullyRewindable
        {
            get => GetProperty(ref _fullyRewindable);
            set => SetProperty(ref _fullyRewindable, value);
        }

        [Ordinal(11)]
        [RED("glitchEffect")]
        public scnbEffectEntry GlitchEffect
        {
            get => GetProperty(ref _glitchEffect);
            set => SetProperty(ref _glitchEffect, value);
        }

        public scnbeventsVFXBraindanceEventDescriptor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
	public class scnbeventsVFXEventDescriptor : CVariable
	{
        private toolsSceneEventID _id;
        private toolsSceneTrackID _trackId;
        private CArray<scnbSceneEventsGroupID> _eventsGroupIds;
        private CUInt32 _startTime;
        private CBool _mute;
        private toolsSceneEventIdsPool _internalSceneEventIdsPool;
        private CRUID _performer;
        private NodeRef _nodeRef;
        private CEnum<scneventsVFXActionType> _action;
        private scnbEffectEntry _effect;
        private CUInt32 _sequenceShift;
        private CHandle<entEffectDesc> _effectDesc;
        private CBool _muteSound;

        [Ordinal(0)]
        [RED("id")]
        public toolsSceneEventID Id
        {
            get => GetProperty(ref _id);
            set => SetProperty(ref _id, value);
        }

        [Ordinal(1)]
        [RED("trackId")]
        public toolsSceneTrackID TrackId
        {
            get => GetProperty(ref _trackId);
            set => SetProperty(ref _trackId, value);
        }

        [Ordinal(2)]
        [RED("eventsGroupIds")]
        public CArray<scnbSceneEventsGroupID> EventsGroupIds
        {
            get => GetProperty(ref _eventsGroupIds);
            set => SetProperty(ref _eventsGroupIds, value);
        }

        [Ordinal(3)]
        [RED("startTime")]
        public CUInt32 StartTime
        {
            get => GetProperty(ref _startTime);
            set => SetProperty(ref _startTime, value);
        }

        [Ordinal(4)]
        [RED("mute")]
        public CBool Mute
        {
            get => GetProperty(ref _mute);
            set => SetProperty(ref _mute, value);
        }

        [Ordinal(5)]
        [RED("internalSceneEventIdsPool")]
        public toolsSceneEventIdsPool InternalSceneEventIdsPool
        {
            get => GetProperty(ref _internalSceneEventIdsPool);
            set => SetProperty(ref _internalSceneEventIdsPool, value);
        }

        [Ordinal(6)]
        [RED("performer")]
        public CRUID Performer
        {
            get => GetProperty(ref _performer);
            set => SetProperty(ref _performer, value);
        }

        [Ordinal(7)]
        [RED("nodeRef")]
        public NodeRef NodeRef
        {
            get => GetProperty(ref _nodeRef);
            set => SetProperty(ref _nodeRef, value);
        }

        [Ordinal(8)]
        [RED("action")]
        public CEnum<scneventsVFXActionType> Action
        {
            get => GetProperty(ref _action);
            set => SetProperty(ref _action, value);
        }

        [Ordinal(9)]
        [RED("effect")]
        public scnbEffectEntry Effect
        {
            get => GetProperty(ref _effect);
            set => SetProperty(ref _effect, value);
        }

        [Ordinal(10)]
        [RED("sequenceShift")]
        public CUInt32 SequenceShift
        {
            get => GetProperty(ref _sequenceShift);
            set => SetProperty(ref _sequenceShift, value);
        }

        [Ordinal(11)]
        [RED("effectDesc")]
        public CHandle<entEffectDesc> EffectDesc
        {
            get => GetProperty(ref _effectDesc);
            set => SetProperty(ref _effectDesc, value);
        }

        [Ordinal(12)]
        [RED("muteSound")]
        public CBool MuteSound
        {
            get => GetProperty(ref _muteSound);
            set => SetProperty(ref _muteSound, value);
        }

        public scnbeventsVFXEventDescriptor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	
	[REDMeta]
	public class scnblocSignature : CVariable
	{
        private scnblocSignature _signature;
        private CUInt64 _val;

        [Ordinal(0)]
        [RED("signature")]
        public scnblocSignature Signature
        {
            get => GetProperty(ref _signature);
            set => SetProperty(ref _signature, value);
        }

        [Ordinal(1)]
        [RED("val")]
        public CUInt64 Val
        {
            get => GetProperty(ref _val);
            set => SetProperty(ref _val, value);
        }

        public scnblocSignature(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	[REDMeta]
	public class scnbEffectEntry : CVariable
	{
        private CName _effectName;
        private scnbSceneEffectId _sceneEffectId;

        [Ordinal(0)]
        [RED("effectName")]
        public CName EffectName
        {
            get => GetProperty(ref _effectName);
            set => SetProperty(ref _effectName, value);
        }

        [Ordinal(1)]
        [RED("sceneEffectId")]
        public scnbSceneEffectId SceneEffectId
        {
            get => GetProperty(ref _sceneEffectId);
            set => SetProperty(ref _sceneEffectId, value);
        }

        public scnbEffectEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class scnblocLocstringId : CVariable
	{
        private CRUID _ruid;

        [Ordinal(0)]
        [RED("ruid")]
        public CRUID Ruid
        {
            get => GetProperty(ref _ruid);
            set => SetProperty(ref _ruid, value);
        }

        public scnblocLocstringId(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	[REDMeta]
	public class scnbSceneActorData : CVariable
	{
        private CRUID _actorId;
        private scnbVoicetagId _voiceTagId;
        private TweakDBID _characterRecordId;
        private CString _name;

        [Ordinal(0)]
        [RED("actorId")]
        public CRUID ActorId
        {
            get => GetProperty(ref _actorId);
            set => SetProperty(ref _actorId, value);
        }

        [Ordinal(1)]
        [RED("voiceTagId")]
        public scnbVoicetagId VoiceTagId
        {
            get => GetProperty(ref _voiceTagId);
            set => SetProperty(ref _voiceTagId, value);
        }

        [Ordinal(2)]
        [RED("characterRecordId")]
        public TweakDBID CharacterRecordId
        {
            get => GetProperty(ref _characterRecordId);
            set => SetProperty(ref _characterRecordId, value);
        }

        [Ordinal(3)]
        [RED("name")]
        public CString Name
        {
            get => GetProperty(ref _name);
            set => SetProperty(ref _name, value);
        }

        public scnbSceneActorData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	[REDMeta]
	public class scnblocVariantId : CVariable
	{
        private CRUID _ruid;

        [Ordinal(0)]
        [RED("ruid")]
        public CRUID Ruid
        {
            get => GetProperty(ref _ruid);
            set => SetProperty(ref _ruid, value);
        }

        public scnblocVariantId(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class scnblocVariant : CVariable
	{
        private scnblocVariantId _variantId;
        private scnblocLocstringId _locstringId;
        private scnblocSignature _signature;
        private CString _content;

        [Ordinal(0)]
        [RED("variantId")]
        public scnblocVariantId VariantId
        {
            get => GetProperty(ref _variantId);
            set => SetProperty(ref _variantId, value);
        }

        [Ordinal(1)]
        [RED("locstringId")]
        public scnblocLocstringId LocstringId
        {
            get => GetProperty(ref _locstringId);
            set => SetProperty(ref _locstringId, value);
        }

        [Ordinal(2)]
        [RED("signature")]
        public scnblocSignature Signature
        {
            get => GetProperty(ref _signature);
            set => SetProperty(ref _signature, value);
        }

        [Ordinal(3)]
        [RED("content")]
        public CString Content
        {
            get => GetProperty(ref _content);
            set => SetProperty(ref _content, value);
        }


        public scnblocVariant(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	[REDMeta]
	public class scnbSceneEffectId : CVariable
	{
        private CRUID _id;

        [Ordinal(0)]
        [RED("id")]
        public CRUID Id
        {
            get => GetProperty(ref _id);
            set => SetProperty(ref _id, value);
        }

        public scnbSceneEffectId(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class scnbGenderMask : CVariable
	{
        private CUInt8 _mask;

        [Ordinal(0)]
        [RED("mask")]
        public CUInt8 Mask
        {
            get => GetProperty(ref _mask);
            set => SetProperty(ref _mask, value);
        }

        public scnbGenderMask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class scnbAudioLayer : CVariable
	{
        private CString _scenePath;
        private CArray<scnbAudioLayerNodeData> _audioEventNodes;

        [Ordinal(0)]
        [RED("scenePath")]
        public CString ScenePath
        {
            get => GetProperty(ref _scenePath);
            set => SetProperty(ref _scenePath, value);
        }

        [Ordinal(1)]
        [RED("audioEventNodes")]
        public CArray<scnbAudioLayerNodeData> AudioEventNodes
        {
            get => GetProperty(ref _audioEventNodes);
            set => SetProperty(ref _audioEventNodes, value);
        }

        public scnbAudioLayer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class scnbPresetsDataWrapper : CVariable
	{
        private CArray<toolsSceneRecorderPresetData> _data;

        [Ordinal(0)]
        [RED("data")]
        public CArray<toolsSceneRecorderPresetData> Data
        {
            get => GetProperty(ref _data);
            set => SetProperty(ref _data, value);
        }

        public scnbPresetsDataWrapper(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class scnbAudioLayerNodeData : CVariable
	{
        private scnNodeId _nodeId;
        private toolsSceneTrackID _parentTrackId;
        private CHandle<toolsAudioEventDescriptor> _audioEvent;

        [Ordinal(1)]
        [RED("nodeId")]
        public scnNodeId NodeId
        {
            get => GetProperty(ref _nodeId);
            set => SetProperty(ref _nodeId, value);
        }

        [Ordinal(2)]
        [RED("parentTrackId")]
        public toolsSceneTrackID ParentTrackId
        {
            get => GetProperty(ref _parentTrackId);
            set => SetProperty(ref _parentTrackId, value);
        }

        [Ordinal(3)]
        [RED("audioEvent")]
        public CHandle<toolsAudioEventDescriptor> AudioEvent
        {
            get => GetProperty(ref _audioEvent);
            set => SetProperty(ref _audioEvent, value);
        }

        public scnbAudioLayerNodeData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	
	[REDMeta]
	public class scnbeventsVFXDurationEventDescriptor : CVariable
	{
        private toolsSceneEventID _id;
        private toolsSceneTrackID _trackId;
        private CArray<scnbSceneEventsGroupID> _eventsGroupIds;
        private CUInt32 _startTime;
        private CUInt32 _duration;
        private toolsSceneEventIdsPool _internalSceneEventIdsPool;
        private CRUID _performer;
        private NodeRef _nodeRef;
        private CEnum<scneventsVFXActionType> _action;
        private CBool _mute;
        private scnbEffectEntry _effect;
        private CHandle<entEffectDesc> _effectDesc;
        private CEnum<scneventsVFXActionType> _endAction;

        [Ordinal(0)]
        [RED("id")]
        public toolsSceneEventID Id
        {
            get => GetProperty(ref _id);
            set => SetProperty(ref _id, value);
        }

        [Ordinal(1)]
        [RED("trackId")]
        public toolsSceneTrackID TrackId
        {
            get => GetProperty(ref _trackId);
            set => SetProperty(ref _trackId, value);
        }

        [Ordinal(2)]
        [RED("eventsGroupIds")]
        public CArray<scnbSceneEventsGroupID> EventsGroupIds
        {
            get => GetProperty(ref _eventsGroupIds);
            set => SetProperty(ref _eventsGroupIds, value);
        }

        [Ordinal(3)]
        [RED("startTime")]
        public CUInt32 StartTime
        {
            get => GetProperty(ref _startTime);
            set => SetProperty(ref _startTime, value);
        }

        [Ordinal(4)]
        [RED("duration")]
        public CUInt32 Duration
        {
            get => GetProperty(ref _duration);
            set => SetProperty(ref _duration, value);
        }

        [Ordinal(5)]
        [RED("internalSceneEventIdsPool")]
        public toolsSceneEventIdsPool InternalSceneEventIdsPool
        {
            get => GetProperty(ref _internalSceneEventIdsPool);
            set => SetProperty(ref _internalSceneEventIdsPool, value);
        }

        [Ordinal(6)]
        [RED("performer")]
        public CRUID Performer
        {
            get => GetProperty(ref _performer);
            set => SetProperty(ref _performer, value);
        }

        [Ordinal(7)]
        [RED("nodeRef")]
        public NodeRef NodeRef
        {
            get => GetProperty(ref _nodeRef);
            set => SetProperty(ref _nodeRef, value);
        }

        [Ordinal(8)]
        [RED("action")]
        public CEnum<scneventsVFXActionType> Action
        {
            get => GetProperty(ref _action);
            set => SetProperty(ref _action, value);
        }

        [Ordinal(9)]
        [RED("mute")]
        public CBool Mute
        {
            get => GetProperty(ref _mute);
            set => SetProperty(ref _mute, value);
        }

        [Ordinal(10)]
        [RED("effect")]
        public scnbEffectEntry Effect
        {
            get => GetProperty(ref _effect);
            set => SetProperty(ref _effect, value);
        }

        [Ordinal(11)]
        [RED("effectDesc")]
        public CHandle<entEffectDesc> EffectDesc
        {
            get => GetProperty(ref _effectDesc);
            set => SetProperty(ref _effectDesc, value);
        }

        [Ordinal(12)]
        [RED("endAction")]
        public CEnum<scneventsVFXActionType> EndAction
        {
            get => GetProperty(ref _endAction);
            set => SetProperty(ref _endAction, value);
        }


        public scnbeventsVFXDurationEventDescriptor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	[REDMeta]
	public class scnbSceneEventsGroupID : CVariable
	{
        private CUInt64 _id;

        [Ordinal(0)]
        [RED("id")]
        public CUInt64 Id
        {
            get => GetProperty(ref _id);
            set => SetProperty(ref _id, value);
        }

        public scnbSceneEventsGroupID(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	

	
}
