using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficCollisionGroupNode : worldNode
	{
		[Ordinal(4)] 
		[RED("collisionEntries")] 
		public CArray<worldCollisionGroupEntry> CollisionEntries
		{
			get => GetPropertyValue<CArray<worldCollisionGroupEntry>>();
			set => SetPropertyValue<CArray<worldCollisionGroupEntry>>(value);
		}

		public worldTrafficCollisionGroupNode()
		{
			CollisionEntries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
