using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TransformRotator : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("transform")] public animTransformIndex Transform { get; set; }
		[Ordinal(3)] [RED("axis")] public Vector3 Axis { get; set; }
		[Ordinal(4)] [RED("valueScale")] public CFloat ValueScale { get; set; }
		[Ordinal(5)] [RED("clamp")] public CBool Clamp { get; set; }
		[Ordinal(6)] [RED("angleMin")] public CFloat AngleMin { get; set; }
		[Ordinal(7)] [RED("angleMax")] public CFloat AngleMax { get; set; }
		[Ordinal(8)] [RED("angleValueNode")] public animFloatLink AngleValueNode { get; set; }
		[Ordinal(9)] [RED("angleSpeedNode")] public animFloatLink AngleSpeedNode { get; set; }

		public animAnimNode_TransformRotator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
