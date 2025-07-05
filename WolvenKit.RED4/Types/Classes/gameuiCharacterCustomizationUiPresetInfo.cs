using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationUiPresetInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("resource")] 
		public CResourceAsyncReference<gameuiCharacterCustomizationUiPreset> Resource
		{
			get => GetPropertyValue<CResourceAsyncReference<gameuiCharacterCustomizationUiPreset>>();
			set => SetPropertyValue<CResourceAsyncReference<gameuiCharacterCustomizationUiPreset>>(value);
		}

		public gameuiCharacterCustomizationUiPresetInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
