using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendOpacityMicromapChunk : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("mChunkIndex")] 
		public CUInt32 MChunkIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("unkIndex")] 
		public CUInt32 UnkIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("terialIdentifier")] 
		public CUInt64 TerialIdentifier
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(3)] 
		[RED("terialName")] 
		public CName TerialName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("mDigest")] 
		public CUInt64 MDigest
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(5)] 
		[RED("mIndexBufferSize")] 
		public CUInt32 MIndexBufferSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("mIndexBuffer16bit")] 
		public CUInt32 MIndexBuffer16bit
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("mIndexBufferOffset")] 
		public CUInt64 MIndexBufferOffset
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(8)] 
		[RED("mArrayBufferOffset")] 
		public CUInt64 MArrayBufferOffset
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(9)] 
		[RED("mDescsBufferOffset")] 
		public CUInt64 MDescsBufferOffset
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(10)] 
		[RED("mDescArrayHistogramData")] 
		public CArray<rendOpacityMicromapUsageCounts> MDescArrayHistogramData
		{
			get => GetPropertyValue<CArray<rendOpacityMicromapUsageCounts>>();
			set => SetPropertyValue<CArray<rendOpacityMicromapUsageCounts>>(value);
		}

		[Ordinal(11)] 
		[RED("mIndexHistogramData")] 
		public CArray<rendOpacityMicromapUsageCounts> MIndexHistogramData
		{
			get => GetPropertyValue<CArray<rendOpacityMicromapUsageCounts>>();
			set => SetPropertyValue<CArray<rendOpacityMicromapUsageCounts>>(value);
		}

		public rendOpacityMicromapChunk()
		{
			MDescArrayHistogramData = new();
			MIndexHistogramData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
