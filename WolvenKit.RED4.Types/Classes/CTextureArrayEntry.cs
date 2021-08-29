using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CTextureArrayEntry : RedBaseClass
	{
		private CResourceReference<CBitmapTexture> _texture;

		[Ordinal(0)] 
		[RED("texture")] 
		public CResourceReference<CBitmapTexture> Texture
		{
			get => GetProperty(ref _texture);
			set => SetProperty(ref _texture, value);
		}
	}
}
