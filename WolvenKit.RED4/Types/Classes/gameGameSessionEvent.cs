using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameGameSessionEvent : gameCallbackSystemEvent
	{
		[Ordinal(1)] 
		[RED("restored")] 
		public CBool Restored
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("preGame")] 
		public CBool PreGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameGameSessionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
