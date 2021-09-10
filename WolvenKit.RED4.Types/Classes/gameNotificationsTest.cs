using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNotificationsTest : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("token")] 
		public CHandle<inkGameNotificationToken> Token
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}
	}
}
