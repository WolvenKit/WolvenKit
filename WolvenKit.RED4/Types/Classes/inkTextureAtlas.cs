using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkTextureAtlas : CResource
	{
		[Ordinal(1)] 
		[RED("activeTexture")] 
		public CEnum<inkTextureType> ActiveTexture
		{
			get => GetPropertyValue<CEnum<inkTextureType>>();
			set => SetPropertyValue<CEnum<inkTextureType>>(value);
		}

		[Ordinal(2)] 
		[RED("textureResolution")] 
		public CEnum<inkETextureResolution> TextureResolution
		{
			get => GetPropertyValue<CEnum<inkETextureResolution>>();
			set => SetPropertyValue<CEnum<inkETextureResolution>>(value);
		}

		[Ordinal(3)] 
		[RED("texture")] 
		public CResourceAsyncReference<CBitmapTexture> Texture
		{
			get => GetPropertyValue<CResourceAsyncReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceAsyncReference<CBitmapTexture>>(value);
		}

		[Ordinal(4)] 
		[RED("dynamicTexture")] 
		public CResourceAsyncReference<DynamicTexture> DynamicTexture
		{
			get => GetPropertyValue<CResourceAsyncReference<DynamicTexture>>();
			set => SetPropertyValue<CResourceAsyncReference<DynamicTexture>>(value);
		}

		[Ordinal(5)] 
		[RED("parts")] 
		public CArray<inkTextureAtlasMapper> Parts
		{
			get => GetPropertyValue<CArray<inkTextureAtlasMapper>>();
			set => SetPropertyValue<CArray<inkTextureAtlasMapper>>(value);
		}

		[Ordinal(6)] 
		[RED("slices")] 
		public CArray<inkTextureAtlasSlice> Slices
		{
			get => GetPropertyValue<CArray<inkTextureAtlasSlice>>();
			set => SetPropertyValue<CArray<inkTextureAtlasSlice>>(value);
		}

		[Ordinal(7)] 
		[RED("slots", 3)] 
		public CArrayFixedSize<inkTextureSlot> Slots
		{
			get => GetPropertyValue<CArrayFixedSize<inkTextureSlot>>();
			set => SetPropertyValue<CArrayFixedSize<inkTextureSlot>>(value);
		}

		[Ordinal(8)] 
		[RED("dynamicTextureSlot")] 
		public inkDynamicTextureSlot DynamicTextureSlot
		{
			get => GetPropertyValue<inkDynamicTextureSlot>();
			set => SetPropertyValue<inkDynamicTextureSlot>(value);
		}

		[Ordinal(9)] 
		[RED("isSingleTextureMode")] 
		public CBool IsSingleTextureMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkTextureAtlas()
		{
			Parts = new();
			Slices = new();
			Slots = new(3);
			DynamicTextureSlot = new() { Parts = new() };
			IsSingleTextureMode = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
