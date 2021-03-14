using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorCollision : IParticleModificator
	{
		private CFloat _restitution;
		private CFloat _dynamicFriction;
		private CFloat _staticFriction;
		private CFloat _velocityDamp;
		private CFloat _angularVelocityDamp;
		private CFloat _particleMass;
		private CFloat _particleRadius;
		private CBool _useGPUAcceleration;
		private CBool _disableGravity;
		private CBool _killOnCollision;

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("dynamicFriction")] 
		public CFloat DynamicFriction
		{
			get
			{
				if (_dynamicFriction == null)
				{
					_dynamicFriction = (CFloat) CR2WTypeManager.Create("Float", "dynamicFriction", cr2w, this);
				}
				return _dynamicFriction;
			}
			set
			{
				if (_dynamicFriction == value)
				{
					return;
				}
				_dynamicFriction = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("staticFriction")] 
		public CFloat StaticFriction
		{
			get
			{
				if (_staticFriction == null)
				{
					_staticFriction = (CFloat) CR2WTypeManager.Create("Float", "staticFriction", cr2w, this);
				}
				return _staticFriction;
			}
			set
			{
				if (_staticFriction == value)
				{
					return;
				}
				_staticFriction = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("velocityDamp")] 
		public CFloat VelocityDamp
		{
			get
			{
				if (_velocityDamp == null)
				{
					_velocityDamp = (CFloat) CR2WTypeManager.Create("Float", "velocityDamp", cr2w, this);
				}
				return _velocityDamp;
			}
			set
			{
				if (_velocityDamp == value)
				{
					return;
				}
				_velocityDamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("angularVelocityDamp")] 
		public CFloat AngularVelocityDamp
		{
			get
			{
				if (_angularVelocityDamp == null)
				{
					_angularVelocityDamp = (CFloat) CR2WTypeManager.Create("Float", "angularVelocityDamp", cr2w, this);
				}
				return _angularVelocityDamp;
			}
			set
			{
				if (_angularVelocityDamp == value)
				{
					return;
				}
				_angularVelocityDamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("particleMass")] 
		public CFloat ParticleMass
		{
			get
			{
				if (_particleMass == null)
				{
					_particleMass = (CFloat) CR2WTypeManager.Create("Float", "particleMass", cr2w, this);
				}
				return _particleMass;
			}
			set
			{
				if (_particleMass == value)
				{
					return;
				}
				_particleMass = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("particleRadius")] 
		public CFloat ParticleRadius
		{
			get
			{
				if (_particleRadius == null)
				{
					_particleRadius = (CFloat) CR2WTypeManager.Create("Float", "particleRadius", cr2w, this);
				}
				return _particleRadius;
			}
			set
			{
				if (_particleRadius == value)
				{
					return;
				}
				_particleRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("useGPUAcceleration")] 
		public CBool UseGPUAcceleration
		{
			get
			{
				if (_useGPUAcceleration == null)
				{
					_useGPUAcceleration = (CBool) CR2WTypeManager.Create("Bool", "useGPUAcceleration", cr2w, this);
				}
				return _useGPUAcceleration;
			}
			set
			{
				if (_useGPUAcceleration == value)
				{
					return;
				}
				_useGPUAcceleration = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("disableGravity")] 
		public CBool DisableGravity
		{
			get
			{
				if (_disableGravity == null)
				{
					_disableGravity = (CBool) CR2WTypeManager.Create("Bool", "disableGravity", cr2w, this);
				}
				return _disableGravity;
			}
			set
			{
				if (_disableGravity == value)
				{
					return;
				}
				_disableGravity = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("killOnCollision")] 
		public CBool KillOnCollision
		{
			get
			{
				if (_killOnCollision == null)
				{
					_killOnCollision = (CBool) CR2WTypeManager.Create("Bool", "killOnCollision", cr2w, this);
				}
				return _killOnCollision;
			}
			set
			{
				if (_killOnCollision == value)
				{
					return;
				}
				_killOnCollision = value;
				PropertySet(this);
			}
		}

		public CParticleModificatorCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
