using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamCloth : meshMeshParameter
	{
		[Ordinal(0)]  [RED("capsules")] public CHandle<physicsclothClothCapsuleExportData> Capsules { get; set; }
		[Ordinal(1)]  [RED("chunks")] public CArray<meshPhxClothChunkData> Chunks { get; set; }
		[Ordinal(2)]  [RED("drivers")] public CArray<CArray<CUInt16>> Drivers { get; set; }
		[Ordinal(3)]  [RED("lodChunkIndices")] public CArray<CArray<CUInt16>> LodChunkIndices { get; set; }

		public meshMeshParamCloth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
