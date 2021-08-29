using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HighlightConnectionComponentEvent : redEvent
	{
		private CBool _isHighlightON;

		[Ordinal(0)] 
		[RED("IsHighlightON")] 
		public CBool IsHighlightON
		{
			get => GetProperty(ref _isHighlightON);
			set => SetProperty(ref _isHighlightON, value);
		}
	}
}
