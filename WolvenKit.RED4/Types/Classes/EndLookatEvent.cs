using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EndLookatEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("repeat")] 
		public CBool Repeat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public EndLookatEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
