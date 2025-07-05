using static WolvenKit.RED4.Types.Enums;
// ReSharper disable InconsistentNaming
// ReSharper disable RedundantTypeArgumentsOfMethod

namespace WolvenKit.RED4.Types;

public class toolsTimeLineBaseDescriptor : IBackendData
{
    [Ordinal(0)]
    [RED("tracks")]
    public toolsTimeLineItemCollection Tracks
    {
        get => GetPropertyValue<toolsTimeLineItemCollection>();
        set => SetPropertyValue<toolsTimeLineItemCollection>(value);
    }

    [Ordinal(1)]
    [RED("events")]
    public toolsTimeLineItemCollection Events
    {
        get => GetPropertyValue<toolsTimeLineItemCollection>();
        set => SetPropertyValue<toolsTimeLineItemCollection>(value);
    }

    [Ordinal(2)]
    [RED("lastUsedId")]
    public CUInt64 LastUsedId
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [Ordinal(3)]
    [RED("tracksRootId")]
    public CUInt64 TracksRootId
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    public toolsTimeLineBaseDescriptor()
    {
        // TODO: Check this value, its not 0
        TracksRootId = ulong.MaxValue;
    }
}

public class toolsTimeLineItemCollection : RedBaseClass
{
    [Ordinal(0)]
    [RED("items")]
    public CArray<CHandle<toolsTimeLineItemDescription>> Items
    {
        get => GetPropertyValue<CArray<CHandle<toolsTimeLineItemDescription>>>();
        set => SetPropertyValue<CArray<CHandle<toolsTimeLineItemDescription>>>(value);
    }
}

public class toolsAudioEventDescriptor : toolsEventDescriptor
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
    public CBool mute
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
    [RED("audioEventName")]
    public CName AudioEventName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(7)]
    [RED("ambientUniqueName")]
    public CName AmbientUniqueName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(8)]
    [RED("emitterName")]
    public CName EmitterName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(9)]
    [RED("performer")]
    public CRUID Performer
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }

    [Ordinal(10)]
    [RED("fastForwardSupport")]
    public CEnum<toolsAudioFastForwardSupport> FastForwardSupport
    {
        get => GetPropertyValue<CEnum<toolsAudioFastForwardSupport>>();
        set => SetPropertyValue<CEnum<toolsAudioFastForwardSupport>>(value);
    }

    [Ordinal(11)]
    [RED("actor")]
    public CRUID Actor
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }

    [Ordinal(12)]
    [RED("prop")]
    public CRUID Prop
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }

    public toolsAudioEventDescriptor()
    {
        EmitterName = CName.Empty;
        FastForwardSupport = Enums.toolsAudioFastForwardSupport.DontMuteDuringFastForward;
    }
}

public class internalSceneEventIdsPool : RedBaseClass
{
    [Ordinal(0)]
    [RED("idsPool")]
    public CArray<scnSceneEventId> IdsPool
    {
        get => GetPropertyValue<CArray<scnSceneEventId>>();
        set => SetPropertyValue<CArray<scnSceneEventId>>(value);
    }
}

public class toolsSceneEventIdsPool : RedBaseClass
{
    [Ordinal(0)]
    [RED("idsPool")]
    public CArray<scnSceneEventId> IdsPool
    {
        get => GetPropertyValue<CArray<scnSceneEventId>>();
        set => SetPropertyValue<CArray<scnSceneEventId>>(value);
    }
}

public class toolsPartsCategory : RedBaseClass
{
    [Ordinal(1)]
    [RED("name")]
    public CName Name
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(2)]
    [RED("logicName")]
    public CName LogicName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(3)]
    [RED("parts")]
    public CArray<CString> Parts
    {
        get => GetPropertyValue<CArray<CString>>();
        set => SetPropertyValue<CArray<CString>>(value);
    }
}

public class toolsIGraphNodeDescriptor : RedBaseClass
{
}

public class toolsAudioDurationEventDescriptor : toolsEventDescriptor
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
    [RED("mute")]
    public CBool Mute
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(6)]
    [RED("internalSceneEventIdsPool")]
    public toolsSceneEventIdsPool InternalSceneEventIdsPool
    {
        get => GetPropertyValue<toolsSceneEventIdsPool>();
        set => SetPropertyValue<toolsSceneEventIdsPool>(value);
    }

    [Ordinal(7)]
    [RED("audioEventName")]
    public CName AudioEventName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(8)]
    [RED("performer")]
    public CRUID Performer
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }

    [Ordinal(9)]
    [RED("playbackDirectionSupport")]
    public CEnum<toolsAudioPlaybackDirectionSupport> PlaybackDirectionSupport
    {
        get => GetPropertyValue<CEnum<toolsAudioPlaybackDirectionSupport>>();
        set => SetPropertyValue<CEnum<toolsAudioPlaybackDirectionSupport>>(value);
    }
}

public class toolsSocketDescription : RedBaseClass
{
    [Ordinal(0)]
    [RED("id")]
    public CUInt32 Id
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(1)]
    [RED("placement")]
    public CEnum<toolsSocketPlacement> Placement
    {
        get => GetPropertyValue<CEnum<toolsSocketPlacement>>();
        set => SetPropertyValue<CEnum<toolsSocketPlacement>>(value);
    }

    [Ordinal(2)]
    [RED("caption")]
    public CString Caption
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(3)]
    [RED("captionColor")]
    public CColor CaptionColor
    {
        get => GetPropertyValue<CColor>();
        set => SetPropertyValue<CColor>(value);
    }

    [Ordinal(4)]
    [RED("isHidden")]
    public CBool IsHidden
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    [Ordinal(5)]
    [RED("linkColor")]
    public CColor LinkColor
    {
        get => GetPropertyValue<CColor>();
        set => SetPropertyValue<CColor>(value);
    }

    [Ordinal(6)]
    [RED("direction")]
    public CEnum<toolsSocketDirection> Direction
    {
        get => GetPropertyValue<CEnum<toolsSocketDirection>>();
        set => SetPropertyValue<CEnum<toolsSocketDirection>>(value);
    }

    public toolsSocketDescription()
    {
        Id = uint.MaxValue;
        CaptionColor = new();
        LinkColor = new();
    }
}

public class houdiniVehicleDestructionMeshEntry : RedBaseClass
{
    [Ordinal(0)]
    [RED("path")]
    public CString Path
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(1)]
    [RED("position", 3)]
    public CStatic<CFloat> Position
    {
        get => GetPropertyValue<CStatic<CFloat>>();
        set => SetPropertyValue<CStatic<CFloat>>(value);
    }

    public houdiniVehicleDestructionMeshEntry()
    {
        // TODO: Check this
        Position = new(3) { 0, 0, 1 };
    }
}

public class houdiniVehicleGridSettings : RedBaseClass
{
    [Ordinal(0)]
    [RED("capturePointsMin")]
    public CUInt32 CapturePointsMin
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(1)]
    [RED("capturePointsMax")]
    public CUInt32 CapturePointsMax
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(2)]
    [RED("captureRadius")]
    public CFloat CaptureRadius
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(3)]
    [RED("pathRest")]
    public CString PathRest
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(4)]
    [RED("pathDeformed")]
    public CString PathDeformed
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(5)]
    [RED("meshes")]
    public CArray<CString> Meshes
    {
        get => GetPropertyValue<CArray<CString>>();
        set => SetPropertyValue<CArray<CString>>(value);
    }

    [Ordinal(6)]
    [RED("extraMeshes")]
    public CArray<houdiniVehicleDestructionMeshEntry> ExtraMeshes
    {
        get => GetPropertyValue<CArray<houdiniVehicleDestructionMeshEntry>>();
        set => SetPropertyValue<CArray<houdiniVehicleDestructionMeshEntry>>(value);
    }
}

public class toolsPresetsData : ISerializable
{
}

public class houdiniVehicleDestructionSettings : ISerializable
{
    [Ordinal(0)]
    [RED("entity")]
    public CString Entity
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(1)]
    [RED("grids")]
    public CArray<houdiniVehicleGridSettings> Grids
    {
        get => GetPropertyValue<CArray<houdiniVehicleGridSettings>>();
        set => SetPropertyValue<CArray<houdiniVehicleGridSettings>>(value);
    }
}

public class toolsSceneEventID : RedBaseClass
{
    [Ordinal(0)]
    [RED("id")]
    public CUInt64 Id
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }
}

public class toolsScreenplaySection : RedBaseClass
{
    [Ordinal(0)]
    [RED("id")]
    public CUInt64 Id
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [Ordinal(1)]
    [RED("index")]
    public CUInt64 Index
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [Ordinal(2)]
    [RED("lines")]
    public CArray<toolsScreenplayLine> Lines
    {
        get => GetPropertyValue<CArray<toolsScreenplayLine>>();
        set => SetPropertyValue<CArray<toolsScreenplayLine>>(value);
    }
}

public class toolsUniqueNodeData : RedBaseClass
{
    [Ordinal(0)]
    [RED("variant")]
    public CArray<scnblocVariant> Variant
    {
        get => GetPropertyValue<CArray<scnblocVariant>>();
        set => SetPropertyValue<CArray<scnblocVariant>>(value);
    }

    [Ordinal(1)]
    [RED("className")]
    public CName ClassName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }
}

public class toolsSocketVisibilityData : RedBaseClass
{
    [Ordinal(0)]
    [RED("socketId")]
    public CUInt32 SocketId
    {
        get => GetPropertyValue<CUInt32>();
        set => SetPropertyValue<CUInt32>(value);
    }

    [Ordinal(1)]
    [RED("name")]
    public CName Name
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(2)]
    [RED("placement")]
    public CEnum<toolsSocketPlacement> Placement
    {
        get => GetPropertyValue<CEnum<toolsSocketPlacement>>();
        set => SetPropertyValue<CEnum<toolsSocketPlacement>>(value);
    }

    [Ordinal(3)]
    [RED("hidden")]
    public CBool Hidden
    {
        get => GetPropertyValue<CBool>();
        set => SetPropertyValue<CBool>(value);
    }

    public toolsSocketVisibilityData()
    {
        SocketId = uint.MaxValue;
    }
}

public class toolsSectionClipboardDataHolder : ISerializable
{
    [Ordinal(0)]
    [RED("backendNodeDescriptor")]
    public CHandle<toolsIGraphNodeDescriptor> BackendNodeDescriptor
    {
        get => GetPropertyValue<CHandle<toolsIGraphNodeDescriptor>>();
        set => SetPropertyValue<CHandle<toolsIGraphNodeDescriptor>>(value);
    }

    [Ordinal(1)]
    [RED("socketData")]
    public CArray<toolsSocketVisibilityData> SocketData
    {
        get => GetPropertyValue<CArray<toolsSocketVisibilityData>>();
        set => SetPropertyValue<CArray<toolsSocketVisibilityData>>(value);
    }

    [Ordinal(2)]
    [RED("uniqueNodeData")]
    public CHandle<toolsUniqueNodeData> UniqueNodeData
    {
        get => GetPropertyValue<CHandle<toolsUniqueNodeData>>();
        set => SetPropertyValue<CHandle<toolsUniqueNodeData>>(value);
    }

    [Ordinal(3)]
    [RED("variants")]
    public CArray<scnblocVariant> Variants
    {
        get => GetPropertyValue<CArray<scnblocVariant>>();
        set => SetPropertyValue<CArray<scnblocVariant>>(value);
    }

    [Ordinal(4)]
    [RED("section")]
    public toolsScreenplaySection Section
    {
        get => GetPropertyValue<toolsScreenplaySection>();
        set => SetPropertyValue<toolsScreenplaySection>(value);
    }

    [Ordinal(5)]
    [RED("actorData")]
    public CArray<scnbSceneActorData> ActorData
    {
        get => GetPropertyValue<CArray<scnbSceneActorData>>();
        set => SetPropertyValue<CArray<scnbSceneActorData>>(value);
    }
}

public class toolsScreenplayLine : RedBaseClass
{
    [Ordinal(0)]
    [RED("sectionId")]
    public CUInt64 SectionId
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [Ordinal(1)]
    [RED("speaker")]
    public CRUID Speaker
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }

    [Ordinal(2)]
    [RED("addressee")]
    public CRUID Addressee
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }

    [Ordinal(3)]
    [RED("id")]
    public CRUID Id
    {
        get => GetPropertyValue<CRUID>();
        set => SetPropertyValue<CRUID>(value);
    }

    [Ordinal(4)]
    [RED("usage")]
    public scnbScreenplayLineUsage Usage
    {
        get => GetPropertyValue<scnbScreenplayLineUsage>();
        set => SetPropertyValue<scnbScreenplayLineUsage>(value);
    }

    [Ordinal(5)]
    [RED("locstringId")]
    public scnblocLocstringId LocstringId
    {
        get => GetPropertyValue<scnblocLocstringId>();
        set => SetPropertyValue<scnblocLocstringId>(value);
    }
}

public class toolsRagdollExportData : ISerializable
{
    [Ordinal(0)]
    [RED("ragdollDesc")]
    public CArray<physicsRagdollBodyInfo> RagdollDesc
    {
        get => GetPropertyValue<CArray<physicsRagdollBodyInfo>>();
        set => SetPropertyValue<CArray<physicsRagdollBodyInfo>>(value);
    }

    [Ordinal(1)]
    [RED("ragdollNames")]
    public CArray<physicsRagdollBodyNames> RagdollNames
    {
        get => GetPropertyValue<CArray<physicsRagdollBodyNames>>();
        set => SetPropertyValue<CArray<physicsRagdollBodyNames>>(value);
    }
}

public class toolsPartsCategories : ISerializable
{
    [Ordinal(0)]
    [RED("categories")]
    public CArray<toolsPartsCategory> Categories
    {
        get => GetPropertyValue<CArray<toolsPartsCategory>>();
        set => SetPropertyValue<CArray<toolsPartsCategory>>(value);
    }
}

public class toolsAppearanceNamingParser : ISerializable
{
    [Ordinal(0)]
    [RED("regex")]
    public CString Regex
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(1)]
    [RED("captureGroups")]
    public CArray<toolsAppearanceNamingCaptureGroup> CaptureGroups
    {
        get => GetPropertyValue<CArray<toolsAppearanceNamingCaptureGroup>>();
        set => SetPropertyValue<CArray<toolsAppearanceNamingCaptureGroup>>(value);
    }
}

public class toolsAppearanceConfigMapping : RedBaseClass
{
    [Ordinal(0)]
    [RED("name")]
    public CName Name
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    [Ordinal(1)]
    [RED("baseTypesFile")]
    public CString BaseTypesFile
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(2)]
    [RED("baseTypePrefix")]
    public CString BaseTypePrefix
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(3)]
    [RED("categoriesFile")]
    public CString CategoriesFile
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(4)]
    [RED("partsFile")]
    public CString PartsFile
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(5)]
    [RED("partsCategoriesFile")]
    public CString PartsCategoriesFile
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(6)]
    [RED("scanDirectory")]
    public CString ScanDirectory
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(7)]
    [RED("filenameParsingRules")]
    public CString FilenameParsingRules
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }
}

public class toolsAppearancesConfig : ISerializable
{
    [Ordinal(0)]
    [RED("mappings")]
    public CArray<toolsAppearanceConfigMapping> Mappings
    {
        get => GetPropertyValue<CArray<toolsAppearanceConfigMapping>>();
        set => SetPropertyValue<CArray<toolsAppearanceConfigMapping>>(value);
    }
}

public class toolsPresetSectionData : RedBaseClass
{
    [Ordinal(0)]
    [RED("sectionNames")]
    public CArray<CString> SectionNames
    {
        get => GetPropertyValue<CArray<CString>>();
        set => SetPropertyValue<CArray<CString>>(value);
    }
}

public class toolsSceneRecorderPresetData : RedBaseClass
{
    [Ordinal(0)]
    [RED("name")]
    public CString Name
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(1)]
    [RED("scenePaths")]
    public CArray<CString> ScenePaths
    {
        get => GetPropertyValue<CArray<CString>>();
        set => SetPropertyValue<CArray<CString>>(value);
    }

    [Ordinal(2)]
    [RED("sectionData")]
    public CArray<toolsPresetSectionData> SectionData
    {
        get => GetPropertyValue<CArray<toolsPresetSectionData>>();
        set => SetPropertyValue<CArray<toolsPresetSectionData>>(value);
    }
}

public class toolsAppearanceNamingCaptureGroup : RedBaseClass
{
    [Ordinal(0)]
    [RED("editorTagPrefix")]
    public CString EditorTagPrefix
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(1)]
    [RED("externalComponent")]
    public CArray<CArray<CString>> ExternalComponent
    {
        get => GetPropertyValue<CArray<CArray<CString>>>();
        set => SetPropertyValue<CArray<CArray<CString>>>(value);
    }

    [Ordinal(2)]
    [RED("mapOfNames")]
    public CArray<CArray<CString>> MapOfNames
    {
        get => GetPropertyValue<CArray<CArray<CString>>>();
        set => SetPropertyValue<CArray<CArray<CString>>>(value);
    }

    [Ordinal(3)]
    [RED("case")]
    public CString Case
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(4)]
    [RED("allowedValueType")]
    public CString AllowedValueType
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }
}

public class toolsTimeLineItemDescription : RedBaseClass
{
}

public class toolsAnimTimelineEvent : toolsTimeLineTrackBaseItem
{
    [Ordinal(6)]
    [RED("trackId")]
    public CUInt64 TrackId
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [Ordinal(7)]
    [RED("startTime")]
    public CFloat StartTime
    {
        get => GetPropertyValue<CFloat>();
        set => SetPropertyValue<CFloat>(value);
    }

    [Ordinal(8)]
    [RED("runtimeEvent")]
    public CHandle<animAnimEvent> RuntimeEvent
    {
        get => GetPropertyValue<CHandle<animAnimEvent>>();
        set => SetPropertyValue<CHandle<animAnimEvent>>(value);
    }
}

public class toolsSceneTrackID : RedBaseClass
{
    [Ordinal(0)]
    [RED("id")]
    public CUInt64 Id
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    public toolsSceneTrackID()
    {
        Id = ulong.MaxValue;
    }
}

public class toolsEventDescriptor : RedBaseClass
{
}

public class toolsTimeLineTrackBaseItem : toolsTimeLineItemDescription
{
    [Ordinal(0)]
    [RED("id")]
    public CUInt64 Id
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [Ordinal(1)]
    [RED("type")]
    public CString Type
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(2)]
    [RED("visualType")]
    public CString VisualType
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(3)]
    [RED("caption")]
    public CString Caption
    {
        get => GetPropertyValue<CString>();
        set => SetPropertyValue<CString>(value);
    }

    [Ordinal(4)]
    [RED("parentId")]
    public CUInt64 ParentId
    {
        get => GetPropertyValue<CUInt64>();
        set => SetPropertyValue<CUInt64>(value);
    }

    [Ordinal(5)]
    [RED("children")]
    public CArray<CUInt64> Children
    {
        get => GetPropertyValue<CArray<CUInt64>>();
        set => SetPropertyValue<CArray<CUInt64>>(value);
    }

    public toolsTimeLineTrackBaseItem()
    {
        // TODO: Check this value, its not 0
        Id = ulong.MaxValue;
        ParentId = ulong.MaxValue;
    }
}