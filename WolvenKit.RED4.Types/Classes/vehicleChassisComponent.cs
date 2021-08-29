using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleChassisComponent : entIPlacedComponent
	{
		private CResourceReference<physicsSystemResource> _collisionResource;
		private CResourceReference<physicsSystemResource> _optionalPlayerOnlyCollisionResource;

		[Ordinal(5)] 
		[RED("collisionResource")] 
		public CResourceReference<physicsSystemResource> CollisionResource
		{
			get => GetProperty(ref _collisionResource);
			set => SetProperty(ref _collisionResource, value);
		}

		[Ordinal(6)] 
		[RED("optionalPlayerOnlyCollisionResource")] 
		public CResourceReference<physicsSystemResource> OptionalPlayerOnlyCollisionResource
		{
			get => GetProperty(ref _optionalPlayerOnlyCollisionResource);
			set => SetProperty(ref _optionalPlayerOnlyCollisionResource, value);
		}
	}
}
