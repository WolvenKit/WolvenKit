using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnscreenMessageGameController : gameuiHUDGameController
	{
		private wCHandle<inkWidget> _root;
		private wCHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_NotificationsDef> _blackboardDef;
		private CHandle<redCallbackObject> _screenMessageUpdateCallbackId;
		private gameSimpleScreenMessage _screenMessage;
		private inkTextWidgetReference _mainTextWidget;
		private CHandle<inkanimDefinition> _blinkingAnim;
		private CHandle<inkanimDefinition> _showAnim;
		private CHandle<inkanimDefinition> _hideAnim;
		private CHandle<inkanimProxy> _animProxyShow;
		private CHandle<inkanimProxy> _animProxyHide;
		private CHandle<inkanimProxy> _animProxyTimeout;

		[Ordinal(9)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(10)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(11)] 
		[RED("blackboardDef")] 
		public CHandle<UI_NotificationsDef> BlackboardDef
		{
			get => GetProperty(ref _blackboardDef);
			set => SetProperty(ref _blackboardDef, value);
		}

		[Ordinal(12)] 
		[RED("screenMessageUpdateCallbackId")] 
		public CHandle<redCallbackObject> ScreenMessageUpdateCallbackId
		{
			get => GetProperty(ref _screenMessageUpdateCallbackId);
			set => SetProperty(ref _screenMessageUpdateCallbackId, value);
		}

		[Ordinal(13)] 
		[RED("screenMessage")] 
		public gameSimpleScreenMessage ScreenMessage
		{
			get => GetProperty(ref _screenMessage);
			set => SetProperty(ref _screenMessage, value);
		}

		[Ordinal(14)] 
		[RED("mainTextWidget")] 
		public inkTextWidgetReference MainTextWidget
		{
			get => GetProperty(ref _mainTextWidget);
			set => SetProperty(ref _mainTextWidget, value);
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

		public OnscreenMessageGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
