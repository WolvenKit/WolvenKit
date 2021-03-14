using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderParticleUpdaterData : CVariable
	{
		private DataBuffer _data;
		private CUInt32 _modifOffset;
		private CArray<CFloat> _animFrameInit;
		private CFloat _turbulenceNoiseInterval;
		private CFloat _turbulenceDuration;
		private CUInt64 _collisionMask;
		private CFloat _collisionDynamicFriction;
		private CFloat _collisionStaticFriction;
		private CFloat _collisionRestitution;
		private CFloat _collisionVelocityDamp;
		private CBool _collisionDisableGravity;
		private CFloat _collisionRadius;
		private CUInt32 _collisionEffectMask;
		private CUInt8 _maxCollisions;
		private CName _eventGenerate;
		private CName _eventReceive;
		private CFloat _eventFrequency;
		private CFloat _eventProbability;
		private CUInt8 _noiseType;
		private CBool _randomPerChannel;
		private CUInt8 _eventSpawnObject;

		[Ordinal(0)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get
			{
				if (_data == null)
				{
					_data = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("modifOffset")] 
		public CUInt32 ModifOffset
		{
			get
			{
				if (_modifOffset == null)
				{
					_modifOffset = (CUInt32) CR2WTypeManager.Create("Uint32", "modifOffset", cr2w, this);
				}
				return _modifOffset;
			}
			set
			{
				if (_modifOffset == value)
				{
					return;
				}
				_modifOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("animFrameInit")] 
		public CArray<CFloat> AnimFrameInit
		{
			get
			{
				if (_animFrameInit == null)
				{
					_animFrameInit = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "animFrameInit", cr2w, this);
				}
				return _animFrameInit;
			}
			set
			{
				if (_animFrameInit == value)
				{
					return;
				}
				_animFrameInit = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("turbulenceNoiseInterval")] 
		public CFloat TurbulenceNoiseInterval
		{
			get
			{
				if (_turbulenceNoiseInterval == null)
				{
					_turbulenceNoiseInterval = (CFloat) CR2WTypeManager.Create("Float", "turbulenceNoiseInterval", cr2w, this);
				}
				return _turbulenceNoiseInterval;
			}
			set
			{
				if (_turbulenceNoiseInterval == value)
				{
					return;
				}
				_turbulenceNoiseInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("turbulenceDuration")] 
		public CFloat TurbulenceDuration
		{
			get
			{
				if (_turbulenceDuration == null)
				{
					_turbulenceDuration = (CFloat) CR2WTypeManager.Create("Float", "turbulenceDuration", cr2w, this);
				}
				return _turbulenceDuration;
			}
			set
			{
				if (_turbulenceDuration == value)
				{
					return;
				}
				_turbulenceDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("collisionMask")] 
		public CUInt64 CollisionMask
		{
			get
			{
				if (_collisionMask == null)
				{
					_collisionMask = (CUInt64) CR2WTypeManager.Create("Uint64", "collisionMask", cr2w, this);
				}
				return _collisionMask;
			}
			set
			{
				if (_collisionMask == value)
				{
					return;
				}
				_collisionMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("collisionDynamicFriction")] 
		public CFloat CollisionDynamicFriction
		{
			get
			{
				if (_collisionDynamicFriction == null)
				{
					_collisionDynamicFriction = (CFloat) CR2WTypeManager.Create("Float", "collisionDynamicFriction", cr2w, this);
				}
				return _collisionDynamicFriction;
			}
			set
			{
				if (_collisionDynamicFriction == value)
				{
					return;
				}
				_collisionDynamicFriction = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("collisionStaticFriction")] 
		public CFloat CollisionStaticFriction
		{
			get
			{
				if (_collisionStaticFriction == null)
				{
					_collisionStaticFriction = (CFloat) CR2WTypeManager.Create("Float", "collisionStaticFriction", cr2w, this);
				}
				return _collisionStaticFriction;
			}
			set
			{
				if (_collisionStaticFriction == value)
				{
					return;
				}
				_collisionStaticFriction = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("collisionRestitution")] 
		public CFloat CollisionRestitution
		{
			get
			{
				if (_collisionRestitution == null)
				{
					_collisionRestitution = (CFloat) CR2WTypeManager.Create("Float", "collisionRestitution", cr2w, this);
				}
				return _collisionRestitution;
			}
			set
			{
				if (_collisionRestitution == value)
				{
					return;
				}
				_collisionRestitution = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("collisionVelocityDamp")] 
		public CFloat CollisionVelocityDamp
		{
			get
			{
				if (_collisionVelocityDamp == null)
				{
					_collisionVelocityDamp = (CFloat) CR2WTypeManager.Create("Float", "collisionVelocityDamp", cr2w, this);
				}
				return _collisionVelocityDamp;
			}
			set
			{
				if (_collisionVelocityDamp == value)
				{
					return;
				}
				_collisionVelocityDamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("collisionDisableGravity")] 
		public CBool CollisionDisableGravity
		{
			get
			{
				if (_collisionDisableGravity == null)
				{
					_collisionDisableGravity = (CBool) CR2WTypeManager.Create("Bool", "collisionDisableGravity", cr2w, this);
				}
				return _collisionDisableGravity;
			}
			set
			{
				if (_collisionDisableGravity == value)
				{
					return;
				}
				_collisionDisableGravity = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("collisionRadius")] 
		public CFloat CollisionRadius
		{
			get
			{
				if (_collisionRadius == null)
				{
					_collisionRadius = (CFloat) CR2WTypeManager.Create("Float", "collisionRadius", cr2w, this);
				}
				return _collisionRadius;
			}
			set
			{
				if (_collisionRadius == value)
				{
					return;
				}
				_collisionRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("collisionEffectMask")] 
		public CUInt32 CollisionEffectMask
		{
			get
			{
				if (_collisionEffectMask == null)
				{
					_collisionEffectMask = (CUInt32) CR2WTypeManager.Create("Uint32", "collisionEffectMask", cr2w, this);
				}
				return _collisionEffectMask;
			}
			set
			{
				if (_collisionEffectMask == value)
				{
					return;
				}
				_collisionEffectMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("maxCollisions")] 
		public CUInt8 MaxCollisions
		{
			get
			{
				if (_maxCollisions == null)
				{
					_maxCollisions = (CUInt8) CR2WTypeManager.Create("Uint8", "maxCollisions", cr2w, this);
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

		[Ordinal(14)] 
		[RED("eventGenerate")] 
		public CName EventGenerate
		{
			get
			{
				if (_eventGenerate == null)
				{
					_eventGenerate = (CName) CR2WTypeManager.Create("CName", "eventGenerate", cr2w, this);
				}
				return _eventGenerate;
			}
			set
			{
				if (_eventGenerate == value)
				{
					return;
				}
				_eventGenerate = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("eventReceive")] 
		public CName EventReceive
		{
			get
			{
				if (_eventReceive == null)
				{
					_eventReceive = (CName) CR2WTypeManager.Create("CName", "eventReceive", cr2w, this);
				}
				return _eventReceive;
			}
			set
			{
				if (_eventReceive == value)
				{
					return;
				}
				_eventReceive = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("eventFrequency")] 
		public CFloat EventFrequency
		{
			get
			{
				if (_eventFrequency == null)
				{
					_eventFrequency = (CFloat) CR2WTypeManager.Create("Float", "eventFrequency", cr2w, this);
				}
				return _eventFrequency;
			}
			set
			{
				if (_eventFrequency == value)
				{
					return;
				}
				_eventFrequency = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("eventProbability")] 
		public CFloat EventProbability
		{
			get
			{
				if (_eventProbability == null)
				{
					_eventProbability = (CFloat) CR2WTypeManager.Create("Float", "eventProbability", cr2w, this);
				}
				return _eventProbability;
			}
			set
			{
				if (_eventProbability == value)
				{
					return;
				}
				_eventProbability = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("noiseType")] 
		public CUInt8 NoiseType
		{
			get
			{
				if (_noiseType == null)
				{
					_noiseType = (CUInt8) CR2WTypeManager.Create("Uint8", "noiseType", cr2w, this);
				}
				return _noiseType;
			}
			set
			{
				if (_noiseType == value)
				{
					return;
				}
				_noiseType = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("randomPerChannel")] 
		public CBool RandomPerChannel
		{
			get
			{
				if (_randomPerChannel == null)
				{
					_randomPerChannel = (CBool) CR2WTypeManager.Create("Bool", "randomPerChannel", cr2w, this);
				}
				return _randomPerChannel;
			}
			set
			{
				if (_randomPerChannel == value)
				{
					return;
				}
				_randomPerChannel = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("eventSpawnObject")] 
		public CUInt8 EventSpawnObject
		{
			get
			{
				if (_eventSpawnObject == null)
				{
					_eventSpawnObject = (CUInt8) CR2WTypeManager.Create("Uint8", "eventSpawnObject", cr2w, this);
				}
				return _eventSpawnObject;
			}
			set
			{
				if (_eventSpawnObject == value)
				{
					return;
				}
				_eventSpawnObject = value;
				PropertySet(this);
			}
		}

		public rendRenderParticleUpdaterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
