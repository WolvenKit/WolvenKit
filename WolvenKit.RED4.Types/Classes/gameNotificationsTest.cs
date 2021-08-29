using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNotificationsTest : gameuiWidgetGameController
	{
		private CHandle<inkGameNotificationToken> _token;

		[Ordinal(2)] 
		[RED("token")] 
		public CHandle<inkGameNotificationToken> Token
		{
			get => GetProperty(ref _token);
			set => SetProperty(ref _token, value);
		}
	}
}
