using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldOffMeshConnectionsData : CVariable
	{
		[Ordinal(0)]  [RED("areas")] public CArray<CUInt8> Areas { get; set; }
		[Ordinal(1)]  [RED("directions")] public CArray<CUInt8> Directions { get; set; }
		[Ordinal(2)]  [RED("flags")] public CArray<CUInt16> Flags { get; set; }
		[Ordinal(3)]  [RED("globalNodeIDs")] public CArray<worldGlobalNodeID> GlobalNodeIDs { get; set; }
		[Ordinal(4)]  [RED("ids")] public CArray<CUInt64> Ids { get; set; }
		[Ordinal(5)]  [RED("radii")] public CArray<CFloat> Radii { get; set; }
		[Ordinal(6)]  [RED("tagIntervals")] public CArray<CUInt16> TagIntervals { get; set; }
		[Ordinal(7)]  [RED("tagsX")] public CArray<CName> TagsX { get; set; }
		[Ordinal(8)]  [RED("userData")] public CArray<CHandle<worldOffMeshUserData>> UserData { get; set; }
		[Ordinal(9)]  [RED("verts")] public CArray<CFloat> Verts { get; set; }

		public worldOffMeshConnectionsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
