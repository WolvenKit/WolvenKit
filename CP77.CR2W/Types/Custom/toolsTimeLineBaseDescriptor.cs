using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class toolsTimeLineBaseDescriptor : CVariable
    {
        [Ordinal(0)] [RED("tracks")] public toolsTimeLineItemCollection tracks { get; set; }
        [Ordinal(1)] [RED("events")] public toolsTimeLineItemCollection events { get; set; }
        [Ordinal(2)] [RED("lastUsedId")] public CUInt64 lastUsedId { get; set; }
        [Ordinal(3)] [RED("tracksRootId")] public CUInt64 tracksRootId { get; set; }

        public toolsTimeLineBaseDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsTimeLineItemCollection : CVariable
	{
        [Ordinal(0)] [RED("items")] public CArray<CHandle<toolsTimeLineItemDescription>> items { get; set; }

		public toolsTimeLineItemCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsAudioEventDescriptor : CVariable
	{
        [Ordinal(0)] [RED("trackId")] public toolsSceneTrackID trackId { get; set; }


        public toolsAudioEventDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsIGraphNodeDescriptor : CVariable
	{
		

        public toolsIGraphNodeDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsAudioDurationEventDescriptor : CVariable
	{
		

        public toolsAudioDurationEventDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
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
    public class toolsSocketDescription : CVariable
    {
        [Ordinal(0)] [RED("id")] public CUInt32 id { get; set; }
        [Ordinal(1)] [RED("placement")] public CEnum<toolsSocketPlacement> placement { get; set; }
        [Ordinal(2)] [RED("caption")] public CString caption { get; set; }
        [Ordinal(3)] [RED("captionColor")] public CColor captionColor { get; set; }
        [Ordinal(4)] [RED("isHidden")] public CBool isHidden { get; set; }
        [Ordinal(5)] [RED("linkColor")] public CColor linkColor { get; set; }
        [Ordinal(6)] [RED("direction")] public CEnum<toolsSocketDirection> direction { get; set; }


        public toolsSocketDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
	public class scnbeventsVFXEventDescriptor : CVariable
	{
		

        public scnbeventsVFXEventDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class houdiniVehicleDestructionSettings : CVariable
	{
        [Ordinal(0)] [RED("entity")] public CString entity { get; set; }

        public houdiniVehicleDestructionSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsSceneEventID : CVariable
	{
        [Ordinal(0)] [RED("id")] public CUInt64 id { get; set; }

        public toolsSceneEventID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	[REDMeta]
	public class scnblocSignature : CVariable
	{
        [Ordinal(0)] [RED("signature")] public scnblocSignature signature { get; set; }
        [Ordinal(1)] [RED("val")] public CUInt64 val { get; set; }

        public scnblocSignature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	[REDMeta]
	public class scnblocLocstringId : CVariable
	{
        [Ordinal(0)] [RED("ruid")] public CRUID ruid { get; set; }

        public scnblocLocstringId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsScreenplaySection : CVariable
	{
        [Ordinal(0)] [RED("id")] public CUInt64 id { get; set; }
        [Ordinal(1)] [RED("index")] public CUInt64 index { get; set; }
        [Ordinal(2)] [RED("lines")] public CArray<toolsScreenplayLine> lines { get; set; }

        public toolsScreenplaySection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
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
	public class toolsUniqueNodeData : CVariable
	{
        [Ordinal(0)] [RED("variant")] public CArray<scnblocVariant> variant { get; set; }
        [Ordinal(1)] [RED("className")] public CName className { get; set; }


        public toolsUniqueNodeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsSocketVisibilityData : CVariable
	{
        
        [Ordinal(0)] [RED("socketId")] public CUInt32 socketId { get; set; }
        [Ordinal(1)] [RED("name")] public CName name { get; set; }
        [Ordinal(2)] [RED("placement")] public CEnum<toolsSocketPlacement> placement { get; set; }
        [Ordinal(3)] [RED("hidden")] public CBool hidden { get; set; }

        public toolsSocketVisibilityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsSectionClipboardDataHolder : CVariable
	{
        [Ordinal(0)] [RED("backendNodeDescriptor")] public CHandle<toolsIGraphNodeDescriptor> backendNodeDescriptor { get; set; }
        [Ordinal(1)] [RED("socketData")] public CArray<toolsSocketVisibilityData> socketData { get; set; }
        [Ordinal(2)] [RED("uniqueNodeData")] public CHandle<toolsUniqueNodeData> uniqueNodeData { get; set; }
        [Ordinal(3)] [RED("variants")] public CArray<scnblocVariant> variants { get; set; }
        [Ordinal(4)] [RED("section")] public toolsScreenplaySection section { get; set; }
        [Ordinal(5)] [RED("actorData")] public CArray<scnbSceneActorData> actorData { get; set; }



        public toolsSectionClipboardDataHolder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsScreenplayLine : CVariable
	{
        [Ordinal(0)] [RED("sectionId")] public CUInt64 sectionId { get; set; }
        [Ordinal(1)] [RED("speaker")] public CRUID speaker { get; set; }
        [Ordinal(2)] [RED("addressee")] public CRUID addressee { get; set; }
        [Ordinal(3)] [RED("id")] public CRUID id { get; set; }
        [Ordinal(4)] [RED("locstringId")] public scnblocLocstringId locstringId { get; set; }
        [Ordinal(5)] [RED("usage")] public scnbScreenplayLineUsage usage { get; set; }

        public toolsScreenplayLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class scnbGenderMask : CVariable
	{
        [Ordinal(0)] [RED("mask")] public CUInt8 mask { get; set; }

        public scnbGenderMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	
	[REDMeta]
	public class toolsTimeLineItemDescription : CVariable
	{
		

        public toolsTimeLineItemDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsAnimTimelineEvent : toolsTimeLineTrackBaseItem
    {
        [Ordinal(0)] [RED("trackId")] public CUInt64 trackId { get; set; }
        [Ordinal(1)] [RED("startTime")] public CFloat startTime { get; set; }
        [Ordinal(2)] [RED("runtimeEvent")] public CHandle<animAnimEvent> runtimeEvent { get; set; }

        public toolsAnimTimelineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	

	[REDMeta]
	public class toolsTimeLineTrackBaseItem : CVariable
	{
        [Ordinal(0)] [RED("id")] public CUInt64 id { get; set; }
        [Ordinal(1)] [RED("type")] public CString type { get; set; }
        [Ordinal(2)] [RED("visualType")] public CString visualType { get; set; }
        [Ordinal(3)] [RED("caption")] public CString caption { get; set; }
        [Ordinal(4)] [RED("parentId")] public CUInt64 parentId { get; set; }
        [Ordinal(5)] [RED("children")] public CArray<CUInt64> children { get; set; }
        
        public toolsTimeLineTrackBaseItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
