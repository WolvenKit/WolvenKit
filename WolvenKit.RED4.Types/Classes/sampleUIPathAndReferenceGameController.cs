using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleUIPathAndReferenceGameController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _textWidget;
		private inkWidgetPath _imageWidgetPath;
		private CWeakHandle<inkImageWidget> _imageWidget;
		private CWeakHandle<inkBasePanelWidget> _panelWidget;

		[Ordinal(2)] 
		[RED("textWidget")] 
		public inkTextWidgetReference TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}

		[Ordinal(3)] 
		[RED("imageWidgetPath")] 
		public inkWidgetPath ImageWidgetPath
		{
			get => GetProperty(ref _imageWidgetPath);
			set => SetProperty(ref _imageWidgetPath, value);
		}

		[Ordinal(4)] 
		[RED("imageWidget")] 
		public CWeakHandle<inkImageWidget> ImageWidget
		{
			get => GetProperty(ref _imageWidget);
			set => SetProperty(ref _imageWidget, value);
		}

		[Ordinal(5)] 
		[RED("panelWidget")] 
		public CWeakHandle<inkBasePanelWidget> PanelWidget
		{
			get => GetProperty(ref _panelWidget);
			set => SetProperty(ref _panelWidget, value);
		}
	}
}
