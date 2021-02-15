using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimationBufferSimd : animIAnimationBuffer
	{
		[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)] [RED("numFrames")] public CUInt32 NumFrames { get; set; }
		[Ordinal(2)] [RED("numExtraJoints")] public CUInt8 NumExtraJoints { get; set; }
		[Ordinal(3)] [RED("numExtraTracks")] public CUInt8 NumExtraTracks { get; set; }
		[Ordinal(4)] [RED("numJoints")] public CUInt16 NumJoints { get; set; }
		[Ordinal(5)] [RED("numTracks")] public CUInt16 NumTracks { get; set; }
		[Ordinal(6)] [RED("numTranslationsToCopy")] public CUInt16 NumTranslationsToCopy { get; set; }
		[Ordinal(7)] [RED("numTranslationsToEvalAlignedToSimd")] public CUInt16 NumTranslationsToEvalAlignedToSimd { get; set; }
		[Ordinal(8)] [RED("quantizationBits")] public CUInt16 QuantizationBits { get; set; }
		[Ordinal(9)] [RED("isScaleConstant")] public CBool IsScaleConstant { get; set; }
		[Ordinal(10)] [RED("isTrackConstant")] public CBool IsTrackConstant { get; set; }
		[Ordinal(11)] [RED("defferedBuffer")] public serializationDeferredDataBuffer DefferedBuffer { get; set; }
		[Ordinal(12)] [RED("inplaceCompressedBuffer")] public DataBuffer InplaceCompressedBuffer { get; set; }
		[Ordinal(13)] [RED("fallbackFrameDesc")] public animAnimFallbackFrameDesc FallbackFrameDesc { get; set; }
		[Ordinal(14)] [RED("fallbackFrameBuffer")] public DataBuffer FallbackFrameBuffer { get; set; }
		[Ordinal(15)] [RED("extraDataNames")] public CArray<CName> ExtraDataNames { get; set; }

		public animAnimationBufferSimd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
