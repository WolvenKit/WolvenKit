using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LiftControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("liftSetup")] 
		public LiftSetup LiftSetup
		{
			get => GetPropertyValue<LiftSetup>();
			set => SetPropertyValue<LiftSetup>(value);
		}

		[Ordinal(106)] 
		[RED("activeFloor")] 
		public CInt32 ActiveFloor
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(107)] 
		[RED("targetFloor")] 
		public CInt32 TargetFloor
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(108)] 
		[RED("movementState")] 
		public CEnum<gamePlatformMovementState> MovementState
		{
			get => GetPropertyValue<CEnum<gamePlatformMovementState>>();
			set => SetPropertyValue<CEnum<gamePlatformMovementState>>(value);
		}

		[Ordinal(109)] 
		[RED("floors")] 
		public CArray<ElevatorFloorSetup> Floors
		{
			get => GetPropertyValue<CArray<ElevatorFloorSetup>>();
			set => SetPropertyValue<CArray<ElevatorFloorSetup>>(value);
		}

		[Ordinal(110)] 
		[RED("floorIDs")] 
		public CArray<entEntityID> FloorIDs
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(111)] 
		[RED("floorPSIDs")] 
		public CArray<gamePersistentID> FloorPSIDs
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		[Ordinal(112)] 
		[RED("floorsAuthorization")] 
		public CArray<CBool> FloorsAuthorization
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		[Ordinal(113)] 
		[RED("timeOnPause")] 
		public CFloat TimeOnPause
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(114)] 
		[RED("isPlayerInsideLift")] 
		public CBool IsPlayerInsideLift
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(115)] 
		[RED("isPlayerInsideLift_RealOne")] 
		public CBool IsPlayerInsideLift_RealOne
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(116)] 
		[RED("isSpeakerDestroyed")] 
		public CBool IsSpeakerDestroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(117)] 
		[RED("hasSpeaker")] 
		public CBool HasSpeaker
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(118)] 
		[RED("stations")] 
		public CArray<RadioStationsMap> Stations
		{
			get => GetPropertyValue<CArray<RadioStationsMap>>();
			set => SetPropertyValue<CArray<RadioStationsMap>>(value);
		}

		[Ordinal(119)] 
		[RED("cachedGoToFloorAction")] 
		public CInt32 CachedGoToFloorAction
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(120)] 
		[RED("isAllDoorsClosed")] 
		public CBool IsAllDoorsClosed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(121)] 
		[RED("isAdsDisabled")] 
		public CBool IsAdsDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LiftControllerPS()
		{
			DeviceName = "LocKey#101";
			TweakDBRecord = 78520840316;
			TweakDBDescriptionRecord = 132145755007;
			DisableQuickHacks = true;
			LiftSetup = new() { LiftSpeed = 2.500000F, LiftStartingDelay = 1.000000F, LiftTravelTimeOverride = 4.000000F, EmptyLiftSpeedMultiplier = 2.000000F, RadioStationNumer = -1 };
			TargetFloor = -1;
			Floors = new();
			FloorIDs = new();
			FloorPSIDs = new();
			FloorsAuthorization = new();
			Stations = new();
			CachedGoToFloorAction = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
