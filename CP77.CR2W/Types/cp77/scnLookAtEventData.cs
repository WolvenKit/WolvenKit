using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnLookAtEventData : CVariable
	{
		[Ordinal(0)] [RED("id")] public CUInt32 Id { get; set; }
		[Ordinal(1)] [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(2)] [RED("singleBodyPartName")] public CName SingleBodyPartName { get; set; }
		[Ordinal(3)] [RED("singleTargetSlot")] public CName SingleTargetSlot { get; set; }
		[Ordinal(4)] [RED("bodyTargetSlot")] public CName BodyTargetSlot { get; set; }
		[Ordinal(5)] [RED("headTargetSlot")] public CName HeadTargetSlot { get; set; }
		[Ordinal(6)] [RED("eyesTargetSlot")] public CName EyesTargetSlot { get; set; }
		[Ordinal(7)] [RED("singleWeight")] public CFloat SingleWeight { get; set; }
		[Ordinal(8)] [RED("bodyWeight")] public CFloat BodyWeight { get; set; }
		[Ordinal(9)] [RED("headWeight")] public CFloat HeadWeight { get; set; }
		[Ordinal(10)] [RED("eyesWeight")] public CFloat EyesWeight { get; set; }
		[Ordinal(11)] [RED("useSingleWeightCurve")] public CBool UseSingleWeightCurve { get; set; }
		[Ordinal(12)] [RED("useBodyWeightCurve")] public CBool UseBodyWeightCurve { get; set; }
		[Ordinal(13)] [RED("useHeadWeightCurve")] public CBool UseHeadWeightCurve { get; set; }
		[Ordinal(14)] [RED("useEyesWeightCurve")] public CBool UseEyesWeightCurve { get; set; }
		[Ordinal(15)] [RED("singleWeightCurve")] public curveData<CFloat> SingleWeightCurve { get; set; }
		[Ordinal(16)] [RED("bodyWeightCurve")] public curveData<CFloat> BodyWeightCurve { get; set; }
		[Ordinal(17)] [RED("headWeightCurve")] public curveData<CFloat> HeadWeightCurve { get; set; }
		[Ordinal(18)] [RED("eyesWeightCurve")] public curveData<CFloat> EyesWeightCurve { get; set; }
		[Ordinal(19)] [RED("singleLimits")] public animLookAtLimits SingleLimits { get; set; }
		[Ordinal(20)] [RED("bodyLimits")] public animLookAtLimits BodyLimits { get; set; }
		[Ordinal(21)] [RED("headLimits")] public animLookAtLimits HeadLimits { get; set; }
		[Ordinal(22)] [RED("eyesLimits")] public animLookAtLimits EyesLimits { get; set; }

		public scnLookAtEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
