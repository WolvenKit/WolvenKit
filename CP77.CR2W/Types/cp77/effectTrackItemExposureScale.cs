using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemExposureScale : effectTrackItem
	{
		[Ordinal(0)]  [RED("fadeOutAngle")] public CFloat FadeOutAngle { get; set; }
		[Ordinal(1)]  [RED("fadeOutRadius")] public CFloat FadeOutRadius { get; set; }
		[Ordinal(2)]  [RED("fullEffectRadius")] public CFloat FullEffectRadius { get; set; }
		[Ordinal(3)]  [RED("fullyVisibleAngle")] public CFloat FullyVisibleAngle { get; set; }
		[Ordinal(4)]  [RED("scale")] public effectEffectParameterEvaluatorFloat Scale { get; set; }
		[Ordinal(5)]  [RED("useInitialCameraPosDirForFadeout")] public CBool UseInitialCameraPosDirForFadeout { get; set; }

		public effectTrackItemExposureScale(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
