using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIMenuNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] 
		[RED("animContainer")] 
		public CWeakHandle<inGameMenuAnimContainer> AnimContainer
		{
			get => GetPropertyValue<CWeakHandle<inGameMenuAnimContainer>>();
			set => SetPropertyValue<CWeakHandle<inGameMenuAnimContainer>>(value);
		}

		[Ordinal(6)] 
		[RED("notificationType")] 
		public CEnum<UIMenuNotificationType> NotificationType
		{
			get => GetPropertyValue<CEnum<UIMenuNotificationType>>();
			set => SetPropertyValue<CEnum<UIMenuNotificationType>>(value);
		}

		public UIMenuNotificationViewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
