using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleComponentPS : ScriptableDeviceComponentPS
	{
		private CBool _defaultStateSet;
		private CBool _stateModifiedByQuest;
		private CBool _playerVehicle;
		private CArray<CName> _npcOccupiedSlots;
		private CBool _isDestroyed;
		private CBool _isStolen;
		private CBool _crystalDomeQuestModified;
		private CBool _crystalDomeQuestState;
		private CBool _crystalDomeState;
		private CBool _visualDestructionSet;
		private CBool _visualDestructionNeeded;
		private CBool _exploded;
		private CBool _sirenOn;
		private CBool _sirenSoundOn;
		private CBool _sirenLightsOn;
		private CBool _anyDoorOpen;
		private CArray<TemporaryDoorState> _previousInteractionState;
		private CBool _thrusterState;
		private CBool _uiQuestModified;
		private CBool _uiState;
		private CHandle<EngDemoContainer> _vehicleSkillChecks;
		private CBool _ready;
		private CBool _isPlayerPerformingBodyDisposal;
		private CHandle<vehicleControllerPS> _vehicleControllerPS;

		[Ordinal(103)] 
		[RED("defaultStateSet")] 
		public CBool DefaultStateSet
		{
			get
			{
				if (_defaultStateSet == null)
				{
					_defaultStateSet = (CBool) CR2WTypeManager.Create("Bool", "defaultStateSet", cr2w, this);
				}
				return _defaultStateSet;
			}
			set
			{
				if (_defaultStateSet == value)
				{
					return;
				}
				_defaultStateSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("stateModifiedByQuest")] 
		public CBool StateModifiedByQuest
		{
			get
			{
				if (_stateModifiedByQuest == null)
				{
					_stateModifiedByQuest = (CBool) CR2WTypeManager.Create("Bool", "stateModifiedByQuest", cr2w, this);
				}
				return _stateModifiedByQuest;
			}
			set
			{
				if (_stateModifiedByQuest == value)
				{
					return;
				}
				_stateModifiedByQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("playerVehicle")] 
		public CBool PlayerVehicle
		{
			get
			{
				if (_playerVehicle == null)
				{
					_playerVehicle = (CBool) CR2WTypeManager.Create("Bool", "playerVehicle", cr2w, this);
				}
				return _playerVehicle;
			}
			set
			{
				if (_playerVehicle == value)
				{
					return;
				}
				_playerVehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("npcOccupiedSlots")] 
		public CArray<CName> NpcOccupiedSlots
		{
			get
			{
				if (_npcOccupiedSlots == null)
				{
					_npcOccupiedSlots = (CArray<CName>) CR2WTypeManager.Create("array:CName", "npcOccupiedSlots", cr2w, this);
				}
				return _npcOccupiedSlots;
			}
			set
			{
				if (_npcOccupiedSlots == value)
				{
					return;
				}
				_npcOccupiedSlots = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("isDestroyed")] 
		public CBool IsDestroyed
		{
			get
			{
				if (_isDestroyed == null)
				{
					_isDestroyed = (CBool) CR2WTypeManager.Create("Bool", "isDestroyed", cr2w, this);
				}
				return _isDestroyed;
			}
			set
			{
				if (_isDestroyed == value)
				{
					return;
				}
				_isDestroyed = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("isStolen")] 
		public CBool IsStolen
		{
			get
			{
				if (_isStolen == null)
				{
					_isStolen = (CBool) CR2WTypeManager.Create("Bool", "isStolen", cr2w, this);
				}
				return _isStolen;
			}
			set
			{
				if (_isStolen == value)
				{
					return;
				}
				_isStolen = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("crystalDomeQuestModified")] 
		public CBool CrystalDomeQuestModified
		{
			get
			{
				if (_crystalDomeQuestModified == null)
				{
					_crystalDomeQuestModified = (CBool) CR2WTypeManager.Create("Bool", "crystalDomeQuestModified", cr2w, this);
				}
				return _crystalDomeQuestModified;
			}
			set
			{
				if (_crystalDomeQuestModified == value)
				{
					return;
				}
				_crystalDomeQuestModified = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("crystalDomeQuestState")] 
		public CBool CrystalDomeQuestState
		{
			get
			{
				if (_crystalDomeQuestState == null)
				{
					_crystalDomeQuestState = (CBool) CR2WTypeManager.Create("Bool", "crystalDomeQuestState", cr2w, this);
				}
				return _crystalDomeQuestState;
			}
			set
			{
				if (_crystalDomeQuestState == value)
				{
					return;
				}
				_crystalDomeQuestState = value;
				PropertySet(this);
			}
		}

		[Ordinal(111)] 
		[RED("crystalDomeState")] 
		public CBool CrystalDomeState
		{
			get
			{
				if (_crystalDomeState == null)
				{
					_crystalDomeState = (CBool) CR2WTypeManager.Create("Bool", "crystalDomeState", cr2w, this);
				}
				return _crystalDomeState;
			}
			set
			{
				if (_crystalDomeState == value)
				{
					return;
				}
				_crystalDomeState = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("visualDestructionSet")] 
		public CBool VisualDestructionSet
		{
			get
			{
				if (_visualDestructionSet == null)
				{
					_visualDestructionSet = (CBool) CR2WTypeManager.Create("Bool", "visualDestructionSet", cr2w, this);
				}
				return _visualDestructionSet;
			}
			set
			{
				if (_visualDestructionSet == value)
				{
					return;
				}
				_visualDestructionSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(113)] 
		[RED("visualDestructionNeeded")] 
		public CBool VisualDestructionNeeded
		{
			get
			{
				if (_visualDestructionNeeded == null)
				{
					_visualDestructionNeeded = (CBool) CR2WTypeManager.Create("Bool", "visualDestructionNeeded", cr2w, this);
				}
				return _visualDestructionNeeded;
			}
			set
			{
				if (_visualDestructionNeeded == value)
				{
					return;
				}
				_visualDestructionNeeded = value;
				PropertySet(this);
			}
		}

		[Ordinal(114)] 
		[RED("exploded")] 
		public CBool Exploded
		{
			get
			{
				if (_exploded == null)
				{
					_exploded = (CBool) CR2WTypeManager.Create("Bool", "exploded", cr2w, this);
				}
				return _exploded;
			}
			set
			{
				if (_exploded == value)
				{
					return;
				}
				_exploded = value;
				PropertySet(this);
			}
		}

		[Ordinal(115)] 
		[RED("sirenOn")] 
		public CBool SirenOn
		{
			get
			{
				if (_sirenOn == null)
				{
					_sirenOn = (CBool) CR2WTypeManager.Create("Bool", "sirenOn", cr2w, this);
				}
				return _sirenOn;
			}
			set
			{
				if (_sirenOn == value)
				{
					return;
				}
				_sirenOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(116)] 
		[RED("sirenSoundOn")] 
		public CBool SirenSoundOn
		{
			get
			{
				if (_sirenSoundOn == null)
				{
					_sirenSoundOn = (CBool) CR2WTypeManager.Create("Bool", "sirenSoundOn", cr2w, this);
				}
				return _sirenSoundOn;
			}
			set
			{
				if (_sirenSoundOn == value)
				{
					return;
				}
				_sirenSoundOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(117)] 
		[RED("sirenLightsOn")] 
		public CBool SirenLightsOn
		{
			get
			{
				if (_sirenLightsOn == null)
				{
					_sirenLightsOn = (CBool) CR2WTypeManager.Create("Bool", "sirenLightsOn", cr2w, this);
				}
				return _sirenLightsOn;
			}
			set
			{
				if (_sirenLightsOn == value)
				{
					return;
				}
				_sirenLightsOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(118)] 
		[RED("anyDoorOpen")] 
		public CBool AnyDoorOpen
		{
			get
			{
				if (_anyDoorOpen == null)
				{
					_anyDoorOpen = (CBool) CR2WTypeManager.Create("Bool", "anyDoorOpen", cr2w, this);
				}
				return _anyDoorOpen;
			}
			set
			{
				if (_anyDoorOpen == value)
				{
					return;
				}
				_anyDoorOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(119)] 
		[RED("previousInteractionState")] 
		public CArray<TemporaryDoorState> PreviousInteractionState
		{
			get
			{
				if (_previousInteractionState == null)
				{
					_previousInteractionState = (CArray<TemporaryDoorState>) CR2WTypeManager.Create("array:TemporaryDoorState", "previousInteractionState", cr2w, this);
				}
				return _previousInteractionState;
			}
			set
			{
				if (_previousInteractionState == value)
				{
					return;
				}
				_previousInteractionState = value;
				PropertySet(this);
			}
		}

		[Ordinal(120)] 
		[RED("thrusterState")] 
		public CBool ThrusterState
		{
			get
			{
				if (_thrusterState == null)
				{
					_thrusterState = (CBool) CR2WTypeManager.Create("Bool", "thrusterState", cr2w, this);
				}
				return _thrusterState;
			}
			set
			{
				if (_thrusterState == value)
				{
					return;
				}
				_thrusterState = value;
				PropertySet(this);
			}
		}

		[Ordinal(121)] 
		[RED("uiQuestModified")] 
		public CBool UiQuestModified
		{
			get
			{
				if (_uiQuestModified == null)
				{
					_uiQuestModified = (CBool) CR2WTypeManager.Create("Bool", "uiQuestModified", cr2w, this);
				}
				return _uiQuestModified;
			}
			set
			{
				if (_uiQuestModified == value)
				{
					return;
				}
				_uiQuestModified = value;
				PropertySet(this);
			}
		}

		[Ordinal(122)] 
		[RED("uiState")] 
		public CBool UiState
		{
			get
			{
				if (_uiState == null)
				{
					_uiState = (CBool) CR2WTypeManager.Create("Bool", "uiState", cr2w, this);
				}
				return _uiState;
			}
			set
			{
				if (_uiState == value)
				{
					return;
				}
				_uiState = value;
				PropertySet(this);
			}
		}

		[Ordinal(123)] 
		[RED("vehicleSkillChecks")] 
		public CHandle<EngDemoContainer> VehicleSkillChecks
		{
			get
			{
				if (_vehicleSkillChecks == null)
				{
					_vehicleSkillChecks = (CHandle<EngDemoContainer>) CR2WTypeManager.Create("handle:EngDemoContainer", "vehicleSkillChecks", cr2w, this);
				}
				return _vehicleSkillChecks;
			}
			set
			{
				if (_vehicleSkillChecks == value)
				{
					return;
				}
				_vehicleSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(124)] 
		[RED("ready")] 
		public CBool Ready
		{
			get
			{
				if (_ready == null)
				{
					_ready = (CBool) CR2WTypeManager.Create("Bool", "ready", cr2w, this);
				}
				return _ready;
			}
			set
			{
				if (_ready == value)
				{
					return;
				}
				_ready = value;
				PropertySet(this);
			}
		}

		[Ordinal(125)] 
		[RED("isPlayerPerformingBodyDisposal")] 
		public CBool IsPlayerPerformingBodyDisposal
		{
			get
			{
				if (_isPlayerPerformingBodyDisposal == null)
				{
					_isPlayerPerformingBodyDisposal = (CBool) CR2WTypeManager.Create("Bool", "isPlayerPerformingBodyDisposal", cr2w, this);
				}
				return _isPlayerPerformingBodyDisposal;
			}
			set
			{
				if (_isPlayerPerformingBodyDisposal == value)
				{
					return;
				}
				_isPlayerPerformingBodyDisposal = value;
				PropertySet(this);
			}
		}

		[Ordinal(126)] 
		[RED("vehicleControllerPS")] 
		public CHandle<vehicleControllerPS> VehicleControllerPS
		{
			get
			{
				if (_vehicleControllerPS == null)
				{
					_vehicleControllerPS = (CHandle<vehicleControllerPS>) CR2WTypeManager.Create("handle:vehicleControllerPS", "vehicleControllerPS", cr2w, this);
				}
				return _vehicleControllerPS;
			}
			set
			{
				if (_vehicleControllerPS == value)
				{
					return;
				}
				_vehicleControllerPS = value;
				PropertySet(this);
			}
		}

		public VehicleComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
