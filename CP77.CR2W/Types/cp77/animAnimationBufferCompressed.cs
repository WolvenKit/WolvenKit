using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimationBufferCompressed : animIAnimationBuffer
	{
		[Ordinal(0)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)] [RED("numFrames")] public CUInt32 NumFrames { get; set; }
		[Ordinal(2)] [RED("numExtraJoints")] public CUInt8 NumExtraJoints { get; set; }
		[Ordinal(3)] [RED("numExtraTracks")] public CUInt8 NumExtraTracks { get; set; }
		[Ordinal(4)] [RED("numJoints")] public CUInt16 NumJoints { get; set; }
		[Ordinal(5)] [RED("numTracks")] public CUInt16 NumTracks { get; set; }
		[Ordinal(6)] [RED("numAnimKeys")] public CUInt32 NumAnimKeys { get; set; }
		[Ordinal(7)] [RED("numAnimKeysRaw")] public CUInt32 NumAnimKeysRaw { get; set; }
		[Ordinal(8)] [RED("numConstAnimKeys")] public CUInt32 NumConstAnimKeys { get; set; }
		[Ordinal(9)] [RED("numTrackKeys")] public CUInt32 NumTrackKeys { get; set; }
		[Ordinal(10)] [RED("numConstTrackKeys")] public CUInt32 NumConstTrackKeys { get; set; }
		[Ordinal(11)] [RED("isScaleConstant")] public CBool IsScaleConstant { get; set; }
		[Ordinal(12)] [RED("hasRawRotations")] public CBool HasRawRotations { get; set; }
		[Ordinal(13)] [RED("fallbackFrameDesc")] public animAnimFallbackFrameDesc FallbackFrameDesc { get; set; }
		[Ordinal(14)] [RED("fallbackFrameBuffer")] public DataBuffer FallbackFrameBuffer { get; set; }
		[Ordinal(15)] [RED("defferedBuffer")] public serializationDeferredDataBuffer DefferedBuffer { get; set; }
		[Ordinal(16)] [RED("dataAddress")] public animAnimDataAddress DataAddress { get; set; }
		[Ordinal(17)] [RED("extraDataNames")] public CArray<CName> ExtraDataNames { get; set; }
		[Ordinal(18)] [RED("inplaceCompressedBuffer")] public DataBuffer InplaceCompressedBuffer { get; set; }

		public animAnimationBufferCompressed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
