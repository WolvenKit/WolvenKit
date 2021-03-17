using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCrosshairContainerController : gameuiHUDGameController
	{
		private TweakDBID _defaultCrosshair;
		private inkWidgetReference _sprintWidget;
		private CHandle<gameIBlackboard> _bbUIData;
		private wCHandle<gameIBlackboard> _bbWeaponInfo;
		private CUInt32 _bbPlayerTierEventId;
		private CUInt32 _bbWeaponEventId;
		private CUInt32 _interactionBlackboardId;
		private CUInt32 _crosshairStateBlackboardId;
		private CUInt32 _isMountedBlackboardId;
		private wCHandle<inkCanvasWidget> _rootWidget;
		private CHandle<inkanimDefinition> _fadeOutAnimation;
		private CHandle<inkanimDefinition> _fadeInAnimation;
		private CEnum<GameplayTier> _sceneTier;
		private CBool _isUnarmed;
		private CBool _isMounted;
		private CFloat _fadeOutValue;
		private CBool _wasLastInteractionWithDevice;
		private CUInt32 _combatStateBlackboardId;
		private CHandle<inkanimProxy> _hiddenAnimProxy;
		private wCHandle<PlayerPuppet> _player;
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
		public CHandle<gameIBlackboard> BbUIData
		{
			get => GetProperty(ref _bbUIData);
			set => SetProperty(ref _bbUIData, value);
		}

		[Ordinal(12)] 
		[RED("bbWeaponInfo")] 
		public wCHandle<gameIBlackboard> BbWeaponInfo
		{
			get => GetProperty(ref _bbWeaponInfo);
			set => SetProperty(ref _bbWeaponInfo, value);
		}

		[Ordinal(13)] 
		[RED("bbPlayerTierEventId")] 
		public CUInt32 BbPlayerTierEventId
		{
			get => GetProperty(ref _bbPlayerTierEventId);
			set => SetProperty(ref _bbPlayerTierEventId, value);
		}

		[Ordinal(14)] 
		[RED("bbWeaponEventId")] 
		public CUInt32 BbWeaponEventId
		{
			get => GetProperty(ref _bbWeaponEventId);
			set => SetProperty(ref _bbWeaponEventId, value);
		}

		[Ordinal(15)] 
		[RED("interactionBlackboardId")] 
		public CUInt32 InteractionBlackboardId
		{
			get => GetProperty(ref _interactionBlackboardId);
			set => SetProperty(ref _interactionBlackboardId, value);
		}

		[Ordinal(16)] 
		[RED("crosshairStateBlackboardId")] 
		public CUInt32 CrosshairStateBlackboardId
		{
			get => GetProperty(ref _crosshairStateBlackboardId);
			set => SetProperty(ref _crosshairStateBlackboardId, value);
		}

		[Ordinal(17)] 
		[RED("isMountedBlackboardId")] 
		public CUInt32 IsMountedBlackboardId
		{
			get => GetProperty(ref _isMountedBlackboardId);
			set => SetProperty(ref _isMountedBlackboardId, value);
		}

		[Ordinal(18)] 
		[RED("rootWidget")] 
		public wCHandle<inkCanvasWidget> RootWidget
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
		public CUInt32 CombatStateBlackboardId
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
		public wCHandle<PlayerPuppet> Player
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

		public gameuiCrosshairContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
