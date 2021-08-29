using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkPlatformSpecificImageController : inkWidgetLogicController
	{
		private CResourceAsyncReference<inkTextureAtlas> _textureAtlas;
		private CResourceAsyncReference<inkTextureAtlas> _textureAtlas_PS4;
		private CResourceAsyncReference<inkTextureAtlas> _textureAtlas_XB1;
		private CName _partName;
		private CName _partName_PS4;
		private CName _partName_XB1;

		[Ordinal(1)] 
		[RED("textureAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas
		{
			get => GetProperty(ref _textureAtlas);
			set => SetProperty(ref _textureAtlas, value);
		}

		[Ordinal(2)] 
		[RED("textureAtlas_PS4")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas_PS4
		{
			get => GetProperty(ref _textureAtlas_PS4);
			set => SetProperty(ref _textureAtlas_PS4, value);
		}

		[Ordinal(3)] 
		[RED("textureAtlas_XB1")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas_XB1
		{
			get => GetProperty(ref _textureAtlas_XB1);
			set => SetProperty(ref _textureAtlas_XB1, value);
		}

		[Ordinal(4)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetProperty(ref _partName);
			set => SetProperty(ref _partName, value);
		}

		[Ordinal(5)] 
		[RED("partName_PS4")] 
		public CName PartName_PS4
		{
			get => GetProperty(ref _partName_PS4);
			set => SetProperty(ref _partName_PS4, value);
		}

		[Ordinal(6)] 
		[RED("partName_XB1")] 
		public CName PartName_XB1
		{
			get => GetProperty(ref _partName_XB1);
			set => SetProperty(ref _partName_XB1, value);
		}
	}
}
