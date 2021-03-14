using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TranslateBone : animAnimNode_Base
	{
		[Ordinal(11)] [RED("inputNode")] public animPoseLink InputNode { get; set; }
		[Ordinal(12)] [RED("inputTranslation")] public animVectorLink InputTranslation { get; set; }
		[Ordinal(13)] [RED("scale")] public Vector4 Scale { get; set; }
		[Ordinal(14)] [RED("biasValue")] public Vector4 BiasValue { get; set; }
		[Ordinal(15)] [RED("bone")] public animTransformIndex Bone { get; set; }
		[Ordinal(16)] [RED("useIncrementalMode")] public CBool UseIncrementalMode { get; set; }
		[Ordinal(17)] [RED("resetOnActivation")] public CBool ResetOnActivation { get; set; }

		public animAnimNode_TranslateBone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
