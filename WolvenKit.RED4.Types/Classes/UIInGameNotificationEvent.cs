using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIInGameNotificationEvent : redEvent
	{
		private CEnum<UIInGameNotificationType> _notificationType;
		private CVariant _additionalInfo;

		[Ordinal(0)] 
		[RED("notificationType")] 
		public CEnum<UIInGameNotificationType> NotificationType
		{
			get => GetProperty(ref _notificationType);
			set => SetProperty(ref _notificationType, value);
		}

		[Ordinal(1)] 
		[RED("additionalInfo")] 
		public CVariant AdditionalInfo
		{
			get => GetProperty(ref _additionalInfo);
			set => SetProperty(ref _additionalInfo, value);
		}
	}
}
