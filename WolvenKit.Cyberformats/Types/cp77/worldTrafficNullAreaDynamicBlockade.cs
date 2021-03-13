using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficNullAreaDynamicBlockade : CVariable
	{
		[Ordinal(0)] [RED("areaID")] public CUInt64 AreaID { get; set; }
		[Ordinal(1)] [RED("offmeshLinks")] public CArray<CUInt64> OffmeshLinks { get; set; }
		[Ordinal(2)] [RED("affectedTrafficLanes")] public CArray<worldTrafficLaneUID> AffectedTrafficLanes { get; set; }

		public worldTrafficNullAreaDynamicBlockade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
