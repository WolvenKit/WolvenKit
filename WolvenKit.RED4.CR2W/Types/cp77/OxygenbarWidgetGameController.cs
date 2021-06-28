using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OxygenbarWidgetGameController : gameuiHUDGameController
	{
		private inkWidgetReference _oxygenControllerRef;
		private inkTextWidgetReference _oxygenPercTextPath;
		private inkTextWidgetReference _oxygenStatusTextPath;
		private CUInt32 _bbPSceneTierEventId;
		private CUInt32 _swimmingStateBlackboardId;
		private wCHandle<NameplateBarLogicController> _oxygenController;
		private wCHandle<inkWidget> _rootWidget;
		private CHandle<inkanimDefinition> _animHideTemp;
		private CHandle<inkanimDefinition> _animShortFade;
		private CHandle<inkanimDefinition> _animLongFade;
		private CHandle<inkanimProxy> _animHideOxygenProxy;
		private CFloat _currentOxygen;
		private CEnum<GameplayTier> _sceneTier;
		private CEnum<gamePSMSwimming> _currentSwimmingState;
		private CHandle<OxygenListener> _oxygenListener;

		[Ordinal(9)] 
		[RED("oxygenControllerRef")] 
		public inkWidgetReference OxygenControllerRef
		{
			get => GetProperty(ref _oxygenControllerRef);
			set => SetProperty(ref _oxygenControllerRef, value);
		}

		[Ordinal(10)] 
		[RED("oxygenPercTextPath")] 
		public inkTextWidgetReference OxygenPercTextPath
		{
			get => GetProperty(ref _oxygenPercTextPath);
			set => SetProperty(ref _oxygenPercTextPath, value);
		}

		[Ordinal(11)] 
		[RED("oxygenStatusTextPath")] 
		public inkTextWidgetReference OxygenStatusTextPath
		{
			get => GetProperty(ref _oxygenStatusTextPath);
			set => SetProperty(ref _oxygenStatusTextPath, value);
		}

		[Ordinal(12)] 
		[RED("bbPSceneTierEventId")] 
		public CUInt32 BbPSceneTierEventId
		{
			get => GetProperty(ref _bbPSceneTierEventId);
			set => SetProperty(ref _bbPSceneTierEventId, value);
		}

		[Ordinal(13)] 
		[RED("swimmingStateBlackboardId")] 
		public CUInt32 SwimmingStateBlackboardId
		{
			get => GetProperty(ref _swimmingStateBlackboardId);
			set => SetProperty(ref _swimmingStateBlackboardId, value);
		}

		[Ordinal(14)] 
		[RED("oxygenController")] 
		public wCHandle<NameplateBarLogicController> OxygenController
		{
			get => GetProperty(ref _oxygenController);
			set => SetProperty(ref _oxygenController, value);
		}

		[Ordinal(15)] 
		[RED("RootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(16)] 
		[RED("animHideTemp")] 
		public CHandle<inkanimDefinition> AnimHideTemp
		{
			get => GetProperty(ref _animHideTemp);
			set => SetProperty(ref _animHideTemp, value);
		}

		[Ordinal(17)] 
		[RED("animShortFade")] 
		public CHandle<inkanimDefinition> AnimShortFade
		{
			get => GetProperty(ref _animShortFade);
			set => SetProperty(ref _animShortFade, value);
		}

		[Ordinal(18)] 
		[RED("animLongFade")] 
		public CHandle<inkanimDefinition> AnimLongFade
		{
			get => GetProperty(ref _animLongFade);
			set => SetProperty(ref _animLongFade, value);
		}

		[Ordinal(19)] 
		[RED("animHideOxygenProxy")] 
		public CHandle<inkanimProxy> AnimHideOxygenProxy
		{
			get => GetProperty(ref _animHideOxygenProxy);
			set => SetProperty(ref _animHideOxygenProxy, value);
		}

		[Ordinal(20)] 
		[RED("currentOxygen")] 
		public CFloat CurrentOxygen
		{
			get => GetProperty(ref _currentOxygen);
			set => SetProperty(ref _currentOxygen, value);
		}

		[Ordinal(21)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get => GetProperty(ref _sceneTier);
			set => SetProperty(ref _sceneTier, value);
		}

		[Ordinal(22)] 
		[RED("currentSwimmingState")] 
		public CEnum<gamePSMSwimming> CurrentSwimmingState
		{
			get => GetProperty(ref _currentSwimmingState);
			set => SetProperty(ref _currentSwimmingState, value);
		}

		[Ordinal(23)] 
		[RED("oxygenListener")] 
		public CHandle<OxygenListener> OxygenListener
		{
			get => GetProperty(ref _oxygenListener);
			set => SetProperty(ref _oxygenListener, value);
		}

		public OxygenbarWidgetGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
