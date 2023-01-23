using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendTopologyData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CArray<CUInt8> Data
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(1)] 
		[RED("metadata")] 
		public CArray<CUInt8> Metadata
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(2)] 
		[RED("dataStride")] 
		public CUInt32 DataStride
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("metadataStride")] 
		public CUInt32 MetadataStride
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public rendTopologyData()
		{
			Data = new();
			Metadata = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
