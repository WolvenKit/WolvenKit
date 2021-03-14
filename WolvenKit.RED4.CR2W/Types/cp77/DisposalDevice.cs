using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisposalDevice : InteractiveDevice
	{
		private CHandle<entMeshComponent> _additionalMeshComponent;
		private wCHandle<NPCPuppet> _npcBody;
		private CHandle<gameIBlackboard> _playerStateMachineBlackboard;
		private CArray<CName> _sideTriggerNames;
		private CArray<CHandle<gameStaticTriggerAreaComponent>> _triggerComponents;
		private CName _currentDisposalSyncName;
		private CName _currentKillSyncName;
		private CBool _isNonlethal;
		private CArray<CName> _physicalMeshNames;
		private CArray<CHandle<entPhysicalMeshComponent>> _physicalMeshes;
		private CFloat _lethalTakedownKillDelay;
		private CArray<CName> _lethalTakedownComponentNames;
		private CArray<CHandle<entIPlacedComponent>> _lethalTakedownComponents;
		private CBool _isReactToHit;
		private CName _distractionSoundName;
		private CFloat _workspotDuration;

		[Ordinal(93)] 
		[RED("additionalMeshComponent")] 
		public CHandle<entMeshComponent> AdditionalMeshComponent
		{
			get
			{
				if (_additionalMeshComponent == null)
				{
					_additionalMeshComponent = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "additionalMeshComponent", cr2w, this);
				}
				return _additionalMeshComponent;
			}
			set
			{
				if (_additionalMeshComponent == value)
				{
					return;
				}
				_additionalMeshComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("npcBody")] 
		public wCHandle<NPCPuppet> NpcBody
		{
			get
			{
				if (_npcBody == null)
				{
					_npcBody = (wCHandle<NPCPuppet>) CR2WTypeManager.Create("whandle:NPCPuppet", "npcBody", cr2w, this);
				}
				return _npcBody;
			}
			set
			{
				if (_npcBody == value)
				{
					return;
				}
				_npcBody = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("playerStateMachineBlackboard")] 
		public CHandle<gameIBlackboard> PlayerStateMachineBlackboard
		{
			get
			{
				if (_playerStateMachineBlackboard == null)
				{
					_playerStateMachineBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "playerStateMachineBlackboard", cr2w, this);
				}
				return _playerStateMachineBlackboard;
			}
			set
			{
				if (_playerStateMachineBlackboard == value)
				{
					return;
				}
				_playerStateMachineBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get
			{
				if (_sideTriggerNames == null)
				{
					_sideTriggerNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "sideTriggerNames", cr2w, this);
				}
				return _sideTriggerNames;
			}
			set
			{
				if (_sideTriggerNames == value)
				{
					return;
				}
				_sideTriggerNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get
			{
				if (_triggerComponents == null)
				{
					_triggerComponents = (CArray<CHandle<gameStaticTriggerAreaComponent>>) CR2WTypeManager.Create("array:handle:gameStaticTriggerAreaComponent", "triggerComponents", cr2w, this);
				}
				return _triggerComponents;
			}
			set
			{
				if (_triggerComponents == value)
				{
					return;
				}
				_triggerComponents = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("currentDisposalSyncName")] 
		public CName CurrentDisposalSyncName
		{
			get
			{
				if (_currentDisposalSyncName == null)
				{
					_currentDisposalSyncName = (CName) CR2WTypeManager.Create("CName", "currentDisposalSyncName", cr2w, this);
				}
				return _currentDisposalSyncName;
			}
			set
			{
				if (_currentDisposalSyncName == value)
				{
					return;
				}
				_currentDisposalSyncName = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("currentKillSyncName")] 
		public CName CurrentKillSyncName
		{
			get
			{
				if (_currentKillSyncName == null)
				{
					_currentKillSyncName = (CName) CR2WTypeManager.Create("CName", "currentKillSyncName", cr2w, this);
				}
				return _currentKillSyncName;
			}
			set
			{
				if (_currentKillSyncName == value)
				{
					return;
				}
				_currentKillSyncName = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("isNonlethal")] 
		public CBool IsNonlethal
		{
			get
			{
				if (_isNonlethal == null)
				{
					_isNonlethal = (CBool) CR2WTypeManager.Create("Bool", "isNonlethal", cr2w, this);
				}
				return _isNonlethal;
			}
			set
			{
				if (_isNonlethal == value)
				{
					return;
				}
				_isNonlethal = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("physicalMeshNames")] 
		public CArray<CName> PhysicalMeshNames
		{
			get
			{
				if (_physicalMeshNames == null)
				{
					_physicalMeshNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "physicalMeshNames", cr2w, this);
				}
				return _physicalMeshNames;
			}
			set
			{
				if (_physicalMeshNames == value)
				{
					return;
				}
				_physicalMeshNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(102)] 
		[RED("physicalMeshes")] 
		public CArray<CHandle<entPhysicalMeshComponent>> PhysicalMeshes
		{
			get
			{
				if (_physicalMeshes == null)
				{
					_physicalMeshes = (CArray<CHandle<entPhysicalMeshComponent>>) CR2WTypeManager.Create("array:handle:entPhysicalMeshComponent", "physicalMeshes", cr2w, this);
				}
				return _physicalMeshes;
			}
			set
			{
				if (_physicalMeshes == value)
				{
					return;
				}
				_physicalMeshes = value;
				PropertySet(this);
			}
		}

		[Ordinal(103)] 
		[RED("lethalTakedownKillDelay")] 
		public CFloat LethalTakedownKillDelay
		{
			get
			{
				if (_lethalTakedownKillDelay == null)
				{
					_lethalTakedownKillDelay = (CFloat) CR2WTypeManager.Create("Float", "lethalTakedownKillDelay", cr2w, this);
				}
				return _lethalTakedownKillDelay;
			}
			set
			{
				if (_lethalTakedownKillDelay == value)
				{
					return;
				}
				_lethalTakedownKillDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("lethalTakedownComponentNames")] 
		public CArray<CName> LethalTakedownComponentNames
		{
			get
			{
				if (_lethalTakedownComponentNames == null)
				{
					_lethalTakedownComponentNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "lethalTakedownComponentNames", cr2w, this);
				}
				return _lethalTakedownComponentNames;
			}
			set
			{
				if (_lethalTakedownComponentNames == value)
				{
					return;
				}
				_lethalTakedownComponentNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("lethalTakedownComponents")] 
		public CArray<CHandle<entIPlacedComponent>> LethalTakedownComponents
		{
			get
			{
				if (_lethalTakedownComponents == null)
				{
					_lethalTakedownComponents = (CArray<CHandle<entIPlacedComponent>>) CR2WTypeManager.Create("array:handle:entIPlacedComponent", "lethalTakedownComponents", cr2w, this);
				}
				return _lethalTakedownComponents;
			}
			set
			{
				if (_lethalTakedownComponents == value)
				{
					return;
				}
				_lethalTakedownComponents = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("isReactToHit")] 
		public CBool IsReactToHit
		{
			get
			{
				if (_isReactToHit == null)
				{
					_isReactToHit = (CBool) CR2WTypeManager.Create("Bool", "isReactToHit", cr2w, this);
				}
				return _isReactToHit;
			}
			set
			{
				if (_isReactToHit == value)
				{
					return;
				}
				_isReactToHit = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("distractionSoundName")] 
		public CName DistractionSoundName
		{
			get
			{
				if (_distractionSoundName == null)
				{
					_distractionSoundName = (CName) CR2WTypeManager.Create("CName", "distractionSoundName", cr2w, this);
				}
				return _distractionSoundName;
			}
			set
			{
				if (_distractionSoundName == value)
				{
					return;
				}
				_distractionSoundName = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("workspotDuration")] 
		public CFloat WorkspotDuration
		{
			get
			{
				if (_workspotDuration == null)
				{
					_workspotDuration = (CFloat) CR2WTypeManager.Create("Float", "workspotDuration", cr2w, this);
				}
				return _workspotDuration;
			}
			set
			{
				if (_workspotDuration == value)
				{
					return;
				}
				_workspotDuration = value;
				PropertySet(this);
			}
		}

		public DisposalDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
