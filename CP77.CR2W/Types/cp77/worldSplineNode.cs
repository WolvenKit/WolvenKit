using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldSplineNode : worldSocketNode
	{
		[Ordinal(0)]  [RED("destSnapedNode")] public NodeRef DestSnapedNode { get; set; }
		[Ordinal(1)]  [RED("destSnapedSocketName")] public CName DestSnapedSocketName { get; set; }
		[Ordinal(2)]  [RED("entrySnapedNode")] public NodeRef EntrySnapedNode { get; set; }
		[Ordinal(3)]  [RED("entrySnapedSocketName")] public CName EntrySnapedSocketName { get; set; }
		[Ordinal(4)]  [RED("splineData")] public CHandle<Spline> SplineData { get; set; }

		public worldSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
