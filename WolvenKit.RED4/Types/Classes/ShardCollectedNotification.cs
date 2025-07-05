using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShardCollectedNotification : GenericNotificationController
	{
		[Ordinal(16)] 
		[RED("shardTitle")] 
		public inkTextWidgetReference ShardTitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("bbListenerId")] 
		public CHandle<redCallbackObject> BbListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public ShardCollectedNotification()
		{
			ShardTitle = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
