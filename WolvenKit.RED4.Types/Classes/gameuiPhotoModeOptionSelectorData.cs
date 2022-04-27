using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPhotoModeOptionSelectorData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("optionData")] 
		public CInt32 OptionData
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("optionText")] 
		public CString OptionText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gameuiPhotoModeOptionSelectorData()
		{
			OptionData = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
