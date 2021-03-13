using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DampQuaternion : animAnimNode_QuaternionValue
	{
		[Ordinal(11)] [RED("defaultRotationSpeed")] public CFloat DefaultRotationSpeed { get; set; }
		[Ordinal(12)] [RED("defaultInitialValue")] public EulerAngles DefaultInitialValue { get; set; }
		[Ordinal(13)] [RED("inputNode")] public animQuaternionLink InputNode { get; set; }
		[Ordinal(14)] [RED("initialValueNode")] public animQuaternionLink InitialValueNode { get; set; }
		[Ordinal(15)] [RED("rotationSpeedNode")] public animFloatLink RotationSpeedNode { get; set; }

		public animAnimNode_DampQuaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
