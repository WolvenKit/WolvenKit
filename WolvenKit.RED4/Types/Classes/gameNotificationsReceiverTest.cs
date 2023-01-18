using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameNotificationsReceiverTest : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("token")] 
		public CHandle<inkGameNotificationToken> Token
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		public gameNotificationsReceiverTest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
