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
