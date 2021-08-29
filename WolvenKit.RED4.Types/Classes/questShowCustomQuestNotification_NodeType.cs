using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questShowCustomQuestNotification_NodeType : questIUIManagerNodeType
	{
		private questCustomQuestNotificationData _customQuestNotificationData;

		[Ordinal(0)] 
		[RED("customQuestNotificationData")] 
		public questCustomQuestNotificationData CustomQuestNotificationData
		{
			get => GetProperty(ref _customQuestNotificationData);
			set => SetProperty(ref _customQuestNotificationData, value);
		}
	}
}
