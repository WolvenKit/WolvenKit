using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPhotoModeOptionSelectorData : RedBaseClass
	{
		private CInt32 _optionData;
		private CString _optionText;

		[Ordinal(0)] 
		[RED("optionData")] 
		public CInt32 OptionData
		{
			get => GetProperty(ref _optionData);
			set => SetProperty(ref _optionData, value);
		}

		[Ordinal(1)] 
		[RED("optionText")] 
		public CString OptionText
		{
			get => GetProperty(ref _optionText);
			set => SetProperty(ref _optionText, value);
		}

		public gameuiPhotoModeOptionSelectorData()
		{
			_optionData = -1;
		}
	}
}
