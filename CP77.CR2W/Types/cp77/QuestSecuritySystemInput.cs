using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuestSecuritySystemInput : redEvent
	{
		[Ordinal(0)]  [RED("notificationScope")] public CEnum<SecurityEventScopeSettings> NotificationScope { get; set; }
		[Ordinal(1)]  [RED("notifySpecificNPCs")] public CArray<NPCReference> NotifySpecificNPCs { get; set; }
		[Ordinal(2)]  [RED("revealPlayerSettings")] public RevealPlayerSettings RevealPlayerSettings { get; set; }

		public QuestSecuritySystemInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
