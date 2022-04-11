using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamTopologyMetadata : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(1)] 
		[RED("offsets")] 
		public CArray<CUInt32> Offsets
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(2)] 
		[RED("sizes")] 
		public CArray<CUInt32> Sizes
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public meshMeshParamTopologyMetadata()
		{
			Offsets = new();
			Sizes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
