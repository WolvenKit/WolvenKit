using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInGameNotificationEvent : redEvent
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

		public UIInGameNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
