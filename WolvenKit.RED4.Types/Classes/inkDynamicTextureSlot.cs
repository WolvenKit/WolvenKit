using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkDynamicTextureSlot : RedBaseClass
	{
		private CResourceAsyncReference<DynamicTexture> _texture;
		private CArray<inkTextureAtlasMapper> _parts;

		[Ordinal(0)] 
		[RED("texture")] 
		public CResourceAsyncReference<DynamicTexture> Texture
		{
			get => GetProperty(ref _texture);
			set => SetProperty(ref _texture, value);
		}

		[Ordinal(1)] 
		[RED("parts")] 
		public CArray<inkTextureAtlasMapper> Parts
		{
			get => GetProperty(ref _parts);
			set => SetProperty(ref _parts, value);
		}
	}
}
