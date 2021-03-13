using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldOffMeshConnectionsData : CVariable
	{
		[Ordinal(0)] [RED("verts")] public CArray<CFloat> Verts { get; set; }
		[Ordinal(1)] [RED("radii")] public CArray<CFloat> Radii { get; set; }
		[Ordinal(2)] [RED("flags")] public CArray<CUInt16> Flags { get; set; }
		[Ordinal(3)] [RED("areas")] public CArray<CUInt8> Areas { get; set; }
		[Ordinal(4)] [RED("directions")] public CArray<CUInt8> Directions { get; set; }
		[Ordinal(5)] [RED("ids")] public CArray<CUInt64> Ids { get; set; }
		[Ordinal(6)] [RED("tagIntervals")] public CArray<CUInt16> TagIntervals { get; set; }
		[Ordinal(7)] [RED("tagsX")] public CArray<CName> TagsX { get; set; }
		[Ordinal(8)] [RED("globalNodeIDs")] public CArray<worldGlobalNodeID> GlobalNodeIDs { get; set; }
		[Ordinal(9)] [RED("userData")] public CArray<CHandle<worldOffMeshUserData>> UserData { get; set; }

		public worldOffMeshConnectionsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
