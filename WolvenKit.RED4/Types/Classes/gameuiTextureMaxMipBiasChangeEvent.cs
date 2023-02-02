using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTextureMaxMipBiasChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("textureMaxMipBias")] 
		public CUInt32 TextureMaxMipBias
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameuiTextureMaxMipBiasChangeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
