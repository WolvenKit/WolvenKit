using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DoorControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("doorProperties")] 
		public DoorSetup DoorProperties
		{
			get => GetPropertyValue<DoorSetup>();
			set => SetPropertyValue<DoorSetup>(value);
		}

		[Ordinal(105)] 
		[RED("doorSkillChecks")] 
		public CHandle<EngDemoContainer> DoorSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(106)] 
		[RED("isOpened")] 
		public CBool IsOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(107)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(108)] 
		[RED("isSealed")] 
		public CBool IsSealed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("alarmRaised")] 
		public CBool AlarmRaised
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(110)] 
		[RED("isBusy")] 
		public CBool IsBusy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(111)] 
		[RED("isLiftDoor")] 
		public CBool IsLiftDoor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(112)] 
		[RED("isPlayerAuthorised")] 
		public CBool IsPlayerAuthorised
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(113)] 
		[RED("openingTokens")] 
		public CArray<entEntityID> OpeningTokens
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		public DoorControllerPS()
		{
			DeviceName = "LocKey#69";
			TweakDBRecord = 52036287653;
			TweakDBDescriptionRecord = 104841659775;
			DoorProperties = new() { DoorType = Enums.EDoorType.INTERACTIVE, AutomaticallyClosesItself = true, OpeningSpeed = 1.000000F, DoorOpeningTime = 1.000000F, DoorOpeningStimRange = 5.000000F };
			OpeningTokens = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
