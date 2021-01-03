using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class appearanceChunkMaskSettings : CVariable
	{
		[Ordinal(0)]  [RED("chunksIds")] public CArray<CUInt64> ChunksIds { get; set; }
		[Ordinal(1)]  [RED("meshGeometryHash")] public CUInt64 MeshGeometryHash { get; set; }
		[Ordinal(2)]  [RED("meshLayout")] public CArray<CUInt32> MeshLayout { get; set; }

		public appearanceChunkMaskSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
