using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JournalNotification : GenericNotificationController
	{
		[Ordinal(12)] 
		[RED("interactionsBlackboard")] 
		public CWeakHandle<gameIBlackboard> InteractionsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(13)] 
		[RED("bbListenerId")] 
		public CHandle<redCallbackObject> BbListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(15)] 
		[RED("questNotificationData")] 
		public CHandle<gameuiQuestUpdateNotificationViewData> QuestNotificationData
		{
			get => GetPropertyValue<CHandle<gameuiQuestUpdateNotificationViewData>>();
			set => SetPropertyValue<CHandle<gameuiQuestUpdateNotificationViewData>>(value);
		}

		public JournalNotification()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
