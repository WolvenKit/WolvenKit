using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkQuadShapeWidget : inkBaseShapeWidget
	{
		private CResourceAsyncReference<inkTextureAtlas> _textureAtlas;
		private CName _texturePart;
		private CArray<Vector2> _vertexList;

		[Ordinal(20)] 
		[RED("textureAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas
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
		[RED("vertexList")] 
		public CArray<Vector2> VertexList
		{
			get => GetProperty(ref _vertexList);
			set => SetProperty(ref _vertexList, value);
		}
	}
}
