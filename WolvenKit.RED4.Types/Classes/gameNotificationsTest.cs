using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameNotificationsTest : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("token")] 
		public CHandle<inkGameNotificationToken> Token
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		public gameNotificationsTest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
