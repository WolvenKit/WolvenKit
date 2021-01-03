using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamCloth_Graphical : meshMeshParameter
	{
		[Ordinal(0)]  [RED("chunks")] public CArray<meshGfxClothChunkData> Chunks { get; set; }
		[Ordinal(1)]  [RED("latchers")] public CArray<CArray<CArray<CUInt16>>> Latchers { get; set; }
		[Ordinal(2)]  [RED("lodChunkIndices")] public CArray<CArray<CUInt16>> LodChunkIndices { get; set; }

		public meshMeshParamCloth_Graphical(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
