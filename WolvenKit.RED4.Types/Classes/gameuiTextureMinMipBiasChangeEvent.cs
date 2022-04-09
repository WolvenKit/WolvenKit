using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTextureMinMipBiasChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("textureMinMipBias")] 
		public CUInt32 TextureMinMipBias
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameuiTextureMinMipBiasChangeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
