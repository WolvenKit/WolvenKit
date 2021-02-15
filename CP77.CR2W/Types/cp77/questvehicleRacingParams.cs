using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questvehicleRacingParams : questVehicleSpecificCommandParams
	{
		[Ordinal(3)] [RED("splineRef")] public NodeRef SplineRef { get; set; }
		[Ordinal(4)] [RED("preciseLevel")] public CFloat PreciseLevel { get; set; }
		[Ordinal(5)] [RED("reverseSpline")] public CBool ReverseSpline { get; set; }
		[Ordinal(6)] [RED("backwards")] public CBool Backwards { get; set; }
		[Ordinal(7)] [RED("closest")] public CBool Closest { get; set; }
		[Ordinal(8)] [RED("rubberBanding")] public CBool RubberBanding { get; set; }
		[Ordinal(9)] [RED("rubberBandingParam")] public CHandle<questParamRubberbanding> RubberBandingParam { get; set; }

		public questvehicleRacingParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
