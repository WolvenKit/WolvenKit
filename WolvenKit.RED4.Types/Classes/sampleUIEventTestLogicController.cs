using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleUIEventTestLogicController : inkWidgetLogicController
	{
		private CName _eventTextWidgetPath;
		private CName _eventVerticalPanelPath;
		private CName _callbackTextWidgetPath;
		private CName _callbackVerticalPanelPath;
		private CName _customCallbackName;
		private CWeakHandle<inkTextWidget> _textWidget;
		private CWeakHandle<inkVerticalPanelWidget> _verticalPanelWidget;
		private CBool _isEnabled;

		[Ordinal(1)] 
		[RED("eventTextWidgetPath")] 
		public CName EventTextWidgetPath
		{
			get => GetProperty(ref _eventTextWidgetPath);
			set => SetProperty(ref _eventTextWidgetPath, value);
		}

		[Ordinal(2)] 
		[RED("eventVerticalPanelPath")] 
		public CName EventVerticalPanelPath
		{
			get => GetProperty(ref _eventVerticalPanelPath);
			set => SetProperty(ref _eventVerticalPanelPath, value);
		}

		[Ordinal(3)] 
		[RED("callbackTextWidgetPath")] 
		public CName CallbackTextWidgetPath
		{
			get => GetProperty(ref _callbackTextWidgetPath);
			set => SetProperty(ref _callbackTextWidgetPath, value);
		}

		[Ordinal(4)] 
		[RED("callbackVerticalPanelPath")] 
		public CName CallbackVerticalPanelPath
		{
			get => GetProperty(ref _callbackVerticalPanelPath);
			set => SetProperty(ref _callbackVerticalPanelPath, value);
		}

		[Ordinal(5)] 
		[RED("customCallbackName")] 
		public CName CustomCallbackName
		{
			get => GetProperty(ref _customCallbackName);
			set => SetProperty(ref _customCallbackName, value);
		}

		[Ordinal(6)] 
		[RED("textWidget")] 
		public CWeakHandle<inkTextWidget> TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}

		[Ordinal(7)] 
		[RED("verticalPanelWidget")] 
		public CWeakHandle<inkVerticalPanelWidget> VerticalPanelWidget
		{
			get => GetProperty(ref _verticalPanelWidget);
			set => SetProperty(ref _verticalPanelWidget, value);
		}

		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}
	}
}
