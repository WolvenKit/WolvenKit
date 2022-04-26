using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderParticleUpdaterData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(1)] 
		[RED("modifOffset")] 
		public CUInt32 ModifOffset
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("animFrameInit")] 
		public CArray<CFloat> AnimFrameInit
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("turbulenceNoiseInterval")] 
		public CFloat TurbulenceNoiseInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("turbulenceDuration")] 
		public CFloat TurbulenceDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("collisionMask")] 
		public CUInt64 CollisionMask
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(6)] 
		[RED("collisionDynamicFriction")] 
		public CFloat CollisionDynamicFriction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("collisionStaticFriction")] 
		public CFloat CollisionStaticFriction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("collisionRestitution")] 
		public CFloat CollisionRestitution
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("collisionVelocityDamp")] 
		public CFloat CollisionVelocityDamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("collisionDisableGravity")] 
		public CBool CollisionDisableGravity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("collisionRadius")] 
		public CFloat CollisionRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("collisionEffectMask")] 
		public CUInt32 CollisionEffectMask
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(13)] 
		[RED("maxCollisions")] 
		public CUInt8 MaxCollisions
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(14)] 
		[RED("eventGenerate")] 
		public CName EventGenerate
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("eventReceive")] 
		public CName EventReceive
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("eventFrequency")] 
		public CFloat EventFrequency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("eventProbability")] 
		public CFloat EventProbability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("noiseType")] 
		public CUInt8 NoiseType
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(19)] 
		[RED("randomPerChannel")] 
		public CBool RandomPerChannel
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("eventSpawnObject")] 
		public CUInt8 EventSpawnObject
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public rendRenderParticleUpdaterData()
		{
			AnimFrameInit = new();
			CollisionRadius = 0.100000F;
			MaxCollisions = 6;
			EventFrequency = 1.000000F;
			EventProbability = 1.000000F;
			RandomPerChannel = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
