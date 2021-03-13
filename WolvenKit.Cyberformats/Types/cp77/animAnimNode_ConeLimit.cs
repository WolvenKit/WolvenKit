using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ConeLimit : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("coneTransform")] public animTransformIndex ConeTransform { get; set; }
		[Ordinal(13)] [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
		[Ordinal(14)] [RED("coneAxisLs")] public Vector3 ConeAxisLs { get; set; }
		[Ordinal(15)] [RED("coneAxisNormalizedLs")] public Vector3 ConeAxisNormalizedLs { get; set; }
		[Ordinal(16)] [RED("coneOffsetMs")] public Vector3 ConeOffsetMs { get; set; }
		[Ordinal(17)] [RED("coneOffsetMsLink")] public animVectorLink ConeOffsetMsLink { get; set; }
		[Ordinal(18)] [RED("marginEaseOutCurve")] public curveData<CFloat> MarginEaseOutCurve { get; set; }
		[Ordinal(19)] [RED("limit1")] public CFloat Limit1 { get; set; }
		[Ordinal(20)] [RED("limit1Link")] public animFloatLink Limit1Link { get; set; }
		[Ordinal(21)] [RED("limit1FloatTrack")] public animNamedTrackIndex Limit1FloatTrack { get; set; }
		[Ordinal(22)] [RED("paraboloidRadius1")] public CFloat ParaboloidRadius1 { get; set; }
		[Ordinal(23)] [RED("limit2")] public CFloat Limit2 { get; set; }
		[Ordinal(24)] [RED("limit2Link")] public animFloatLink Limit2Link { get; set; }
		[Ordinal(25)] [RED("limit2FloatTrack")] public animNamedTrackIndex Limit2FloatTrack { get; set; }
		[Ordinal(26)] [RED("paraboloidRadius2")] public CFloat ParaboloidRadius2 { get; set; }
		[Ordinal(27)] [RED("limit3")] public CFloat Limit3 { get; set; }
		[Ordinal(28)] [RED("limit3Link")] public animFloatLink Limit3Link { get; set; }
		[Ordinal(29)] [RED("limit3FloatTrack")] public animNamedTrackIndex Limit3FloatTrack { get; set; }
		[Ordinal(30)] [RED("paraboloidRadius3")] public CFloat ParaboloidRadius3 { get; set; }
		[Ordinal(31)] [RED("limit4")] public CFloat Limit4 { get; set; }
		[Ordinal(32)] [RED("limit4Link")] public animFloatLink Limit4Link { get; set; }
		[Ordinal(33)] [RED("limit4FloatTrack")] public animNamedTrackIndex Limit4FloatTrack { get; set; }
		[Ordinal(34)] [RED("paraboloidRadius4")] public CFloat ParaboloidRadius4 { get; set; }
		[Ordinal(35)] [RED("coneLimitReached")] public animNamedTrackIndex ConeLimitReached { get; set; }
		[Ordinal(36)] [RED("debug")] public CBool Debug { get; set; }
		[Ordinal(37)] [RED("colorfulCone")] public CBool ColorfulCone { get; set; }
		[Ordinal(38)] [RED("applyDebugConeScalling")] public CBool ApplyDebugConeScalling { get; set; }

		public animAnimNode_ConeLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
