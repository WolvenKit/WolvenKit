using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SDeviceActionData : CVariable
	{
		[Ordinal(0)]  [RED("attachedToSkillCheck")] public CEnum<EDeviceChallengeSkill> AttachedToSkillCheck { get; set; }
		[Ordinal(1)]  [RED("currentDisplayName")] public CName CurrentDisplayName { get; set; }
		[Ordinal(2)]  [RED("hasInteraction")] public CBool HasInteraction { get; set; }
		[Ordinal(3)]  [RED("hasUI")] public CBool HasUI { get; set; }
		[Ordinal(4)]  [RED("interactionRecord")] public CString InteractionRecord { get; set; }
		[Ordinal(5)]  [RED("isQuickHack")] public CBool IsQuickHack { get; set; }
		[Ordinal(6)]  [RED("isSpiderbotAction")] public CBool IsSpiderbotAction { get; set; }
		[Ordinal(7)]  [RED("objectActionRecord")] public TweakDBID ObjectActionRecord { get; set; }
		[Ordinal(8)]  [RED("spiderbotLocationOverrideReference")] public NodeRef SpiderbotLocationOverrideReference { get; set; }
		[Ordinal(9)]  [RED("widgetRecord")] public TweakDBID WidgetRecord { get; set; }

		public SDeviceActionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
