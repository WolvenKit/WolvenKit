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

		[Ordinal(192)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SecurityTurretData> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(193)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetProperty(ref _animFeatureName);
			set => SetProperty(ref _animFeatureName, value);
		}

		[Ordinal(194)] 
		[RED("lookAtSlot")] 
		public CHandle<entSlotComponent> LookAtSlot
		{
			get => GetProperty(ref _lookAtSlot);
			set => SetProperty(ref _lookAtSlot, value);
		}

		[Ordinal(195)] 
		[RED("laserMesh")] 
		public CHandle<entMeshComponent> LaserMesh
		{
			get => GetProperty(ref _laserMesh);
			set => SetProperty(ref _laserMesh, value);
		}

		[Ordinal(196)] 
		[RED("targetingComp")] 
		public CHandle<gameTargetingComponent> TargetingComp
		{
			get => GetProperty(ref _targetingComp);
			set => SetProperty(ref _targetingComp, value);
		}

		[Ordinal(197)] 
		[RED("triggerSideOne")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerSideOne
		{
			get => GetProperty(ref _triggerSideOne);
			set => SetProperty(ref _triggerSideOne, value);
		}

		[Ordinal(198)] 
		[RED("triggerSideTwo")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerSideTwo
		{
			get => GetProperty(ref _triggerSideTwo);
			set => SetProperty(ref _triggerSideTwo, value);
		}

		[Ordinal(199)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(200)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(201)] 
		[RED("laserGameEffect")] 
		public CHandle<gameEffectInstance> LaserGameEffect
		{
			get => GetProperty(ref _laserGameEffect);
			set => SetProperty(ref _laserGameEffect, value);
		}

		[Ordinal(202)] 
		[RED("laserFXSlotName")] 
		public CName LaserFXSlotName
		{
			get => GetProperty(ref _laserFXSlotName);
			set => SetProperty(ref _laserFXSlotName, value);
		}

		[Ordinal(203)] 
		[RED("burstDelayEvtID")] 
		public gameDelayID BurstDelayEvtID
		{
			get => GetProperty(ref _burstDelayEvtID);
			set => SetProperty(ref _burstDelayEvtID, value);
		}

		[Ordinal(204)] 
		[RED("isBurstDelayOngoing")] 
		public CBool IsBurstDelayOngoing
		{
			get => GetProperty(ref _isBurstDelayOngoing);
			set => SetProperty(ref _isBurstDelayOngoing, value);
		}

		[Ordinal(205)] 
		[RED("nextShootCycleDelayEvtID")] 
		public gameDelayID NextShootCycleDelayEvtID
		{
			get => GetProperty(ref _nextShootCycleDelayEvtID);
			set => SetProperty(ref _nextShootCycleDelayEvtID, value);
		}

		[Ordinal(206)] 
		[RED("isShootingOngoing")] 
		public CBool IsShootingOngoing
		{
			get => GetProperty(ref _isShootingOngoing);
			set => SetProperty(ref _isShootingOngoing, value);
		}

		[Ordinal(207)] 
		[RED("timeToNextShot")] 
		public CFloat TimeToNextShot
		{
			get => GetProperty(ref _timeToNextShot);
			set => SetProperty(ref _timeToNextShot, value);
		}

		[Ordinal(208)] 
		[RED("optim_CheckTargetParametersShots")] 
		public CInt32 Optim_CheckTargetParametersShots
		{
			get => GetProperty(ref _optim_CheckTargetParametersShots);
			set => SetProperty(ref _optim_CheckTargetParametersShots, value);
		}

		[Ordinal(209)] 
		[RED("netClientCurrentlyAppliedState")] 
		public CHandle<SecurityTurretReplicatedState> NetClientCurrentlyAppliedState
		{
			get => GetProperty(ref _netClientCurrentlyAppliedState);
			set => SetProperty(ref _netClientCurrentlyAppliedState, value);
		}

		public SecurityTurret(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
