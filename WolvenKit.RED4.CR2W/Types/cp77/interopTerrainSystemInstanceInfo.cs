using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopTerrainSystemInstanceInfo : CVariable
	{
		private CUInt32 _cellSize;
		private CUInt32 _cellRes;
		private CUInt32 _numUsedCells;
		private CUInt32 _numPatches;
		private CUInt32 _numPatchesFromTerrainNodes;
		private CUInt32 _numPatchesFromRoadNodes;
		private CBool _isEnabled;
		private CBool _isVisibleCompiled;
		private CBool _useDebugDraw;
		private CUInt32 _gridWidth;
		private CUInt32 _gridHeight;
		private CArray<CUInt32> _numUsedLODCells;

		[Ordinal(0)] 
		[RED("cellSize")] 
		public CUInt32 CellSize
		{
			get => GetProperty(ref _cellSize);
			set => SetProperty(ref _cellSize, value);
		}

		[Ordinal(1)] 
		[RED("cellRes")] 
		public CUInt32 CellRes
		{
			get => GetProperty(ref _cellRes);
			set => SetProperty(ref _cellRes, value);
		}

		[Ordinal(2)] 
		[RED("numUsedCells")] 
		public CUInt32 NumUsedCells
		{
			get => GetProperty(ref _numUsedCells);
			set => SetProperty(ref _numUsedCells, value);
		}

		[Ordinal(3)] 
		[RED("numPatches")] 
		public CUInt32 NumPatches
		{
			get => GetProperty(ref _numPatches);
			set => SetProperty(ref _numPatches, value);
		}

		[Ordinal(4)] 
		[RED("numPatchesFromTerrainNodes")] 
		public CUInt32 NumPatchesFromTerrainNodes
		{
			get => GetProperty(ref _numPatchesFromTerrainNodes);
			set => SetProperty(ref _numPatchesFromTerrainNodes, value);
		}

		[Ordinal(5)] 
		[RED("numPatchesFromRoadNodes")] 
		public CUInt32 NumPatchesFromRoadNodes
		{
			get => GetProperty(ref _numPatchesFromRoadNodes);
			set => SetProperty(ref _numPatchesFromRoadNodes, value);
		}

		[Ordinal(6)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(7)] 
		[RED("isVisibleCompiled")] 
		public CBool IsVisibleCompiled
		{
			get => GetProperty(ref _isVisibleCompiled);
			set => SetProperty(ref _isVisibleCompiled, value);
		}

		[Ordinal(8)] 
		[RED("useDebugDraw")] 
		public CBool UseDebugDraw
		{
			get => GetProperty(ref _useDebugDraw);
			set => SetProperty(ref _useDebugDraw, value);
		}

		[Ordinal(9)] 
		[RED("gridWidth")] 
		public CUInt32 GridWidth
		{
			get => GetProperty(ref _gridWidth);
			set => SetProperty(ref _gridWidth, value);
		}

		[Ordinal(10)] 
		[RED("gridHeight")] 
		public CUInt32 GridHeight
		{
			get => GetProperty(ref _gridHeight);
			set => SetProperty(ref _gridHeight, value);
		}

		[Ordinal(11)] 
		[RED("numUsedLODCells")] 
		public CArray<CUInt32> NumUsedLODCells
		{
			get => GetProperty(ref _numUsedLODCells);
			set => SetProperty(ref _numUsedLODCells, value);
		}

		public interopTerrainSystemInstanceInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
