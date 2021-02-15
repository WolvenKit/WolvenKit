using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSceneTier_ConditionType : questISceneConditionType
	{
		[Ordinal(0)] [RED("tier")] public CEnum<GameplayTier> Tier { get; set; }
		[Ordinal(1)] [RED("isInverted")] public CBool IsInverted { get; set; }

		public questSceneTier_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
