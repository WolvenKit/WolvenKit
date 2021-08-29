using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CGIDataResource : resStreamedResource
	{
		private SerializationDeferredDataBuffer _data;
		private CUInt64 _sectorHash;

		[Ordinal(1)] 
		[RED("data")] 
		public SerializationDeferredDataBuffer Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(2)] 
		[RED("sectorHash")] 
		public CUInt64 SectorHash
		{
			get => GetProperty(ref _sectorHash);
			set => SetProperty(ref _sectorHash, value);
		}
	}
}
