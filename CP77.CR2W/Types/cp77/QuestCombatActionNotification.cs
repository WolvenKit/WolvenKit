using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestCombatActionNotification : QuestSecuritySystemInput
	{
		[Ordinal(0)]  [RED("notificationScope")] public CEnum<SecurityEventScopeSettings> NotificationScope { get; set; }
		[Ordinal(1)]  [RED("notifySpecificNPCs")] public CArray<NPCReference> NotifySpecificNPCs { get; set; }
		[Ordinal(2)]  [RED("revealPlayerSettings")] public RevealPlayerSettings RevealPlayerSettings { get; set; }

		public QuestCombatActionNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
