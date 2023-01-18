using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questShowCustomQuestNotification_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("customQuestNotificationData")] 
		public questCustomQuestNotificationData CustomQuestNotificationData
		{
			get => GetPropertyValue<questCustomQuestNotificationData>();
			set => SetPropertyValue<questCustomQuestNotificationData>(value);
		}

		public questShowCustomQuestNotification_NodeType()
		{
			CustomQuestNotificationData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
