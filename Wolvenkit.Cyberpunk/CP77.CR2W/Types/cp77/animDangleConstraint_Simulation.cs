using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animDangleConstraint_Simulation : ISerializable
	{
		[Ordinal(0)]  [RED("alpha")] public CFloat Alpha { get; set; }
		[Ordinal(1)]  [RED("collisionRoundedShapes")] public CArray<animCollisionRoundedShape> CollisionRoundedShapes { get; set; }
		[Ordinal(2)]  [RED("dangleAltersTransformsOfItsChildren")] public CBool DangleAltersTransformsOfItsChildren { get; set; }
		[Ordinal(3)]  [RED("jsonCollisionShapes")] public rRef<JsonResource> JsonCollisionShapes { get; set; }
		[Ordinal(4)]  [RED("jsonCollisionShapesLoadedSuccessfully")] public CBool JsonCollisionShapesLoadedSuccessfully { get; set; }
		[Ordinal(5)]  [RED("parentRotationAltersTransformsOfDangleAndItsChildren")] public CBool ParentRotationAltersTransformsOfDangleAndItsChildren { get; set; }
		[Ordinal(6)]  [RED("parentRotationAltersTransformsOfNonDanglesAndItsChildren")] public CBool ParentRotationAltersTransformsOfNonDanglesAndItsChildren { get; set; }
		[Ordinal(7)]  [RED("rotateParentToLookAtDangle")] public CBool RotateParentToLookAtDangle { get; set; }

		public animDangleConstraint_Simulation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
