using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCrosshairContainerController : gameuiHUDGameController
	{
		private TweakDBID _defaultCrosshair;
		private inkWidgetReference _sprintWidget;
		private CWeakHandle<gameIBlackboard> _bbUIData;
		private CWeakHandle<gameIBlackboard> _bbWeaponInfo;
		private CHandle<redCallbackObject> _bbPlayerTierEventId;
		private CHandle<redCallbackObject> _bbWeaponEventId;
		private CHandle<redCallbackObject> _interactionBlackboardId;
		private CHandle<redCallbackObject> _crosshairStateBlackboardId;
		private CHandle<redCallbackObject> _isMountedBlackboardId;
		private CWeakHandle<inkCanvasWidget> _rootWidget;
		private CHandle<inkanimDefinition> _fadeOutAnimation;
		private CHandle<inkanimDefinition> _fadeInAnimation;
		private CEnum<GameplayTier> _sceneTier;
		private CBool _isUnarmed;
		private CBool _isMounted;
		private CFloat _fadeOutValue;
		private CBool _wasLastInteractionWithDevice;
		private CHandle<redCallbackObject> _combatStateBlackboardId;
		private CHandle<inkanimProxy> _hiddenAnimProxy;
		private CWeakHandle<PlayerPuppet> _player;
		private inkWidgetReference _hiddenTextCanvas;

		[Ordinal(9)] 
		[RED("defaultCrosshair")] 
		public TweakDBID DefaultCrosshair
		{
			get => GetProperty(ref _defaultCrosshair);
			set => SetProperty(ref _defaultCrosshair, value);
		}

		[Ordinal(10)] 
		[RED("sprintWidget")] 
		public inkWidgetReference SprintWidget
		{
			get => GetProperty(ref _sprintWidget);
			set => SetProperty(ref _sprintWidget, value);
		}

		[Ordinal(11)] 
		[RED("bbUIData")] 
		public CWeakHandle<gameIBlackboard> BbUIData
		{
			get => GetProperty(ref _bbUIData);
			set => SetProperty(ref _bbUIData, value);
		}

		[Ordinal(12)] 
		[RED("bbWeaponInfo")] 
		public CWeakHandle<gameIBlackboard> BbWeaponInfo
		{
			get => GetProperty(ref _bbWeaponInfo);
			set => SetProperty(ref _bbWeaponInfo, value);
		}

		[Ordinal(13)] 
		[RED("bbPlayerTierEventId")] 
		public CHandle<redCallbackObject> BbPlayerTierEventId
		{
			get => GetProperty(ref _bbPlayerTierEventId);
			set => SetProperty(ref _bbPlayerTierEventId, value);
		}

		[Ordinal(14)] 
		[RED("bbWeaponEventId")] 
		public CHandle<redCallbackObject> BbWeaponEventId
		{
			get => GetProperty(ref _bbWeaponEventId);
			set => SetProperty(ref _bbWeaponEventId, value);
		}

		[Ordinal(15)] 
		[RED("interactionBlackboardId")] 
		public CHandle<redCallbackObject> InteractionBlackboardId
		{
			get => GetProperty(ref _interactionBlackboardId);
			set => SetProperty(ref _interactionBlackboardId, value);
		}

		[Ordinal(16)] 
		[RED("crosshairStateBlackboardId")] 
		public CHandle<redCallbackObject> CrosshairStateBlackboardId
		{
			get => GetProperty(ref _crosshairStateBlackboardId);
			set => SetProperty(ref _crosshairStateBlackboardId, value);
		}

		[Ordinal(17)] 
		[RED("isMountedBlackboardId")] 
		public CHandle<redCallbackObject> IsMountedBlackboardId
		{
			get => GetProperty(ref _isMountedBlackboardId);
			set => SetProperty(ref _isMountedBlackboardId, value);
		}

		[Ordinal(18)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCanvasWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(19)] 
		[RED("fadeOutAnimation")] 
		public CHandle<inkanimDefinition> FadeOutAnimation
		{
			get => GetProperty(ref _fadeOutAnimation);
			set => SetProperty(ref _fadeOutAnimation, value);
		}

		[Ordinal(20)] 
		[RED("fadeInAnimation")] 
		public CHandle<inkanimDefinition> FadeInAnimation
		{
			get => GetProperty(ref _fadeInAnimation);
			set => SetProperty(ref _fadeInAnimation, value);
		}

		[Ordinal(21)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get => GetProperty(ref _sceneTier);
			set => SetProperty(ref _sceneTier, value);
		}

		[Ordinal(22)] 
		[RED("isUnarmed")] 
		public CBool IsUnarmed
		{
			get => GetProperty(ref _isUnarmed);
			set => SetProperty(ref _isUnarmed, value);
		}

		[Ordinal(23)] 
		[RED("isMounted")] 
		public CBool IsMounted
		{
			get => GetProperty(ref _isMounted);
			set => SetProperty(ref _isMounted, value);
		}

		[Ordinal(24)] 
		[RED("fadeOutValue")] 
		public CFloat FadeOutValue
		{
			get => GetProperty(ref _fadeOutValue);
			set => SetProperty(ref _fadeOutValue, value);
		}

		[Ordinal(25)] 
		[RED("wasLastInteractionWithDevice")] 
		public CBool WasLastInteractionWithDevice
		{
			get => GetProperty(ref _wasLastInteractionWithDevice);
			set => SetProperty(ref _wasLastInteractionWithDevice, value);
		}

		[Ordinal(26)] 
		[RED("CombatStateBlackboardId")] 
		public CHandle<redCallbackObject> CombatStateBlackboardId
		{
			get => GetProperty(ref _combatStateBlackboardId);
			set => SetProperty(ref _combatStateBlackboardId, value);
		}

		[Ordinal(27)] 
		[RED("hiddenAnimProxy")] 
		public CHandle<inkanimProxy> HiddenAnimProxy
		{
			get => GetProperty(ref _hiddenAnimProxy);
			set => SetProperty(ref _hiddenAnimProxy, value);
		}

		[Ordinal(28)] 
		[RED("Player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(29)] 
		[RED("HiddenTextCanvas")] 
		public inkWidgetReference HiddenTextCanvas
		{
			get => GetProperty(ref _hiddenTextCanvas);
			set => SetProperty(ref _hiddenTextCanvas, value);
		}
	}
}
