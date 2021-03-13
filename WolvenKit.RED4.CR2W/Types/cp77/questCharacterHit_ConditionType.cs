using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterHit_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] [RED("attackerRef")] public gameEntityReference AttackerRef { get; set; }
		[Ordinal(1)] [RED("isAttackerPlayer")] public CBool IsAttackerPlayer { get; set; }
		[Ordinal(2)] [RED("targetRef")] public gameEntityReference TargetRef { get; set; }
		[Ordinal(3)] [RED("isTargetPlayer")] public CBool IsTargetPlayer { get; set; }
		[Ordinal(4)] [RED("includeHitTypes")] public CArray<CEnum<questCharacterHitEventType>> IncludeHitTypes { get; set; }
		[Ordinal(5)] [RED("excludeHitTypes")] public CArray<CEnum<questCharacterHitEventType>> ExcludeHitTypes { get; set; }
		[Ordinal(6)] [RED("includeHitShapes")] public CArray<CName> IncludeHitShapes { get; set; }
		[Ordinal(7)] [RED("excludeHitShapes")] public CArray<CName> ExcludeHitShapes { get; set; }

		public questCharacterHit_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
