using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStaticLaneCollisions : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lane")] 
		public worldTrafficLaneUID Lane
		{
			get => GetPropertyValue<worldTrafficLaneUID>();
			set => SetPropertyValue<worldTrafficLaneUID>(value);
		}

		[Ordinal(1)] 
		[RED("collisions")] 
		public CArray<worldTrafficStaticCollisionSphere> Collisions
		{
			get => GetPropertyValue<CArray<worldTrafficStaticCollisionSphere>>();
			set => SetPropertyValue<CArray<worldTrafficStaticCollisionSphere>>(value);
		}

		[Ordinal(2)] 
		[RED("deadEndStart")] 
		public CFloat DeadEndStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldStaticLaneCollisions()
		{
			Lane = new();
			Collisions = new();
			DeadEndStart = float.PositiveInfinity;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
