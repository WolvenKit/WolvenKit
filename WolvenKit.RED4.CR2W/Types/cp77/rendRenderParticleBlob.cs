using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderParticleBlob : IRenderResourceBlob
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

		public rendRenderParticleBlob(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
