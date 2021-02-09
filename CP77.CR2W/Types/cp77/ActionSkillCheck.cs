using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ActionSkillCheck : ActionBool
	{
		[Ordinal(22)]  [RED("skillCheck")] public CHandle<SkillCheckBase> SkillCheck { get; set; }
		[Ordinal(23)]  [RED("skillCheckName")] public CEnum<EDeviceChallengeSkill> SkillCheckName { get; set; }
		[Ordinal(24)]  [RED("localizedName")] public CString LocalizedName { get; set; }
		[Ordinal(25)]  [RED("skillcheckDescription")] public UIInteractionSkillCheck SkillcheckDescription { get; set; }
		[Ordinal(26)]  [RED("wasPassed")] public CBool WasPassed { get; set; }
		[Ordinal(27)]  [RED("availableUnpowered")] public CBool AvailableUnpowered { get; set; }

		public ActionSkillCheck(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
