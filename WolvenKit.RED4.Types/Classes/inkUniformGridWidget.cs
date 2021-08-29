using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkUniformGridWidget : inkCompoundWidget
	{
		private CUInt32 _wrappingWidgetCount;
		private CEnum<inkEOrientation> _orientation;

		[Ordinal(23)] 
		[RED("wrappingWidgetCount")] 
		public CUInt32 WrappingWidgetCount
		{
			get => GetProperty(ref _wrappingWidgetCount);
			set => SetProperty(ref _wrappingWidgetCount, value);
		}

		[Ordinal(24)] 
		[RED("orientation")] 
		public CEnum<inkEOrientation> Orientation
		{
			get => GetProperty(ref _orientation);
			set => SetProperty(ref _orientation, value);
		}
	}
}
