using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopTerrainSystemInstanceInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("cellSize")] 
		public CUInt32 CellSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("cellRes")] 
		public CUInt32 CellRes
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("numUsedCells")] 
		public CUInt32 NumUsedCells
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("numPatches")] 
		public CUInt32 NumPatches
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("numPatchesFromTerrainNodes")] 
		public CUInt32 NumPatchesFromTerrainNodes
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("numPatchesFromRoadNodes")] 
		public CUInt32 NumPatchesFromRoadNodes
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isVisibleCompiled")] 
		public CBool IsVisibleCompiled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("useDebugDraw")] 
		public CBool UseDebugDraw
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("gridWidth")] 
		public CUInt32 GridWidth
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(10)] 
		[RED("gridHeight")] 
		public CUInt32 GridHeight
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(11)] 
		[RED("numUsedLODCells")] 
		public CArray<CUInt32> NumUsedLODCells
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public interopTerrainSystemInstanceInfo()
		{
			NumUsedLODCells = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
