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
		[RED("additionalInfo")] 
		public CVariant AdditionalInfo
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}

		public UIInGameNotificationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
