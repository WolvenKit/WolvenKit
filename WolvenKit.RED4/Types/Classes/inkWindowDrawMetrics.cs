using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWindowDrawMetrics : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("allTextures")] 
		public CArray<Vector2> AllTextures
		{
			get => GetPropertyValue<CArray<Vector2>>();
			set => SetPropertyValue<CArray<Vector2>>(value);
		}

		[Ordinal(1)] 
		[RED("textureSizeTypes")] 
		public CArray<Vector2> TextureSizeTypes
		{
			get => GetPropertyValue<CArray<Vector2>>();
			set => SetPropertyValue<CArray<Vector2>>(value);
		}

		[Ordinal(2)] 
		[RED("textureTypeTotal")] 
		public CArray<CUInt32> TextureTypeTotal
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(3)] 
		[RED("maxUsedTextureTypes")] 
		public CArray<CUInt32> MaxUsedTextureTypes
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(4)] 
		[RED("drawMetrics")] 
		public CArray<inkSingleDrawMetric> DrawMetrics
		{
			get => GetPropertyValue<CArray<inkSingleDrawMetric>>();
			set => SetPropertyValue<CArray<inkSingleDrawMetric>>(value);
		}

		public inkWindowDrawMetrics()
		{
			AllTextures = new();
			TextureSizeTypes = new();
			TextureTypeTotal = new();
			MaxUsedTextureTypes = new();
			DrawMetrics = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
