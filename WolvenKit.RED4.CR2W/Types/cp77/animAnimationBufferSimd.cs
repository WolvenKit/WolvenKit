using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimationBufferSimd : animIAnimationBuffer
	{
		private CFloat _duration;
		private CUInt32 _numFrames;
		private CUInt8 _numExtraJoints;
		private CUInt8 _numExtraTracks;
		private CUInt16 _numJoints;
		private CUInt16 _numTracks;
		private CUInt16 _numTranslationsToCopy;
		private CUInt16 _numTranslationsToEvalAlignedToSimd;
		private CUInt16 _quantizationBits;
		private CBool _isScaleConstant;
		private CBool _isTrackConstant;
		private animAnimDataAddress _dataAddress;
		private serializationDeferredDataBuffer _defferedBuffer;
		private DataBuffer _inplaceCompressedBuffer;
		private CArray<CUInt16> _fallbackFrameIndices;
		private CArray<CName> _extraDataNames;

		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(1)] 
		[RED("numFrames")] 
		public CUInt32 NumFrames
		{
			get => GetProperty(ref _numFrames);
			set => SetProperty(ref _numFrames, value);
		}

		[Ordinal(2)] 
		[RED("numExtraJoints")] 
		public CUInt8 NumExtraJoints
		{
			get => GetProperty(ref _numExtraJoints);
			set => SetProperty(ref _numExtraJoints, value);
		}

		[Ordinal(3)] 
		[RED("numExtraTracks")] 
		public CUInt8 NumExtraTracks
		{
			get => GetProperty(ref _numExtraTracks);
			set => SetProperty(ref _numExtraTracks, value);
		}

		[Ordinal(4)] 
		[RED("numJoints")] 
		public CUInt16 NumJoints
		{
			get => GetProperty(ref _numJoints);
			set => SetProperty(ref _numJoints, value);
		}

		[Ordinal(5)] 
		[RED("numTracks")] 
		public CUInt16 NumTracks
		{
			get => GetProperty(ref _numTracks);
			set => SetProperty(ref _numTracks, value);
		}

		[Ordinal(6)] 
		[RED("numTranslationsToCopy")] 
		public CUInt16 NumTranslationsToCopy
		{
			get => GetProperty(ref _numTranslationsToCopy);
			set => SetProperty(ref _numTranslationsToCopy, value);
		}

		[Ordinal(7)] 
		[RED("numTranslationsToEvalAlignedToSimd")] 
		public CUInt16 NumTranslationsToEvalAlignedToSimd
		{
			get => GetProperty(ref _numTranslationsToEvalAlignedToSimd);
			set => SetProperty(ref _numTranslationsToEvalAlignedToSimd, value);
		}

		[Ordinal(8)] 
		[RED("quantizationBits")] 
		public CUInt16 QuantizationBits
		{
			get => GetProperty(ref _quantizationBits);
			set => SetProperty(ref _quantizationBits, value);
		}

		[Ordinal(9)] 
		[RED("isScaleConstant")] 
		public CBool IsScaleConstant
		{
			get => GetProperty(ref _isScaleConstant);
			set => SetProperty(ref _isScaleConstant, value);
		}

		[Ordinal(10)] 
		[RED("isTrackConstant")] 
		public CBool IsTrackConstant
		{
			get => GetProperty(ref _isTrackConstant);
			set => SetProperty(ref _isTrackConstant, value);
		}

		[Ordinal(11)] 
		[RED("dataAddress")] 
		public animAnimDataAddress DataAddress
		{
			get => GetProperty(ref _dataAddress);
			set => SetProperty(ref _dataAddress, value);
		}

		[Ordinal(12)] 
		[RED("defferedBuffer")] 
		public serializationDeferredDataBuffer DefferedBuffer
		{
			get => GetProperty(ref _defferedBuffer);
			set => SetProperty(ref _defferedBuffer, value);
		}

		[Ordinal(13)] 
		[RED("inplaceCompressedBuffer")] 
		public DataBuffer InplaceCompressedBuffer
		{
			get => GetProperty(ref _inplaceCompressedBuffer);
			set => SetProperty(ref _inplaceCompressedBuffer, value);
		}

		[Ordinal(14)] 
		[RED("fallbackFrameIndices")] 
		public CArray<CUInt16> FallbackFrameIndices
		{
			get => GetProperty(ref _fallbackFrameIndices);
			set => SetProperty(ref _fallbackFrameIndices, value);
		}

		[Ordinal(15)] 
		[RED("extraDataNames")] 
		public CArray<CName> ExtraDataNames
		{
			get => GetProperty(ref _extraDataNames);
			set => SetProperty(ref _extraDataNames, value);
		}

		public animAnimationBufferSimd(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
