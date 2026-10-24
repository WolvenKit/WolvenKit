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
			EmitterInfo = new rendRenderParticleBlobEmitterInfo();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
