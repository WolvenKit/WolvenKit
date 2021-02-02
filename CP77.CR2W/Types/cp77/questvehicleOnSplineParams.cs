using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questvehicleOnSplineParams : questVehicleSpecificCommandParams
	{
		[Ordinal(0)]  [RED("splineRef")] public NodeRef SplineRef { get; set; }
		[Ordinal(1)]  [RED("reverseSpline")] public CBool ReverseSpline { get; set; }
		[Ordinal(2)]  [RED("backwards")] public CBool Backwards { get; set; }
		[Ordinal(3)]  [RED("closest")] public CBool Closest { get; set; }
		[Ordinal(4)]  [RED("forcedStartSpeed")] public CFloat ForcedStartSpeed { get; set; }
		[Ordinal(5)]  [RED("stopAtEnd")] public CBool StopAtEnd { get; set; }
		[Ordinal(6)]  [RED("keepDistance")] public CBool KeepDistance { get; set; }
		[Ordinal(7)]  [RED("keepDistanceParam")] public CHandle<questParamKeepDistance> KeepDistanceParam { get; set; }
		[Ordinal(8)]  [RED("rubberBanding")] public CBool RubberBanding { get; set; }
		[Ordinal(9)]  [RED("rubberBandingParam")] public CHandle<questParamRubberbanding> RubberBandingParam { get; set; }

		public questvehicleOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
