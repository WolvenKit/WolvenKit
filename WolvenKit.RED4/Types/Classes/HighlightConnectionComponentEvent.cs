using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HighlightConnectionComponentEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("IsHighlightON")] 
		public CBool IsHighlightON
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HighlightConnectionComponentEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
