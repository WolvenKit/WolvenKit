using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HighlightConnectionComponentEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("IsHighlightON")] 
		public CBool IsHighlightON
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
