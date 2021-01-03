using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicalJointPin : ISerializable
	{
		[Ordinal(0)]  [RED("featureIndex")] public CInt32 FeatureIndex { get; set; }
		[Ordinal(1)]  [RED("localPosition")] public Vector3 LocalPosition { get; set; }
		[Ordinal(2)]  [RED("localRotation")] public Quaternion LocalRotation { get; set; }
		[Ordinal(3)]  [RED("object")] public CHandle<physicsISystemObject> Object { get; set; }

		public physicsPhysicalJointPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
