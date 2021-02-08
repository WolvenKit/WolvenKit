using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class scnbExternalLayer : IMaterial
    {
        [Ordinal(0)] [RED("scenePath")] public CString scenePath { get; set; }
        [Ordinal(1)] [RED("layerName")] public CString layerName { get; set; }
        [Ordinal(2)] [RED("layerEvents")] public CArray<scnbExternalLayerEventData> layerEvents { get; set; }


        public scnbExternalLayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class scnbExternalLayerEventData : CVariable
    {
        [Ordinal(0)] [RED("trackName")] public CString trackName { get; set; }
        [Ordinal(1)] [RED("nodeId")] public scnNodeId nodeId { get; set; }
        [Ordinal(2)] [RED("parentTrackId")] public toolsSceneTrackID parentTrackId { get; set; }
        [Ordinal(3)] [RED("event")] public CHandle<toolsEventDescriptor> event_ { get; set; }



        public scnbExternalLayerEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }



    [REDMeta]
    public class scnbPerformerInScene_NodeType : CVariable
    {
        [Ordinal(0)] [RED("action")] public CEnum<populationSpawnerObjectCtrlAction> action { get; set; }
        [Ordinal(1)] [RED("performer")] public CRUID performer { get; set; }
        [Ordinal(2)] [RED("performerAcquisitionPlanType")] public CEnum<scnbPerformerAcquisitionPlanType> performerAcquisitionPlanType { get; set; }
        [Ordinal(3)] [RED("reference")] public NodeRef reference { get; set; }
        [Ordinal(4)] [RED("entryName")] public CName entryName { get; set; }
        [Ordinal(5)] [RED("template")] public rRef<communityCommunityTemplate> template { get; set; }
        [Ordinal(6)] [RED("phaseName")] public CName phaseName { get; set; }

        public scnbPerformerInScene_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class scnbScreenplayLineUsage : CVariable
    {
        [Ordinal(0)] [RED("playerGenderMask")] public scnbGenderMask playerGenderMask { get; set; }

        public scnbScreenplayLineUsage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class scnbVoicetagId : CVariable
    {
        [Ordinal(0)] [RED("id")] public CRUID id { get; set; }

        public scnbVoicetagId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class scnbgraphSectionNode : CVariable
    {
        [Ordinal(0)] [RED("id")] public CUInt64 id { get; set; }
        [Ordinal(1)] [RED("position")] public Point position { get; set; }
        [Ordinal(2)] [RED("caption")] public CString caption { get; set; }
        [Ordinal(3)] [RED("sockets")] public CArray<CHandle<toolsSocketDescription>> sockets { get; set; }
        [Ordinal(4)] [RED("sceneNodeId")] public scnNodeId sceneNodeId { get; set; }
        [Ordinal(5)] [RED("titleFixedSize")] public Point titleFixedSize { get; set; }

        public scnbgraphSectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    
    [REDMeta]
	public class scnbeventsVFXBraindanceEventDescriptor : CVariable
	{
        [Ordinal(0)] [RED] public toolsSceneEventID id { get; set; }
        [Ordinal(1)] [RED] public toolsSceneTrackID trackId { get; set; }
        [Ordinal(2)] [RED] public CBool endActionBreak { get; set; }
        [Ordinal(3)] [RED] public CBool fullyRewindable { get; set; }
        [Ordinal(4)] [RED] public NodeRef nodeRef { get; set; }
        [Ordinal(5)] [RED] public scnbEffectEntry effect { get; set; }
        [Ordinal(6)] [RED] public scnbEffectEntry glitchEffect { get; set; }
        [Ordinal(7)] [RED] public toolsSceneEventIdsPool internalSceneEventIdsPool { get; set; }
        [Ordinal(8)] [RED] public CUInt32 duration { get; set; }
        [Ordinal(9)] [RED] public CUInt32 startTime { get; set; }
        [Ordinal(10)] [RED] public CRUID performer { get; set; }

        public scnbeventsVFXBraindanceEventDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
	public class scnbeventsVFXEventDescriptor : CVariable
	{
        [Ordinal(0)] [RED] public toolsSceneEventID id { get; set; }
        [Ordinal(1)] [RED] public toolsSceneTrackID trackId { get; set; }
        [Ordinal(2)] [RED] public CUInt32 startTime { get; set; }
        [Ordinal(3)] [RED] public CUInt32 performer { get; set; }
        [Ordinal(4)] [RED] public CArray<scnbSceneEventsGroupID> eventsGroupIds { get; set; }
        [Ordinal(5)] [RED] public toolsSceneEventIdsPool internalSceneEventIdsPool { get; set; }
        [Ordinal(6)] [RED] public CEnum<scneventsVFXActionType> action { get; set; }
        [Ordinal(7)] [RED] public CBool mute { get; set; }
        [Ordinal(8)] [RED] public NodeRef nodeRef { get; set; }
        [Ordinal(9)] [RED] public scnbEffectEntry effect { get; set; }
        [Ordinal(10)] [RED] public CHandle<entEffectDesc> effectDesc { get; set; }

        public scnbeventsVFXEventDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	
	[REDMeta]
	public class scnblocSignature : CVariable
	{
        [Ordinal(0)] [RED("signature")] public scnblocSignature signature { get; set; }
        [Ordinal(1)] [RED("val")] public CUInt64 val { get; set; }

        public scnblocSignature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	[REDMeta]
	public class scnbEffectEntry : CVariable
	{
        [Ordinal(0)] [RED] public CName effectName { get; set; }
        [Ordinal(1)] [RED] public scnbSceneEffectId sceneEffectId { get; set; }

        public scnbEffectEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class scnblocLocstringId : CVariable
	{
        [Ordinal(0)] [RED("ruid")] public CRUID ruid { get; set; }

        public scnblocLocstringId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	[REDMeta]
	public class scnbSceneActorData : CVariable
	{
        [Ordinal(0)] [RED("actorId")] public CRUID actorId { get; set; }
        [Ordinal(1)] [RED("voiceTagId")] public scnbVoicetagId voiceTagId { get; set; }
        [Ordinal(2)] [RED("characterRecordId")] public TweakDBID characterRecordId { get; set; }
        [Ordinal(3)] [RED("name")] public CString name { get; set; }

        public scnbSceneActorData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	[REDMeta]
	public class scnblocVariantId : CVariable
	{
        [Ordinal(0)] [RED("ruid")] public CRUID ruid { get; set; }

        public scnblocVariantId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class scnblocVariant : CVariable
	{
        [Ordinal(0)] [RED("variantId")] public scnblocVariantId variantId { get; set; }
        [Ordinal(1)] [RED("locstringId")] public scnblocLocstringId locstringId { get; set; }
        [Ordinal(2)] [RED("signature")] public scnblocSignature signature { get; set; }
        [Ordinal(3)] [RED("content")] public CString content { get; set; }


        public scnblocVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	[REDMeta]
	public class scnbSceneEffectId : CVariable
	{
        [Ordinal(0)] [RED] public CRUID id { get; set; }

        public scnbSceneEffectId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class scnbGenderMask : CVariable
	{
        [Ordinal(0)] [RED] public CUInt8 mask { get; set; }

        public scnbGenderMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class scnbAudioLayer : CVariable
	{
        [Ordinal(0)] [RED] public CString scenePath { get; set; }
        [Ordinal(1)] [RED] public CArray<scnbAudioLayerNodeData> audioEventNodes { get; set; }

        public scnbAudioLayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class scnbPresetsDataWrapper : CVariable
	{
        [Ordinal(0)] [RED] public CArray<toolsSceneRecorderPresetData> data { get; set; }

        public scnbPresetsDataWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class scnbAudioLayerNodeData : CVariable
	{
        [Ordinal(0)] [RED] public CHandle<toolsAudioEventDescriptor> audioEvent { get; set; }
        [Ordinal(1)] [RED] public scnNodeId nodeId { get; set; }
        [Ordinal(2)] [RED] public toolsSceneTrackID parentTrackId { get; set; }

        public scnbAudioLayerNodeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	
	[REDMeta]
	public class scnbeventsVFXDurationEventDescriptor : CVariable
	{
        [Ordinal(0)] [RED] public CRUID performer { get; set; }
        [Ordinal(1)] [RED] public CUInt32 duration { get; set; }
        [Ordinal(2)] [RED] public toolsSceneTrackID trackId { get; set; }
        [Ordinal(3)] [RED] public toolsSceneEventIdsPool internalSceneEventIdsPool { get; set; }
        [Ordinal(4)] [RED] public toolsSceneEventID id { get; set; }
        [Ordinal(5)] [RED] public CEnum<scneventsVFXActionType> endAction { get; set; }
        [Ordinal(6)] [RED] public scnbEffectEntry effect { get; set; }
        [Ordinal(7)] [RED] public CHandle<entEffectDesc> effectDesc { get; set; }
        [Ordinal(8)] [RED] public CUInt32 startTime { get; set; }
        [Ordinal(9)] [RED] public NodeRef nodeRef { get; set; }
        [Ordinal(10)] [RED] public CArray<scnbSceneEventsGroupID> eventsGroupIds { get; set; }


        public scnbeventsVFXDurationEventDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	[REDMeta]
	public class scnbSceneEventsGroupID : CVariable
	{
        [Ordinal(0)] [RED("id")] public CUInt64 id { get; set; }

        public scnbSceneEventsGroupID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	

	
}
