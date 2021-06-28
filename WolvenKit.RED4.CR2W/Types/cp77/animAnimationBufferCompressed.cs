using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimationBufferCompressed : animIAnimationBuffer
	{
		private CFloat _duration;
		private CUInt32 _numFrames;
		private CUInt8 _numExtraJoints;
		private CUInt8 _numExtraTracks;
		private CUInt16 _numJoints;
		private CUInt16 _numTracks;
		private CUInt32 _numAnimKeys;
		private CUInt32 _numAnimKeysRaw;
		private CUInt32 _numConstAnimKeys;
		private CUInt32 _numTrackKeys;
		private CUInt32 _numConstTrackKeys;
		private CBool _isScaleConstant;
		private CBool _hasRawRotations;
		private animAnimFallbackFrameDesc _fallbackFrameDesc;
		private DataBuffer _fallbackFrameBuffer;
		private serializationDeferredDataBuffer _defferedBuffer;
		private animAnimDataAddress _dataAddress;
		private CArray<CName> _extraDataNames;
		private DataBuffer _inplaceCompressedBuffer;

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
		[RED("numAnimKeys")] 
		public CUInt32 NumAnimKeys
		{
			get => GetProperty(ref _numAnimKeys);
			set => SetProperty(ref _numAnimKeys, value);
		}

		[Ordinal(7)] 
		[RED("numAnimKeysRaw")] 
		public CUInt32 NumAnimKeysRaw
		{
			get => GetProperty(ref _numAnimKeysRaw);
			set => SetProperty(ref _numAnimKeysRaw, value);
		}

		[Ordinal(8)] 
		[RED("numConstAnimKeys")] 
		public CUInt32 NumConstAnimKeys
		{
			get => GetProperty(ref _numConstAnimKeys);
			set => SetProperty(ref _numConstAnimKeys, value);
		}

		[Ordinal(9)] 
		[RED("numTrackKeys")] 
		public CUInt32 NumTrackKeys
		{
			get => GetProperty(ref _numTrackKeys);
			set => SetProperty(ref _numTrackKeys, value);
		}

		[Ordinal(10)] 
		[RED("numConstTrackKeys")] 
		public CUInt32 NumConstTrackKeys
		{
			get => GetProperty(ref _numConstTrackKeys);
			set => SetProperty(ref _numConstTrackKeys, value);
		}

		[Ordinal(11)] 
		[RED("isScaleConstant")] 
		public CBool IsScaleConstant
		{
			get => GetProperty(ref _isScaleConstant);
			set => SetProperty(ref _isScaleConstant, value);
		}

		[Ordinal(12)] 
		[RED("hasRawRotations")] 
		public CBool HasRawRotations
		{
			get => GetProperty(ref _hasRawRotations);
			set => SetProperty(ref _hasRawRotations, value);
		}

		[Ordinal(13)] 
		[RED("fallbackFrameDesc")] 
		public animAnimFallbackFrameDesc FallbackFrameDesc
		{
			get => GetProperty(ref _fallbackFrameDesc);
			set => SetProperty(ref _fallbackFrameDesc, value);
		}

		[Ordinal(14)] 
		[RED("fallbackFrameBuffer")] 
		public DataBuffer FallbackFrameBuffer
		{
			get => GetProperty(ref _fallbackFrameBuffer);
			set => SetProperty(ref _fallbackFrameBuffer, value);
		}

		[Ordinal(15)] 
		[RED("defferedBuffer")] 
		public serializationDeferredDataBuffer DefferedBuffer
		{
			get => GetProperty(ref _defferedBuffer);
			set => SetProperty(ref _defferedBuffer, value);
		}

		[Ordinal(16)] 
		[RED("dataAddress")] 
		public animAnimDataAddress DataAddress
		{
			get => GetProperty(ref _dataAddress);
			set => SetProperty(ref _dataAddress, value);
		}

		[Ordinal(17)] 
		[RED("extraDataNames")] 
		public CArray<CName> ExtraDataNames
		{
			get => GetProperty(ref _extraDataNames);
			set => SetProperty(ref _extraDataNames, value);
		}

		[Ordinal(18)] 
		[RED("inplaceCompressedBuffer")] 
		public DataBuffer InplaceCompressedBuffer
		{
			get => GetProperty(ref _inplaceCompressedBuffer);
			set => SetProperty(ref _inplaceCompressedBuffer, value);
		}

		public animAnimationBufferCompressed(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
