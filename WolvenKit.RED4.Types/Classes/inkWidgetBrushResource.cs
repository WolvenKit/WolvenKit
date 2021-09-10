using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetBrushResource : CResource
	{
		[Ordinal(1)] 
		[RED("brush")] 
		public CHandle<inkWidgetBrush> Brush
		{
			get => GetPropertyValue<CHandle<inkWidgetBrush>>();
			set => SetPropertyValue<CHandle<inkWidgetBrush>>(value);
		}
	}
}
