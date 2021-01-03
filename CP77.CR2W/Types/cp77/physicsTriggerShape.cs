using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsTriggerShape : CVariable
	{
		[Ordinal(0)]  [RED("shapeLocalPose")] public Transform ShapeLocalPose { get; set; }
		[Ordinal(1)]  [RED("shapeSize")] public Vector3 ShapeSize { get; set; }
		[Ordinal(2)]  [RED("shapeType")] public CEnum<physicsShapeType> ShapeType { get; set; }

		public physicsTriggerShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
