using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVisionAppearanceForcedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CBool State
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameVisionAppearanceForcedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
