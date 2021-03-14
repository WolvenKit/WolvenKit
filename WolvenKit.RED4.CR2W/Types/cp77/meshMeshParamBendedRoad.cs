using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamBendedRoad : meshMeshParameter
	{
		[Ordinal(0)] [RED("occInds")] public CArray<CUInt16> OccInds { get; set; }
		[Ordinal(1)] [RED("occVerts")] public CArray<Vector4> OccVerts { get; set; }
		[Ordinal(2)] [RED("occSkinWeights")] public CArray<Vector4> OccSkinWeights { get; set; }
		[Ordinal(3)] [RED("occSkinInds")] public CArray<CColor> OccSkinInds { get; set; }
		[Ordinal(4)] [RED("collInds")] public CArray<CArray<CUInt16>> CollInds { get; set; }
		[Ordinal(5)] [RED("collVerts")] public CArray<CArray<Vector3>> CollVerts { get; set; }
		[Ordinal(6)] [RED("collSkinWeights")] public CArray<CArray<Vector4>> CollSkinWeights { get; set; }
		[Ordinal(7)] [RED("collSkinInds")] public CArray<CArray<CColor>> CollSkinInds { get; set; }
		[Ordinal(8)] [RED("collMaterialName")] public CArray<CString> CollMaterialName { get; set; }
		[Ordinal(9)] [RED("collFilterPresetName")] public CArray<CString> CollFilterPresetName { get; set; }
		[Ordinal(10)] [RED("collFaceMatInds")] public CArray<CArray<CUInt16>> CollFaceMatInds { get; set; }
		[Ordinal(11)] [RED("collFaceMaterialNames")] public CArray<CArray<CString>> CollFaceMaterialNames { get; set; }

		public meshMeshParamBendedRoad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
