using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInteractionSkillCheck : CVariable
	{
		[Ordinal(0)] [RED("isValid")] public CBool IsValid { get; set; }
		[Ordinal(1)] [RED("skillCheck")] public CEnum<EDeviceChallengeSkill> SkillCheck { get; set; }
		[Ordinal(2)] [RED("skillName")] public CString SkillName { get; set; }
		[Ordinal(3)] [RED("requiredSkill")] public CInt32 RequiredSkill { get; set; }
		[Ordinal(4)] [RED("playerSkill")] public CInt32 PlayerSkill { get; set; }
		[Ordinal(5)] [RED("actionDisplayName")] public CString ActionDisplayName { get; set; }
		[Ordinal(6)] [RED("hasAdditionalRequirements")] public CBool HasAdditionalRequirements { get; set; }
		[Ordinal(7)] [RED("additionalReqOperator")] public CEnum<ELogicOperator> AdditionalReqOperator { get; set; }
		[Ordinal(8)] [RED("additionalRequirements")] public CArray<ConditionData> AdditionalRequirements { get; set; }
		[Ordinal(9)] [RED("isPassed")] public CBool IsPassed { get; set; }
		[Ordinal(10)] [RED("ownerID")] public entEntityID OwnerID { get; set; }

		public UIInteractionSkillCheck(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
