using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMaterialOverride : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("base")] 
		public CName Base
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("override")] 
		public CName Override
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioMaterialOverride()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
