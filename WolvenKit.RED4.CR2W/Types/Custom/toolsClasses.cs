using System;
using System.IO;
using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class toolsTimeLineBaseDescriptor : CVariable
    {
        private toolsTimeLineItemCollection _tracks;
        private toolsTimeLineItemCollection _events;
        private CUInt64 _lastUsedId;
        private CUInt64 _tracksRootId;

        [Ordinal(0)]
        [RED("tracks")]
        public toolsTimeLineItemCollection Tracks
        {
            get => GetProperty(ref _tracks);
            set => SetProperty(ref _tracks, value);
        }

        [Ordinal(1)]
        [RED("events")]
        public toolsTimeLineItemCollection Events
        {
            get => GetProperty(ref _events);
            set => SetProperty(ref _events, value);
        }

        [Ordinal(2)]
        [RED("lastUsedId")]
        public CUInt64 LastUsedId
        {
            get => GetProperty(ref _lastUsedId);
            set => SetProperty(ref _lastUsedId, value);
        }

        [Ordinal(3)]
        [RED("tracksRootId")]
        public CUInt64 TracksRootId
        {
            get => GetProperty(ref _tracksRootId);
            set => SetProperty(ref _tracksRootId, value);
        }

        public toolsTimeLineBaseDescriptor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsTimeLineItemCollection : CVariable
	{
        private CArray<CHandle<toolsTimeLineItemDescription>> _items;

        [Ordinal(0)]
        [RED("items")]
        public CArray<CHandle<toolsTimeLineItemDescription>> Items
        {
            get => GetProperty(ref _items);
            set => SetProperty(ref _items, value);
        }

        public toolsTimeLineItemCollection(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsAudioEventDescriptor : CVariable
	{
        private toolsSceneEventID _id;
        private toolsSceneTrackID _trackId;
        private CArray<scnbSceneEventsGroupID> _eventsGroupIds;
        private CUInt32 _startTime;
        private CBool _mute;
        private toolsSceneEventIdsPool _internalSceneEventIdsPool;
        private CName _audioEventName;
        private CName _ambientUniqueName;
        private CName _emitterName;
        private CRUID _performer;
        private CEnum<toolsAudioFastForwardSupport> _fastForwardSupport;
        private CRUID _actor;
        private CRUID _prop;

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
        public CBool mute
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
        [RED("audioEventName")]
        public CName AudioEventName
        {
            get => GetProperty(ref _audioEventName);
            set => SetProperty(ref _audioEventName, value);
        }

        [Ordinal(7)]
        [RED("ambientUniqueName")]
        public CName AmbientUniqueName
        {
            get => GetProperty(ref _ambientUniqueName);
            set => SetProperty(ref _ambientUniqueName, value);
        }

        [Ordinal(8)]
        [RED("emitterName")]
        public CName EmitterName
        {
            get => GetProperty(ref _emitterName);
            set => SetProperty(ref _emitterName, value);
        }

        [Ordinal(9)]
        [RED("performer")]
        public CRUID Performer
        {
            get => GetProperty(ref _performer);
            set => SetProperty(ref _performer, value);
        }

        [Ordinal(10)]
        [RED("fastForwardSupport")]
        public CEnum<toolsAudioFastForwardSupport> FastForwardSupport
        {
            get => GetProperty(ref _fastForwardSupport);
            set => SetProperty(ref _fastForwardSupport, value);
        }

        [Ordinal(11)]
        [RED("actor")]
        public CRUID Actor
        {
            get => GetProperty(ref _actor);
            set => SetProperty(ref _actor, value);
        }

        [Ordinal(12)]
        [RED("prop")]
        public CRUID Prop
        {
            get => GetProperty(ref _prop);
            set => SetProperty(ref _prop, value);
        }

        public toolsAudioEventDescriptor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class internalSceneEventIdsPool : CVariable
	{
        private CArray<scnSceneEventId> _idsPool;

        [Ordinal(0)]
        [RED("idsPool")]
        public CArray<scnSceneEventId> IdsPool
        {
            get => GetProperty(ref _idsPool);
            set => SetProperty(ref _idsPool, value);
        }

        public internalSceneEventIdsPool(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsSceneEventIdsPool : CVariable
	{
        private CArray<scnSceneEventId> _idsPool;

        [Ordinal(0)]
        [RED("idsPool")]
        public CArray<scnSceneEventId> IdsPool
        {
            get => GetProperty(ref _idsPool);
            set => SetProperty(ref _idsPool, value);
        }

        public toolsSceneEventIdsPool(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsPartsCategory : CVariable
	{
        private CName _name;
        private CName _logicName;
        private CArray<CString> _parts;

        [Ordinal(1)]
        [RED("name")]
        public CName Name
        {
            get => GetProperty(ref _name);
            set => SetProperty(ref _name, value);
        }

        [Ordinal(2)]
        [RED("logicName")]
        public CName LogicName
        {
            get => GetProperty(ref _logicName);
            set => SetProperty(ref _logicName, value);
        }

        [Ordinal(3)]
        [RED("parts")]
        public CArray<CString> Parts
        {
            get => GetProperty(ref _parts);
            set => SetProperty(ref _parts, value);
        }

        public toolsPartsCategory(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
	public class toolsIGraphNodeDescriptor : CVariable
	{


        public toolsIGraphNodeDescriptor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsAudioDurationEventDescriptor : CVariable
	{
        private toolsSceneEventID _id;
        private toolsSceneTrackID _trackId;
        private CArray<scnbSceneEventsGroupID> _eventsGroupIds;
        private CUInt32 _startTime;
        private CUInt32 _duration;
        private CBool _mute;
        private toolsSceneEventIdsPool _internalSceneEventIdsPool;
        private CName _audioEventName;
        private CRUID _performer;
        private CEnum<toolsAudioPlaybackDirectionSupport> _playbackDirectionSupport;

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
        [RED("mute")]
        public CBool Mute
        {
            get => GetProperty(ref _mute);
            set => SetProperty(ref _mute, value);
        }

        [Ordinal(6)]
        [RED("internalSceneEventIdsPool")]
        public toolsSceneEventIdsPool InternalSceneEventIdsPool
        {
            get => GetProperty(ref _internalSceneEventIdsPool);
            set => SetProperty(ref _internalSceneEventIdsPool, value);
        }

        [Ordinal(7)]
        [RED("audioEventName")]
        public CName AudioEventName
        {
            get => GetProperty(ref _audioEventName);
            set => SetProperty(ref _audioEventName, value);
        }

        [Ordinal(8)]
        [RED("performer")]
        public CRUID Performer
        {
            get => GetProperty(ref _performer);
            set => SetProperty(ref _performer, value);
        }

        [Ordinal(9)]
        [RED("playbackDirectionSupport")]
        public CEnum<toolsAudioPlaybackDirectionSupport> PlaybackDirectionSupport
        {
            get => GetProperty(ref _playbackDirectionSupport);
            set => SetProperty(ref _playbackDirectionSupport, value);
        }

        public toolsAudioDurationEventDescriptor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class toolsSocketDescription : CVariable
    {
        private CUInt32 _id;
        private CEnum<toolsSocketPlacement> _placement;
        private CString _caption;
        private CColor _captionColor;
        private CBool _isHidden;
        private CColor _linkColor;
        private CEnum<toolsSocketDirection> _direction;

        [Ordinal(0)]
        [RED("id")]
        public CUInt32 Id
        {
            get => GetProperty(ref _id);
            set => SetProperty(ref _id, value);
        }

        [Ordinal(1)]
        [RED("placement")]
        public CEnum<toolsSocketPlacement> Placement
        {
            get => GetProperty(ref _placement);
            set => SetProperty(ref _placement, value);
        }

        [Ordinal(2)]
        [RED("caption")]
        public CString Caption
        {
            get => GetProperty(ref _caption);
            set => SetProperty(ref _caption, value);
        }

        [Ordinal(3)]
        [RED("captionColor")]
        public CColor CaptionColor
        {
            get => GetProperty(ref _captionColor);
            set => SetProperty(ref _captionColor, value);
        }

        [Ordinal(4)]
        [RED("isHidden")]
        public CBool IsHidden
        {
            get => GetProperty(ref _isHidden);
            set => SetProperty(ref _isHidden, value);
        }

        [Ordinal(5)]
        [RED("linkColor")]
        public CColor LinkColor
        {
            get => GetProperty(ref _linkColor);
            set => SetProperty(ref _linkColor, value);
        }

        [Ordinal(6)]
        [RED("direction")]
        public CEnum<toolsSocketDirection> Direction
        {
            get => GetProperty(ref _direction);
            set => SetProperty(ref _direction, value);
        }


        public toolsSocketDescription(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
	public class houdiniVehicleDestructionMeshEntry : CVariable
	{
        private CString _path;
        private CStatic<CFloat> _position;

        [Ordinal(0)]
        [RED("path")]
        public CString Path
        {
            get => GetProperty(ref _path);
            set => SetProperty(ref _path, value);
        }

        [Ordinal(1)]
        [RED("position", 3)]
        public CStatic<CFloat> Position
        {
            get => GetProperty(ref _position);
            set => SetProperty(ref _position, value);
        }

        public houdiniVehicleDestructionMeshEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
	public class houdiniVehicleGridSettings : CVariable
	{
        private CUInt32 _capturePointsMin;
        private CUInt32 _capturePointsMax;
        private CFloat _captureRadius;
        private CString _pathRest;
        private CString _pathDeformed;
        private CArray<CString> _meshes;
        private CArray<houdiniVehicleDestructionMeshEntry> _extraMeshes;

        [Ordinal(0)]
        [RED("capturePointsMin")]
        public CUInt32 CapturePointsMin
        {
            get => GetProperty(ref _capturePointsMin);
            set => SetProperty(ref _capturePointsMin, value);
        }

        [Ordinal(1)]
        [RED("capturePointsMax")]
        public CUInt32 CapturePointsMax
        {
            get => GetProperty(ref _capturePointsMax);
            set => SetProperty(ref _capturePointsMax, value);
        }

        [Ordinal(2)]
        [RED("captureRadius")]
        public CFloat CaptureRadius
        {
            get => GetProperty(ref _captureRadius);
            set => SetProperty(ref _captureRadius, value);
        }

        [Ordinal(3)]
        [RED("pathRest")]
        public CString PathRest
        {
            get => GetProperty(ref _pathRest);
            set => SetProperty(ref _pathRest, value);
        }

        [Ordinal(4)]
        [RED("pathDeformed")]
        public CString PathDeformed
        {
            get => GetProperty(ref _pathDeformed);
            set => SetProperty(ref _pathDeformed, value);
        }

        [Ordinal(5)]
        [RED("meshes")]
        public CArray<CString> Meshes
        {
            get => GetProperty(ref _meshes);
            set => SetProperty(ref _meshes, value);
        }

        [Ordinal(6)]
        [RED("extraMeshes")]
        public CArray<houdiniVehicleDestructionMeshEntry> ExtraMeshes
        {
            get => GetProperty(ref _extraMeshes);
            set => SetProperty(ref _extraMeshes, value);
        }


        public houdiniVehicleGridSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
	public class toolsPresetsData : CVariable
	{
        public toolsPresetsData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class houdiniVehicleDestructionSettings : CVariable
	{
        private CString _entity;
        private CArray<houdiniVehicleGridSettings> _grids;

        [Ordinal(0)]
        [RED("entity")]
        public CString Entity
        {
            get => GetProperty(ref _entity);
            set => SetProperty(ref _entity, value);
        }

        [Ordinal(1)]
        [RED("grids")]
        public CArray<houdiniVehicleGridSettings> Grids
        {
            get => GetProperty(ref _grids);
            set => SetProperty(ref _grids, value);
        }

        public houdiniVehicleDestructionSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsSceneEventID : CVariable
	{
        private CUInt64 _id;

        [Ordinal(0)]
        [RED("id")]
        public CUInt64 Id
        {
            get => GetProperty(ref _id);
            set => SetProperty(ref _id, value);
        }

        public toolsSceneEventID(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }


	[REDMeta]
	public class toolsScreenplaySection : CVariable
	{
        private CUInt64 _id;
        private CUInt64 _index;
        private CArray<toolsScreenplayLine> _lines;

        [Ordinal(0)]
        [RED("id")]
        public CUInt64 Id
        {
            get => GetProperty(ref _id);
            set => SetProperty(ref _id, value);
        }

        [Ordinal(1)]
        [RED("index")]
        public CUInt64 Index
        {
            get => GetProperty(ref _index);
            set => SetProperty(ref _index, value);
        }

        [Ordinal(2)]
        [RED("lines")]
        public CArray<toolsScreenplayLine> Lines
        {
            get => GetProperty(ref _lines);
            set => SetProperty(ref _lines, value);
        }

        public toolsScreenplaySection(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }


	[REDMeta]
	public class toolsUniqueNodeData : CVariable
	{
        private CArray<scnblocVariant> _variant;
        private CName _className;

        [Ordinal(0)]
        [RED("variant")]
        public CArray<scnblocVariant> Variant
        {
            get => GetProperty(ref _variant);
            set => SetProperty(ref _variant, value);
        }

        [Ordinal(1)]
        [RED("className")]
        public CName ClassName
        {
            get => GetProperty(ref _className);
            set => SetProperty(ref _className, value);
        }


        public toolsUniqueNodeData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsSocketVisibilityData : CVariable
	{
        private CUInt32 _socketId;
        private CName _name;
        private CEnum<toolsSocketPlacement> _placement;
        private CBool _hidden;

        [Ordinal(0)]
        [RED("socketId")]
        public CUInt32 SocketId
        {
            get => GetProperty(ref _socketId);
            set => SetProperty(ref _socketId, value);
        }

        [Ordinal(1)]
        [RED("name")]
        public CName Name
        {
            get => GetProperty(ref _name);
            set => SetProperty(ref _name, value);
        }

        [Ordinal(2)]
        [RED("placement")]
        public CEnum<toolsSocketPlacement> Placement
        {
            get => GetProperty(ref _placement);
            set => SetProperty(ref _placement, value);
        }

        [Ordinal(3)]
        [RED("hidden")]
        public CBool Hidden
        {
            get => GetProperty(ref _hidden);
            set => SetProperty(ref _hidden, value);
        }

        public toolsSocketVisibilityData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsSectionClipboardDataHolder : CVariable
	{
        private CHandle<toolsIGraphNodeDescriptor> _backendNodeDescriptor;
        private CArray<toolsSocketVisibilityData> _socketData;
        private CHandle<toolsUniqueNodeData> _uniqueNodeData;
        private CArray<scnblocVariant> _variants;
        private toolsScreenplaySection _section;
        private CArray<scnbSceneActorData> _actorData;

        [Ordinal(0)]
        [RED("backendNodeDescriptor")]
        public CHandle<toolsIGraphNodeDescriptor> BackendNodeDescriptor
        {
            get => GetProperty(ref _backendNodeDescriptor);
            set => SetProperty(ref _backendNodeDescriptor, value);
        }

        [Ordinal(1)]
        [RED("socketData")]
        public CArray<toolsSocketVisibilityData> SocketData
        {
            get => GetProperty(ref _socketData);
            set => SetProperty(ref _socketData, value);
        }

        [Ordinal(2)]
        [RED("uniqueNodeData")]
        public CHandle<toolsUniqueNodeData> UniqueNodeData
        {
            get => GetProperty(ref _uniqueNodeData);
            set => SetProperty(ref _uniqueNodeData, value);
        }

        [Ordinal(3)]
        [RED("variants")]
        public CArray<scnblocVariant> Variants
        {
            get => GetProperty(ref _variants);
            set => SetProperty(ref _variants, value);
        }

        [Ordinal(4)]
        [RED("section")]
        public toolsScreenplaySection Section
        {
            get => GetProperty(ref _section);
            set => SetProperty(ref _section, value);
        }

        [Ordinal(5)]
        [RED("actorData")]
        public CArray<scnbSceneActorData> ActorData
        {
            get => GetProperty(ref _actorData);
            set => SetProperty(ref _actorData, value);
        }


        public toolsSectionClipboardDataHolder(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsScreenplayLine : CVariable
	{
        private CUInt64 _sectionId;
        private CRUID _speaker;
        private CRUID _addressee;
        private CRUID _id;
        private scnblocLocstringId _locstringId;
        private scnbScreenplayLineUsage _usage;

        [Ordinal(0)]
        [RED("sectionId")]
        public CUInt64 SectionId
        {
            get => GetProperty(ref _sectionId);
            set => SetProperty(ref _sectionId, value);
        }

        [Ordinal(1)]
        [RED("speaker")]
        public CRUID Speaker
        {
            get => GetProperty(ref _speaker);
            set => SetProperty(ref _speaker, value);
        }

        [Ordinal(2)]
        [RED("addressee")]
        public CRUID Addressee
        {
            get => GetProperty(ref _addressee);
            set => SetProperty(ref _addressee, value);
        }

        [Ordinal(3)]
        [RED("id")]
        public CRUID Id
        {
            get => GetProperty(ref _id);
            set => SetProperty(ref _id, value);
        }

        [Ordinal(4)]
        [RED("locstringId")]
        public scnblocLocstringId LocstringId
        {
            get => GetProperty(ref _locstringId);
            set => SetProperty(ref _locstringId, value);
        }

        [Ordinal(5)]
        [RED("usage")]
        public scnbScreenplayLineUsage Usage
        {
            get => GetProperty(ref _usage);
            set => SetProperty(ref _usage, value);
        }

        public toolsScreenplayLine(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsRagdollExportData : CVariable
	{
        private CArray<physicsRagdollBodyInfo> _ragdollDesc;
        private CArray<physicsRagdollBodyNames> _ragdollNames;

        [Ordinal(0)]
        [RED("ragdollDesc")]
        public CArray<physicsRagdollBodyInfo> RagdollDesc
        {
            get => GetProperty(ref _ragdollDesc);
            set => SetProperty(ref _ragdollDesc, value);
        }

        [Ordinal(1)]
        [RED("ragdollNames")]
        public CArray<physicsRagdollBodyNames> RagdollNames
        {
            get => GetProperty(ref _ragdollNames);
            set => SetProperty(ref _ragdollNames, value);
        }

        public toolsRagdollExportData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsVisualTagsRoot : CVariable
	{
        private CArray<toolsVisualTagsSchema> _schemas;

        [Ordinal(0)]
        [RED("schemas")]
        public CArray<toolsVisualTagsSchema> Schemas
        {
            get => GetProperty(ref _schemas);
            set => SetProperty(ref _schemas, value);
        }

        public toolsVisualTagsRoot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsPartsCategories : CVariable
	{
        private CArray<toolsPartsCategory> _categories;

        [Ordinal(0)]
        [RED("categories")]
        public CArray<toolsPartsCategory> Categories
        {
            get => GetProperty(ref _categories);
            set => SetProperty(ref _categories, value);
        }

        public toolsPartsCategories(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsAppearanceNamingParser : CVariable
	{
        private CString _regex;
        private CArray<toolsAppearanceNamingCaptureGroup> _captureGroups;

        [Ordinal(0)]
        [RED("regex")]
        public CString Regex
        {
            get => GetProperty(ref _regex);
            set => SetProperty(ref _regex, value);
        }

        [Ordinal(1)]
        [RED("captureGroups")]
        public CArray<toolsAppearanceNamingCaptureGroup> CaptureGroups
        {
            get => GetProperty(ref _captureGroups);
            set => SetProperty(ref _captureGroups, value);
        }

        public toolsAppearanceNamingParser(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
	public class toolsAppearanceConfigMapping : CVariable
	{
        private CName _name;
        private CString _baseTypesFile;
        private CString _baseTypePrefix;
        private CString _categoriesFile;
        private CString _partsFile;
        private CString _partsCategoriesFile;
        private CString _scanDirectory;
        private CString _filenameParsingRules;

        [Ordinal(0)]
        [RED("name")]
        public CName Name
        {
            get => GetProperty(ref _name);
            set => SetProperty(ref _name, value);
        }

        [Ordinal(1)]
        [RED("baseTypesFile")]
        public CString BaseTypesFile
        {
            get => GetProperty(ref _baseTypesFile);
            set => SetProperty(ref _baseTypesFile, value);
        }

        [Ordinal(2)]
        [RED("baseTypePrefix")]
        public CString BaseTypePrefix
        {
            get => GetProperty(ref _baseTypePrefix);
            set => SetProperty(ref _baseTypePrefix, value);
        }

        [Ordinal(3)]
        [RED("categoriesFile")]
        public CString CategoriesFile
        {
            get => GetProperty(ref _categoriesFile);
            set => SetProperty(ref _categoriesFile, value);
        }

        [Ordinal(4)]
        [RED("partsFile")]
        public CString PartsFile
        {
            get => GetProperty(ref _partsFile);
            set => SetProperty(ref _partsFile, value);
        }

        [Ordinal(5)]
        [RED("partsCategoriesFile")]
        public CString PartsCategoriesFile
        {
            get => GetProperty(ref _partsCategoriesFile);
            set => SetProperty(ref _partsCategoriesFile, value);
        }

        [Ordinal(6)]
        [RED("scanDirectory")]
        public CString ScanDirectory
        {
            get => GetProperty(ref _scanDirectory);
            set => SetProperty(ref _scanDirectory, value);
        }

        [Ordinal(7)]
        [RED("filenameParsingRules")]
        public CString FilenameParsingRules
        {
            get => GetProperty(ref _filenameParsingRules);
            set => SetProperty(ref _filenameParsingRules, value);
        }


        public toolsAppearanceConfigMapping(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsVisualTagsSchema : CVariable
	{
        private CName _name;
        private CArray<toolsVisualTagsGroup> _categories;
        private CArray<toolsVisualTagsGroup> _presets;

        [Ordinal(0)]
        [RED("name")]
        public CName Name
        {
            get => GetProperty(ref _name);
            set => SetProperty(ref _name, value);
        }

        [Ordinal(1)]
        [RED("categories")]
        public CArray<toolsVisualTagsGroup> Categories
        {
            get => GetProperty(ref _categories);
            set => SetProperty(ref _categories, value);
        }

        [Ordinal(2)]
        [RED("presets")]
        public CArray<toolsVisualTagsGroup> Presets
        {
            get => GetProperty(ref _presets);
            set => SetProperty(ref _presets, value);
        }

        public toolsVisualTagsSchema(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsAppearancesConfig : CVariable
	{
        private CArray<toolsAppearanceConfigMapping> _mappings;

        [Ordinal(0)]
        [RED("mappings")]
        public CArray<toolsAppearanceConfigMapping> Mappings
        {
            get => GetProperty(ref _mappings);
            set => SetProperty(ref _mappings, value);
        }

        public toolsAppearancesConfig(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsVisualTagsDefinition : CVariable
	{
        private CName _name;

        [Ordinal(0)]
        [RED("name")]
        public CName Name
        {
            get => GetProperty(ref _name);
            set => SetProperty(ref _name, value);
        }

        public toolsVisualTagsDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsPresetSectionData : CVariable
	{
        private CArray<CString> _sectionNames;

        [Ordinal(0)]
        [RED("sectionNames")]
        public CArray<CString> SectionNames
        {
            get => GetProperty(ref _sectionNames);
            set => SetProperty(ref _sectionNames, value);
        }

        public toolsPresetSectionData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsSceneRecorderPresetData : CVariable
	{
        private CString _name;
        private CArray<CString> _scenePaths;
        private CArray<toolsPresetSectionData> _sectionData;

        [Ordinal(0)]
        [RED("name")]
        public CString Name
        {
            get => GetProperty(ref _name);
            set => SetProperty(ref _name, value);
        }

        [Ordinal(1)]
        [RED("scenePaths")]
        public CArray<CString> ScenePaths
        {
            get => GetProperty(ref _scenePaths);
            set => SetProperty(ref _scenePaths, value);
        }

        [Ordinal(2)]
        [RED("sectionData")]
        public CArray<toolsPresetSectionData> SectionData
        {
            get => GetProperty(ref _sectionData);
            set => SetProperty(ref _sectionData, value);
        }

        public toolsSceneRecorderPresetData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsVisualTagsGroup : CVariable
	{
        private CName _name;
        private CArray<toolsVisualTagsDefinition> _tags;

        [Ordinal(0)]
        [RED("name")]
        public CName Name
        {
            get => GetProperty(ref _name);
            set => SetProperty(ref _name, value);
        }

        [Ordinal(1)]
        [RED("tags")]
        public CArray<toolsVisualTagsDefinition> Tags
        {
            get => GetProperty(ref _tags);
            set => SetProperty(ref _tags, value);
        }

        public toolsVisualTagsGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsAppearanceNamingCaptureGroup : CVariable
	{
        private CString _editorTagPrefix;
        private CArray<CArray<CString>> _externalComponent;
        private CArray<CArray<CString>> _mapOfNames;
        private CString _case;
        private CString _allowedValueType;

        [Ordinal(0)]
        [RED("editorTagPrefix")]
        public CString EditorTagPrefix
        {
            get => GetProperty(ref _editorTagPrefix);
            set => SetProperty(ref _editorTagPrefix, value);
        }

        [Ordinal(1)]
        [RED("externalComponent")]
        public CArray<CArray<CString>> ExternalComponent
        {
            get => GetProperty(ref _externalComponent);
            set => SetProperty(ref _externalComponent, value);
        }

        [Ordinal(2)]
        [RED("mapOfNames")]
        public CArray<CArray<CString>> MapOfNames
        {
            get => GetProperty(ref _mapOfNames);
            set => SetProperty(ref _mapOfNames, value);
        }

        [Ordinal(3)]
        [RED("case")]
        public CString Case
        {
            get => GetProperty(ref _case);
            set => SetProperty(ref _case, value);
        }

        [Ordinal(4)]
        [RED("allowedValueType")]
        public CString AllowedValueType
        {
            get => GetProperty(ref _allowedValueType);
            set => SetProperty(ref _allowedValueType, value);
        }

        public toolsAppearanceNamingCaptureGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
	[REDMeta]
	public class toolsTimeLineItemDescription : CVariable
	{
        public toolsTimeLineItemDescription(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

	[REDMeta]
	public class toolsAnimTimelineEvent : toolsTimeLineTrackBaseItem
    {
        private CUInt64 _trackId;
        private CFloat _startTime;
        private CHandle<animAnimEvent> _runtimeEvent;

        [Ordinal(6)]
        [RED("trackId")]
        public CUInt64 TrackId
        {
            get => GetProperty(ref _trackId);
            set => SetProperty(ref _trackId, value);
        }

        [Ordinal(7)]
        [RED("startTime")]
        public CFloat StartTime
        {
            get => GetProperty(ref _startTime);
            set => SetProperty(ref _startTime, value);
        }

        [Ordinal(8)]
        [RED("runtimeEvent")]
        public CHandle<animAnimEvent> RuntimeEvent
        {
            get => GetProperty(ref _runtimeEvent);
            set => SetProperty(ref _runtimeEvent, value);
        }

        public toolsAnimTimelineEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class toolsSceneTrackID : CVariable
    {
        private CUInt64 _id;

        [Ordinal(0)]
        [RED("id")]
        public CUInt64 Id
        {
            get => GetProperty(ref _id);
            set => SetProperty(ref _id, value);
        }


        public toolsSceneTrackID(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class toolsEventDescriptor : CVariable
    {
        public toolsEventDescriptor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
	public class toolsTimeLineTrackBaseItem : CVariable
	{
        private CUInt64 _id;
        private CString _type;
        private CString _visualType;
        private CString _caption;
        private CUInt64 _parentId;
        private CArray<CUInt64> _children;

        [Ordinal(0)]
        [RED("id")]
        public CUInt64 Id
        {
            get => GetProperty(ref _id);
            set => SetProperty(ref _id, value);
        }

        [Ordinal(1)]
        [RED("type")]
        public CString Type
        {
            get => GetProperty(ref _type);
            set => SetProperty(ref _type, value);
        }

        [Ordinal(2)]
        [RED("visualType")]
        public CString VisualType
        {
            get => GetProperty(ref _visualType);
            set => SetProperty(ref _visualType, value);
        }

        [Ordinal(3)]
        [RED("caption")]
        public CString Caption
        {
            get => GetProperty(ref _caption);
            set => SetProperty(ref _caption, value);
        }

        [Ordinal(4)]
        [RED("parentId")]
        public CUInt64 ParentId
        {
            get => GetProperty(ref _parentId);
            set => SetProperty(ref _parentId, value);
        }

        [Ordinal(5)]
        [RED("children")]
        public CArray<CUInt64> Children
        {
            get => GetProperty(ref _children);
            set => SetProperty(ref _children, value);
        }

        public toolsTimeLineTrackBaseItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
