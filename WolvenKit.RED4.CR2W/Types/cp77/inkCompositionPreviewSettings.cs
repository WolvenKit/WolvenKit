using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCompositionPreviewSettings : ISerializable
	{
		private CName _sourceState;
		private CName _targetState;
		private CEnum<inkETextureResolution> _previewResolution;
		private raRef<CBitmapTexture> _gameFrameTexture;
		private raRef<inkTextureAtlas> _textureAtlas;
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
		public raRef<CBitmapTexture> GameFrameTexture
		{
			get => GetProperty(ref _gameFrameTexture);
			set => SetProperty(ref _gameFrameTexture, value);
		}

		[Ordinal(4)] 
		[RED("textureAtlas")] 
		public raRef<inkTextureAtlas> TextureAtlas
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

		public inkCompositionPreviewSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
