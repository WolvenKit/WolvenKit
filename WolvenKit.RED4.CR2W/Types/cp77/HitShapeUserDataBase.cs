using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitShapeUserDataBase : gameHitShapeUserData
	{
		[Ordinal(0)] [RED("hitShapeTag")] public CName HitShapeTag { get; set; }
		[Ordinal(1)] [RED("hitShapeType")] public CEnum<EHitShapeType> HitShapeType { get; set; }
		[Ordinal(2)] [RED("hitReactionZone")] public CEnum<EHitReactionZone> HitReactionZone { get; set; }
		[Ordinal(3)] [RED("dismembermentPart")] public CEnum<EAIDismembermentBodyPart> DismembermentPart { get; set; }
		[Ordinal(4)] [RED("isProtectionLayer")] public CBool IsProtectionLayer { get; set; }
		[Ordinal(5)] [RED("isInternalWeakspot")] public CBool IsInternalWeakspot { get; set; }
		[Ordinal(6)] [RED("hitShapeDamageMod")] public CFloat HitShapeDamageMod { get; set; }

		public HitShapeUserDataBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
