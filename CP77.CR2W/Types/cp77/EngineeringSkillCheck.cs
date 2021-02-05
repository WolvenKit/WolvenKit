using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EngineeringSkillCheck : SkillCheckBase
	{
		[Ordinal(0)]  [RED("alternativeName")] public TweakDBID AlternativeName { get; set; }
		[Ordinal(1)]  [RED("difficulty")] public CEnum<EGameplayChallengeLevel> Difficulty { get; set; }
		[Ordinal(2)]  [RED("additionalRequirements")] public CHandle<GameplayConditionContainer> AdditionalRequirements { get; set; }
		[Ordinal(3)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(4)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(5)]  [RED("wasPassed")] public CBool WasPassed { get; set; }
		[Ordinal(6)]  [RED("skillCheckPerformed")] public CBool SkillCheckPerformed { get; set; }
		[Ordinal(7)]  [RED("skillToCheck")] public CEnum<EDeviceChallengeSkill> SkillToCheck { get; set; }
		[Ordinal(8)]  [RED("baseSkill")] public CHandle<GameplaySkillCondition> BaseSkill { get; set; }
		[Ordinal(9)]  [RED("isDynamic")] public CBool IsDynamic { get; set; }

		public EngineeringSkillCheck(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
