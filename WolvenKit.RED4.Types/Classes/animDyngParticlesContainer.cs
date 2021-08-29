using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animDyngParticlesContainer : RedBaseClass
	{
		private Vector3 _externalForceWS;
		private animVectorLink _externalForceWsLink;
		private CArray<animDyngParticle> _particles;
		private CFloat _gravityWS;

		[Ordinal(0)] 
		[RED("externalForceWS")] 
		public Vector3 ExternalForceWS
		{
			get => GetProperty(ref _externalForceWS);
			set => SetProperty(ref _externalForceWS, value);
		}

		[Ordinal(1)] 
		[RED("externalForceWsLink")] 
		public animVectorLink ExternalForceWsLink
		{
			get => GetProperty(ref _externalForceWsLink);
			set => SetProperty(ref _externalForceWsLink, value);
		}

		[Ordinal(2)] 
		[RED("particles")] 
		public CArray<animDyngParticle> Particles
		{
			get => GetProperty(ref _particles);
			set => SetProperty(ref _particles, value);
		}

		[Ordinal(3)] 
		[RED("gravityWS")] 
		public CFloat GravityWS
		{
			get => GetProperty(ref _gravityWS);
			set => SetProperty(ref _gravityWS, value);
		}
	}
}
