using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshMeshImportedSnapPoint : ISerializable
	{
		[Ordinal(0)] [RED("localToCloud")] public Matrix LocalToCloud { get; set; }
		[Ordinal(1)] [RED("range")] public CFloat Range { get; set; }
		[Ordinal(2)] [RED("rotationAlignmentSteps")] public CUInt8 RotationAlignmentSteps { get; set; }
		[Ordinal(3)] [RED("snapTags")] public meshImportedSnapTags SnapTags { get; set; }

		public meshMeshImportedSnapPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
