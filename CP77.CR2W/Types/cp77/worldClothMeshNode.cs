using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldClothMeshNode : worldMeshNode
	{
		[Ordinal(0)]  [RED("affectedByWind")] public CBool AffectedByWind { get; set; }
		[Ordinal(1)]  [RED("collisionMask")] public physicsEClothCollisionMaskEnum CollisionMask { get; set; }

		public worldClothMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
