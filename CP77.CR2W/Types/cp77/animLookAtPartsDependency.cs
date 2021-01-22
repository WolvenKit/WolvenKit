using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animLookAtPartsDependency : CVariable
	{
		[Ordinal(0)]  [RED("angle")] public CFloat Angle { get; set; }
		[Ordinal(1)]  [RED("horizontalPullSpeedByAngleCurve")] public curveData<CFloat> HorizontalPullSpeedByAngleCurve { get; set; }
		[Ordinal(2)]  [RED("horizontalPullSpeedFactor")] public CFloat HorizontalPullSpeedFactor { get; set; }
		[Ordinal(3)]  [RED("innerSquareScale")] public CFloat InnerSquareScale { get; set; }
		[Ordinal(4)]  [RED("masterPart")] public CName MasterPart { get; set; }
		[Ordinal(5)]  [RED("pullScaleBySquareSizeCurve")] public curveData<CFloat> PullScaleBySquareSizeCurve { get; set; }
		[Ordinal(6)]  [RED("pullScaleBySquareSizeFactor")] public CFloat PullScaleBySquareSizeFactor { get; set; }
		[Ordinal(7)]  [RED("slavePart")] public CName SlavePart { get; set; }
		[Ordinal(8)]  [RED("speedToTargetByAngleCurve")] public curveData<CFloat> SpeedToTargetByAngleCurve { get; set; }
		[Ordinal(9)]  [RED("speedToTargetFactor")] public CFloat SpeedToTargetFactor { get; set; }
		[Ordinal(10)]  [RED("verticalPullSpeedByAngleCurve")] public curveData<CFloat> VerticalPullSpeedByAngleCurve { get; set; }
		[Ordinal(11)]  [RED("verticalPullSpeedFactor")] public CFloat VerticalPullSpeedFactor { get; set; }

		public animLookAtPartsDependency(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
