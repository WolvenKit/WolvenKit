using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationVersionUpdateInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("newVersion")] 
		public CUInt32 NewVersion
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("optionUpdates")] 
		public CArray<gameuiCharacterCustomizationOptionVersionUpdateInfo> OptionUpdates
		{
			get => GetPropertyValue<CArray<gameuiCharacterCustomizationOptionVersionUpdateInfo>>();
			set => SetPropertyValue<CArray<gameuiCharacterCustomizationOptionVersionUpdateInfo>>(value);
		}

		public gameuiCharacterCustomizationVersionUpdateInfo()
		{
			OptionUpdates = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
