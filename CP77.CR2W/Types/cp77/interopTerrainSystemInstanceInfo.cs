using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopTerrainSystemInstanceInfo : CVariable
	{
		[Ordinal(0)]  [RED("cellSize")] public CUInt32 CellSize { get; set; }
		[Ordinal(1)]  [RED("cellRes")] public CUInt32 CellRes { get; set; }
		[Ordinal(2)]  [RED("numUsedCells")] public CUInt32 NumUsedCells { get; set; }
		[Ordinal(3)]  [RED("numPatches")] public CUInt32 NumPatches { get; set; }
		[Ordinal(4)]  [RED("numPatchesFromTerrainNodes")] public CUInt32 NumPatchesFromTerrainNodes { get; set; }
		[Ordinal(5)]  [RED("numPatchesFromRoadNodes")] public CUInt32 NumPatchesFromRoadNodes { get; set; }
		[Ordinal(6)]  [RED("gridWidth")] public CUInt32 GridWidth { get; set; }
		[Ordinal(7)]  [RED("gridHeight")] public CUInt32 GridHeight { get; set; }
		[Ordinal(8)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(9)]  [RED("isVisibleCompiled")] public CBool IsVisibleCompiled { get; set; }
		[Ordinal(10)]  [RED("useDebugDraw")] public CBool UseDebugDraw { get; set; }
		[Ordinal(11)]  [RED("numUsedLODCells")] public CArray<CUInt32> NumUsedLODCells { get; set; }

		public interopTerrainSystemInstanceInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
