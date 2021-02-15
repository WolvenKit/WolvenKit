using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TargetNPCRarityHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] [RED("rarity")] public CEnum<gamedataNPCRarity> Rarity { get; set; }

		public TargetNPCRarityHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
