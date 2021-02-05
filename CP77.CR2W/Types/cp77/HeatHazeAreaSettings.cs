using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HeatHazeAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("effectStrength")] public curveData<CFloat> EffectStrength { get; set; }
		[Ordinal(1)]  [RED("startDistance")] public curveData<CFloat> StartDistance { get; set; }
		[Ordinal(2)]  [RED("maxDistance")] public curveData<CFloat> MaxDistance { get; set; }
		[Ordinal(3)]  [RED("patternScale")] public curveData<CFloat> PatternScale { get; set; }
		[Ordinal(4)]  [RED("movementSpeedScale")] public curveData<CFloat> MovementSpeedScale { get; set; }

		public HeatHazeAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
