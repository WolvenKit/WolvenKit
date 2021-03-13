using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshCookedClothMeshTopologyData : CVariable
	{
		[Ordinal(0)] [RED("cookedData")] public DataBuffer CookedData { get; set; }
		[Ordinal(1)] [RED("gfxIndexToTriangles")] public CArray<CUInt32> GfxIndexToTriangles { get; set; }
		[Ordinal(2)] [RED("phxIndexToTriangles")] public CArray<CUInt32> PhxIndexToTriangles { get; set; }
		[Ordinal(3)] [RED("gfxBarycentrics")] public CArray<CUInt32> GfxBarycentrics { get; set; }
		[Ordinal(4)] [RED("phxBarycentrics")] public CArray<CUInt32> PhxBarycentrics { get; set; }
		[Ordinal(5)] [RED("phxLodSwitchData")] public CArray<CUInt32> PhxLodSwitchData { get; set; }
		[Ordinal(6)] [RED("phxSimulated")] public CArray<CUInt32> PhxSimulated { get; set; }
		[Ordinal(7)] [RED("gfxNumIndicesToTriangles")] public CUInt32 GfxNumIndicesToTriangles { get; set; }
		[Ordinal(8)] [RED("phxNumIndicesToTriangles")] public CUInt32 PhxNumIndicesToTriangles { get; set; }
		[Ordinal(9)] [RED("gfxNumBarycentrics")] public CUInt32 GfxNumBarycentrics { get; set; }
		[Ordinal(10)] [RED("phxNumBarycentrics")] public CUInt32 PhxNumBarycentrics { get; set; }
		[Ordinal(11)] [RED("phxNumLodSwitchData")] public CUInt32 PhxNumLodSwitchData { get; set; }
		[Ordinal(12)] [RED("phxNumSimulated")] public CUInt32 PhxNumSimulated { get; set; }

		public meshCookedClothMeshTopologyData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
