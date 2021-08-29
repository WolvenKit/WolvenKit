using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderParticleBlob : IRenderResourceBlob
	{
		private rendRenderParticleBlobHeader _header;
		private rendRenderParticleUpdaterData _updaterData;
		private rendEmitterSimulationShaders _gpuSimShaders;

		[Ordinal(0)] 
		[RED("header")] 
		public rendRenderParticleBlobHeader Header
		{
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(1)] 
		[RED("updaterData")] 
		public rendRenderParticleUpdaterData UpdaterData
		{
			get => GetProperty(ref _updaterData);
			set => SetProperty(ref _updaterData, value);
		}

		[Ordinal(2)] 
		[RED("gpuSimShaders")] 
		public rendEmitterSimulationShaders GpuSimShaders
		{
			get => GetProperty(ref _gpuSimShaders);
			set => SetProperty(ref _gpuSimShaders, value);
		}
	}
}
