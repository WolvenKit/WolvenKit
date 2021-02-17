using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameHitShapeBVH : CVariable
	{
		[Ordinal(0)] [RED("nodeName")] public CName NodeName { get; set; }
		[Ordinal(1)] [RED("childrenNodes")] public CArray<gameHitShapeBVH> ChildrenNodes { get; set; }
		[Ordinal(2)] [RED("childrenShapeNames")] public CArray<CName> ChildrenShapeNames { get; set; }

		public gameHitShapeBVH(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
