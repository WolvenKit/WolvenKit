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
			get => GetProperty(ref _collisionEntries);
			set => SetProperty(ref _collisionEntries, value);
		}

		public worldTrafficCollisionGroupNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
