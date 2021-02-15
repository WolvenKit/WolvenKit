using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterControlledObjectHit_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] [RED("attackerRef")] public gameEntityReference AttackerRef { get; set; }
		[Ordinal(1)] [RED("targetRef")] public gameEntityReference TargetRef { get; set; }
		[Ordinal(2)] [RED("isTargetPlayer")] public CBool IsTargetPlayer { get; set; }
		[Ordinal(3)] [RED("includeHitTypes")] public CArray<CEnum<questCharacterHitEventType>> IncludeHitTypes { get; set; }
		[Ordinal(4)] [RED("excludeHitTypes")] public CArray<CEnum<questCharacterHitEventType>> ExcludeHitTypes { get; set; }
		[Ordinal(5)] [RED("includeHitShapes")] public CArray<CName> IncludeHitShapes { get; set; }
		[Ordinal(6)] [RED("excludeHitShapes")] public CArray<CName> ExcludeHitShapes { get; set; }

		public questCharacterControlledObjectHit_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
