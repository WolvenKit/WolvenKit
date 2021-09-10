using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CustomQuestNotificationUserData : inkGameNotificationData
	{
		[Ordinal(6)] 
		[RED("data")] 
		public questCustomQuestNotificationData Data
		{
			get => GetPropertyValue<questCustomQuestNotificationData>();
			set => SetPropertyValue<questCustomQuestNotificationData>(value);
		}

		public CustomQuestNotificationUserData()
		{
			Data = new();
		}
	}
}
