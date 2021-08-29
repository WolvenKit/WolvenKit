using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkTextureAtlasMapper : RedBaseClass
	{
		private CName _partName;
		private Rect _clippingRectInPixels;
		private RectF _clippingRectInUVCoords;

		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetProperty(ref _partName);
			set => SetProperty(ref _partName, value);
		}

		[Ordinal(1)] 
		[RED("clippingRectInPixels")] 
		public Rect ClippingRectInPixels
		{
			get => GetProperty(ref _clippingRectInPixels);
			set => SetProperty(ref _clippingRectInPixels, value);
		}

		[Ordinal(2)] 
		[RED("clippingRectInUVCoords")] 
		public RectF ClippingRectInUVCoords
		{
			get => GetProperty(ref _clippingRectInUVCoords);
			set => SetProperty(ref _clippingRectInUVCoords, value);
		}
	}
}
