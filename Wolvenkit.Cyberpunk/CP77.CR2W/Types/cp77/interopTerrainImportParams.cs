using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopTerrainImportParams : CVariable
	{
		[Ordinal(0)]  [RED("cellRes")] public CUInt32 CellRes { get; set; }
		[Ordinal(1)]  [RED("cellSize")] public CUInt32 CellSize { get; set; }
		[Ordinal(2)]  [RED("dstPrefabNodePath")] public toolsEditorObjectIDPath DstPrefabNodePath { get; set; }
		[Ordinal(3)]  [RED("extraOffset")] public Vector2 ExtraOffset { get; set; }
		[Ordinal(4)]  [RED("importColorMaps")] public CBool ImportColorMaps { get; set; }
		[Ordinal(5)]  [RED("importControlMaps")] public CBool ImportControlMaps { get; set; }
		[Ordinal(6)]  [RED("importHeightMaps")] public CBool ImportHeightMaps { get; set; }
		[Ordinal(7)]  [RED("nodesNamingPattern")] public CString NodesNamingPattern { get; set; }
		[Ordinal(8)]  [RED("overwriteTransformsOfExistingNodes")] public CBool OverwriteTransformsOfExistingNodes { get; set; }
		[Ordinal(9)]  [RED("position")] public Vector3 Position { get; set; }
		[Ordinal(10)]  [RED("prefabPlacementInterval")] public CUInt32 PrefabPlacementInterval { get; set; }
		[Ordinal(11)]  [RED("prefabsDestinationPath")] public CString PrefabsDestinationPath { get; set; }
		[Ordinal(12)]  [RED("prefabsNamingPattern")] public CString PrefabsNamingPattern { get; set; }
		[Ordinal(13)]  [RED("scale")] public Vector3 Scale { get; set; }
		[Ordinal(14)]  [RED("tileHeight")] public CUInt32 TileHeight { get; set; }
		[Ordinal(15)]  [RED("tileWidth")] public CUInt32 TileWidth { get; set; }

		public interopTerrainImportParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
