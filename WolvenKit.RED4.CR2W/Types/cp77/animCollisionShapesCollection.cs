using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCollisionShapesCollection : ISerializable
	{
		[Ordinal(0)] [RED("collisionRoundedShapes")] public CArray<animCollisionRoundedShape> CollisionRoundedShapes { get; set; }

		public animCollisionShapesCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
