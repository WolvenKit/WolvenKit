using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkTextureSlot : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("texture")] 
		public CResourceAsyncReference<CBitmapTexture> Texture
		{
			get => GetPropertyValue<CResourceAsyncReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceAsyncReference<CBitmapTexture>>(value);
		}

		[Ordinal(1)] 
		[RED("parts")] 
		public CArray<inkTextureAtlasMapper> Parts
		{
			get => GetPropertyValue<CArray<inkTextureAtlasMapper>>();
			set => SetPropertyValue<CArray<inkTextureAtlasMapper>>(value);
		}

		[Ordinal(2)] 
		[RED("slices")] 
		public CArray<inkTextureAtlasSlice> Slices
		{
			get => GetPropertyValue<CArray<inkTextureAtlasSlice>>();
			set => SetPropertyValue<CArray<inkTextureAtlasSlice>>(value);
		}

		public inkTextureSlot()
		{
			Parts = new();
			Slices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
