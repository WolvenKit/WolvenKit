using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animCAnimationBufferBitwiseCompressed : animIAnimationBuffer
	{
		[Ordinal(0)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("bones")] 
		public CArray<animSAnimationBufferBitwiseCompressedBoneTrack> Bones
		{
			get => GetPropertyValue<CArray<animSAnimationBufferBitwiseCompressedBoneTrack>>();
			set => SetPropertyValue<CArray<animSAnimationBufferBitwiseCompressedBoneTrack>>(value);
		}

		[Ordinal(2)] 
		[RED("tracks")] 
		public CArray<animSAnimationBufferBitwiseCompressedData> Tracks
		{
			get => GetPropertyValue<CArray<animSAnimationBufferBitwiseCompressedData>>();
			set => SetPropertyValue<CArray<animSAnimationBufferBitwiseCompressedData>>(value);
		}

		[Ordinal(3)] 
		[RED("data")] 
		public CArray<CInt8> Data
		{
			get => GetPropertyValue<CArray<CInt8>>();
			set => SetPropertyValue<CArray<CInt8>>(value);
		}

		[Ordinal(4)] 
		[RED("fallbackData")] 
		public CArray<CInt8> FallbackData
		{
			get => GetPropertyValue<CArray<CInt8>>();
			set => SetPropertyValue<CArray<CInt8>>(value);
		}

		[Ordinal(5)] 
		[RED("deferredData")] 
		public SerializationDeferredDataBuffer DeferredData
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}

		[Ordinal(6)] 
		[RED("orientationCompressionMethod")] 
		public CEnum<SAnimationBufferOrientationCompressionMethod> OrientationCompressionMethod
		{
			get => GetPropertyValue<CEnum<SAnimationBufferOrientationCompressionMethod>>();
			set => SetPropertyValue<CEnum<SAnimationBufferOrientationCompressionMethod>>(value);
		}

		[Ordinal(7)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("numFrames")] 
		public CUInt32 NumFrames
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(9)] 
		[RED("dt")] 
		public CFloat Dt
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("streamingOption")] 
		public CEnum<SAnimationBufferStreamingOption> StreamingOption
		{
			get => GetPropertyValue<CEnum<SAnimationBufferStreamingOption>>();
			set => SetPropertyValue<CEnum<SAnimationBufferStreamingOption>>(value);
		}

		[Ordinal(11)] 
		[RED("nonStreamableBones")] 
		public CUInt32 NonStreamableBones
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(12)] 
		[RED("extraDataNames")] 
		public CArray<CName> ExtraDataNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(13)] 
		[RED("numExtraBones")] 
		public CUInt32 NumExtraBones
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public animCAnimationBufferBitwiseCompressed()
		{
			Bones = new();
			Tracks = new();
			Data = new();
			FallbackData = new();
			Duration = 1.000000F;
			Dt = 0.033000F;
			ExtraDataNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
