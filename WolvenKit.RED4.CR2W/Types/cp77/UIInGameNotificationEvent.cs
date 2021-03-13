using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInGameNotificationEvent : redEvent
	{
		[Ordinal(0)] [RED("notificationType")] public CEnum<UIInGameNotificationType> NotificationType { get; set; }
		[Ordinal(1)] [RED("additionalInfo")] public CVariant AdditionalInfo { get; set; }

		public UIInGameNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
