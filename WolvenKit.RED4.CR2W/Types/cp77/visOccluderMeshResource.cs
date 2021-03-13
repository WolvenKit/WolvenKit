using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class visOccluderMeshResource : visIOccluderResource
	{
		[Ordinal(1)] [RED("resourceVersion")] public CUInt32 ResourceVersion { get; set; }
		[Ordinal(2)] [RED("vertices")] public DataBuffer Vertices { get; set; }
		[Ordinal(3)] [RED("indices")] public DataBuffer Indices { get; set; }
		[Ordinal(4)] [RED("boundingBox")] public Box BoundingBox { get; set; }
		[Ordinal(5)] [RED("twoSided")] public CBool TwoSided { get; set; }

		public visOccluderMeshResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
