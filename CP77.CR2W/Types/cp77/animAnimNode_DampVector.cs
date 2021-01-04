using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DampVector : animAnimNode_VectorValue
	{
		[Ordinal(0)]  [RED("decreaseSpeedNode")] public animVectorLink DecreaseSpeedNode { get; set; }
		[Ordinal(1)]  [RED("defaultDecreaseSpeed")] public Vector4 DefaultDecreaseSpeed { get; set; }
		[Ordinal(2)]  [RED("defaultIncreaseSpeed")] public Vector4 DefaultIncreaseSpeed { get; set; }
		[Ordinal(3)]  [RED("defaultInitialValue")] public Vector4 DefaultInitialValue { get; set; }
		[Ordinal(4)]  [RED("increaseSpeedNode")] public animVectorLink IncreaseSpeedNode { get; set; }
		[Ordinal(5)]  [RED("inputNode")] public animVectorLink InputNode { get; set; }
		[Ordinal(6)]  [RED("startFromDefaultValue")] public CBool StartFromDefaultValue { get; set; }

		public animAnimNode_DampVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
