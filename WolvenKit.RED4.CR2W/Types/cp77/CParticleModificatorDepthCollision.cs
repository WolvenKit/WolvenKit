using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorDepthCollision : IParticleModificator
	{
		private CUInt32 _maxCollisions;
		private CFloat _restitution;
		private CFloat _friction;
		private CFloat _radius;
		private CEnum<EDepthCollisionEffect> _collisionEffect;

		[Ordinal(4)] 
		[RED("maxCollisions")] 
		public CUInt32 MaxCollisions
		{
			get
			{
				if (_maxCollisions == null)
				{
					_maxCollisions = (CUInt32) CR2WTypeManager.Create("Uint32", "maxCollisions", cr2w, this);
				}
				return _maxCollisions;
			}
			set
			{
				if (_maxCollisions == value)
				{
					return;
				}
				_maxCollisions = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("restitution")] 
		public CFloat Restitution
		{
			get
			{
				if (_restitution == null)
				{
					_restitution = (CFloat) CR2WTypeManager.Create("Float", "restitution", cr2w, this);
				}
				return _restitution;
			}
			set
			{
				if (_restitution == value)
				{
					return;
				}
				_restitution = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("friction")] 
		public CFloat Friction
		{
			get
			{
				if (_friction == null)
				{
					_friction = (CFloat) CR2WTypeManager.Create("Float", "friction", cr2w, this);
				}
				return _friction;
			}
			set
			{
				if (_friction == value)
				{
					return;
				}
				_friction = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("collisionEffect")] 
		public CEnum<EDepthCollisionEffect> CollisionEffect
		{
			get
			{
				if (_collisionEffect == null)
				{
					_collisionEffect = (CEnum<EDepthCollisionEffect>) CR2WTypeManager.Create("EDepthCollisionEffect", "collisionEffect", cr2w, this);
				}
				return _collisionEffect;
			}
			set
			{
				if (_collisionEffect == value)
				{
					return;
				}
				_collisionEffect = value;
				PropertySet(this);
			}
		}

		public CParticleModificatorDepthCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
