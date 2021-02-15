using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animfssBodyOfflineParams : CVariable
	{
		[Ordinal(0)] [RED("HipsTilt")] public CFloat HipsTilt { get; set; }
		[Ordinal(1)] [RED("HipsShift")] public CFloat HipsShift { get; set; }
		[Ordinal(2)] [RED("LegsPullFactorMin")] public CFloat LegsPullFactorMin { get; set; }
		[Ordinal(3)] [RED("LegsPullFactorMax")] public CFloat LegsPullFactorMax { get; set; }
		[Ordinal(4)] [RED("LegLengthAdjustment")] public CFloat LegLengthAdjustment { get; set; }
		[Ordinal(5)] [RED("LegMaxStretchOffset")] public CFloat LegMaxStretchOffset { get; set; }
		[Ordinal(6)] [RED("LegMaxStretchAdjustment")] public CFloat LegMaxStretchAdjustment { get; set; }

		public animfssBodyOfflineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
