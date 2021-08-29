using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkTextureAtlasSlice : RedBaseClass
	{
		private CName _partName;
		private RectF _nineSliceScaleRect;

		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetProperty(ref _partName);
			set => SetProperty(ref _partName, value);
		}

		[Ordinal(1)] 
		[RED("nineSliceScaleRect")] 
		public RectF NineSliceScaleRect
		{
			get => GetProperty(ref _nineSliceScaleRect);
			set => SetProperty(ref _nineSliceScaleRect, value);
		}
	}
}
