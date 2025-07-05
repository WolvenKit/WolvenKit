using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCustomizationGroup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("customization")] 
		public CArray<gameuiCustomizationAppearance> Customization
		{
			get => GetPropertyValue<CArray<gameuiCustomizationAppearance>>();
			set => SetPropertyValue<CArray<gameuiCustomizationAppearance>>(value);
		}

		[Ordinal(2)] 
		[RED("morphs")] 
		public CArray<gameuiCustomizationMorph> Morphs
		{
			get => GetPropertyValue<CArray<gameuiCustomizationMorph>>();
			set => SetPropertyValue<CArray<gameuiCustomizationMorph>>(value);
		}

		public gameuiCustomizationGroup()
		{
			Customization = new();
			Morphs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
