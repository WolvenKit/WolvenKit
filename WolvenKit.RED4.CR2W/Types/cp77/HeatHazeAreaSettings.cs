using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HeatHazeAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("effectStrength")] public curveData<CFloat> EffectStrength { get; set; }
		[Ordinal(3)] [RED("startDistance")] public curveData<CFloat> StartDistance { get; set; }
		[Ordinal(4)] [RED("maxDistance")] public curveData<CFloat> MaxDistance { get; set; }
		[Ordinal(5)] [RED("patternScale")] public curveData<CFloat> PatternScale { get; set; }
		[Ordinal(6)] [RED("movementSpeedScale")] public curveData<CFloat> MovementSpeedScale { get; set; }

		public HeatHazeAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
