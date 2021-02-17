using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerRequirementItemLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("requirementNameText")] public inkTextWidgetReference RequirementNameText { get; set; }
		[Ordinal(2)] [RED("requirementLevelText")] public inkTextWidgetReference RequirementLevelText { get; set; }
		[Ordinal(3)] [RED("requirementIcon")] public inkImageWidgetReference RequirementIcon { get; set; }
		[Ordinal(4)] [RED("requirementStruct")] public UIInteractionSkillCheck RequirementStruct { get; set; }
		[Ordinal(5)] [RED("skillCheck")] public CEnum<EDeviceChallengeSkill> SkillCheck { get; set; }

		public ScannerRequirementItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
