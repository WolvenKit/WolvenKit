using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NarrativePlateLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _textWidget;
		private inkWidgetReference _captionWidget;
		private inkWidgetReference _root;

		[Ordinal(1)] 
		[RED("textWidget")] 
		public inkWidgetReference TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}

		[Ordinal(2)] 
		[RED("captionWidget")] 
		public inkWidgetReference CaptionWidget
		{
			get => GetProperty(ref _captionWidget);
			set => SetProperty(ref _captionWidget, value);
		}

		[Ordinal(3)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}
	}
}
