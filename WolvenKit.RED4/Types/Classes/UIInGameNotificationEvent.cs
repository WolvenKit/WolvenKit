using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInGameNotificationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("notificationType")] 
		public CEnum<UIInGameNotificationType> NotificationType
		{
			get => GetPropertyValue<CEnum<UIInGameNotificationType>>();
			set => SetPropertyValue<CEnum<UIInGameNotificationType>>(value);
		}

		[Ordinal(1)] 
		[RED("animContainer")] 
		public CWeakHandle<inGameMenuAnimContainer> AnimContainer
		{
			get => GetPropertyValue<CWeakHandle<inGameMenuAnimContainer>>();
			set => SetPropertyValue<CWeakHandle<inGameMenuAnimContainer>>(value);
		}

		[Ordinal(2)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("overrideCurrentNotification")] 
		public CBool OverrideCurrentNotification
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UIInGameNotificationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
