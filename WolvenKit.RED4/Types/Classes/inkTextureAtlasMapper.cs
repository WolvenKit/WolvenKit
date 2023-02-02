using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkTextureAtlasMapper : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("clippingRectInPixels")] 
		public Rect ClippingRectInPixels
		{
			get => GetPropertyValue<Rect>();
			set => SetPropertyValue<Rect>(value);
		}

		[Ordinal(2)] 
		[RED("clippingRectInUVCoords")] 
		public RectF ClippingRectInUVCoords
		{
			get => GetPropertyValue<RectF>();
			set => SetPropertyValue<RectF>(value);
		}

		public inkTextureAtlasMapper()
		{
			ClippingRectInPixels = new();
			ClippingRectInUVCoords = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
