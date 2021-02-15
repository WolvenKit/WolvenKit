using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsTriggerShape : CVariable
	{
		[Ordinal(0)] [RED("shapeType")] public CEnum<physicsShapeType> ShapeType { get; set; }
		[Ordinal(1)] [RED("shapeSize")] public Vector3 ShapeSize { get; set; }
		[Ordinal(2)] [RED("shapeLocalPose")] public Transform ShapeLocalPose { get; set; }

		public physicsTriggerShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
