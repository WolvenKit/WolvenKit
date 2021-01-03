using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animfssBodyOfflineParams : CVariable
	{
		[Ordinal(0)]  [RED("HipsShift")] public CFloat HipsShift { get; set; }
		[Ordinal(1)]  [RED("HipsTilt")] public CFloat HipsTilt { get; set; }
		[Ordinal(2)]  [RED("LegLengthAdjustment")] public CFloat LegLengthAdjustment { get; set; }
		[Ordinal(3)]  [RED("LegMaxStretchAdjustment")] public CFloat LegMaxStretchAdjustment { get; set; }
		[Ordinal(4)]  [RED("LegMaxStretchOffset")] public CFloat LegMaxStretchOffset { get; set; }
		[Ordinal(5)]  [RED("LegsPullFactorMax")] public CFloat LegsPullFactorMax { get; set; }
		[Ordinal(6)]  [RED("LegsPullFactorMin")] public CFloat LegsPullFactorMin { get; set; }

		public animfssBodyOfflineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
