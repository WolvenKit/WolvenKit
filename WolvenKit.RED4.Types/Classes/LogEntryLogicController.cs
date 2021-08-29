using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LogEntryLogicController : inkWidgetLogicController
	{
		private CWeakHandle<inkWidget> _root;
		private inkTextWidgetReference _textWidget;
		private CHandle<inkanimProxy> _animProxyTimeout;
		private CHandle<inkanimProxy> _animProxyFadeOut;

		[Ordinal(1)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(2)] 
		[RED("textWidget")] 
		public inkTextWidgetReference TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}

		[Ordinal(3)] 
		[RED("animProxyTimeout")] 
		public CHandle<inkanimProxy> AnimProxyTimeout
		{
			get => GetProperty(ref _animProxyTimeout);
			set => SetProperty(ref _animProxyTimeout, value);
		}

		[Ordinal(4)] 
		[RED("animProxyFadeOut")] 
		public CHandle<inkanimProxy> AnimProxyFadeOut
		{
			get => GetProperty(ref _animProxyFadeOut);
			set => SetProperty(ref _animProxyFadeOut, value);
		}
	}
}
