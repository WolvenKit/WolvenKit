using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StaminabarWidgetGameController : gameuiHUDGameController
	{
		private inkWidgetReference _staminaControllerRef;
		private inkTextWidgetReference _staminaPercTextPath;
		private inkTextWidgetReference _staminaStatusTextPath;
		private CUInt32 _bbPSceneTierEventId;
		private CUInt32 _bbPStaminaPSMEventId;
		private wCHandle<NameplateBarLogicController> _staminaController;
		private wCHandle<inkWidget> _rootWidget;
		private CHandle<inkanimDefinition> _animLongFade;
		private CHandle<inkanimProxy> _animHideStaminaProxy;
		private CFloat _currentStamina;
		private CEnum<GameplayTier> _sceneTier;
		private CEnum<gamePSMStamina> _staminaState;
		private CHandle<StaminaPoolListener> _staminaPoolListener;

		[Ordinal(9)] 
		[RED("staminaControllerRef")] 
		public inkWidgetReference StaminaControllerRef
		{
			get => GetProperty(ref _staminaControllerRef);
			set => SetProperty(ref _staminaControllerRef, value);
		}

		[Ordinal(10)] 
		[RED("staminaPercTextPath")] 
		public inkTextWidgetReference StaminaPercTextPath
		{
			get => GetProperty(ref _staminaPercTextPath);
			set => SetProperty(ref _staminaPercTextPath, value);
		}

		[Ordinal(11)] 
		[RED("staminaStatusTextPath")] 
		public inkTextWidgetReference StaminaStatusTextPath
		{
			get => GetProperty(ref _staminaStatusTextPath);
			set => SetProperty(ref _staminaStatusTextPath, value);
		}

		[Ordinal(12)] 
		[RED("bbPSceneTierEventId")] 
		public CUInt32 BbPSceneTierEventId
		{
			get => GetProperty(ref _bbPSceneTierEventId);
			set => SetProperty(ref _bbPSceneTierEventId, value);
		}

		[Ordinal(13)] 
		[RED("bbPStaminaPSMEventId")] 
		public CUInt32 BbPStaminaPSMEventId
		{
			get => GetProperty(ref _bbPStaminaPSMEventId);
			set => SetProperty(ref _bbPStaminaPSMEventId, value);
		}

		[Ordinal(14)] 
		[RED("staminaController")] 
		public wCHandle<NameplateBarLogicController> StaminaController
		{
			get => GetProperty(ref _staminaController);
			set => SetProperty(ref _staminaController, value);
		}

		[Ordinal(15)] 
		[RED("RootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(16)] 
		[RED("animLongFade")] 
		public CHandle<inkanimDefinition> AnimLongFade
		{
			get => GetProperty(ref _animLongFade);
			set => SetProperty(ref _animLongFade, value);
		}

		[Ordinal(17)] 
		[RED("animHideStaminaProxy")] 
		public CHandle<inkanimProxy> AnimHideStaminaProxy
		{
			get => GetProperty(ref _animHideStaminaProxy);
			set => SetProperty(ref _animHideStaminaProxy, value);
		}

		[Ordinal(18)] 
		[RED("currentStamina")] 
		public CFloat CurrentStamina
		{
			get => GetProperty(ref _currentStamina);
			set => SetProperty(ref _currentStamina, value);
		}

		[Ordinal(19)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get => GetProperty(ref _sceneTier);
			set => SetProperty(ref _sceneTier, value);
		}

		[Ordinal(20)] 
		[RED("staminaState")] 
		public CEnum<gamePSMStamina> StaminaState
		{
			get => GetProperty(ref _staminaState);
			set => SetProperty(ref _staminaState, value);
		}

		[Ordinal(21)] 
		[RED("staminaPoolListener")] 
		public CHandle<StaminaPoolListener> StaminaPoolListener
		{
			get => GetProperty(ref _staminaPoolListener);
			set => SetProperty(ref _staminaPoolListener, value);
		}

		public StaminabarWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
