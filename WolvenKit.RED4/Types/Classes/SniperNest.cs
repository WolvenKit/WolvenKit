using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SniperNest : SensorDevice
	{
		[Ordinal(200)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SecurityTurretData> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_SecurityTurretData>>();
			set => SetPropertyValue<CHandle<AnimFeature_SecurityTurretData>>(value);
		}

		[Ordinal(201)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(202)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(203)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(204)] 
		[RED("teleportAfterEnter")] 
		public NodeRef TeleportAfterEnter
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(205)] 
		[RED("burstDelayEvtID")] 
		public gameDelayID BurstDelayEvtID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(206)] 
		[RED("isBurstDelayOngoing")] 
		public CBool IsBurstDelayOngoing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(207)] 
		[RED("nextShootCycleDelayEvtID")] 
		public gameDelayID NextShootCycleDelayEvtID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(208)] 
		[RED("isShootingOngoing")] 
		public CBool IsShootingOngoing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(209)] 
		[RED("timeToNextShot")] 
		public CFloat TimeToNextShot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(210)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(211)] 
		[RED("targetZoom")] 
		public CFloat TargetZoom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(212)] 
		[RED("startZoom")] 
		public CFloat StartZoom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(213)] 
		[RED("zoomLerpTimeStamp")] 
		public CFloat ZoomLerpTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(214)] 
		[RED("zoomLerpDuration")] 
		public CFloat ZoomLerpDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SniperNest()
		{
			ControllerTypeName = "SniperNestController";
			DefaultSensePreset = "Senses.BasicTurret";
			IdleSound = "idleStart";
			IdleSoundStop = "idleStop";
			SoundDeviceON = "activated";
			SoundDeviceOFF = "deactivated";
			SoundDeviceDestroyed = "destroyed";
			MinPitch = -20.000000F;
			MinYaw = 10.000000F;
			MaxYaw = 170.000000F;
			AnimFeatureName = "SecurityTurretData";
			ItemID = new gameItemID();
			BurstDelayEvtID = new gameDelayID();
			NextShootCycleDelayEvtID = new gameDelayID();
			TargetZoom = 1.000000F;
			StartZoom = 1.000000F;
			ZoomLerpTimeStamp = -1.000000F;
			ZoomLerpDuration = 0.200000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
