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
        [Ordinal(0)] [RED] public toolsSceneEventID id { get; set; }
        [Ordinal(1)] [RED]public toolsSceneTrackID trackId { get; set; }
        [Ordinal(2)] [RED] public CArray<scnbSceneEventsGroupID> eventsGroupIds { get; set; }
        [Ordinal(3)] [RED] public CUInt32 startTime { get; set; }
        [Ordinal(4)] [RED] public CBool mute { get; set; }
        [Ordinal(5)] [RED] public toolsSceneEventIdsPool internalSceneEventIdsPool { get; set; }
        [Ordinal(6)] [RED] public CName audioEventName { get; set; }
        [Ordinal(7)] [RED] public CName ambientUniqueName { get; set; }
        [Ordinal(8)] [RED] public CName emitterName { get; set; }
        [Ordinal(9)] [RED] public CRUID performer { get; set; }
        [Ordinal(10)] [RED] public CEnum<toolsAudioFastForwardSupport> fastForwardSupport { get; set; }
        [Ordinal(11)] [RED] public CRUID actor { get; set; }
        [Ordinal(12)] [RED] public CRUID prop { get; set; }

        public toolsAudioEventDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class internalSceneEventIdsPool : CVariable
	{
        [Ordinal(0)] [RED("idsPool")] public CArray<scnSceneEventId> idsPool { get; set; }

        public internalSceneEventIdsPool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsSceneEventIdsPool : CVariable
	{
        [Ordinal(0)] [RED("idsPool")] public CArray<scnSceneEventId> idsPool { get; set; }

        public toolsSceneEventIdsPool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsPartsCategory : CVariable
	{
        [Ordinal(1)] [RED] public CName name { get; set; }
        [Ordinal(2)] [RED] public CName logicName { get; set; }
        [Ordinal(3)] [RED] public CArray<CString> parts { get; set; }

        public toolsPartsCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
	public class toolsIGraphNodeDescriptor : CVariable
	{


        public toolsIGraphNodeDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsAudioDurationEventDescriptor : CVariable
	{
        [Ordinal(0)] [RED] public toolsSceneEventID id { get; set; }
        [Ordinal(1)] [RED("trackId")] public toolsSceneTrackID trackId { get; set; }
        [Ordinal(2)] [RED] public CArray<scnbSceneEventsGroupID> eventsGroupIds { get; set; }
        [Ordinal(3)] [RED("startTime")] public CUInt32 startTime { get; set; }
        [Ordinal(4)] [RED("duration")] public CUInt32 duration { get; set; }
        [Ordinal(5)] [RED] public CBool mute { get; set; }
        [Ordinal(6)] [RED] public toolsSceneEventIdsPool internalSceneEventIdsPool { get; set; }
        [Ordinal(7)] [RED] public CName audioEventName { get; set; }
        [Ordinal(8)] [RED] public CRUID performer { get; set; }
        [Ordinal(9)] [RED] public CEnum<toolsAudioPlaybackDirectionSupport> playbackDirectionSupport { get; set; }

        public toolsAudioDurationEventDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
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
	public class houdiniVehicleDestructionMeshEntry : CVariable
	{
        [Ordinal(0)] [RED("path")] public CString Path { get; set; }
        [Ordinal(1)] [RED("position", 3)] public CStatic<CFloat> Position { get; set; }

        public houdiniVehicleDestructionMeshEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
	public class houdiniVehicleGridSettings : CVariable
	{
        [Ordinal(0)] [RED("capturePointsMin")] public CUInt32 capturePointsMin { get; set; }
        [Ordinal(1)] [RED("capturePointsMax")] public CUInt32 capturePointsMax { get; set; }
        [Ordinal(2)] [RED("captureRadius")] public CFloat CaptureRadius { get; set; }
        [Ordinal(3)] [RED("pathRest")] public CString PathRest { get; set; }
        [Ordinal(4)] [RED("pathDeformed")] public CString PathDeformed { get; set; }
        [Ordinal(5)] [RED("meshes")] public CArray<CString> Meshes { get; set; }
        [Ordinal(6)] [RED("extraMeshes")] public CArray<houdiniVehicleDestructionMeshEntry> ExtraMeshes { get; set; }


        public houdiniVehicleGridSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
	public class toolsPresetsData : CVariable
	{
        public toolsPresetsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class houdiniVehicleDestructionSettings : CVariable
	{
        [Ordinal(0)] [RED("entity")] public CString entity { get; set; }
        [Ordinal(1)] [RED("grids")] public CArray<houdiniVehicleGridSettings> Grids { get; set; }

        public houdiniVehicleDestructionSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsSceneEventID : CVariable
	{
        [Ordinal(0)] [RED("id")] public CUInt64 id { get; set; }

        public toolsSceneEventID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
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
	public class toolsRagdollExportData : CVariable
	{
        [Ordinal(0)] [RED] public CArray<physicsRagdollBodyInfo> ragdollDesc { get; set; }
        [Ordinal(1)] [RED] public CArray<physicsRagdollBodyNames> ragdollNames { get; set; }

        public toolsRagdollExportData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsVisualTagsRoot : CVariable
	{
        [Ordinal(0)] [RED] public CArray<toolsVisualTagsSchema> schemas { get; set; }

        public toolsVisualTagsRoot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsPartsCategories : CVariable
	{
        [Ordinal(0)] [RED] public CArray<toolsPartsCategory> categories { get; set; }

        public toolsPartsCategories(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsAppearanceNamingParser : CVariable
	{
        [Ordinal(0)] [RED] public CString regex { get; set; }
        [Ordinal(1)] [RED] public CArray<toolsAppearanceNamingCaptureGroup> captureGroups { get; set; }

        public toolsAppearanceNamingParser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
	public class toolsAppearanceConfigMapping : CVariable
	{
        [Ordinal(0)] [RED] public  CName name { get; set; }
        [Ordinal(1)] [RED] public CString baseTypesFile { get; set; }
        [Ordinal(2)] [RED] public  CString baseTypePrefix { get; set; }
        [Ordinal(3)] [RED] public  CString categoriesFile { get; set; }
        [Ordinal(4)] [RED] public CString partsFile { get; set; }
        [Ordinal(5)] [RED] public  CString partsCategoriesFile { get; set; }
        [Ordinal(6)] [RED] public  CString scanDirectory { get; set; }
        [Ordinal(7)] [RED] public CString filenameParsingRules { get; set; }


        public toolsAppearanceConfigMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsVisualTagsSchema : CVariable
	{
        [Ordinal(0)] [RED] public CName name { get; set; }
        [Ordinal(1)] [RED] public CArray<toolsVisualTagsGroup> categories { get; set; }
        [Ordinal(2)] [RED] public CArray<toolsVisualTagsGroup> presets { get; set; }

        public toolsVisualTagsSchema(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsAppearancesConfig : CVariable
	{
        [Ordinal(0)] [RED] public CArray<toolsAppearanceConfigMapping> mappings { get; set; }

        public toolsAppearancesConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsVisualTagsDefinition : CVariable
	{
        [Ordinal(0)] [RED] public CName name { get; set; }

        public toolsVisualTagsDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsPresetSectionData : CVariable
	{
        [Ordinal(0)] [RED] public CArray<CString> sectionNames { get; set; }

        public toolsPresetSectionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsSceneRecorderPresetData : CVariable
	{
        [Ordinal(0)] [RED("name")] public CString Name { get; set; }
        [Ordinal(1)] [RED("scenePaths")] public CArray<CString> ScenePaths { get; set; }
        [Ordinal(2)] [RED("sectionData")] public CArray<toolsPresetSectionData> SectionData { get; set; }

        public toolsSceneRecorderPresetData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsVisualTagsGroup : CVariable
	{
        [Ordinal(0)] [RED] public CName name { get; set; }
        [Ordinal(1)] [RED] public CArray<toolsVisualTagsDefinition> tags { get; set; }

        public toolsVisualTagsGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsAppearanceNamingCaptureGroup : CVariable
	{
        [Ordinal(0)] [RED] public CString editorTagPrefix { get; set; }
        [Ordinal(1)] [RED] public CArray<CArray<CString>> externalComponent { get; set; }
        [Ordinal(2)] [RED] public CArray<CArray<CString>> mapOfNames { get; set; }
        [Ordinal(3)] [RED("case")] public CString case_ { get; set; }
        [Ordinal(4)] [RED] public CString allowedValueType { get; set; }

        public toolsAppearanceNamingCaptureGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsTimeLineItemDescription : CVariable
	{
        public toolsTimeLineItemDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsAnimTimelineEvent : toolsTimeLineTrackBaseItem
    {
        [Ordinal(6)] [RED] public CUInt64 trackId { get; set; }
        [Ordinal(7)] [RED] public CFloat startTime { get; set; }
        [Ordinal(8)] [RED] public CHandle<animAnimEvent> runtimeEvent { get; set; }

        public toolsAnimTimelineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class toolsSceneTrackID : CVariable
    {
        [Ordinal(0)] [RED("id")] public CUInt64 id { get; set; }


        public toolsSceneTrackID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class toolsEventDescriptor : CVariable
    {
        public toolsEventDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
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
