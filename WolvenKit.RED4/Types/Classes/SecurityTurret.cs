using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityTurret : SensorDevice
	{
		[Ordinal(189)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SecurityTurretData> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_SecurityTurretData>>();
			set => SetPropertyValue<CHandle<AnimFeature_SecurityTurretData>>(value);
		}

		[Ordinal(190)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(191)] 
		[RED("lookAtSlot")] 
		public CHandle<entSlotComponent> LookAtSlot
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(192)] 
		[RED("laserMesh")] 
		public CHandle<entMeshComponent> LaserMesh
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(193)] 
		[RED("targetingComp")] 
		public CHandle<gameTargetingComponent> TargetingComp
		{
			get => GetPropertyValue<CHandle<gameTargetingComponent>>();
			set => SetPropertyValue<CHandle<gameTargetingComponent>>(value);
		}

		[Ordinal(194)] 
		[RED("triggerSideOne")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerSideOne
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(195)] 
		[RED("triggerSideTwo")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerSideTwo
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(196)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(197)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(198)] 
		[RED("laserGameEffect")] 
		public CHandle<gameEffectInstance> LaserGameEffect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(199)] 
		[RED("laserFXSlotName")] 
		public CName LaserFXSlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(200)] 
		[RED("burstDelayEvtID")] 
		public gameDelayID BurstDelayEvtID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(201)] 
		[RED("isBurstDelayOngoing")] 
		public CBool IsBurstDelayOngoing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(202)] 
		[RED("nextShootCycleDelayEvtID")] 
		public gameDelayID NextShootCycleDelayEvtID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(203)] 
		[RED("isShootingOngoing")] 
		public CBool IsShootingOngoing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(204)] 
		[RED("timeToNextShot")] 
		public CFloat TimeToNextShot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(205)] 
		[RED("optim_CheckTargetParametersShots")] 
		public CInt32 Optim_CheckTargetParametersShots
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(206)] 
		[RED("netClientCurrentlyAppliedState")] 
		public CHandle<SecurityTurretReplicatedState> NetClientCurrentlyAppliedState
		{
			get => GetPropertyValue<CHandle<SecurityTurretReplicatedState>>();
			set => SetPropertyValue<CHandle<SecurityTurretReplicatedState>>(value);
		}

		public SecurityTurret()
		{
			ControllerTypeName = "SecurityTurretController";
			DefaultSensePreset = 77796192748;
			IdleSound = "idleStart";
			IdleSoundStop = "idleStop";
			SoundDeviceON = "activated";
			SoundDeviceOFF = "deactivated";
			SoundDeviceDestroyed = "destroyed";
			AnimFeatureName = "SecurityTurretData";
			ItemID = new();
			LaserFXSlotName = "laser";
			BurstDelayEvtID = new();
			NextShootCycleDelayEvtID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
