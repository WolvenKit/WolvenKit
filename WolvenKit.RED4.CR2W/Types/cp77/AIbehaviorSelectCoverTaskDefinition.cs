using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectCoverTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _cover;
		private CHandle<AIArgumentMapping> _coverID;
		private CHandle<AIArgumentMapping> _multiCoverID;
		private CHandle<AIArgumentMapping> _combatTarget;
		private CHandle<AIArgumentMapping> _friendlyTarget;
		private CHandle<AIArgumentMapping> _combatZone;
		private CName _sectorSelection;
		private CHandle<AIArgumentMapping> _ignoreRestrictMovementArea;
		private CHandle<AIArgumentMapping> _selectionPreset;
		private CHandle<AIArgumentMapping> _onActivationSelectionPreset;
		private CHandle<AIArgumentMapping> _secondStagePreset;
		private CHandle<AIArgumentMapping> _coverChangeThreshold;
		private CHandle<AIArgumentMapping> _coverGatheringCenterObject;
		private CHandle<AIArgumentMapping> _coverDisablingDuration;

		[Ordinal(1)] 
		[RED("cover")] 
		public CHandle<AIArgumentMapping> Cover
		{
			get
			{
				if (_cover == null)
				{
					_cover = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "cover", cr2w, this);
				}
				return _cover;
			}
			set
			{
				if (_cover == value)
				{
					return;
				}
				_cover = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("coverID")] 
		public CHandle<AIArgumentMapping> CoverID
		{
			get
			{
				if (_coverID == null)
				{
					_coverID = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "coverID", cr2w, this);
				}
				return _coverID;
			}
			set
			{
				if (_coverID == value)
				{
					return;
				}
				_coverID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("multiCoverID")] 
		public CHandle<AIArgumentMapping> MultiCoverID
		{
			get
			{
				if (_multiCoverID == null)
				{
					_multiCoverID = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "multiCoverID", cr2w, this);
				}
				return _multiCoverID;
			}
			set
			{
				if (_multiCoverID == value)
				{
					return;
				}
				_multiCoverID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("combatTarget")] 
		public CHandle<AIArgumentMapping> CombatTarget
		{
			get
			{
				if (_combatTarget == null)
				{
					_combatTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "combatTarget", cr2w, this);
				}
				return _combatTarget;
			}
			set
			{
				if (_combatTarget == value)
				{
					return;
				}
				_combatTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("friendlyTarget")] 
		public CHandle<AIArgumentMapping> FriendlyTarget
		{
			get
			{
				if (_friendlyTarget == null)
				{
					_friendlyTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "friendlyTarget", cr2w, this);
				}
				return _friendlyTarget;
			}
			set
			{
				if (_friendlyTarget == value)
				{
					return;
				}
				_friendlyTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("combatZone")] 
		public CHandle<AIArgumentMapping> CombatZone
		{
			get
			{
				if (_combatZone == null)
				{
					_combatZone = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "combatZone", cr2w, this);
				}
				return _combatZone;
			}
			set
			{
				if (_combatZone == value)
				{
					return;
				}
				_combatZone = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("sectorSelection")] 
		public CName SectorSelection
		{
			get
			{
				if (_sectorSelection == null)
				{
					_sectorSelection = (CName) CR2WTypeManager.Create("CName", "sectorSelection", cr2w, this);
				}
				return _sectorSelection;
			}
			set
			{
				if (_sectorSelection == value)
				{
					return;
				}
				_sectorSelection = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ignoreRestrictMovementArea")] 
		public CHandle<AIArgumentMapping> IgnoreRestrictMovementArea
		{
			get
			{
				if (_ignoreRestrictMovementArea == null)
				{
					_ignoreRestrictMovementArea = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "ignoreRestrictMovementArea", cr2w, this);
				}
				return _ignoreRestrictMovementArea;
			}
			set
			{
				if (_ignoreRestrictMovementArea == value)
				{
					return;
				}
				_ignoreRestrictMovementArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("selectionPreset")] 
		public CHandle<AIArgumentMapping> SelectionPreset
		{
			get
			{
				if (_selectionPreset == null)
				{
					_selectionPreset = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "selectionPreset", cr2w, this);
				}
				return _selectionPreset;
			}
			set
			{
				if (_selectionPreset == value)
				{
					return;
				}
				_selectionPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("onActivationSelectionPreset")] 
		public CHandle<AIArgumentMapping> OnActivationSelectionPreset
		{
			get
			{
				if (_onActivationSelectionPreset == null)
				{
					_onActivationSelectionPreset = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "onActivationSelectionPreset", cr2w, this);
				}
				return _onActivationSelectionPreset;
			}
			set
			{
				if (_onActivationSelectionPreset == value)
				{
					return;
				}
				_onActivationSelectionPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("secondStagePreset")] 
		public CHandle<AIArgumentMapping> SecondStagePreset
		{
			get
			{
				if (_secondStagePreset == null)
				{
					_secondStagePreset = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "secondStagePreset", cr2w, this);
				}
				return _secondStagePreset;
			}
			set
			{
				if (_secondStagePreset == value)
				{
					return;
				}
				_secondStagePreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("coverChangeThreshold")] 
		public CHandle<AIArgumentMapping> CoverChangeThreshold
		{
			get
			{
				if (_coverChangeThreshold == null)
				{
					_coverChangeThreshold = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "coverChangeThreshold", cr2w, this);
				}
				return _coverChangeThreshold;
			}
			set
			{
				if (_coverChangeThreshold == value)
				{
					return;
				}
				_coverChangeThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("coverGatheringCenterObject")] 
		public CHandle<AIArgumentMapping> CoverGatheringCenterObject
		{
			get
			{
				if (_coverGatheringCenterObject == null)
				{
					_coverGatheringCenterObject = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "coverGatheringCenterObject", cr2w, this);
				}
				return _coverGatheringCenterObject;
			}
			set
			{
				if (_coverGatheringCenterObject == value)
				{
					return;
				}
				_coverGatheringCenterObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("coverDisablingDuration")] 
		public CHandle<AIArgumentMapping> CoverDisablingDuration
		{
			get
			{
				if (_coverDisablingDuration == null)
				{
					_coverDisablingDuration = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "coverDisablingDuration", cr2w, this);
				}
				return _coverDisablingDuration;
			}
			set
			{
				if (_coverDisablingDuration == value)
				{
					return;
				}
				_coverDisablingDuration = value;
				PropertySet(this);
			}
		}

		public AIbehaviorSelectCoverTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
