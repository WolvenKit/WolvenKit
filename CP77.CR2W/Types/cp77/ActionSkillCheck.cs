using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ActionSkillCheck : ActionBool
	{
		[Ordinal(0)]  [RED("availableUnpowered")] public CBool AvailableUnpowered { get; set; }
		[Ordinal(1)]  [RED("localizedName")] public CString LocalizedName { get; set; }
		[Ordinal(2)]  [RED("skillCheck")] public CHandle<SkillCheckBase> SkillCheck { get; set; }
		[Ordinal(3)]  [RED("skillCheckName")] public CEnum<EDeviceChallengeSkill> SkillCheckName { get; set; }
		[Ordinal(4)]  [RED("skillcheckDescription")] public UIInteractionSkillCheck SkillcheckDescription { get; set; }
		[Ordinal(5)]  [RED("wasPassed")] public CBool WasPassed { get; set; }

		public ActionSkillCheck(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
