using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkUniformGridWidget : inkCompoundWidget
	{
		[Ordinal(23)] 
		[RED("wrappingWidgetCount")] 
		public CUInt32 WrappingWidgetCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(24)] 
		[RED("orientation")] 
		public CEnum<inkEOrientation> Orientation
		{
			get => GetPropertyValue<CEnum<inkEOrientation>>();
			set => SetPropertyValue<CEnum<inkEOrientation>>(value);
		}

		public inkUniformGridWidget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
