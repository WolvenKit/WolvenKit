using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkCompositionPreviewSettings : ISerializable
	{
		private CName _sourceState;
		private CName _targetState;
		private CEnum<inkETextureResolution> _previewResolution;
		private CResourceAsyncReference<CBitmapTexture> _gameFrameTexture;
		private CResourceAsyncReference<inkTextureAtlas> _textureAtlas;
		private CName _texturePart;

		[Ordinal(0)] 
		[RED("sourceState")] 
		public CName SourceState
		{
			get => GetProperty(ref _sourceState);
			set => SetProperty(ref _sourceState, value);
		}

		[Ordinal(1)] 
		[RED("targetState")] 
		public CName TargetState
		{
			get => GetProperty(ref _targetState);
			set => SetProperty(ref _targetState, value);
		}

		[Ordinal(2)] 
		[RED("previewResolution")] 
		public CEnum<inkETextureResolution> PreviewResolution
		{
			get => GetProperty(ref _previewResolution);
			set => SetProperty(ref _previewResolution, value);
		}

		[Ordinal(3)] 
		[RED("gameFrameTexture")] 
		public CResourceAsyncReference<CBitmapTexture> GameFrameTexture
		{
			get => GetProperty(ref _gameFrameTexture);
			set => SetProperty(ref _gameFrameTexture, value);
		}

		[Ordinal(4)] 
		[RED("textureAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas
		{
			get => GetProperty(ref _textureAtlas);
			set => SetProperty(ref _textureAtlas, value);
		}

		[Ordinal(5)] 
		[RED("texturePart")] 
		public CName TexturePart
		{
			get => GetProperty(ref _texturePart);
			set => SetProperty(ref _texturePart, value);
		}

		public inkCompositionPreviewSettings()
		{
			_previewResolution = new() { Value = Enums.inkETextureResolution.HD_1280_720 };
		}
	}
}
