using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficCollisionGroupNode : worldNode
	{
		[Ordinal(4)] [RED("collisionEntries")] public CArray<worldCollisionGroupEntry> CollisionEntries { get; set; }

		public worldTrafficCollisionGroupNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
