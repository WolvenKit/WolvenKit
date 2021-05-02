using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshCookedClothMeshTopologyData : CVariable
	{
		private DataBuffer _cookedData;
		private CArray<CUInt32> _gfxIndexToTriangles;
		private CArray<CUInt32> _phxIndexToTriangles;
		private CArray<CUInt32> _gfxBarycentrics;
		private CArray<CUInt32> _phxBarycentrics;
		private CArray<CUInt32> _phxLodSwitchData;
		private CArray<CUInt32> _phxSimulated;
		private CUInt32 _gfxNumIndicesToTriangles;
		private CUInt32 _phxNumIndicesToTriangles;
		private CUInt32 _gfxNumBarycentrics;
		private CUInt32 _phxNumBarycentrics;
		private CUInt32 _phxNumLodSwitchData;
		private CUInt32 _phxNumSimulated;

		[Ordinal(0)] 
		[RED("cookedData")] 
		public DataBuffer CookedData
		{
			get => GetProperty(ref _cookedData);
			set => SetProperty(ref _cookedData, value);
		}

		[Ordinal(1)] 
		[RED("gfxIndexToTriangles")] 
		public CArray<CUInt32> GfxIndexToTriangles
		{
			get => GetProperty(ref _gfxIndexToTriangles);
			set => SetProperty(ref _gfxIndexToTriangles, value);
		}

		[Ordinal(2)] 
		[RED("phxIndexToTriangles")] 
		public CArray<CUInt32> PhxIndexToTriangles
		{
			get => GetProperty(ref _phxIndexToTriangles);
			set => SetProperty(ref _phxIndexToTriangles, value);
		}

		[Ordinal(3)] 
		[RED("gfxBarycentrics")] 
		public CArray<CUInt32> GfxBarycentrics
		{
			get => GetProperty(ref _gfxBarycentrics);
			set => SetProperty(ref _gfxBarycentrics, value);
		}

		[Ordinal(4)] 
		[RED("phxBarycentrics")] 
		public CArray<CUInt32> PhxBarycentrics
		{
			get => GetProperty(ref _phxBarycentrics);
			set => SetProperty(ref _phxBarycentrics, value);
		}

		[Ordinal(5)] 
		[RED("phxLodSwitchData")] 
		public CArray<CUInt32> PhxLodSwitchData
		{
			get => GetProperty(ref _phxLodSwitchData);
			set => SetProperty(ref _phxLodSwitchData, value);
		}

		[Ordinal(6)] 
		[RED("phxSimulated")] 
		public CArray<CUInt32> PhxSimulated
		{
			get => GetProperty(ref _phxSimulated);
			set => SetProperty(ref _phxSimulated, value);
		}

		[Ordinal(7)] 
		[RED("gfxNumIndicesToTriangles")] 
		public CUInt32 GfxNumIndicesToTriangles
		{
			get => GetProperty(ref _gfxNumIndicesToTriangles);
			set => SetProperty(ref _gfxNumIndicesToTriangles, value);
		}

		[Ordinal(8)] 
		[RED("phxNumIndicesToTriangles")] 
		public CUInt32 PhxNumIndicesToTriangles
		{
			get => GetProperty(ref _phxNumIndicesToTriangles);
			set => SetProperty(ref _phxNumIndicesToTriangles, value);
		}

		[Ordinal(9)] 
		[RED("gfxNumBarycentrics")] 
		public CUInt32 GfxNumBarycentrics
		{
			get => GetProperty(ref _gfxNumBarycentrics);
			set => SetProperty(ref _gfxNumBarycentrics, value);
		}

		[Ordinal(10)] 
		[RED("phxNumBarycentrics")] 
		public CUInt32 PhxNumBarycentrics
		{
			get => GetProperty(ref _phxNumBarycentrics);
			set => SetProperty(ref _phxNumBarycentrics, value);
		}

		[Ordinal(11)] 
		[RED("phxNumLodSwitchData")] 
		public CUInt32 PhxNumLodSwitchData
		{
			get => GetProperty(ref _phxNumLodSwitchData);
			set => SetProperty(ref _phxNumLodSwitchData, value);
		}

		[Ordinal(12)] 
		[RED("phxNumSimulated")] 
		public CUInt32 PhxNumSimulated
		{
			get => GetProperty(ref _phxNumSimulated);
			set => SetProperty(ref _phxNumSimulated, value);
		}

		public meshCookedClothMeshTopologyData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
