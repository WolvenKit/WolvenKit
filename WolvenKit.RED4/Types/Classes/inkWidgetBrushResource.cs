using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetBrushResource : CResource
	{
		[Ordinal(1)] 
		[RED("brush")] 
		public CHandle<inkWidgetBrush> Brush
		{
			get => GetPropertyValue<CHandle<inkWidgetBrush>>();
			set => SetPropertyValue<CHandle<inkWidgetBrush>>(value);
		}

		public inkWidgetBrushResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
