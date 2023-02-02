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

		public UIMenuNotificationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
