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
			get
			{
				if (_staminaControllerRef == null)
				{
					_staminaControllerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "staminaControllerRef", cr2w, this);
				}
				return _staminaControllerRef;
			}
			set
			{
				if (_staminaControllerRef == value)
				{
					return;
				}
				_staminaControllerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("staminaPercTextPath")] 
		public inkTextWidgetReference StaminaPercTextPath
		{
			get
			{
				if (_staminaPercTextPath == null)
				{
					_staminaPercTextPath = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "staminaPercTextPath", cr2w, this);
				}
				return _staminaPercTextPath;
			}
			set
			{
				if (_staminaPercTextPath == value)
				{
					return;
				}
				_staminaPercTextPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("staminaStatusTextPath")] 
		public inkTextWidgetReference StaminaStatusTextPath
		{
			get
			{
				if (_staminaStatusTextPath == null)
				{
					_staminaStatusTextPath = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "staminaStatusTextPath", cr2w, this);
				}
				return _staminaStatusTextPath;
			}
			set
			{
				if (_staminaStatusTextPath == value)
				{
					return;
				}
				_staminaStatusTextPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("bbPSceneTierEventId")] 
		public CUInt32 BbPSceneTierEventId
		{
			get
			{
				if (_bbPSceneTierEventId == null)
				{
					_bbPSceneTierEventId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbPSceneTierEventId", cr2w, this);
				}
				return _bbPSceneTierEventId;
			}
			set
			{
				if (_bbPSceneTierEventId == value)
				{
					return;
				}
				_bbPSceneTierEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bbPStaminaPSMEventId")] 
		public CUInt32 BbPStaminaPSMEventId
		{
			get
			{
				if (_bbPStaminaPSMEventId == null)
				{
					_bbPStaminaPSMEventId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbPStaminaPSMEventId", cr2w, this);
				}
				return _bbPStaminaPSMEventId;
			}
			set
			{
				if (_bbPStaminaPSMEventId == value)
				{
					return;
				}
				_bbPStaminaPSMEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("staminaController")] 
		public wCHandle<NameplateBarLogicController> StaminaController
		{
			get
			{
				if (_staminaController == null)
				{
					_staminaController = (wCHandle<NameplateBarLogicController>) CR2WTypeManager.Create("whandle:NameplateBarLogicController", "staminaController", cr2w, this);
				}
				return _staminaController;
			}
			set
			{
				if (_staminaController == value)
				{
					return;
				}
				_staminaController = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("RootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "RootWidget", cr2w, this);
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

		[Ordinal(16)] 
		[RED("animLongFade")] 
		public CHandle<inkanimDefinition> AnimLongFade
		{
			get
			{
				if (_animLongFade == null)
				{
					_animLongFade = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animLongFade", cr2w, this);
				}
				return _animLongFade;
			}
			set
			{
				if (_animLongFade == value)
				{
					return;
				}
				_animLongFade = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("animHideStaminaProxy")] 
		public CHandle<inkanimProxy> AnimHideStaminaProxy
		{
			get
			{
				if (_animHideStaminaProxy == null)
				{
					_animHideStaminaProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animHideStaminaProxy", cr2w, this);
				}
				return _animHideStaminaProxy;
			}
			set
			{
				if (_animHideStaminaProxy == value)
				{
					return;
				}
				_animHideStaminaProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("currentStamina")] 
		public CFloat CurrentStamina
		{
			get
			{
				if (_currentStamina == null)
				{
					_currentStamina = (CFloat) CR2WTypeManager.Create("Float", "currentStamina", cr2w, this);
				}
				return _currentStamina;
			}
			set
			{
				if (_currentStamina == value)
				{
					return;
				}
				_currentStamina = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
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

		[Ordinal(20)] 
		[RED("staminaState")] 
		public CEnum<gamePSMStamina> StaminaState
		{
			get
			{
				if (_staminaState == null)
				{
					_staminaState = (CEnum<gamePSMStamina>) CR2WTypeManager.Create("gamePSMStamina", "staminaState", cr2w, this);
				}
				return _staminaState;
			}
			set
			{
				if (_staminaState == value)
				{
					return;
				}
				_staminaState = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("staminaPoolListener")] 
		public CHandle<StaminaPoolListener> StaminaPoolListener
		{
			get
			{
				if (_staminaPoolListener == null)
				{
					_staminaPoolListener = (CHandle<StaminaPoolListener>) CR2WTypeManager.Create("handle:StaminaPoolListener", "staminaPoolListener", cr2w, this);
				}
				return _staminaPoolListener;
			}
			set
			{
				if (_staminaPoolListener == value)
				{
					return;
				}
				_staminaPoolListener = value;
				PropertySet(this);
			}
		}

		public StaminabarWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
