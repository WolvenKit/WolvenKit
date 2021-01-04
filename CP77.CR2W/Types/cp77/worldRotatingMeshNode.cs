using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldRotatingMeshNode : worldMeshNode
	{
		[Ordinal(0)]  [RED("fullRotationTime")] public CFloat FullRotationTime { get; set; }
		[Ordinal(1)]  [RED("reverseDirection")] public CBool ReverseDirection { get; set; }
		[Ordinal(2)]  [RED("rotationAxis")] public CEnum<worldRotatingMeshNodeAxis> RotationAxis { get; set; }

		public worldRotatingMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
