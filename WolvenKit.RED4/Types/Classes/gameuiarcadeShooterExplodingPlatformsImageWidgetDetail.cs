using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterExplodingPlatformsImageWidgetDetail : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("platformName")] 
		public CName PlatformName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("platformImageDetails")] 
		public CArray<gameuiarcadeShooterPlatformImageDetail> PlatformImageDetails
		{
			get => GetPropertyValue<CArray<gameuiarcadeShooterPlatformImageDetail>>();
			set => SetPropertyValue<CArray<gameuiarcadeShooterPlatformImageDetail>>(value);
		}

		public gameuiarcadeShooterExplodingPlatformsImageWidgetDetail()
		{
			PlatformImageDetails = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
