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
			Header = new rendRenderParticleBlobHeader { EmitterInfo = new rendRenderParticleBlobEmitterInfo { RenderObjectType = Enums.ERenderObjectType.ROT_Static, VolumetricParticleColor = new HDRColor() } };
			UpdaterData = new rendRenderParticleUpdaterData();
			GpuSimShaders = new rendEmitterSimulationShaders();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
