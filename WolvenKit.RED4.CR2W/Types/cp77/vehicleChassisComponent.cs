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
			get
			{
				if (_collisionResource == null)
				{
					_collisionResource = (rRef<physicsSystemResource>) CR2WTypeManager.Create("rRef:physicsSystemResource", "collisionResource", cr2w, this);
				}
				return _collisionResource;
			}
			set
			{
				if (_collisionResource == value)
				{
					return;
				}
				_collisionResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("optionalPlayerOnlyCollisionResource")] 
		public rRef<physicsSystemResource> OptionalPlayerOnlyCollisionResource
		{
			get
			{
				if (_optionalPlayerOnlyCollisionResource == null)
				{
					_optionalPlayerOnlyCollisionResource = (rRef<physicsSystemResource>) CR2WTypeManager.Create("rRef:physicsSystemResource", "optionalPlayerOnlyCollisionResource", cr2w, this);
				}
				return _optionalPlayerOnlyCollisionResource;
			}
			set
			{
				if (_optionalPlayerOnlyCollisionResource == value)
				{
					return;
				}
				_optionalPlayerOnlyCollisionResource = value;
				PropertySet(this);
			}
		}

		public vehicleChassisComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
