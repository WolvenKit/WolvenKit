using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TextSectionLogicController : inkWidgetLogicController
	{
		private CWeakHandle<inkWidget> _rootWidget;
		private CWeakHandle<inkTextWidget> _textWidget;
		private CHandle<inkanimProxy> _showAnimProxy;

		[Ordinal(1)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(2)] 
		[RED("textWidget")] 
		public CWeakHandle<inkTextWidget> TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}

		[Ordinal(3)] 
		[RED("showAnimProxy")] 
		public CHandle<inkanimProxy> ShowAnimProxy
		{
			get => GetProperty(ref _showAnimProxy);
			set => SetProperty(ref _showAnimProxy, value);
		}
	}
}
