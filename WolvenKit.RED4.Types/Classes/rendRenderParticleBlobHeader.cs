using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderParticleBlobHeader : RedBaseClass
	{
		private CUInt32 _version;
		private rendRenderParticleBlobEmitterInfo _emitterInfo;

		[Ordinal(0)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		[Ordinal(1)] 
		[RED("emitterInfo")] 
		public rendRenderParticleBlobEmitterInfo EmitterInfo
		{
			get => GetProperty(ref _emitterInfo);
			set => SetProperty(ref _emitterInfo, value);
		}
	}
}
