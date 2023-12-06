using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MessengerNotification : GenericNotificationController
	{
		[Ordinal(16)] 
		[RED("messageText")] 
		public inkTextWidgetReference MessageText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("avatar")] 
		public inkImageWidgetReference Avatar
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("mappinIcon")] 
		public inkImageWidgetReference MappinIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("envelopIcon")] 
		public inkWidgetReference EnvelopIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("interactionsBlackboard")] 
		public CWeakHandle<gameIBlackboard> InteractionsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(22)] 
		[RED("deviceBlackboard")] 
		public CWeakHandle<gameIBlackboard> DeviceBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(23)] 
		[RED("contactsActiveCallback")] 
		public CHandle<redCallbackObject> ContactsActiveCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(24)] 
		[RED("messageData")] 
		public CHandle<gameuiPhoneMessageNotificationViewData> MessageData
		{
			get => GetPropertyValue<CHandle<gameuiPhoneMessageNotificationViewData>>();
			set => SetPropertyValue<CHandle<gameuiPhoneMessageNotificationViewData>>(value);
		}

		[Ordinal(25)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(26)] 
		[RED("textSizeLimit")] 
		public CInt32 TextSizeLimit
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(27)] 
		[RED("journalMgr")] 
		public CWeakHandle<gameJournalManager> JournalMgr
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(28)] 
		[RED("mappinSystem")] 
		public CWeakHandle<gamemappinsMappinSystem> MappinSystem
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsMappinSystem>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsMappinSystem>>(value);
		}

		public MessengerNotification()
		{
			MessageText = new inkTextWidgetReference();
			Avatar = new inkImageWidgetReference();
			DescriptionText = new inkTextWidgetReference();
			MappinIcon = new inkImageWidgetReference();
			EnvelopIcon = new inkWidgetReference();
			TextSizeLimit = 40;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
