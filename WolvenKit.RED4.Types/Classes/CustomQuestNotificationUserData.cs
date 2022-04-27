using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CustomQuestNotificationUserData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("data")] 
		public questCustomQuestNotificationData Data
		{
			get => GetPropertyValue<questCustomQuestNotificationData>();
			set => SetPropertyValue<questCustomQuestNotificationData>(value);
		}

		public CustomQuestNotificationUserData()
		{
			Data = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
