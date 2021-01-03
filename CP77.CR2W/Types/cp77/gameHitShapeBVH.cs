using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameHitShapeBVH : CVariable
	{
		[Ordinal(0)]  [RED("childrenNodes")] public CArray<gameHitShapeBVH> ChildrenNodes { get; set; }
		[Ordinal(1)]  [RED("childrenShapeNames")] public CArray<CName> ChildrenShapeNames { get; set; }
		[Ordinal(2)]  [RED("nodeName")] public CName NodeName { get; set; }

		public gameHitShapeBVH(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
