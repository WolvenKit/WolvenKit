using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entGarmentParameterComponentData : CVariable
	{
		[Ordinal(0)]  [RED("componentID")] public CRUID ComponentID { get; set; }
		[Ordinal(1)]  [RED("meshGeometryHash")] public CUInt64 MeshGeometryHash { get; set; }
		[Ordinal(2)]  [RED("chunks")] public CArray<entGarmentParameterChunkData> Chunks { get; set; }
		[Ordinal(3)]  [RED("hideComponent")] public CBool HideComponent { get; set; }
		[Ordinal(4)]  [RED("bendPowerMultiplier")] public CFloat BendPowerMultiplier { get; set; }
		[Ordinal(5)]  [RED("bendPowerOffset")] public CFloat BendPowerOffset { get; set; }
		[Ordinal(6)]  [RED("smoothingStrength")] public CFloat SmoothingStrength { get; set; }
		[Ordinal(7)]  [RED("smoothingThreshold")] public CFloat SmoothingThreshold { get; set; }
		[Ordinal(8)]  [RED("smoothingExponent")] public CFloat SmoothingExponent { get; set; }
		[Ordinal(9)]  [RED("smoothingNumNeighbours")] public CUInt32 SmoothingNumNeighbours { get; set; }
		[Ordinal(10)]  [RED("garmentBorderThreshold")] public CFloat GarmentBorderThreshold { get; set; }
		[Ordinal(11)]  [RED("removeHiddenTriangles")] public CBool RemoveHiddenTriangles { get; set; }
		[Ordinal(12)]  [RED("disableGarment")] public CBool DisableGarment { get; set; }
		[Ordinal(13)]  [RED("mergeWithInnerLayer")] public CBool MergeWithInnerLayer { get; set; }

		public entGarmentParameterComponentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
