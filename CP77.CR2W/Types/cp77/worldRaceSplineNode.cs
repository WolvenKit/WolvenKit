using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldRaceSplineNode : worldSpeedSplineNode
	{
		[Ordinal(15)] [RED("offsets")] public CArray<worldRaceSplineNodeOffset> Offsets { get; set; }
		[Ordinal(16)] [RED("offsetDefault")] public CFloat OffsetDefault { get; set; }

		public worldRaceSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
