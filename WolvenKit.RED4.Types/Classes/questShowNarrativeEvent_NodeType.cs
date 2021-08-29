using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questShowNarrativeEvent_NodeType : questIUIManagerNodeType
	{
		private CString _eventText;
		private CColor _textColor;
		private CFloat _durationSec;

		[Ordinal(0)] 
		[RED("eventText")] 
		public CString EventText
		{
			get => GetProperty(ref _eventText);
			set => SetProperty(ref _eventText, value);
		}

		[Ordinal(1)] 
		[RED("textColor")] 
		public CColor TextColor
		{
			get => GetProperty(ref _textColor);
			set => SetProperty(ref _textColor, value);
		}

		[Ordinal(2)] 
		[RED("durationSec")] 
		public CFloat DurationSec
		{
			get => GetProperty(ref _durationSec);
			set => SetProperty(ref _durationSec, value);
		}
	}
}
