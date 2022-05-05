using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SmartHouseConfiguration : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enableInteraction")] 
		public CBool EnableInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SmartHouseConfiguration()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
