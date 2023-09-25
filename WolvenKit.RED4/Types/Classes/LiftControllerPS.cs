using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LiftControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("liftSetup")] 
		public LiftSetup LiftSetup
		{
			get => GetPropertyValue<LiftSetup>();
			set => SetPropertyValue<LiftSetup>(value);
		}

		[Ordinal(109)] 
		[RED("activeFloor")] 
		public CInt32 ActiveFloor
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(110)] 
		[RED("targetFloor")] 
		public CInt32 TargetFloor
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(111)] 
		[RED("movementState")] 
		public CEnum<gamePlatformMovementState> MovementState
		{
			get => GetPropertyValue<CEnum<gamePlatformMovementState>>();
			set => SetPropertyValue<CEnum<gamePlatformMovementState>>(value);
		}

		[Ordinal(112)] 
		[RED("floors")] 
		public CArray<ElevatorFloorSetup> Floors
		{
			get => GetPropertyValue<CArray<ElevatorFloorSetup>>();
			set => SetPropertyValue<CArray<ElevatorFloorSetup>>(value);
		}

		[Ordinal(113)] 
		[RED("floorIDs")] 
		public CArray<entEntityID> FloorIDs
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(114)] 
		[RED("floorPSIDs")] 
		public CArray<gamePersistentID> FloorPSIDs
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		[Ordinal(115)] 
		[RED("floorsAuthorization")] 
		public CArray<CBool> FloorsAuthorization
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		[Ordinal(116)] 
		[RED("timeOnPause")] 
		public CFloat TimeOnPause
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(117)] 
		[RED("isPlayerInsideLift")] 
		public CBool IsPlayerInsideLift
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(118)] 
		[RED("isPlayerInsideLift_RealOne")] 
		public CBool IsPlayerInsideLift_RealOne
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(119)] 
		[RED("isSpeakerDestroyed")] 
		public CBool IsSpeakerDestroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(120)] 
		[RED("hasSpeaker")] 
		public CBool HasSpeaker
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(121)] 
		[RED("cachedGoToFloorAction")] 
		public CInt32 CachedGoToFloorAction
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(122)] 
		[RED("isAllDoorsClosed")] 
		public CBool IsAllDoorsClosed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(123)] 
		[RED("isAdsDisabled")] 
		public CBool IsAdsDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LiftControllerPS()
		{
			DeviceName = "LocKey#101";
			TweakDBRecord = "Devices.LiftDevice";
			TweakDBDescriptionRecord = 132145755007;
			DisableQuickHacks = true;
			LiftSetup = new LiftSetup { LiftSpeed = 2.500000F, LiftStartingDelay = 1.000000F, LiftTravelTimeOverride = 4.000000F, EmptyLiftSpeedMultiplier = 2.000000F, RadioStationNumer = -1, MovingCurve = "cosine", ExtraFX = new EffectFiringData() };
			TargetFloor = -1;
			Floors = new();
			FloorIDs = new();
			FloorPSIDs = new();
			FloorsAuthorization = new();
			CachedGoToFloorAction = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
