using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animDyngParticlesContainer : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("externalForceWS")] 
		public Vector3 ExternalForceWS
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("externalForceWsLink")] 
		public animVectorLink ExternalForceWsLink
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(2)] 
		[RED("particles")] 
		public CArray<animDyngParticle> Particles
		{
			get => GetPropertyValue<CArray<animDyngParticle>>();
			set => SetPropertyValue<CArray<animDyngParticle>>(value);
		}

		[Ordinal(3)] 
		[RED("gravityWS")] 
		public CFloat GravityWS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animDyngParticlesContainer()
		{
			ExternalForceWS = new();
			ExternalForceWsLink = new();
			Particles = new();
			GravityWS = 9.810000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
