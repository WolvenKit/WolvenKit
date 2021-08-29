using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CharacterCreationTooltipData : MessageTooltipData
	{
		private CString _attribiuteLevel;
		private CString _maxedOrMinimumLabelText;

		[Ordinal(4)] 
		[RED("attribiuteLevel")] 
		public CString AttribiuteLevel
		{
			get => GetProperty(ref _attribiuteLevel);
			set => SetProperty(ref _attribiuteLevel, value);
		}

		[Ordinal(5)] 
		[RED("maxedOrMinimumLabelText")] 
		public CString MaxedOrMinimumLabelText
		{
			get => GetProperty(ref _maxedOrMinimumLabelText);
			set => SetProperty(ref _maxedOrMinimumLabelText, value);
		}
	}
}
