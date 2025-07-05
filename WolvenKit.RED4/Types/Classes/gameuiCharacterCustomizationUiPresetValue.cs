using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationUiPresetValue : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("optionName")] 
		public CName OptionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CUInt32 Value
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameuiCharacterCustomizationUiPresetValue()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
