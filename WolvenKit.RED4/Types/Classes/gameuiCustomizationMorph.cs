using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCustomizationMorph : gameuiCensorshipInfo
	{
		[Ordinal(2)] 
		[RED("regionName")] 
		public CName RegionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("targetName")] 
		public CName TargetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiCustomizationMorph()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
