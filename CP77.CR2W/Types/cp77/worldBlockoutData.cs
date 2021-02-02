using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutData : ISerializable
	{
		[Ordinal(0)]  [RED("points")] public CArray<worldBlockoutPoint> Points { get; set; }
		[Ordinal(1)]  [RED("edges")] public CArray<worldBlockoutEdge> Edges { get; set; }
		[Ordinal(2)]  [RED("areas")] public CArray<worldBlockoutArea> Areas { get; set; }
		[Ordinal(3)]  [RED("freePoints")] public CArray<CUInt32> FreePoints { get; set; }
		[Ordinal(4)]  [RED("freeEdges")] public CArray<CUInt32> FreeEdges { get; set; }
		[Ordinal(5)]  [RED("freeAreas")] public CArray<CUInt32> FreeAreas { get; set; }
		[Ordinal(6)]  [RED("worldSize")] public Vector2 WorldSize { get; set; }

		public worldBlockoutData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
