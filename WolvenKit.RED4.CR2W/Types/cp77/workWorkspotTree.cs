using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotTree : ISerializable
	{
		private raRef<animRig> _workspotRig;
		private CArray<CName> _availableRigSlots;
		private CArray<CName> _availablePropIds;
		private CArray<workWorkspotGlobalProp> _globalProps;
		private CHandle<workIEntry> _rootEntry;
		private CUInt32 _idCounter;
		private CBool _dontInjectWorkspotGraph;
		private CName _animGraphSlotName;
		private CFloat _autoTransitionBlendTime;
		private CArray<CHandle<workIWorkspotItemAction>> _initialActions;
		private CFloat _blendOutTime;
		private CBool _hasEntityPathsGenerated;
		private CArray<CName> _entitiesPaths;
		private CArray<workWorkspotAnimsetEntry> _animsets;
		private CArray<workWorkspotAnimsetEntry> _finalAnimsets;
		private redTagList _tags;
		private CEnum<workWorkspotItemPolicy> _itemsPolicy;
		private CEnum<CensorshipFlags> _censorshipFlags;
		private CArray<workTransitionAnim> _customTransitionAnims;
		private CFloat _inertializationDurationEnter;
		private CFloat _inertializationDurationExitNatural;
		private CFloat _inertializationDurationExitForced;
		private CBool _useTimeLimitForSequences;
		private CBool _disableAutoAnimsetGeneraion;
		private CBool _frezeAtTheLastFrame_UseWithCaution;
		private CFloat _sequencesTimeLimit;
		private CBool _snapToTerrain;
		private CBool _unmountBodyCarry;
		private TweakDBID _statusEffectID;
		private redTagList _whitelistVisualTags;
		private redTagList _blacklistVisualTags;

		[Ordinal(0)] 
		[RED("workspotRig")] 
		public raRef<animRig> WorkspotRig
		{
			get => GetProperty(ref _workspotRig);
			set => SetProperty(ref _workspotRig, value);
		}

		[Ordinal(1)] 
		[RED("availableRigSlots")] 
		public CArray<CName> AvailableRigSlots
		{
			get => GetProperty(ref _availableRigSlots);
			set => SetProperty(ref _availableRigSlots, value);
		}

		[Ordinal(2)] 
		[RED("availablePropIds")] 
		public CArray<CName> AvailablePropIds
		{
			get => GetProperty(ref _availablePropIds);
			set => SetProperty(ref _availablePropIds, value);
		}

		[Ordinal(3)] 
		[RED("globalProps")] 
		public CArray<workWorkspotGlobalProp> GlobalProps
		{
			get => GetProperty(ref _globalProps);
			set => SetProperty(ref _globalProps, value);
		}

		[Ordinal(4)] 
		[RED("rootEntry")] 
		public CHandle<workIEntry> RootEntry
		{
			get => GetProperty(ref _rootEntry);
			set => SetProperty(ref _rootEntry, value);
		}

		[Ordinal(5)] 
		[RED("idCounter")] 
		public CUInt32 IdCounter
		{
			get => GetProperty(ref _idCounter);
			set => SetProperty(ref _idCounter, value);
		}

		[Ordinal(6)] 
		[RED("dontInjectWorkspotGraph")] 
		public CBool DontInjectWorkspotGraph
		{
			get => GetProperty(ref _dontInjectWorkspotGraph);
			set => SetProperty(ref _dontInjectWorkspotGraph, value);
		}

		[Ordinal(7)] 
		[RED("animGraphSlotName")] 
		public CName AnimGraphSlotName
		{
			get => GetProperty(ref _animGraphSlotName);
			set => SetProperty(ref _animGraphSlotName, value);
		}

		[Ordinal(8)] 
		[RED("autoTransitionBlendTime")] 
		public CFloat AutoTransitionBlendTime
		{
			get => GetProperty(ref _autoTransitionBlendTime);
			set => SetProperty(ref _autoTransitionBlendTime, value);
		}

		[Ordinal(9)] 
		[RED("initialActions")] 
		public CArray<CHandle<workIWorkspotItemAction>> InitialActions
		{
			get => GetProperty(ref _initialActions);
			set => SetProperty(ref _initialActions, value);
		}

		[Ordinal(10)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get => GetProperty(ref _blendOutTime);
			set => SetProperty(ref _blendOutTime, value);
		}

		[Ordinal(11)] 
		[RED("hasEntityPathsGenerated")] 
		public CBool HasEntityPathsGenerated
		{
			get => GetProperty(ref _hasEntityPathsGenerated);
			set => SetProperty(ref _hasEntityPathsGenerated, value);
		}

		[Ordinal(12)] 
		[RED("entitiesPaths")] 
		public CArray<CName> EntitiesPaths
		{
			get => GetProperty(ref _entitiesPaths);
			set => SetProperty(ref _entitiesPaths, value);
		}

		[Ordinal(13)] 
		[RED("animsets")] 
		public CArray<workWorkspotAnimsetEntry> Animsets
		{
			get => GetProperty(ref _animsets);
			set => SetProperty(ref _animsets, value);
		}

		[Ordinal(14)] 
		[RED("finalAnimsets")] 
		public CArray<workWorkspotAnimsetEntry> FinalAnimsets
		{
			get => GetProperty(ref _finalAnimsets);
			set => SetProperty(ref _finalAnimsets, value);
		}

		[Ordinal(15)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(16)] 
		[RED("itemsPolicy")] 
		public CEnum<workWorkspotItemPolicy> ItemsPolicy
		{
			get => GetProperty(ref _itemsPolicy);
			set => SetProperty(ref _itemsPolicy, value);
		}

		[Ordinal(17)] 
		[RED("censorshipFlags")] 
		public CEnum<CensorshipFlags> CensorshipFlags
		{
			get => GetProperty(ref _censorshipFlags);
			set => SetProperty(ref _censorshipFlags, value);
		}

		[Ordinal(18)] 
		[RED("customTransitionAnims")] 
		public CArray<workTransitionAnim> CustomTransitionAnims
		{
			get => GetProperty(ref _customTransitionAnims);
			set => SetProperty(ref _customTransitionAnims, value);
		}

		[Ordinal(19)] 
		[RED("inertializationDurationEnter")] 
		public CFloat InertializationDurationEnter
		{
			get => GetProperty(ref _inertializationDurationEnter);
			set => SetProperty(ref _inertializationDurationEnter, value);
		}

		[Ordinal(20)] 
		[RED("inertializationDurationExitNatural")] 
		public CFloat InertializationDurationExitNatural
		{
			get => GetProperty(ref _inertializationDurationExitNatural);
			set => SetProperty(ref _inertializationDurationExitNatural, value);
		}

		[Ordinal(21)] 
		[RED("inertializationDurationExitForced")] 
		public CFloat InertializationDurationExitForced
		{
			get => GetProperty(ref _inertializationDurationExitForced);
			set => SetProperty(ref _inertializationDurationExitForced, value);
		}

		[Ordinal(22)] 
		[RED("useTimeLimitForSequences")] 
		public CBool UseTimeLimitForSequences
		{
			get => GetProperty(ref _useTimeLimitForSequences);
			set => SetProperty(ref _useTimeLimitForSequences, value);
		}

		[Ordinal(23)] 
		[RED("disableAutoAnimsetGeneraion")] 
		public CBool DisableAutoAnimsetGeneraion
		{
			get => GetProperty(ref _disableAutoAnimsetGeneraion);
			set => SetProperty(ref _disableAutoAnimsetGeneraion, value);
		}

		[Ordinal(24)] 
		[RED("frezeAtTheLastFrame_UseWithCaution")] 
		public CBool FrezeAtTheLastFrame_UseWithCaution
		{
			get => GetProperty(ref _frezeAtTheLastFrame_UseWithCaution);
			set => SetProperty(ref _frezeAtTheLastFrame_UseWithCaution, value);
		}

		[Ordinal(25)] 
		[RED("sequencesTimeLimit")] 
		public CFloat SequencesTimeLimit
		{
			get => GetProperty(ref _sequencesTimeLimit);
			set => SetProperty(ref _sequencesTimeLimit, value);
		}

		[Ordinal(26)] 
		[RED("snapToTerrain")] 
		public CBool SnapToTerrain
		{
			get => GetProperty(ref _snapToTerrain);
			set => SetProperty(ref _snapToTerrain, value);
		}

		[Ordinal(27)] 
		[RED("unmountBodyCarry")] 
		public CBool UnmountBodyCarry
		{
			get => GetProperty(ref _unmountBodyCarry);
			set => SetProperty(ref _unmountBodyCarry, value);
		}

		[Ordinal(28)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetProperty(ref _statusEffectID);
			set => SetProperty(ref _statusEffectID, value);
		}

		[Ordinal(29)] 
		[RED("whitelistVisualTags")] 
		public redTagList WhitelistVisualTags
		{
			get => GetProperty(ref _whitelistVisualTags);
			set => SetProperty(ref _whitelistVisualTags, value);
		}

		[Ordinal(30)] 
		[RED("blacklistVisualTags")] 
		public redTagList BlacklistVisualTags
		{
			get => GetProperty(ref _blacklistVisualTags);
			set => SetProperty(ref _blacklistVisualTags, value);
		}

		public workWorkspotTree(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
