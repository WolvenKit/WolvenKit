using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HubTimeSkipController : inkWidgetLogicController
	{
		private inkTextWidgetReference _gameTimeText;
		private inkWidgetReference _cantSkipTimeContainer;
		private inkWidgetReference _timeSkipButton;
		private wCHandle<gameuiMenuGameController> _gameCtrlRef;
		private wCHandle<gameTimeSystem> _timeSystem;
		private CHandle<inkGameNotificationToken> _timeSkipPopupToken;
		private CHandle<inkanimProxy> _cantSkipTimeAnim;
		private CHandle<textTextParameterSet> _gameTimeTextParams;
		private CBool _canSkipTime;

		[Ordinal(1)] 
		[RED("gameTimeText")] 
		public inkTextWidgetReference GameTimeText
		{
			get => GetProperty(ref _gameTimeText);
			set => SetProperty(ref _gameTimeText, value);
		}

		[Ordinal(2)] 
		[RED("cantSkipTimeContainer")] 
		public inkWidgetReference CantSkipTimeContainer
		{
			get => GetProperty(ref _cantSkipTimeContainer);
			set => SetProperty(ref _cantSkipTimeContainer, value);
		}

		[Ordinal(3)] 
		[RED("timeSkipButton")] 
		public inkWidgetReference TimeSkipButton
		{
			get => GetProperty(ref _timeSkipButton);
			set => SetProperty(ref _timeSkipButton, value);
		}

		[Ordinal(4)] 
		[RED("gameCtrlRef")] 
		public wCHandle<gameuiMenuGameController> GameCtrlRef
		{
			get => GetProperty(ref _gameCtrlRef);
			set => SetProperty(ref _gameCtrlRef, value);
		}

		[Ordinal(5)] 
		[RED("timeSystem")] 
		public wCHandle<gameTimeSystem> TimeSystem
		{
			get => GetProperty(ref _timeSystem);
			set => SetProperty(ref _timeSystem, value);
		}

		[Ordinal(6)] 
		[RED("timeSkipPopupToken")] 
		public CHandle<inkGameNotificationToken> TimeSkipPopupToken
		{
			get => GetProperty(ref _timeSkipPopupToken);
			set => SetProperty(ref _timeSkipPopupToken, value);
		}

		[Ordinal(7)] 
		[RED("cantSkipTimeAnim")] 
		public CHandle<inkanimProxy> CantSkipTimeAnim
		{
			get => GetProperty(ref _cantSkipTimeAnim);
			set => SetProperty(ref _cantSkipTimeAnim, value);
		}

		[Ordinal(8)] 
		[RED("gameTimeTextParams")] 
		public CHandle<textTextParameterSet> GameTimeTextParams
		{
			get => GetProperty(ref _gameTimeTextParams);
			set => SetProperty(ref _gameTimeTextParams, value);
		}

		[Ordinal(9)] 
		[RED("canSkipTime")] 
		public CBool CanSkipTime
		{
			get => GetProperty(ref _canSkipTime);
			set => SetProperty(ref _canSkipTime, value);
		}

		public HubTimeSkipController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
