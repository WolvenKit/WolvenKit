using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OverclockHudEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("activated")] 
		public CBool Activated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public OverclockHudEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
