using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerVisionModeControllerInvalidateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayerVisionModeControllerInvalidateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
