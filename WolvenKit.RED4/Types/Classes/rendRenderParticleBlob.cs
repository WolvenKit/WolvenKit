using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderParticleBlob : IRenderResourceBlob
	{
		[Ordinal(0)] 
		[RED("header")] 
		public rendRenderParticleBlobHeader Header
		{
			get => GetPropertyValue<rendRenderParticleBlobHeader>();
			set => SetPropertyValue<rendRenderParticleBlobHeader>(value);
		}

		[Ordinal(1)] 
		[RED("updaterData")] 
		public rendRenderParticleUpdaterData UpdaterData
		{
			get => GetPropertyValue<rendRenderParticleUpdaterData>();
			set => SetPropertyValue<rendRenderParticleUpdaterData>(value);
		}

		[Ordinal(2)] 
		[RED("gpuSimShaders")] 
		public rendEmitterSimulationShaders GpuSimShaders
		{
			get => GetPropertyValue<rendEmitterSimulationShaders>();
			set => SetPropertyValue<rendEmitterSimulationShaders>(value);
		}

		public rendRenderParticleBlob()
		{
			Header = new rendRenderParticleBlobHeader { EmitterInfo = new rendRenderParticleBlobEmitterInfo { Seeds = new(), Lods = new(), VolumetricParticleColor = new HDRColor(), VolumetricParticleNoiseVelocity = new Vector3() } };
			UpdaterData = new rendRenderParticleUpdaterData { AnimFrameInit = new(), CollisionRadius = 0.100000F, MaxCollisions = 6, EventFrequency = 1.000000F, EventProbability = 1.000000F, RandomPerChannel = true };
			GpuSimShaders = new rendEmitterSimulationShaders { SimCS = new(2) };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
