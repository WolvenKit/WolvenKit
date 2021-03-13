using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionSkillCheck : ActionBool
	{
		[Ordinal(25)] [RED("skillCheck")] public CHandle<SkillCheckBase> SkillCheck { get; set; }
		[Ordinal(26)] [RED("skillCheckName")] public CEnum<EDeviceChallengeSkill> SkillCheckName { get; set; }
		[Ordinal(27)] [RED("localizedName")] public CString LocalizedName { get; set; }
		[Ordinal(28)] [RED("skillcheckDescription")] public UIInteractionSkillCheck SkillcheckDescription { get; set; }
		[Ordinal(29)] [RED("wasPassed")] public CBool WasPassed { get; set; }
		[Ordinal(30)] [RED("availableUnpowered")] public CBool AvailableUnpowered { get; set; }

		public ActionSkillCheck(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
