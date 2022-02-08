using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShardCollectedNotification : GenericNotificationController
	{
		[Ordinal(12)] 
		[RED("shardTitle")] 
		public inkTextWidgetReference ShardTitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public ShardCollectedNotification()
		{
			ShardTitle = new();
		}
	}
}
