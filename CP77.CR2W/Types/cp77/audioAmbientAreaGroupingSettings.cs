using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAmbientAreaGroupingSettings : CVariable
	{
		[Ordinal(0)]  [RED("GroupCountTag")] public CName GroupCountTag { get; set; }
		[Ordinal(1)]  [RED("GroupCountRtpc")] public CName GroupCountRtpc { get; set; }
		[Ordinal(2)]  [RED("GroupAvgDistanceRtpc")] public CName GroupAvgDistanceRtpc { get; set; }
		[Ordinal(3)]  [RED("MinDistance")] public CFloat MinDistance { get; set; }
		[Ordinal(4)]  [RED("MaxDistance")] public CFloat MaxDistance { get; set; }
		[Ordinal(5)]  [RED("groupingVariant")] public CEnum<audioAmbientGroupingVariant> GroupingVariant { get; set; }

		public audioAmbientAreaGroupingSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
