using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questvehicleOnSplineParams : questVehicleSpecificCommandParams
	{
		[Ordinal(3)] [RED("splineRef")] public NodeRef SplineRef { get; set; }
		[Ordinal(4)] [RED("reverseSpline")] public CBool ReverseSpline { get; set; }
		[Ordinal(5)] [RED("backwards")] public CBool Backwards { get; set; }
		[Ordinal(6)] [RED("closest")] public CBool Closest { get; set; }
		[Ordinal(7)] [RED("forcedStartSpeed")] public CFloat ForcedStartSpeed { get; set; }
		[Ordinal(8)] [RED("stopAtEnd")] public CBool StopAtEnd { get; set; }
		[Ordinal(9)] [RED("keepDistance")] public CBool KeepDistance { get; set; }
		[Ordinal(10)] [RED("keepDistanceParam")] public CHandle<questParamKeepDistance> KeepDistanceParam { get; set; }
		[Ordinal(11)] [RED("rubberBanding")] public CBool RubberBanding { get; set; }
		[Ordinal(12)] [RED("rubberBandingParam")] public CHandle<questParamRubberbanding> RubberBandingParam { get; set; }

		public questvehicleOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
