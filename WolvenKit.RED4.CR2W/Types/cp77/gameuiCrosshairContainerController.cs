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
			get
			{
				if (_defaultCrosshair == null)
				{
					_defaultCrosshair = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "defaultCrosshair", cr2w, this);
				}
				return _defaultCrosshair;
			}
			set
			{
				if (_defaultCrosshair == value)
				{
					return;
				}
				_defaultCrosshair = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("sprintWidget")] 
		public inkWidgetReference SprintWidget
		{
			get
			{
				if (_sprintWidget == null)
				{
					_sprintWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "sprintWidget", cr2w, this);
				}
				return _sprintWidget;
			}
			set
			{
				if (_sprintWidget == value)
				{
					return;
				}
				_sprintWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("bbUIData")] 
		public CHandle<gameIBlackboard> BbUIData
		{
			get
			{
				if (_bbUIData == null)
				{
					_bbUIData = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "bbUIData", cr2w, this);
				}
				return _bbUIData;
			}
			set
			{
				if (_bbUIData == value)
				{
					return;
				}
				_bbUIData = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("bbWeaponInfo")] 
		public wCHandle<gameIBlackboard> BbWeaponInfo
		{
			get
			{
				if (_bbWeaponInfo == null)
				{
					_bbWeaponInfo = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "bbWeaponInfo", cr2w, this);
				}
				return _bbWeaponInfo;
			}
			set
			{
				if (_bbWeaponInfo == value)
				{
					return;
				}
				_bbWeaponInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bbPlayerTierEventId")] 
		public CUInt32 BbPlayerTierEventId
		{
			get
			{
				if (_bbPlayerTierEventId == null)
				{
					_bbPlayerTierEventId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbPlayerTierEventId", cr2w, this);
				}
				return _bbPlayerTierEventId;
			}
			set
			{
				if (_bbPlayerTierEventId == value)
				{
					return;
				}
				_bbPlayerTierEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("bbWeaponEventId")] 
		public CUInt32 BbWeaponEventId
		{
			get
			{
				if (_bbWeaponEventId == null)
				{
					_bbWeaponEventId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbWeaponEventId", cr2w, this);
				}
				return _bbWeaponEventId;
			}
			set
			{
				if (_bbWeaponEventId == value)
				{
					return;
				}
				_bbWeaponEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("interactionBlackboardId")] 
		public CUInt32 InteractionBlackboardId
		{
			get
			{
				if (_interactionBlackboardId == null)
				{
					_interactionBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "interactionBlackboardId", cr2w, this);
				}
				return _interactionBlackboardId;
			}
			set
			{
				if (_interactionBlackboardId == value)
				{
					return;
				}
				_interactionBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("crosshairStateBlackboardId")] 
		public CUInt32 CrosshairStateBlackboardId
		{
			get
			{
				if (_crosshairStateBlackboardId == null)
				{
					_crosshairStateBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "crosshairStateBlackboardId", cr2w, this);
				}
				return _crosshairStateBlackboardId;
			}
			set
			{
				if (_crosshairStateBlackboardId == value)
				{
					return;
				}
				_crosshairStateBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("isMountedBlackboardId")] 
		public CUInt32 IsMountedBlackboardId
		{
			get
			{
				if (_isMountedBlackboardId == null)
				{
					_isMountedBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "isMountedBlackboardId", cr2w, this);
				}
				return _isMountedBlackboardId;
			}
			set
			{
				if (_isMountedBlackboardId == value)
				{
					return;
				}
				_isMountedBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("rootWidget")] 
		public wCHandle<inkCanvasWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("fadeOutAnimation")] 
		public CHandle<inkanimDefinition> FadeOutAnimation
		{
			get
			{
				if (_fadeOutAnimation == null)
				{
					_fadeOutAnimation = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "fadeOutAnimation", cr2w, this);
				}
				return _fadeOutAnimation;
			}
			set
			{
				if (_fadeOutAnimation == value)
				{
					return;
				}
				_fadeOutAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("fadeInAnimation")] 
		public CHandle<inkanimDefinition> FadeInAnimation
		{
			get
			{
				if (_fadeInAnimation == null)
				{
					_fadeInAnimation = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "fadeInAnimation", cr2w, this);
				}
				return _fadeInAnimation;
			}
			set
			{
				if (_fadeInAnimation == value)
				{
					return;
				}
				_fadeInAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get
			{
				if (_sceneTier == null)
				{
					_sceneTier = (CEnum<GameplayTier>) CR2WTypeManager.Create("GameplayTier", "sceneTier", cr2w, this);
				}
				return _sceneTier;
			}
			set
			{
				if (_sceneTier == value)
				{
					return;
				}
				_sceneTier = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("isUnarmed")] 
		public CBool IsUnarmed
		{
			get
			{
				if (_isUnarmed == null)
				{
					_isUnarmed = (CBool) CR2WTypeManager.Create("Bool", "isUnarmed", cr2w, this);
				}
				return _isUnarmed;
			}
			set
			{
				if (_isUnarmed == value)
				{
					return;
				}
				_isUnarmed = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("isMounted")] 
		public CBool IsMounted
		{
			get
			{
				if (_isMounted == null)
				{
					_isMounted = (CBool) CR2WTypeManager.Create("Bool", "isMounted", cr2w, this);
				}
				return _isMounted;
			}
			set
			{
				if (_isMounted == value)
				{
					return;
				}
				_isMounted = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("fadeOutValue")] 
		public CFloat FadeOutValue
		{
			get
			{
				if (_fadeOutValue == null)
				{
					_fadeOutValue = (CFloat) CR2WTypeManager.Create("Float", "fadeOutValue", cr2w, this);
				}
				return _fadeOutValue;
			}
			set
			{
				if (_fadeOutValue == value)
				{
					return;
				}
				_fadeOutValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("wasLastInteractionWithDevice")] 
		public CBool WasLastInteractionWithDevice
		{
			get
			{
				if (_wasLastInteractionWithDevice == null)
				{
					_wasLastInteractionWithDevice = (CBool) CR2WTypeManager.Create("Bool", "wasLastInteractionWithDevice", cr2w, this);
				}
				return _wasLastInteractionWithDevice;
			}
			set
			{
				if (_wasLastInteractionWithDevice == value)
				{
					return;
				}
				_wasLastInteractionWithDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("CombatStateBlackboardId")] 
		public CUInt32 CombatStateBlackboardId
		{
			get
			{
				if (_combatStateBlackboardId == null)
				{
					_combatStateBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "CombatStateBlackboardId", cr2w, this);
				}
				return _combatStateBlackboardId;
			}
			set
			{
				if (_combatStateBlackboardId == value)
				{
					return;
				}
				_combatStateBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("hiddenAnimProxy")] 
		public CHandle<inkanimProxy> HiddenAnimProxy
		{
			get
			{
				if (_hiddenAnimProxy == null)
				{
					_hiddenAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "hiddenAnimProxy", cr2w, this);
				}
				return _hiddenAnimProxy;
			}
			set
			{
				if (_hiddenAnimProxy == value)
				{
					return;
				}
				_hiddenAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("Player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "Player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("HiddenTextCanvas")] 
		public inkWidgetReference HiddenTextCanvas
		{
			get
			{
				if (_hiddenTextCanvas == null)
				{
					_hiddenTextCanvas = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "HiddenTextCanvas", cr2w, this);
				}
				return _hiddenTextCanvas;
			}
			set
			{
				if (_hiddenTextCanvas == value)
				{
					return;
				}
				_hiddenTextCanvas = value;
				PropertySet(this);
			}
		}

		public gameuiCrosshairContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
