using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIMenuNotificationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("notificationType")] 
		public CEnum<UIMenuNotificationType> NotificationType
		{
			get => GetPropertyValue<CEnum<UIMenuNotificationType>>();
			set => SetPropertyValue<CEnum<UIMenuNotificationType>>(value);
		}

		[Ordinal(1)] 
		[RED("additionalInfo")] 
		public CVariant AdditionalInfo
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}

		[Ordinal(2)] 
		[RED("animContainer")] 
		public CWeakHandle<inGameMenuAnimContainer> AnimContainer
		{
			get => GetPropertyValue<CWeakHandle<inGameMenuAnimContainer>>();
			set => SetPropertyValue<CWeakHandle<inGameMenuAnimContainer>>(value);
		}

		public UIMenuNotificationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
