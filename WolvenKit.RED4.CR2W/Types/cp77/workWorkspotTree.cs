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
			get
			{
				if (_workspotRig == null)
				{
					_workspotRig = (raRef<animRig>) CR2WTypeManager.Create("raRef:animRig", "workspotRig", cr2w, this);
				}
				return _workspotRig;
			}
			set
			{
				if (_workspotRig == value)
				{
					return;
				}
				_workspotRig = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("availableRigSlots")] 
		public CArray<CName> AvailableRigSlots
		{
			get
			{
				if (_availableRigSlots == null)
				{
					_availableRigSlots = (CArray<CName>) CR2WTypeManager.Create("array:CName", "availableRigSlots", cr2w, this);
				}
				return _availableRigSlots;
			}
			set
			{
				if (_availableRigSlots == value)
				{
					return;
				}
				_availableRigSlots = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("availablePropIds")] 
		public CArray<CName> AvailablePropIds
		{
			get
			{
				if (_availablePropIds == null)
				{
					_availablePropIds = (CArray<CName>) CR2WTypeManager.Create("array:CName", "availablePropIds", cr2w, this);
				}
				return _availablePropIds;
			}
			set
			{
				if (_availablePropIds == value)
				{
					return;
				}
				_availablePropIds = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("globalProps")] 
		public CArray<workWorkspotGlobalProp> GlobalProps
		{
			get
			{
				if (_globalProps == null)
				{
					_globalProps = (CArray<workWorkspotGlobalProp>) CR2WTypeManager.Create("array:workWorkspotGlobalProp", "globalProps", cr2w, this);
				}
				return _globalProps;
			}
			set
			{
				if (_globalProps == value)
				{
					return;
				}
				_globalProps = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rootEntry")] 
		public CHandle<workIEntry> RootEntry
		{
			get
			{
				if (_rootEntry == null)
				{
					_rootEntry = (CHandle<workIEntry>) CR2WTypeManager.Create("handle:workIEntry", "rootEntry", cr2w, this);
				}
				return _rootEntry;
			}
			set
			{
				if (_rootEntry == value)
				{
					return;
				}
				_rootEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("idCounter")] 
		public CUInt32 IdCounter
		{
			get
			{
				if (_idCounter == null)
				{
					_idCounter = (CUInt32) CR2WTypeManager.Create("Uint32", "idCounter", cr2w, this);
				}
				return _idCounter;
			}
			set
			{
				if (_idCounter == value)
				{
					return;
				}
				_idCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("dontInjectWorkspotGraph")] 
		public CBool DontInjectWorkspotGraph
		{
			get
			{
				if (_dontInjectWorkspotGraph == null)
				{
					_dontInjectWorkspotGraph = (CBool) CR2WTypeManager.Create("Bool", "dontInjectWorkspotGraph", cr2w, this);
				}
				return _dontInjectWorkspotGraph;
			}
			set
			{
				if (_dontInjectWorkspotGraph == value)
				{
					return;
				}
				_dontInjectWorkspotGraph = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("animGraphSlotName")] 
		public CName AnimGraphSlotName
		{
			get
			{
				if (_animGraphSlotName == null)
				{
					_animGraphSlotName = (CName) CR2WTypeManager.Create("CName", "animGraphSlotName", cr2w, this);
				}
				return _animGraphSlotName;
			}
			set
			{
				if (_animGraphSlotName == value)
				{
					return;
				}
				_animGraphSlotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("autoTransitionBlendTime")] 
		public CFloat AutoTransitionBlendTime
		{
			get
			{
				if (_autoTransitionBlendTime == null)
				{
					_autoTransitionBlendTime = (CFloat) CR2WTypeManager.Create("Float", "autoTransitionBlendTime", cr2w, this);
				}
				return _autoTransitionBlendTime;
			}
			set
			{
				if (_autoTransitionBlendTime == value)
				{
					return;
				}
				_autoTransitionBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("initialActions")] 
		public CArray<CHandle<workIWorkspotItemAction>> InitialActions
		{
			get
			{
				if (_initialActions == null)
				{
					_initialActions = (CArray<CHandle<workIWorkspotItemAction>>) CR2WTypeManager.Create("array:handle:workIWorkspotItemAction", "initialActions", cr2w, this);
				}
				return _initialActions;
			}
			set
			{
				if (_initialActions == value)
				{
					return;
				}
				_initialActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get
			{
				if (_blendOutTime == null)
				{
					_blendOutTime = (CFloat) CR2WTypeManager.Create("Float", "blendOutTime", cr2w, this);
				}
				return _blendOutTime;
			}
			set
			{
				if (_blendOutTime == value)
				{
					return;
				}
				_blendOutTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("hasEntityPathsGenerated")] 
		public CBool HasEntityPathsGenerated
		{
			get
			{
				if (_hasEntityPathsGenerated == null)
				{
					_hasEntityPathsGenerated = (CBool) CR2WTypeManager.Create("Bool", "hasEntityPathsGenerated", cr2w, this);
				}
				return _hasEntityPathsGenerated;
			}
			set
			{
				if (_hasEntityPathsGenerated == value)
				{
					return;
				}
				_hasEntityPathsGenerated = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("entitiesPaths")] 
		public CArray<CName> EntitiesPaths
		{
			get
			{
				if (_entitiesPaths == null)
				{
					_entitiesPaths = (CArray<CName>) CR2WTypeManager.Create("array:CName", "entitiesPaths", cr2w, this);
				}
				return _entitiesPaths;
			}
			set
			{
				if (_entitiesPaths == value)
				{
					return;
				}
				_entitiesPaths = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("animsets")] 
		public CArray<workWorkspotAnimsetEntry> Animsets
		{
			get
			{
				if (_animsets == null)
				{
					_animsets = (CArray<workWorkspotAnimsetEntry>) CR2WTypeManager.Create("array:workWorkspotAnimsetEntry", "animsets", cr2w, this);
				}
				return _animsets;
			}
			set
			{
				if (_animsets == value)
				{
					return;
				}
				_animsets = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("finalAnimsets")] 
		public CArray<workWorkspotAnimsetEntry> FinalAnimsets
		{
			get
			{
				if (_finalAnimsets == null)
				{
					_finalAnimsets = (CArray<workWorkspotAnimsetEntry>) CR2WTypeManager.Create("array:workWorkspotAnimsetEntry", "finalAnimsets", cr2w, this);
				}
				return _finalAnimsets;
			}
			set
			{
				if (_finalAnimsets == value)
				{
					return;
				}
				_finalAnimsets = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (redTagList) CR2WTypeManager.Create("redTagList", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("itemsPolicy")] 
		public CEnum<workWorkspotItemPolicy> ItemsPolicy
		{
			get
			{
				if (_itemsPolicy == null)
				{
					_itemsPolicy = (CEnum<workWorkspotItemPolicy>) CR2WTypeManager.Create("workWorkspotItemPolicy", "itemsPolicy", cr2w, this);
				}
				return _itemsPolicy;
			}
			set
			{
				if (_itemsPolicy == value)
				{
					return;
				}
				_itemsPolicy = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("censorshipFlags")] 
		public CEnum<CensorshipFlags> CensorshipFlags
		{
			get
			{
				if (_censorshipFlags == null)
				{
					_censorshipFlags = (CEnum<CensorshipFlags>) CR2WTypeManager.Create("CensorshipFlags", "censorshipFlags", cr2w, this);
				}
				return _censorshipFlags;
			}
			set
			{
				if (_censorshipFlags == value)
				{
					return;
				}
				_censorshipFlags = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("customTransitionAnims")] 
		public CArray<workTransitionAnim> CustomTransitionAnims
		{
			get
			{
				if (_customTransitionAnims == null)
				{
					_customTransitionAnims = (CArray<workTransitionAnim>) CR2WTypeManager.Create("array:workTransitionAnim", "customTransitionAnims", cr2w, this);
				}
				return _customTransitionAnims;
			}
			set
			{
				if (_customTransitionAnims == value)
				{
					return;
				}
				_customTransitionAnims = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("inertializationDurationEnter")] 
		public CFloat InertializationDurationEnter
		{
			get
			{
				if (_inertializationDurationEnter == null)
				{
					_inertializationDurationEnter = (CFloat) CR2WTypeManager.Create("Float", "inertializationDurationEnter", cr2w, this);
				}
				return _inertializationDurationEnter;
			}
			set
			{
				if (_inertializationDurationEnter == value)
				{
					return;
				}
				_inertializationDurationEnter = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("inertializationDurationExitNatural")] 
		public CFloat InertializationDurationExitNatural
		{
			get
			{
				if (_inertializationDurationExitNatural == null)
				{
					_inertializationDurationExitNatural = (CFloat) CR2WTypeManager.Create("Float", "inertializationDurationExitNatural", cr2w, this);
				}
				return _inertializationDurationExitNatural;
			}
			set
			{
				if (_inertializationDurationExitNatural == value)
				{
					return;
				}
				_inertializationDurationExitNatural = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("inertializationDurationExitForced")] 
		public CFloat InertializationDurationExitForced
		{
			get
			{
				if (_inertializationDurationExitForced == null)
				{
					_inertializationDurationExitForced = (CFloat) CR2WTypeManager.Create("Float", "inertializationDurationExitForced", cr2w, this);
				}
				return _inertializationDurationExitForced;
			}
			set
			{
				if (_inertializationDurationExitForced == value)
				{
					return;
				}
				_inertializationDurationExitForced = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("useTimeLimitForSequences")] 
		public CBool UseTimeLimitForSequences
		{
			get
			{
				if (_useTimeLimitForSequences == null)
				{
					_useTimeLimitForSequences = (CBool) CR2WTypeManager.Create("Bool", "useTimeLimitForSequences", cr2w, this);
				}
				return _useTimeLimitForSequences;
			}
			set
			{
				if (_useTimeLimitForSequences == value)
				{
					return;
				}
				_useTimeLimitForSequences = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("disableAutoAnimsetGeneraion")] 
		public CBool DisableAutoAnimsetGeneraion
		{
			get
			{
				if (_disableAutoAnimsetGeneraion == null)
				{
					_disableAutoAnimsetGeneraion = (CBool) CR2WTypeManager.Create("Bool", "disableAutoAnimsetGeneraion", cr2w, this);
				}
				return _disableAutoAnimsetGeneraion;
			}
			set
			{
				if (_disableAutoAnimsetGeneraion == value)
				{
					return;
				}
				_disableAutoAnimsetGeneraion = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("frezeAtTheLastFrame_UseWithCaution")] 
		public CBool FrezeAtTheLastFrame_UseWithCaution
		{
			get
			{
				if (_frezeAtTheLastFrame_UseWithCaution == null)
				{
					_frezeAtTheLastFrame_UseWithCaution = (CBool) CR2WTypeManager.Create("Bool", "frezeAtTheLastFrame_UseWithCaution", cr2w, this);
				}
				return _frezeAtTheLastFrame_UseWithCaution;
			}
			set
			{
				if (_frezeAtTheLastFrame_UseWithCaution == value)
				{
					return;
				}
				_frezeAtTheLastFrame_UseWithCaution = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("sequencesTimeLimit")] 
		public CFloat SequencesTimeLimit
		{
			get
			{
				if (_sequencesTimeLimit == null)
				{
					_sequencesTimeLimit = (CFloat) CR2WTypeManager.Create("Float", "sequencesTimeLimit", cr2w, this);
				}
				return _sequencesTimeLimit;
			}
			set
			{
				if (_sequencesTimeLimit == value)
				{
					return;
				}
				_sequencesTimeLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("snapToTerrain")] 
		public CBool SnapToTerrain
		{
			get
			{
				if (_snapToTerrain == null)
				{
					_snapToTerrain = (CBool) CR2WTypeManager.Create("Bool", "snapToTerrain", cr2w, this);
				}
				return _snapToTerrain;
			}
			set
			{
				if (_snapToTerrain == value)
				{
					return;
				}
				_snapToTerrain = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("unmountBodyCarry")] 
		public CBool UnmountBodyCarry
		{
			get
			{
				if (_unmountBodyCarry == null)
				{
					_unmountBodyCarry = (CBool) CR2WTypeManager.Create("Bool", "unmountBodyCarry", cr2w, this);
				}
				return _unmountBodyCarry;
			}
			set
			{
				if (_unmountBodyCarry == value)
				{
					return;
				}
				_unmountBodyCarry = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get
			{
				if (_statusEffectID == null)
				{
					_statusEffectID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statusEffectID", cr2w, this);
				}
				return _statusEffectID;
			}
			set
			{
				if (_statusEffectID == value)
				{
					return;
				}
				_statusEffectID = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("whitelistVisualTags")] 
		public redTagList WhitelistVisualTags
		{
			get
			{
				if (_whitelistVisualTags == null)
				{
					_whitelistVisualTags = (redTagList) CR2WTypeManager.Create("redTagList", "whitelistVisualTags", cr2w, this);
				}
				return _whitelistVisualTags;
			}
			set
			{
				if (_whitelistVisualTags == value)
				{
					return;
				}
				_whitelistVisualTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("blacklistVisualTags")] 
		public redTagList BlacklistVisualTags
		{
			get
			{
				if (_blacklistVisualTags == null)
				{
					_blacklistVisualTags = (redTagList) CR2WTypeManager.Create("redTagList", "blacklistVisualTags", cr2w, this);
				}
				return _blacklistVisualTags;
			}
			set
			{
				if (_blacklistVisualTags == value)
				{
					return;
				}
				_blacklistVisualTags = value;
				PropertySet(this);
			}
		}

		public workWorkspotTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
