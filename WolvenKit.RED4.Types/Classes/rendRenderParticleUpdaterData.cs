using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderParticleUpdaterData : RedBaseClass
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
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("modifOffset")] 
		public CUInt32 ModifOffset
		{
			get => GetProperty(ref _modifOffset);
			set => SetProperty(ref _modifOffset, value);
		}

		[Ordinal(2)] 
		[RED("animFrameInit")] 
		public CArray<CFloat> AnimFrameInit
		{
			get => GetProperty(ref _animFrameInit);
			set => SetProperty(ref _animFrameInit, value);
		}

		[Ordinal(3)] 
		[RED("turbulenceNoiseInterval")] 
		public CFloat TurbulenceNoiseInterval
		{
			get => GetProperty(ref _turbulenceNoiseInterval);
			set => SetProperty(ref _turbulenceNoiseInterval, value);
		}

		[Ordinal(4)] 
		[RED("turbulenceDuration")] 
		public CFloat TurbulenceDuration
		{
			get => GetProperty(ref _turbulenceDuration);
			set => SetProperty(ref _turbulenceDuration, value);
		}

		[Ordinal(5)] 
		[RED("collisionMask")] 
		public CUInt64 CollisionMask
		{
			get => GetProperty(ref _collisionMask);
			set => SetProperty(ref _collisionMask, value);
		}

		[Ordinal(6)] 
		[RED("collisionDynamicFriction")] 
		public CFloat CollisionDynamicFriction
		{
			get => GetProperty(ref _collisionDynamicFriction);
			set => SetProperty(ref _collisionDynamicFriction, value);
		}

		[Ordinal(7)] 
		[RED("collisionStaticFriction")] 
		public CFloat CollisionStaticFriction
		{
			get => GetProperty(ref _collisionStaticFriction);
			set => SetProperty(ref _collisionStaticFriction, value);
		}

		[Ordinal(8)] 
		[RED("collisionRestitution")] 
		public CFloat CollisionRestitution
		{
			get => GetProperty(ref _collisionRestitution);
			set => SetProperty(ref _collisionRestitution, value);
		}

		[Ordinal(9)] 
		[RED("collisionVelocityDamp")] 
		public CFloat CollisionVelocityDamp
		{
			get => GetProperty(ref _collisionVelocityDamp);
			set => SetProperty(ref _collisionVelocityDamp, value);
		}

		[Ordinal(10)] 
		[RED("collisionDisableGravity")] 
		public CBool CollisionDisableGravity
		{
			get => GetProperty(ref _collisionDisableGravity);
			set => SetProperty(ref _collisionDisableGravity, value);
		}

		[Ordinal(11)] 
		[RED("collisionRadius")] 
		public CFloat CollisionRadius
		{
			get => GetProperty(ref _collisionRadius);
			set => SetProperty(ref _collisionRadius, value);
		}

		[Ordinal(12)] 
		[RED("collisionEffectMask")] 
		public CUInt32 CollisionEffectMask
		{
			get => GetProperty(ref _collisionEffectMask);
			set => SetProperty(ref _collisionEffectMask, value);
		}

		[Ordinal(13)] 
		[RED("maxCollisions")] 
		public CUInt8 MaxCollisions
		{
			get => GetProperty(ref _maxCollisions);
			set => SetProperty(ref _maxCollisions, value);
		}

		[Ordinal(14)] 
		[RED("eventGenerate")] 
		public CName EventGenerate
		{
			get => GetProperty(ref _eventGenerate);
			set => SetProperty(ref _eventGenerate, value);
		}

		[Ordinal(15)] 
		[RED("eventReceive")] 
		public CName EventReceive
		{
			get => GetProperty(ref _eventReceive);
			set => SetProperty(ref _eventReceive, value);
		}

		[Ordinal(16)] 
		[RED("eventFrequency")] 
		public CFloat EventFrequency
		{
			get => GetProperty(ref _eventFrequency);
			set => SetProperty(ref _eventFrequency, value);
		}

		[Ordinal(17)] 
		[RED("eventProbability")] 
		public CFloat EventProbability
		{
			get => GetProperty(ref _eventProbability);
			set => SetProperty(ref _eventProbability, value);
		}

		[Ordinal(18)] 
		[RED("noiseType")] 
		public CUInt8 NoiseType
		{
			get => GetProperty(ref _noiseType);
			set => SetProperty(ref _noiseType, value);
		}

		[Ordinal(19)] 
		[RED("randomPerChannel")] 
		public CBool RandomPerChannel
		{
			get => GetProperty(ref _randomPerChannel);
			set => SetProperty(ref _randomPerChannel, value);
		}

		[Ordinal(20)] 
		[RED("eventSpawnObject")] 
		public CUInt8 EventSpawnObject
		{
			get => GetProperty(ref _eventSpawnObject);
			set => SetProperty(ref _eventSpawnObject, value);
		}
	}
}
