using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CTextureArrayEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("texture")] 
		public CResourceReference<CBitmapTexture> Texture
		{
			get => GetPropertyValue<CResourceReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceReference<CBitmapTexture>>(value);
		}
	}
}
