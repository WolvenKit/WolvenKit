using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTaggedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CBool State
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameTaggedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
