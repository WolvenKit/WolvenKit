using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkDynamicTextureSlot : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("texture")] 
		public CResourceAsyncReference<DynamicTexture> Texture
		{
			get => GetPropertyValue<CResourceAsyncReference<DynamicTexture>>();
			set => SetPropertyValue<CResourceAsyncReference<DynamicTexture>>(value);
		}

		[Ordinal(1)] 
		[RED("parts")] 
		public CArray<inkTextureAtlasMapper> Parts
		{
			get => GetPropertyValue<CArray<inkTextureAtlasMapper>>();
			set => SetPropertyValue<CArray<inkTextureAtlasMapper>>(value);
		}

		public inkDynamicTextureSlot()
		{
			Parts = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
