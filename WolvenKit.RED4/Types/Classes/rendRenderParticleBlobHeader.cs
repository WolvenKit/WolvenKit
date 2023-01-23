using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderParticleBlobHeader : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("emitterInfo")] 
		public rendRenderParticleBlobEmitterInfo EmitterInfo
		{
			get => GetPropertyValue<rendRenderParticleBlobEmitterInfo>();
			set => SetPropertyValue<rendRenderParticleBlobEmitterInfo>(value);
		}

		public rendRenderParticleBlobHeader()
		{
			EmitterInfo = new() { RenderObjectType = Enums.ERenderObjectType.ROT_Particle, Seeds = new(), Lods = new(), VolumetricParticleColor = new() { Red = 1.000000F, Green = 1.000000F, Blue = 1.000000F, Alpha = 1.000000F }, VolumetricParticleNoiseVelocity = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
