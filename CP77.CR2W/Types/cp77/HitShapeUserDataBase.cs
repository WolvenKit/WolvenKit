using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HitShapeUserDataBase : gameHitShapeUserData
	{
		[Ordinal(0)]  [RED("dismembermentPart")] public CEnum<EAIDismembermentBodyPart> DismembermentPart { get; set; }
		[Ordinal(1)]  [RED("hitReactionZone")] public CEnum<EHitReactionZone> HitReactionZone { get; set; }
		[Ordinal(2)]  [RED("hitShapeDamageMod")] public CFloat HitShapeDamageMod { get; set; }
		[Ordinal(3)]  [RED("hitShapeTag")] public CName HitShapeTag { get; set; }
		[Ordinal(4)]  [RED("hitShapeType")] public CEnum<EHitShapeType> HitShapeType { get; set; }
		[Ordinal(5)]  [RED("isInternalWeakspot")] public CBool IsInternalWeakspot { get; set; }
		[Ordinal(6)]  [RED("isProtectionLayer")] public CBool IsProtectionLayer { get; set; }

		public HitShapeUserDataBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
