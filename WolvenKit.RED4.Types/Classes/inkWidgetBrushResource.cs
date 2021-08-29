using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetBrushResource : CResource
	{
		private CHandle<inkWidgetBrush> _brush;

		[Ordinal(1)] 
		[RED("brush")] 
		public CHandle<inkWidgetBrush> Brush
		{
			get => GetProperty(ref _brush);
			set => SetProperty(ref _brush, value);
		}
	}
}
