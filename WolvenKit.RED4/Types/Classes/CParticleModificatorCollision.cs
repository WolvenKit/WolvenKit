using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorCollision : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("restitution")] 
		public CFloat Restitution
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("dynamicFriction")] 
		public CFloat DynamicFriction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("staticFriction")] 
		public CFloat StaticFriction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("velocityDamp")] 
		public CFloat VelocityDamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("angularVelocityDamp")] 
		public CFloat AngularVelocityDamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("particleMass")] 
		public CFloat ParticleMass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("particleRadius")] 
		public CFloat ParticleRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("useGPUAcceleration")] 
		public CBool UseGPUAcceleration
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("disableGravity")] 
		public CBool DisableGravity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("killOnCollision")] 
		public CBool KillOnCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CParticleModificatorCollision()
		{
			EditorName = "Collision";
			EditorGroup = "Physics";
			IsEnabled = true;
			DynamicFriction = 0.050000F;
			AngularVelocityDamp = 0.500000F;
			ParticleMass = 0.100000F;
			ParticleRadius = 0.010000F;
			UseGPUAcceleration = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
