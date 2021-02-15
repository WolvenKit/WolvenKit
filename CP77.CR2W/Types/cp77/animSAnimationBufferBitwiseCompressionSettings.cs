using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animSAnimationBufferBitwiseCompressionSettings : CVariable
	{
		[Ordinal(0)] [RED("translationTolerance")] public CFloat TranslationTolerance { get; set; }
		[Ordinal(1)] [RED("translationSkipFrameTolerance")] public CFloat TranslationSkipFrameTolerance { get; set; }
		[Ordinal(2)] [RED("orientationTolerance")] public CFloat OrientationTolerance { get; set; }
		[Ordinal(3)] [RED("orientationCompressionMethod")] public CEnum<SAnimationBufferOrientationCompressionMethod> OrientationCompressionMethod { get; set; }
		[Ordinal(4)] [RED("orientationSkipFrameTolerance")] public CFloat OrientationSkipFrameTolerance { get; set; }
		[Ordinal(5)] [RED("scaleTolerance")] public CFloat ScaleTolerance { get; set; }
		[Ordinal(6)] [RED("scaleSkipFrameTolerance")] public CFloat ScaleSkipFrameTolerance { get; set; }
		[Ordinal(7)] [RED("trackTolerance")] public CFloat TrackTolerance { get; set; }
		[Ordinal(8)] [RED("trackSkipFrameTolerance")] public CFloat TrackSkipFrameTolerance { get; set; }

		public animSAnimationBufferBitwiseCompressionSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
