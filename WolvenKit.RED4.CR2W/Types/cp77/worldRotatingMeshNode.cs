using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRotatingMeshNode : worldMeshNode
	{
		[Ordinal(15)] [RED("rotationAxis")] public CEnum<worldRotatingMeshNodeAxis> RotationAxis { get; set; }
		[Ordinal(16)] [RED("fullRotationTime")] public CFloat FullRotationTime { get; set; }
		[Ordinal(17)] [RED("reverseDirection")] public CBool ReverseDirection { get; set; }

		public worldRotatingMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
