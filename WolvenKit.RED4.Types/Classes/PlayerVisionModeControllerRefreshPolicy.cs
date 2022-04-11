using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerVisionModeControllerRefreshPolicy : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("kerenzikov")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> Kerenzikov
		{
			get => GetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>(value);
		}

		[Ordinal(1)] 
		[RED("restrictedScene")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> RestrictedScene
		{
			get => GetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>(value);
		}

		[Ordinal(2)] 
		[RED("dead")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> Dead
		{
			get => GetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>(value);
		}

		[Ordinal(3)] 
		[RED("takedown")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> Takedown
		{
			get => GetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>(value);
		}

		[Ordinal(4)] 
		[RED("deviceTakeover")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> DeviceTakeover
		{
			get => GetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>(value);
		}

		[Ordinal(5)] 
		[RED("braindanceFPP")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> BraindanceFPP
		{
			get => GetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>(value);
		}

		[Ordinal(6)] 
		[RED("braindanceActive")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> BraindanceActive
		{
			get => GetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>(value);
		}

		[Ordinal(7)] 
		[RED("veryHardLanding")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> VeryHardLanding
		{
			get => GetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>(value);
		}

		[Ordinal(8)] 
		[RED("noScanningRestriction")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> NoScanningRestriction
		{
			get => GetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>(value);
		}

		[Ordinal(9)] 
		[RED("hasNotCybereye")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> HasNotCybereye
		{
			get => GetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>(value);
		}

		[Ordinal(10)] 
		[RED("isPhotoMode")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> IsPhotoMode
		{
			get => GetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>(value);
		}

		[Ordinal(11)] 
		[RED("isBriefingActive")] 
		public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> IsBriefingActive
		{
			get => GetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerVisionModeControllerRefreshPolicyEnum>>(value);
		}

		public PlayerVisionModeControllerRefreshPolicy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
