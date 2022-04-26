using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CGIDataResource : resStreamedResource
	{
		[Ordinal(1)] 
		[RED("data")] 
		public SerializationDeferredDataBuffer Data
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}

		[Ordinal(2)] 
		[RED("sectorHash")] 
		public CUInt64 SectorHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public CGIDataResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
