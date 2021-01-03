using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UIMenuNotificationEvent : redEvent
	{
		[Ordinal(0)]  [RED("additionalInfo")] public CVariant AdditionalInfo { get; set; }
		[Ordinal(1)]  [RED("notificationType")] public CEnum<UIMenuNotificationType> NotificationType { get; set; }

		public UIMenuNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
