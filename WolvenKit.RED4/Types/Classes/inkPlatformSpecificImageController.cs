using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkPlatformSpecificImageController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("textureAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(2)] 
		[RED("textureAtlas_PS4")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas_PS4
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(3)] 
		[RED("textureAtlas_Prospero")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas_Prospero
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(4)] 
		[RED("textureAtlas_XB1")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas_XB1
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(5)] 
		[RED("textureAtlas_Scarlett")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas_Scarlett
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(6)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("partName_PS4")] 
		public CName PartName_PS4
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("partName_Prospero")] 
		public CName PartName_Prospero
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("partName_XB1")] 
		public CName PartName_XB1
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("partName_Scarlett")] 
		public CName PartName_Scarlett
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkPlatformSpecificImageController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
