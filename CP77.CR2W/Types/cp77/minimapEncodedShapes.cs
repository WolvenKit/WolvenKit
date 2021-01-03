using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class minimapEncodedShapes : CResource
	{
		[Ordinal(0)]  [RED("BoxQuantizationBias")] public Vector3 BoxQuantizationBias { get; set; }
		[Ordinal(1)]  [RED("BoxQuantizationScale")] public Vector3 BoxQuantizationScale { get; set; }
		[Ordinal(2)]  [RED("Buffer")] public DataBuffer Buffer { get; set; }
		[Ordinal(3)]  [RED("NumBorderPoints")] public CUInt32 NumBorderPoints { get; set; }
		[Ordinal(4)]  [RED("NumFillPoints")] public CUInt32 NumFillPoints { get; set; }
		[Ordinal(5)]  [RED("NumOwners")] public CUInt32 NumOwners { get; set; }
		[Ordinal(6)]  [RED("NumPoints")] public CUInt32 NumPoints { get; set; }
		[Ordinal(7)]  [RED("NumShapes")] public CUInt32 NumShapes { get; set; }
		[Ordinal(8)]  [RED("NumSpatialBuckets")] public CUInt32 NumSpatialBuckets { get; set; }
		[Ordinal(9)]  [RED("NumUniqueGeometry")] public CUInt32 NumUniqueGeometry { get; set; }
		[Ordinal(10)]  [RED("QuantizationBias")] public Vector2 QuantizationBias { get; set; }
		[Ordinal(11)]  [RED("QuantizationScale")] public Vector2 QuantizationScale { get; set; }
		[Ordinal(12)]  [RED("Version")] public CUInt32 Version { get; set; }

		public minimapEncodedShapes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
