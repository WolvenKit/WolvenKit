using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleChassisComponent : entIPlacedComponent
	{
		private rRef<physicsSystemResource> _collisionResource;
		private rRef<physicsSystemResource> _optionalPlayerOnlyCollisionResource;

		[Ordinal(5)] 
		[RED("collisionResource")] 
		public rRef<physicsSystemResource> CollisionResource
		{
			get => GetProperty(ref _collisionResource);
			set => SetProperty(ref _collisionResource, value);
		}

		[Ordinal(6)] 
		[RED("optionalPlayerOnlyCollisionResource")] 
		public rRef<physicsSystemResource> OptionalPlayerOnlyCollisionResource
		{
			get => GetProperty(ref _optionalPlayerOnlyCollisionResource);
			set => SetProperty(ref _optionalPlayerOnlyCollisionResource, value);
		}

		public vehicleChassisComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
