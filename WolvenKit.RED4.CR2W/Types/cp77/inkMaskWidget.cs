using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkMaskWidget : inkLeafWidget
	{
		private raRef<inkTextureAtlas> _textureAtlas;
		private CName _texturePart;
		private CName _dynamicTextureMask;
		private CEnum<inkMaskDataSource> _dataSource;
		private CBool _invertMask;
		private CFloat _maskTransparency;

		[Ordinal(20)] 
		[RED("textureAtlas")] 
		public raRef<inkTextureAtlas> TextureAtlas
		{
			get => GetProperty(ref _textureAtlas);
			set => SetProperty(ref _textureAtlas, value);
		}

		[Ordinal(21)] 
		[RED("texturePart")] 
		public CName TexturePart
		{
			get => GetProperty(ref _texturePart);
			set => SetProperty(ref _texturePart, value);
		}

		[Ordinal(22)] 
		[RED("dynamicTextureMask")] 
		public CName DynamicTextureMask
		{
			get => GetProperty(ref _dynamicTextureMask);
			set => SetProperty(ref _dynamicTextureMask, value);
		}

		[Ordinal(23)] 
		[RED("dataSource")] 
		public CEnum<inkMaskDataSource> DataSource
		{
			get => GetProperty(ref _dataSource);
			set => SetProperty(ref _dataSource, value);
		}

		[Ordinal(24)] 
		[RED("invertMask")] 
		public CBool InvertMask
		{
			get => GetProperty(ref _invertMask);
			set => SetProperty(ref _invertMask, value);
		}

		[Ordinal(25)] 
		[RED("maskTransparency")] 
		public CFloat MaskTransparency
		{
			get => GetProperty(ref _maskTransparency);
			set => SetProperty(ref _maskTransparency, value);
		}

		public inkMaskWidget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
