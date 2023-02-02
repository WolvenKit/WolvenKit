using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCrowdNullAreaCollisionData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("areaID")] 
		public CUInt64 AreaID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("collisions")] 
		public CArray<worldTrafficStaticCollisionSphere> Collisions
		{
			get => GetPropertyValue<CArray<worldTrafficStaticCollisionSphere>>();
			set => SetPropertyValue<CArray<worldTrafficStaticCollisionSphere>>(value);
		}

		public worldCrowdNullAreaCollisionData()
		{
			Collisions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
