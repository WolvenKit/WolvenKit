using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationUiPreset : CResource
	{
		[Ordinal(1)] 
		[RED("isMaleVO")] 
		public CBool IsMaleVO
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("values")] 
		public CArray<gameuiCharacterCustomizationUiPresetValue> Values
		{
			get => GetPropertyValue<CArray<gameuiCharacterCustomizationUiPresetValue>>();
			set => SetPropertyValue<CArray<gameuiCharacterCustomizationUiPresetValue>>(value);
		}

		public gameuiCharacterCustomizationUiPreset()
		{
			Values = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
