using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsRagdollBodyInfo : CVariable
	{
		[Ordinal(0)]  [RED("BodyPart")] public CEnum<physicsRagdollBodyPartE> BodyPart { get; set; }
		[Ordinal(1)]  [RED("ChildAnimIndex")] public CInt32 ChildAnimIndex { get; set; }
		[Ordinal(2)]  [RED("ExcludeFromEarlyCollision")] public CBool ExcludeFromEarlyCollision { get; set; }
		[Ordinal(3)]  [RED("FilterDataOverride")] public CName FilterDataOverride { get; set; }
		[Ordinal(4)]  [RED("HalfHeight")] public CFloat HalfHeight { get; set; }
		[Ordinal(5)]  [RED("IsRootDisplacementPart")] public CBool IsRootDisplacementPart { get; set; }
		[Ordinal(6)]  [RED("IsStiff")] public CBool IsStiff { get; set; }
		[Ordinal(7)]  [RED("ParentAnimIndex")] public CInt32 ParentAnimIndex { get; set; }
		[Ordinal(8)]  [RED("ParentBodyIndex")] public CInt32 ParentBodyIndex { get; set; }
		[Ordinal(9)]  [RED("ShapeLocalRotation")] public Quaternion ShapeLocalRotation { get; set; }
		[Ordinal(10)]  [RED("ShapeLocalTranslation")] public Vector3 ShapeLocalTranslation { get; set; }
		[Ordinal(11)]  [RED("ShapeRadius")] public CFloat ShapeRadius { get; set; }
		[Ordinal(12)]  [RED("ShapeType")] public CEnum<physicsRagdollShapeType> ShapeType { get; set; }
		[Ordinal(13)]  [RED("SwingAnglesY", 2)] public CArrayFixedSize<CFloat> SwingAnglesY { get; set; }
		[Ordinal(14)]  [RED("SwingAnglesZ", 2)] public CArrayFixedSize<CFloat> SwingAnglesZ { get; set; }
		[Ordinal(15)]  [RED("TwistAngles", 2)] public CArrayFixedSize<CFloat> TwistAngles { get; set; }

		public physicsRagdollBodyInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
