using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MakeNotificationQueueSilentEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("notificationType")] 
		public CEnum<GenericNotificationType> NotificationType
		{
			get => GetPropertyValue<CEnum<GenericNotificationType>>();
			set => SetPropertyValue<CEnum<GenericNotificationType>>(value);
		}

		[Ordinal(1)] 
		[RED("makeSilent")] 
		public CBool MakeSilent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MakeNotificationQueueSilentEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
