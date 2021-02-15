using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicalJointPin : ISerializable
	{
		[Ordinal(0)] [RED("object")] public CHandle<physicsISystemObject> Object { get; set; }
		[Ordinal(1)] [RED("featureIndex")] public CInt32 FeatureIndex { get; set; }
		[Ordinal(2)] [RED("localPosition")] public Vector3 LocalPosition { get; set; }
		[Ordinal(3)] [RED("localRotation")] public Quaternion LocalRotation { get; set; }

		public physicsPhysicalJointPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
