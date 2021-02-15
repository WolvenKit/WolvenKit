using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldClothMeshNode : worldMeshNode
	{
		[Ordinal(13)] [RED("affectedByWind")] public CBool AffectedByWind { get; set; }
		[Ordinal(14)] [RED("collisionMask")] public CEnum<physicsEClothCollisionMaskEnum> CollisionMask { get; set; }

		public worldClothMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
