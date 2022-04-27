using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkBrushWrapper : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("brush")] 
		public CHandle<inkWidgetBrush> Brush
		{
			get => GetPropertyValue<CHandle<inkWidgetBrush>>();
			set => SetPropertyValue<CHandle<inkWidgetBrush>>(value);
		}

		[Ordinal(1)] 
		[RED("externalBrush")] 
		public CResourceReference<inkWidgetBrushResource> ExternalBrush
		{
			get => GetPropertyValue<CResourceReference<inkWidgetBrushResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetBrushResource>>(value);
		}

		public inkBrushWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
