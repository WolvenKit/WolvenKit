using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectPropertyDictionaryPropertyEntry : CVariable
	{
		[Ordinal(0)] [RED("id")] public CUInt16 Id { get; set; }
		[Ordinal(1)] [RED("usage")] public CUInt32 Usage { get; set; }
		[Ordinal(2)] [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(3)] [RED("sourceAnimset")] public CUInt64 SourceAnimset { get; set; }
		[Ordinal(4)] [RED("type")] public CEnum<gameSmartObjectPointType> Type { get; set; }
		[Ordinal(5)] [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(6)] [RED("movementOrientation")] public CEnum<moveMovementOrientationType> MovementOrientation { get; set; }
		[Ordinal(7)] [RED("isOnNavmesh")] public CBool IsOnNavmesh { get; set; }
		[Ordinal(8)] [RED("isReachable")] public CBool IsReachable { get; set; }
		[Ordinal(9)] [RED("overObstacle")] public CBool OverObstacle { get; set; }

		public gameSmartObjectPropertyDictionaryPropertyEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
