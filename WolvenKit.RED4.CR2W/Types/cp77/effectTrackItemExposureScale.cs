using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemExposureScale : effectTrackItem
	{
		[Ordinal(3)] [RED("scale")] public effectEffectParameterEvaluatorFloat Scale { get; set; }
		[Ordinal(4)] [RED("useInitialCameraPosDirForFadeout")] public CBool UseInitialCameraPosDirForFadeout { get; set; }
		[Ordinal(5)] [RED("fullEffectRadius")] public CFloat FullEffectRadius { get; set; }
		[Ordinal(6)] [RED("fadeOutRadius")] public CFloat FadeOutRadius { get; set; }
		[Ordinal(7)] [RED("fullyVisibleAngle")] public CFloat FullyVisibleAngle { get; set; }
		[Ordinal(8)] [RED("fadeOutAngle")] public CFloat FadeOutAngle { get; set; }

		public effectTrackItemExposureScale(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
