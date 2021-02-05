using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldOffMeshConnectionNode : worldSplineNode
	{
		[Ordinal(0)]  [RED("isBidirectional")] public CBool IsBidirectional { get; set; }
		[Ordinal(1)]  [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<worldOffMeshConnectionType> Type { get; set; }
		[Ordinal(3)]  [RED("tags")] public CArray<CName> Tags { get; set; }

		public worldOffMeshConnectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
