using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldFoliageCompiledResource : CResource
	{
		private CUInt32 _version;
		private CUInt32 _populationCount;
		private CUInt32 _bucketCount;
		private DataBuffer _dataBuffer;

		[Ordinal(1)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		[Ordinal(2)] 
		[RED("populationCount")] 
		public CUInt32 PopulationCount
		{
			get => GetProperty(ref _populationCount);
			set => SetProperty(ref _populationCount, value);
		}

		[Ordinal(3)] 
		[RED("bucketCount")] 
		public CUInt32 BucketCount
		{
			get => GetProperty(ref _bucketCount);
			set => SetProperty(ref _bucketCount, value);
		}

		[Ordinal(4)] 
		[RED("dataBuffer")] 
		public DataBuffer DataBuffer
		{
			get => GetProperty(ref _dataBuffer);
			set => SetProperty(ref _dataBuffer, value);
		}
	}
}
