using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkTextureSlot : RedBaseClass
	{
		private CResourceAsyncReference<CBitmapTexture> _texture;
		private CArray<inkTextureAtlasMapper> _parts;
		private CArray<inkTextureAtlasSlice> _slices;

		[Ordinal(0)] 
		[RED("texture")] 
		public CResourceAsyncReference<CBitmapTexture> Texture
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

		[Ordinal(2)] 
		[RED("slices")] 
		public CArray<inkTextureAtlasSlice> Slices
		{
			get => GetProperty(ref _slices);
			set => SetProperty(ref _slices, value);
		}
	}
}
