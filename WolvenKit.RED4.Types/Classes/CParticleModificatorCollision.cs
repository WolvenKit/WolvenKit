using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleModificatorCollision : IParticleModificator
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
			get => GetProperty(ref _restitution);
			set => SetProperty(ref _restitution, value);
		}

		[Ordinal(5)] 
		[RED("dynamicFriction")] 
		public CFloat DynamicFriction
		{
			get => GetProperty(ref _dynamicFriction);
			set => SetProperty(ref _dynamicFriction, value);
		}

		[Ordinal(6)] 
		[RED("staticFriction")] 
		public CFloat StaticFriction
		{
			get => GetProperty(ref _staticFriction);
			set => SetProperty(ref _staticFriction, value);
		}

		[Ordinal(7)] 
		[RED("velocityDamp")] 
		public CFloat VelocityDamp
		{
			get => GetProperty(ref _velocityDamp);
			set => SetProperty(ref _velocityDamp, value);
		}

		[Ordinal(8)] 
		[RED("angularVelocityDamp")] 
		public CFloat AngularVelocityDamp
		{
			get => GetProperty(ref _angularVelocityDamp);
			set => SetProperty(ref _angularVelocityDamp, value);
		}

		[Ordinal(9)] 
		[RED("particleMass")] 
		public CFloat ParticleMass
		{
			get => GetProperty(ref _particleMass);
			set => SetProperty(ref _particleMass, value);
		}

		[Ordinal(10)] 
		[RED("particleRadius")] 
		public CFloat ParticleRadius
		{
			get => GetProperty(ref _particleRadius);
			set => SetProperty(ref _particleRadius, value);
		}

		[Ordinal(11)] 
		[RED("useGPUAcceleration")] 
		public CBool UseGPUAcceleration
		{
			get => GetProperty(ref _useGPUAcceleration);
			set => SetProperty(ref _useGPUAcceleration, value);
		}

		[Ordinal(12)] 
		[RED("disableGravity")] 
		public CBool DisableGravity
		{
			get => GetProperty(ref _disableGravity);
			set => SetProperty(ref _disableGravity, value);
		}

		[Ordinal(13)] 
		[RED("killOnCollision")] 
		public CBool KillOnCollision
		{
			get => GetProperty(ref _killOnCollision);
			set => SetProperty(ref _killOnCollision, value);
		}
	}
}
