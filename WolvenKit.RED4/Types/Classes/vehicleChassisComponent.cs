using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleChassisComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("collisionResource")] 
		public CResourceReference<physicsSystemResource> CollisionResource
		{
			get => GetPropertyValue<CResourceReference<physicsSystemResource>>();
			set => SetPropertyValue<CResourceReference<physicsSystemResource>>(value);
		}

		[Ordinal(6)] 
		[RED("optionalPlayerOnlyCollisionResource")] 
		public CResourceReference<physicsSystemResource> OptionalPlayerOnlyCollisionResource
		{
			get => GetPropertyValue<CResourceReference<physicsSystemResource>>();
			set => SetPropertyValue<CResourceReference<physicsSystemResource>>(value);
		}

		public vehicleChassisComponent()
		{
			Name = "Chassis";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
