using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficCollisionGroupNode : worldNode
	{
		private CArray<worldCollisionGroupEntry> _collisionEntries;

		[Ordinal(4)] 
		[RED("collisionEntries")] 
		public CArray<worldCollisionGroupEntry> CollisionEntries
		{
			get => GetProperty(ref _collisionEntries);
			set => SetProperty(ref _collisionEntries, value);
		}
	}
}
