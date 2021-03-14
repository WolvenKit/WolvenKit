using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficCollisionGroupNode : worldNode
	{
		private CArray<worldCollisionGroupEntry> _collisionEntries;

		[Ordinal(4)] 
		[RED("collisionEntries")] 
		public CArray<worldCollisionGroupEntry> CollisionEntries
		{
			get
			{
				if (_collisionEntries == null)
				{
					_collisionEntries = (CArray<worldCollisionGroupEntry>) CR2WTypeManager.Create("array:worldCollisionGroupEntry", "collisionEntries", cr2w, this);
				}
				return _collisionEntries;
			}
			set
			{
				if (_collisionEntries == value)
				{
					return;
				}
				_collisionEntries = value;
				PropertySet(this);
			}
		}

		public worldTrafficCollisionGroupNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
