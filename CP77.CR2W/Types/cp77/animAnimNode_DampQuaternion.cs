using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DampQuaternion : animAnimNode_QuaternionValue
	{
		[Ordinal(1)] [RED("defaultRotationSpeed")] public CFloat DefaultRotationSpeed { get; set; }
		[Ordinal(2)] [RED("defaultInitialValue")] public EulerAngles DefaultInitialValue { get; set; }
		[Ordinal(3)] [RED("inputNode")] public animQuaternionLink InputNode { get; set; }
		[Ordinal(4)] [RED("initialValueNode")] public animQuaternionLink InitialValueNode { get; set; }
		[Ordinal(5)] [RED("rotationSpeedNode")] public animFloatLink RotationSpeedNode { get; set; }

		public animAnimNode_DampQuaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
