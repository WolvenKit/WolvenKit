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
			get
			{
				if (_cellSize == null)
				{
					_cellSize = (CUInt32) CR2WTypeManager.Create("Uint32", "cellSize", cr2w, this);
				}
				return _cellSize;
			}
			set
			{
				if (_cellSize == value)
				{
					return;
				}
				_cellSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cellRes")] 
		public CUInt32 CellRes
		{
			get
			{
				if (_cellRes == null)
				{
					_cellRes = (CUInt32) CR2WTypeManager.Create("Uint32", "cellRes", cr2w, this);
				}
				return _cellRes;
			}
			set
			{
				if (_cellRes == value)
				{
					return;
				}
				_cellRes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("numUsedCells")] 
		public CUInt32 NumUsedCells
		{
			get
			{
				if (_numUsedCells == null)
				{
					_numUsedCells = (CUInt32) CR2WTypeManager.Create("Uint32", "numUsedCells", cr2w, this);
				}
				return _numUsedCells;
			}
			set
			{
				if (_numUsedCells == value)
				{
					return;
				}
				_numUsedCells = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("numPatches")] 
		public CUInt32 NumPatches
		{
			get
			{
				if (_numPatches == null)
				{
					_numPatches = (CUInt32) CR2WTypeManager.Create("Uint32", "numPatches", cr2w, this);
				}
				return _numPatches;
			}
			set
			{
				if (_numPatches == value)
				{
					return;
				}
				_numPatches = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("numPatchesFromTerrainNodes")] 
		public CUInt32 NumPatchesFromTerrainNodes
		{
			get
			{
				if (_numPatchesFromTerrainNodes == null)
				{
					_numPatchesFromTerrainNodes = (CUInt32) CR2WTypeManager.Create("Uint32", "numPatchesFromTerrainNodes", cr2w, this);
				}
				return _numPatchesFromTerrainNodes;
			}
			set
			{
				if (_numPatchesFromTerrainNodes == value)
				{
					return;
				}
				_numPatchesFromTerrainNodes = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("numPatchesFromRoadNodes")] 
		public CUInt32 NumPatchesFromRoadNodes
		{
			get
			{
				if (_numPatchesFromRoadNodes == null)
				{
					_numPatchesFromRoadNodes = (CUInt32) CR2WTypeManager.Create("Uint32", "numPatchesFromRoadNodes", cr2w, this);
				}
				return _numPatchesFromRoadNodes;
			}
			set
			{
				if (_numPatchesFromRoadNodes == value)
				{
					return;
				}
				_numPatchesFromRoadNodes = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isVisibleCompiled")] 
		public CBool IsVisibleCompiled
		{
			get
			{
				if (_isVisibleCompiled == null)
				{
					_isVisibleCompiled = (CBool) CR2WTypeManager.Create("Bool", "isVisibleCompiled", cr2w, this);
				}
				return _isVisibleCompiled;
			}
			set
			{
				if (_isVisibleCompiled == value)
				{
					return;
				}
				_isVisibleCompiled = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("useDebugDraw")] 
		public CBool UseDebugDraw
		{
			get
			{
				if (_useDebugDraw == null)
				{
					_useDebugDraw = (CBool) CR2WTypeManager.Create("Bool", "useDebugDraw", cr2w, this);
				}
				return _useDebugDraw;
			}
			set
			{
				if (_useDebugDraw == value)
				{
					return;
				}
				_useDebugDraw = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("gridWidth")] 
		public CUInt32 GridWidth
		{
			get
			{
				if (_gridWidth == null)
				{
					_gridWidth = (CUInt32) CR2WTypeManager.Create("Uint32", "gridWidth", cr2w, this);
				}
				return _gridWidth;
			}
			set
			{
				if (_gridWidth == value)
				{
					return;
				}
				_gridWidth = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("gridHeight")] 
		public CUInt32 GridHeight
		{
			get
			{
				if (_gridHeight == null)
				{
					_gridHeight = (CUInt32) CR2WTypeManager.Create("Uint32", "gridHeight", cr2w, this);
				}
				return _gridHeight;
			}
			set
			{
				if (_gridHeight == value)
				{
					return;
				}
				_gridHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("numUsedLODCells")] 
		public CArray<CUInt32> NumUsedLODCells
		{
			get
			{
				if (_numUsedLODCells == null)
				{
					_numUsedLODCells = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "numUsedLODCells", cr2w, this);
				}
				return _numUsedLODCells;
			}
			set
			{
				if (_numUsedLODCells == value)
				{
					return;
				}
				_numUsedLODCells = value;
				PropertySet(this);
			}
		}

		public interopTerrainSystemInstanceInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
