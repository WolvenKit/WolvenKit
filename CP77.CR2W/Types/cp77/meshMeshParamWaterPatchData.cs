using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamWaterPatchData : meshMeshParameter
	{
		[Ordinal(0)]  [RED("animLength")] public CFloat AnimLength { get; set; }
		[Ordinal(1)]  [RED("animLoop")] public CBool AnimLoop { get; set; }
		[Ordinal(2)]  [RED("nodes")] public CStatic<4096,static<16,Float>> Nodes { get; set; }

		public meshMeshParamWaterPatchData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
