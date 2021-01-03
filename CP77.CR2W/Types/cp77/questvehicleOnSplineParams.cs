using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questvehicleOnSplineParams : questVehicleSpecificCommandParams
	{
		[Ordinal(0)]  [RED("backwards")] public CBool Backwards { get; set; }
		[Ordinal(1)]  [RED("closest")] public CBool Closest { get; set; }
		[Ordinal(2)]  [RED("forcedStartSpeed")] public CFloat ForcedStartSpeed { get; set; }
		[Ordinal(3)]  [RED("keepDistance")] public CBool KeepDistance { get; set; }
		[Ordinal(4)]  [RED("keepDistanceParam")] public CHandle<questParamKeepDistance> KeepDistanceParam { get; set; }
		[Ordinal(5)]  [RED("reverseSpline")] public CBool ReverseSpline { get; set; }
		[Ordinal(6)]  [RED("rubberBanding")] public CBool RubberBanding { get; set; }
		[Ordinal(7)]  [RED("rubberBandingParam")] public CHandle<questParamRubberbanding> RubberBandingParam { get; set; }
		[Ordinal(8)]  [RED("splineRef")] public NodeRef SplineRef { get; set; }
		[Ordinal(9)]  [RED("stopAtEnd")] public CBool StopAtEnd { get; set; }

		public questvehicleOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
