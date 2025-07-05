using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questInt32FactDBProvider : questIInt32ValueProvider
	{
		[Ordinal(0)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questInt32FactDBProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
