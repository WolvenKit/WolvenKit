using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerVisionModeControllerBBListeners : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public CHandle<redCallbackObject> Kerenzikov
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(1)] 
		[RED("restrictedScene")] 
		public CHandle<redCallbackObject> RestrictedScene
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(2)] 
		[RED("dead")] 
		public CHandle<redCallbackObject> Dead
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(3)] 
		[RED("takedown")] 
		public CHandle<redCallbackObject> Takedown
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(4)] 
		[RED("deviceTakeover")] 
		public CHandle<redCallbackObject> DeviceTakeover
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(5)] 
		[RED("braindanceFPP")] 
		public CHandle<redCallbackObject> BraindanceFPP
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(6)] 
		[RED("braindanceActive")] 
		public CHandle<redCallbackObject> BraindanceActive
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(7)] 
		[RED("veryHardLanding")] 
		public CHandle<redCallbackObject> VeryHardLanding
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(8)] 
		[RED("isBriefingActive")] 
		public CHandle<redCallbackObject> IsBriefingActive
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(9)] 
		[RED("twintoneOverrideShown")] 
		public CHandle<redCallbackObject> TwintoneOverrideShown
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public PlayerVisionModeControllerBBListeners()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
