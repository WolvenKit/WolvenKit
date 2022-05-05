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
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
