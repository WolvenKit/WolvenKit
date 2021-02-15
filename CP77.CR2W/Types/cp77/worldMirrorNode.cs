using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldMirrorNode : worldMeshNode
	{
		[Ordinal(13)] [RED("cullingBoxExtents")] public Vector3 CullingBoxExtents { get; set; }
		[Ordinal(14)] [RED("cullingBoxOffset")] public Vector3 CullingBoxOffset { get; set; }

		public worldMirrorNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
