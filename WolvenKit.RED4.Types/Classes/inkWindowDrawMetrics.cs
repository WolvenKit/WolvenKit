using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWindowDrawMetrics : RedBaseClass
	{
		private CArray<Vector2> _allTextures;
		private CArray<Vector2> _textureSizeTypes;
		private CArray<CUInt32> _textureTypeTotal;
		private CArray<CUInt32> _maxUsedTextureTypes;
		private CArray<inkSingleDrawMetric> _drawMetrics;

		[Ordinal(0)] 
		[RED("allTextures")] 
		public CArray<Vector2> AllTextures
		{
			get => GetProperty(ref _allTextures);
			set => SetProperty(ref _allTextures, value);
		}

		[Ordinal(1)] 
		[RED("textureSizeTypes")] 
		public CArray<Vector2> TextureSizeTypes
		{
			get => GetProperty(ref _textureSizeTypes);
			set => SetProperty(ref _textureSizeTypes, value);
		}

		[Ordinal(2)] 
		[RED("textureTypeTotal")] 
		public CArray<CUInt32> TextureTypeTotal
		{
			get => GetProperty(ref _textureTypeTotal);
			set => SetProperty(ref _textureTypeTotal, value);
		}

		[Ordinal(3)] 
		[RED("maxUsedTextureTypes")] 
		public CArray<CUInt32> MaxUsedTextureTypes
		{
			get => GetProperty(ref _maxUsedTextureTypes);
			set => SetProperty(ref _maxUsedTextureTypes, value);
		}

		[Ordinal(4)] 
		[RED("drawMetrics")] 
		public CArray<inkSingleDrawMetric> DrawMetrics
		{
			get => GetProperty(ref _drawMetrics);
			set => SetProperty(ref _drawMetrics, value);
		}
	}
}
