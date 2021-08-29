using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkBrushWrapper : RedBaseClass
	{
		private CHandle<inkWidgetBrush> _brush;
		private CResourceReference<inkWidgetBrushResource> _externalBrush;

		[Ordinal(0)] 
		[RED("brush")] 
		public CHandle<inkWidgetBrush> Brush
		{
			get => GetProperty(ref _brush);
			set => SetProperty(ref _brush, value);
		}

		[Ordinal(1)] 
		[RED("externalBrush")] 
		public CResourceReference<inkWidgetBrushResource> ExternalBrush
		{
			get => GetProperty(ref _externalBrush);
			set => SetProperty(ref _externalBrush, value);
		}
	}
}
