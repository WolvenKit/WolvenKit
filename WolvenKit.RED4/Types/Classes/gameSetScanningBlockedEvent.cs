using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSetScanningBlockedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameSetScanningBlockedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
