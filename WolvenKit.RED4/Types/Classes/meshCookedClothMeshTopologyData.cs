using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshCookedClothMeshTopologyData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("cookedData")] 
		public DataBuffer CookedData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(1)] 
		[RED("gfxIndexToTriangles")] 
		public CArray<CUInt32> GfxIndexToTriangles
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(2)] 
		[RED("phxIndexToTriangles")] 
		public CArray<CUInt32> PhxIndexToTriangles
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(3)] 
		[RED("gfxBarycentrics")] 
		public CArray<CUInt32> GfxBarycentrics
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(4)] 
		[RED("phxBarycentrics")] 
		public CArray<CUInt32> PhxBarycentrics
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(5)] 
		[RED("phxLodSwitchData")] 
		public CArray<CUInt32> PhxLodSwitchData
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(6)] 
		[RED("phxSimulated")] 
		public CArray<CUInt32> PhxSimulated
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(7)] 
		[RED("gfxNumIndicesToTriangles")] 
		public CUInt32 GfxNumIndicesToTriangles
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(8)] 
		[RED("phxNumIndicesToTriangles")] 
		public CUInt32 PhxNumIndicesToTriangles
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(9)] 
		[RED("gfxNumBarycentrics")] 
		public CUInt32 GfxNumBarycentrics
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(10)] 
		[RED("phxNumBarycentrics")] 
		public CUInt32 PhxNumBarycentrics
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(11)] 
		[RED("phxNumLodSwitchData")] 
		public CUInt32 PhxNumLodSwitchData
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(12)] 
		[RED("phxNumSimulated")] 
		public CUInt32 PhxNumSimulated
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public meshCookedClothMeshTopologyData()
		{
			GfxIndexToTriangles = new();
			PhxIndexToTriangles = new();
			GfxBarycentrics = new();
			PhxBarycentrics = new();
			PhxLodSwitchData = new();
			PhxSimulated = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
