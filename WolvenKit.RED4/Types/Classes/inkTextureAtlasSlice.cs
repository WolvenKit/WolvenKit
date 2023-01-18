using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkTextureAtlasSlice : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("nineSliceScaleRect")] 
		public RectF NineSliceScaleRect
		{
			get => GetPropertyValue<RectF>();
			set => SetPropertyValue<RectF>(value);
		}

		public inkTextureAtlasSlice()
		{
			NineSliceScaleRect = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
