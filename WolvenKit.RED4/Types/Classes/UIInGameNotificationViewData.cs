using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInGameNotificationViewData : gameuiGenericNotificationViewData
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
		public CEnum<UIInGameNotificationType> NotificationType
		{
			get => GetPropertyValue<CEnum<UIInGameNotificationType>>();
			set => SetPropertyValue<CEnum<UIInGameNotificationType>>(value);
		}

		public UIInGameNotificationViewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
