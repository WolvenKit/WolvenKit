using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimationBufferCompressed : animIAnimationBuffer
	{
		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("numFrames")] 
		public CUInt32 NumFrames
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("numExtraJoints")] 
		public CUInt8 NumExtraJoints
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(3)] 
		[RED("numExtraTracks")] 
		public CUInt8 NumExtraTracks
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(4)] 
		[RED("numJoints")] 
		public CUInt16 NumJoints
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(5)] 
		[RED("numTracks")] 
		public CUInt16 NumTracks
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(6)] 
		[RED("numAnimKeys")] 
		public CUInt32 NumAnimKeys
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("numAnimKeysRaw")] 
		public CUInt32 NumAnimKeysRaw
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(8)] 
		[RED("numConstAnimKeys")] 
		public CUInt32 NumConstAnimKeys
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(9)] 
		[RED("numTrackKeys")] 
		public CUInt32 NumTrackKeys
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(10)] 
		[RED("numConstTrackKeys")] 
		public CUInt32 NumConstTrackKeys
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(11)] 
		[RED("isScaleConstant")] 
		public CBool IsScaleConstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("hasRawRotations")] 
		public CBool HasRawRotations
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("fallbackFrameIndices")] 
		public CArray<CUInt16> FallbackFrameIndices
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(14)] 
		[RED("defferedBuffer")] 
		public SerializationDeferredDataBuffer DefferedBuffer
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}

		[Ordinal(15)] 
		[RED("dataAddress")] 
		public animAnimDataAddress DataAddress
		{
			get => GetPropertyValue<animAnimDataAddress>();
			set => SetPropertyValue<animAnimDataAddress>(value);
		}

		[Ordinal(16)] 
		[RED("extraDataNames")] 
		public CArray<CName> ExtraDataNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(17)] 
		[RED("inplaceCompressedBuffer")] 
		public DataBuffer InplaceCompressedBuffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public animAnimationBufferCompressed()
		{
			FallbackFrameIndices = new();
			DataAddress = new() { UnkIndex = 4294967295, FsetInBytes = 4294967295, ZeInBytes = 4294967295 };
			ExtraDataNames = new();
		}
	}
}
