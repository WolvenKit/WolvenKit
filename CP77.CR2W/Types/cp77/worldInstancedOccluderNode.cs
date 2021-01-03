using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldInstancedOccluderNode : worldNode
	{
		[Ordinal(0)]  [RED("autohideDistanceScale")] public CUInt8 AutohideDistanceScale { get; set; }
		[Ordinal(1)]  [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(2)]  [RED("occluderType")] public CEnum<visWorldOccluderType> OccluderType { get; set; }
		[Ordinal(3)]  [RED("worldBounds")] public Box WorldBounds { get; set; }

		public worldInstancedOccluderNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
