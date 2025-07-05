using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerVisionModeControllerBlackboardListenersFunctions : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public CName Kerenzikov
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("restrictedScene")] 
		public CName RestrictedScene
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("dead")] 
		public CName Dead
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("takedown")] 
		public CName Takedown
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("deviceTakeover")] 
		public CName DeviceTakeover
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("braindanceFPP")] 
		public CName BraindanceFPP
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("braindanceActive")] 
		public CName BraindanceActive
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("veryHardLanding")] 
		public CName VeryHardLanding
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("isBriefingActive")] 
		public CName IsBriefingActive
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("twintoneOverrideShown")] 
		public CName TwintoneOverrideShown
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PlayerVisionModeControllerBlackboardListenersFunctions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
