using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityTurret : SensorDevice
	{
		private CHandle<AnimFeature_SecurityTurretData> _animFeature;
		private CName _animFeatureName;
		private CHandle<entSlotComponent> _lookAtSlot;
		private CHandle<entMeshComponent> _laserMesh;
		private CHandle<gameTargetingComponent> _targetingComp;
		private CHandle<gameStaticTriggerAreaComponent> _triggerSideOne;
		private CHandle<gameStaticTriggerAreaComponent> _triggerSideTwo;
		private wCHandle<gameweaponObject> _weapon;
		private gameItemID _itemID;
		private CHandle<gameEffectInstance> _laserGameEffect;
		private CName _laserFXSlotName;
		private gameDelayID _burstDelayEvtID;
		private CBool _isBurstDelayOngoing;
		private gameDelayID _nextShootCycleDelayEvtID;
		private CBool _isShootingOngoing;
		private CFloat _timeToNextShot;
		private CInt32 _optim_CheckTargetParametersShots;
		private CHandle<SecurityTurretReplicatedState> _netClientCurrentlyAppliedState;

		[Ordinal(187)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SecurityTurretData> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<AnimFeature_SecurityTurretData>) CR2WTypeManager.Create("handle:AnimFeature_SecurityTurretData", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(188)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get
			{
				if (_animFeatureName == null)
				{
					_animFeatureName = (CName) CR2WTypeManager.Create("CName", "animFeatureName", cr2w, this);
				}
				return _animFeatureName;
			}
			set
			{
				if (_animFeatureName == value)
				{
					return;
				}
				_animFeatureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(189)] 
		[RED("lookAtSlot")] 
		public CHandle<entSlotComponent> LookAtSlot
		{
			get
			{
				if (_lookAtSlot == null)
				{
					_lookAtSlot = (CHandle<entSlotComponent>) CR2WTypeManager.Create("handle:entSlotComponent", "lookAtSlot", cr2w, this);
				}
				return _lookAtSlot;
			}
			set
			{
				if (_lookAtSlot == value)
				{
					return;
				}
				_lookAtSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(190)] 
		[RED("laserMesh")] 
		public CHandle<entMeshComponent> LaserMesh
		{
			get
			{
				if (_laserMesh == null)
				{
					_laserMesh = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "laserMesh", cr2w, this);
				}
				return _laserMesh;
			}
			set
			{
				if (_laserMesh == value)
				{
					return;
				}
				_laserMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(191)] 
		[RED("targetingComp")] 
		public CHandle<gameTargetingComponent> TargetingComp
		{
			get
			{
				if (_targetingComp == null)
				{
					_targetingComp = (CHandle<gameTargetingComponent>) CR2WTypeManager.Create("handle:gameTargetingComponent", "targetingComp", cr2w, this);
				}
				return _targetingComp;
			}
			set
			{
				if (_targetingComp == value)
				{
					return;
				}
				_targetingComp = value;
				PropertySet(this);
			}
		}

		[Ordinal(192)] 
		[RED("triggerSideOne")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerSideOne
		{
			get
			{
				if (_triggerSideOne == null)
				{
					_triggerSideOne = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "triggerSideOne", cr2w, this);
				}
				return _triggerSideOne;
			}
			set
			{
				if (_triggerSideOne == value)
				{
					return;
				}
				_triggerSideOne = value;
				PropertySet(this);
			}
		}

		[Ordinal(193)] 
		[RED("triggerSideTwo")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerSideTwo
		{
			get
			{
				if (_triggerSideTwo == null)
				{
					_triggerSideTwo = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "triggerSideTwo", cr2w, this);
				}
				return _triggerSideTwo;
			}
			set
			{
				if (_triggerSideTwo == value)
				{
					return;
				}
				_triggerSideTwo = value;
				PropertySet(this);
			}
		}

		[Ordinal(194)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get
			{
				if (_weapon == null)
				{
					_weapon = (wCHandle<gameweaponObject>) CR2WTypeManager.Create("whandle:gameweaponObject", "weapon", cr2w, this);
				}
				return _weapon;
			}
			set
			{
				if (_weapon == value)
				{
					return;
				}
				_weapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(195)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(196)] 
		[RED("laserGameEffect")] 
		public CHandle<gameEffectInstance> LaserGameEffect
		{
			get
			{
				if (_laserGameEffect == null)
				{
					_laserGameEffect = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "laserGameEffect", cr2w, this);
				}
				return _laserGameEffect;
			}
			set
			{
				if (_laserGameEffect == value)
				{
					return;
				}
				_laserGameEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(197)] 
		[RED("laserFXSlotName")] 
		public CName LaserFXSlotName
		{
			get
			{
				if (_laserFXSlotName == null)
				{
					_laserFXSlotName = (CName) CR2WTypeManager.Create("CName", "laserFXSlotName", cr2w, this);
				}
				return _laserFXSlotName;
			}
			set
			{
				if (_laserFXSlotName == value)
				{
					return;
				}
				_laserFXSlotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(198)] 
		[RED("burstDelayEvtID")] 
		public gameDelayID BurstDelayEvtID
		{
			get
			{
				if (_burstDelayEvtID == null)
				{
					_burstDelayEvtID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "burstDelayEvtID", cr2w, this);
				}
				return _burstDelayEvtID;
			}
			set
			{
				if (_burstDelayEvtID == value)
				{
					return;
				}
				_burstDelayEvtID = value;
				PropertySet(this);
			}
		}

		[Ordinal(199)] 
		[RED("isBurstDelayOngoing")] 
		public CBool IsBurstDelayOngoing
		{
			get
			{
				if (_isBurstDelayOngoing == null)
				{
					_isBurstDelayOngoing = (CBool) CR2WTypeManager.Create("Bool", "isBurstDelayOngoing", cr2w, this);
				}
				return _isBurstDelayOngoing;
			}
			set
			{
				if (_isBurstDelayOngoing == value)
				{
					return;
				}
				_isBurstDelayOngoing = value;
				PropertySet(this);
			}
		}

		[Ordinal(200)] 
		[RED("nextShootCycleDelayEvtID")] 
		public gameDelayID NextShootCycleDelayEvtID
		{
			get
			{
				if (_nextShootCycleDelayEvtID == null)
				{
					_nextShootCycleDelayEvtID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "nextShootCycleDelayEvtID", cr2w, this);
				}
				return _nextShootCycleDelayEvtID;
			}
			set
			{
				if (_nextShootCycleDelayEvtID == value)
				{
					return;
				}
				_nextShootCycleDelayEvtID = value;
				PropertySet(this);
			}
		}

		[Ordinal(201)] 
		[RED("isShootingOngoing")] 
		public CBool IsShootingOngoing
		{
			get
			{
				if (_isShootingOngoing == null)
				{
					_isShootingOngoing = (CBool) CR2WTypeManager.Create("Bool", "isShootingOngoing", cr2w, this);
				}
				return _isShootingOngoing;
			}
			set
			{
				if (_isShootingOngoing == value)
				{
					return;
				}
				_isShootingOngoing = value;
				PropertySet(this);
			}
		}

		[Ordinal(202)] 
		[RED("timeToNextShot")] 
		public CFloat TimeToNextShot
		{
			get
			{
				if (_timeToNextShot == null)
				{
					_timeToNextShot = (CFloat) CR2WTypeManager.Create("Float", "timeToNextShot", cr2w, this);
				}
				return _timeToNextShot;
			}
			set
			{
				if (_timeToNextShot == value)
				{
					return;
				}
				_timeToNextShot = value;
				PropertySet(this);
			}
		}

		[Ordinal(203)] 
		[RED("optim_CheckTargetParametersShots")] 
		public CInt32 Optim_CheckTargetParametersShots
		{
			get
			{
				if (_optim_CheckTargetParametersShots == null)
				{
					_optim_CheckTargetParametersShots = (CInt32) CR2WTypeManager.Create("Int32", "optim_CheckTargetParametersShots", cr2w, this);
				}
				return _optim_CheckTargetParametersShots;
			}
			set
			{
				if (_optim_CheckTargetParametersShots == value)
				{
					return;
				}
				_optim_CheckTargetParametersShots = value;
				PropertySet(this);
			}
		}

		[Ordinal(204)] 
		[RED("netClientCurrentlyAppliedState")] 
		public CHandle<SecurityTurretReplicatedState> NetClientCurrentlyAppliedState
		{
			get
			{
				if (_netClientCurrentlyAppliedState == null)
				{
					_netClientCurrentlyAppliedState = (CHandle<SecurityTurretReplicatedState>) CR2WTypeManager.Create("handle:SecurityTurretReplicatedState", "netClientCurrentlyAppliedState", cr2w, this);
				}
				return _netClientCurrentlyAppliedState;
			}
			set
			{
				if (_netClientCurrentlyAppliedState == value)
				{
					return;
				}
				_netClientCurrentlyAppliedState = value;
				PropertySet(this);
			}
		}

		public SecurityTurret(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
