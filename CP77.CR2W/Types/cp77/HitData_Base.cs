using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitData_Base : gameHitShapeUserData
	{
		[Ordinal(0)] [RED("hitShapeTag")] public CName HitShapeTag { get; set; }
		[Ordinal(1)] [RED("bodyPartStatPoolName")] public CName BodyPartStatPoolName { get; set; }
		[Ordinal(2)] [RED("hitShapeType")] public CEnum<HitShape_Type> HitShapeType { get; set; }

		public HitData_Base(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
