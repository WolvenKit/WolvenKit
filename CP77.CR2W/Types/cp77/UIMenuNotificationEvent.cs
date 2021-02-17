using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UIMenuNotificationEvent : redEvent
	{
		[Ordinal(0)] [RED("notificationType")] public CEnum<UIMenuNotificationType> NotificationType { get; set; }
		[Ordinal(1)] [RED("additionalInfo")] public CVariant AdditionalInfo { get; set; }

		public UIMenuNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
