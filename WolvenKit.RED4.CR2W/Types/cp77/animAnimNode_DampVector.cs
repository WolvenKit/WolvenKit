using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DampVector : animAnimNode_VectorValue
	{
		[Ordinal(11)] [RED("defaultIncreaseSpeed")] public Vector4 DefaultIncreaseSpeed { get; set; }
		[Ordinal(12)] [RED("defaultDecreaseSpeed")] public Vector4 DefaultDecreaseSpeed { get; set; }
		[Ordinal(13)] [RED("startFromDefaultValue")] public CBool StartFromDefaultValue { get; set; }
		[Ordinal(14)] [RED("defaultInitialValue")] public Vector4 DefaultInitialValue { get; set; }
		[Ordinal(15)] [RED("inputNode")] public animVectorLink InputNode { get; set; }
		[Ordinal(16)] [RED("increaseSpeedNode")] public animVectorLink IncreaseSpeedNode { get; set; }
		[Ordinal(17)] [RED("decreaseSpeedNode")] public animVectorLink DecreaseSpeedNode { get; set; }

		public animAnimNode_DampVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
