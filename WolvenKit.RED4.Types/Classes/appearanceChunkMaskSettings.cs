using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class appearanceChunkMaskSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("chunksIds")] 
		public CArray<CUInt64> ChunksIds
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		[Ordinal(1)] 
		[RED("meshLayout")] 
		public CArray<CUInt32> MeshLayout
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(2)] 
		[RED("meshGeometryHash")] 
		public CUInt64 MeshGeometryHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public appearanceChunkMaskSettings()
		{
			ChunksIds = new();
			MeshLayout = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
