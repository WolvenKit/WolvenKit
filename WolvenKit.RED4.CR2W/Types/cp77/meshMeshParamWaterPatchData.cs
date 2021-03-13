using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamWaterPatchData : meshMeshParameter
	{
		[Ordinal(0)] [RED("animLoop")] public CBool AnimLoop { get; set; }
		[Ordinal(1)] [RED("animLength")] public CFloat AnimLength { get; set; }
		[Ordinal(2)] [RED("nodes", 4096)] public CStatic<CStatic<CFloat>> Nodes { get; set; }

		public meshMeshParamWaterPatchData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
