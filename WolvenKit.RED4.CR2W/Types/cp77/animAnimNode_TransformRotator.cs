using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TransformRotator : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("transform")] public animTransformIndex Transform { get; set; }
		[Ordinal(13)] [RED("axis")] public Vector3 Axis { get; set; }
		[Ordinal(14)] [RED("valueScale")] public CFloat ValueScale { get; set; }
		[Ordinal(15)] [RED("clamp")] public CBool Clamp { get; set; }
		[Ordinal(16)] [RED("angleMin")] public CFloat AngleMin { get; set; }
		[Ordinal(17)] [RED("angleMax")] public CFloat AngleMax { get; set; }
		[Ordinal(18)] [RED("angleValueNode")] public animFloatLink AngleValueNode { get; set; }
		[Ordinal(19)] [RED("angleSpeedNode")] public animFloatLink AngleSpeedNode { get; set; }

		public animAnimNode_TransformRotator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
