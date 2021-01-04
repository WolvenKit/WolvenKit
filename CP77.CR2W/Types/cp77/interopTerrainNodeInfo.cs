using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopTerrainNodeInfo : CVariable
	{
		[Ordinal(0)]  [RED("blendModeColorIsIgnore")] public CBool BlendModeColorIsIgnore { get; set; }
		[Ordinal(1)]  [RED("blendModeHeightIsIgnore")] public CBool BlendModeHeightIsIgnore { get; set; }
		[Ordinal(2)]  [RED("blendModeHeightIsNormal")] public CBool BlendModeHeightIsNormal { get; set; }
		[Ordinal(3)]  [RED("blendModeHolesIsIgnore")] public CBool BlendModeHolesIsIgnore { get; set; }
		[Ordinal(4)]  [RED("blendOrder")] public CUInt8 BlendOrder { get; set; }
		[Ordinal(5)]  [RED("densityTexelSize")] public CFloat DensityTexelSize { get; set; }
		[Ordinal(6)]  [RED("externalDataSource")] public CBool ExternalDataSource { get; set; }
		[Ordinal(7)]  [RED("height")] public CUInt32 Height { get; set; }
		[Ordinal(8)]  [RED("isTerrainNode")] public CBool IsTerrainNode { get; set; }
		[Ordinal(9)]  [RED("nodeCellResScale")] public CFloat NodeCellResScale { get; set; }
		[Ordinal(10)]  [RED("nodeIDPath")] public toolsEditorObjectIDPath NodeIDPath { get; set; }
		[Ordinal(11)]  [RED("nodeName")] public CString NodeName { get; set; }
		[Ordinal(12)]  [RED("nodeScale")] public Vector3 NodeScale { get; set; }
		[Ordinal(13)]  [RED("nodeTransform")] public Transform NodeTransform { get; set; }
		[Ordinal(14)]  [RED("terrainSysID")] public CUInt16 TerrainSysID { get; set; }
		[Ordinal(15)]  [RED("width")] public CUInt32 Width { get; set; }

		public interopTerrainNodeInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
