using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LiftSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("startingFloorTerminal")] 
		public CInt32 StartingFloorTerminal
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("liftSpeed")] 
		public CFloat LiftSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("liftStartingDelay")] 
		public CFloat LiftStartingDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("liftTravelTimeOverride")] 
		public CFloat LiftTravelTimeOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("isLiftTravelTimeOverride")] 
		public CBool IsLiftTravelTimeOverride
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("emptyLiftSpeedMultiplier")] 
		public CFloat EmptyLiftSpeedMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("radioStationNumer")] 
		public CInt32 RadioStationNumer
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("speakerDestroyedQuestFact")] 
		public CName SpeakerDestroyedQuestFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("speakerDestroyedVFX")] 
		public CName SpeakerDestroyedVFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("authorizationTextOverride")] 
		public CString AuthorizationTextOverride
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public LiftSetup()
		{
			LiftSpeed = 2.500000F;
			LiftStartingDelay = 1.000000F;
			LiftTravelTimeOverride = 4.000000F;
			EmptyLiftSpeedMultiplier = 2.000000F;
			RadioStationNumer = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
