using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WarningMessageGameController : gameuiHUDGameController
	{
		private CWeakHandle<inkWidget> _root;
		private inkTextWidgetReference _mainTextWidget;
		private CWeakHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_NotificationsDef> _blackboardDef;
		private CHandle<redCallbackObject> _warningMessageCallbackId;
		private gameSimpleScreenMessage _simpleMessage;
		private CHandle<inkanimDefinition> _blinkingAnim;
		private CHandle<inkanimDefinition> _showAnim;
		private CHandle<inkanimDefinition> _hideAnim;
		private CHandle<inkanimProxy> _animProxyShow;
		private CHandle<inkanimProxy> _animProxyHide;
		private CHandle<inkanimProxy> _animProxyTimeout;

		[Ordinal(9)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(10)] 
		[RED("mainTextWidget")] 
		public inkTextWidgetReference MainTextWidget
		{
			get => GetProperty(ref _mainTextWidget);
			set => SetProperty(ref _mainTextWidget, value);
		}

		[Ordinal(11)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(12)] 
		[RED("blackboardDef")] 
		public CHandle<UI_NotificationsDef> BlackboardDef
		{
			get => GetProperty(ref _blackboardDef);
			set => SetProperty(ref _blackboardDef, value);
		}

		[Ordinal(13)] 
		[RED("warningMessageCallbackId")] 
		public CHandle<redCallbackObject> WarningMessageCallbackId
		{
			get => GetProperty(ref _warningMessageCallbackId);
			set => SetProperty(ref _warningMessageCallbackId, value);
		}

		[Ordinal(14)] 
		[RED("simpleMessage")] 
		public gameSimpleScreenMessage SimpleMessage
		{
			get => GetProperty(ref _simpleMessage);
			set => SetProperty(ref _simpleMessage, value);
		}

		[Ordinal(15)] 
		[RED("blinkingAnim")] 
		public CHandle<inkanimDefinition> BlinkingAnim
		{
			get => GetProperty(ref _blinkingAnim);
			set => SetProperty(ref _blinkingAnim, value);
		}

		[Ordinal(16)] 
		[RED("showAnim")] 
		public CHandle<inkanimDefinition> ShowAnim
		{
			get => GetProperty(ref _showAnim);
			set => SetProperty(ref _showAnim, value);
		}

		[Ordinal(17)] 
		[RED("hideAnim")] 
		public CHandle<inkanimDefinition> HideAnim
		{
			get => GetProperty(ref _hideAnim);
			set => SetProperty(ref _hideAnim, value);
		}

		[Ordinal(18)] 
		[RED("animProxyShow")] 
		public CHandle<inkanimProxy> AnimProxyShow
		{
			get => GetProperty(ref _animProxyShow);
			set => SetProperty(ref _animProxyShow, value);
		}

		[Ordinal(19)] 
		[RED("animProxyHide")] 
		public CHandle<inkanimProxy> AnimProxyHide
		{
			get => GetProperty(ref _animProxyHide);
			set => SetProperty(ref _animProxyHide, value);
		}

		[Ordinal(20)] 
		[RED("animProxyTimeout")] 
		public CHandle<inkanimProxy> AnimProxyTimeout
		{
			get => GetProperty(ref _animProxyTimeout);
			set => SetProperty(ref _animProxyTimeout, value);
		}
	}
}
