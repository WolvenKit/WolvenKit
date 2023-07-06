using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShardCollectedNotification : GenericNotificationController
	{
		[Ordinal(12)] 
		[RED("shardTitle")] 
		public inkTextWidgetReference ShardTitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("bbListenerId")] 
		public CHandle<redCallbackObject> BbListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public ShardCollectedNotification()
		{
			ShardTitle = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
