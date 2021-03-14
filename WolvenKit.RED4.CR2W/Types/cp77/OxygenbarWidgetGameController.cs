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
			get
			{
				if (_oxygenControllerRef == null)
				{
					_oxygenControllerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "oxygenControllerRef", cr2w, this);
				}
				return _oxygenControllerRef;
			}
			set
			{
				if (_oxygenControllerRef == value)
				{
					return;
				}
				_oxygenControllerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("oxygenPercTextPath")] 
		public inkTextWidgetReference OxygenPercTextPath
		{
			get
			{
				if (_oxygenPercTextPath == null)
				{
					_oxygenPercTextPath = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "oxygenPercTextPath", cr2w, this);
				}
				return _oxygenPercTextPath;
			}
			set
			{
				if (_oxygenPercTextPath == value)
				{
					return;
				}
				_oxygenPercTextPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("oxygenStatusTextPath")] 
		public inkTextWidgetReference OxygenStatusTextPath
		{
			get
			{
				if (_oxygenStatusTextPath == null)
				{
					_oxygenStatusTextPath = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "oxygenStatusTextPath", cr2w, this);
				}
				return _oxygenStatusTextPath;
			}
			set
			{
				if (_oxygenStatusTextPath == value)
				{
					return;
				}
				_oxygenStatusTextPath = value;
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
		[RED("swimmingStateBlackboardId")] 
		public CUInt32 SwimmingStateBlackboardId
		{
			get
			{
				if (_swimmingStateBlackboardId == null)
				{
					_swimmingStateBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "swimmingStateBlackboardId", cr2w, this);
				}
				return _swimmingStateBlackboardId;
			}
			set
			{
				if (_swimmingStateBlackboardId == value)
				{
					return;
				}
				_swimmingStateBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("oxygenController")] 
		public wCHandle<NameplateBarLogicController> OxygenController
		{
			get
			{
				if (_oxygenController == null)
				{
					_oxygenController = (wCHandle<NameplateBarLogicController>) CR2WTypeManager.Create("whandle:NameplateBarLogicController", "oxygenController", cr2w, this);
				}
				return _oxygenController;
			}
			set
			{
				if (_oxygenController == value)
				{
					return;
				}
				_oxygenController = value;
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
		[RED("animHideTemp")] 
		public CHandle<inkanimDefinition> AnimHideTemp
		{
			get
			{
				if (_animHideTemp == null)
				{
					_animHideTemp = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animHideTemp", cr2w, this);
				}
				return _animHideTemp;
			}
			set
			{
				if (_animHideTemp == value)
				{
					return;
				}
				_animHideTemp = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("animShortFade")] 
		public CHandle<inkanimDefinition> AnimShortFade
		{
			get
			{
				if (_animShortFade == null)
				{
					_animShortFade = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animShortFade", cr2w, this);
				}
				return _animShortFade;
			}
			set
			{
				if (_animShortFade == value)
				{
					return;
				}
				_animShortFade = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
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

		[Ordinal(19)] 
		[RED("animHideOxygenProxy")] 
		public CHandle<inkanimProxy> AnimHideOxygenProxy
		{
			get
			{
				if (_animHideOxygenProxy == null)
				{
					_animHideOxygenProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animHideOxygenProxy", cr2w, this);
				}
				return _animHideOxygenProxy;
			}
			set
			{
				if (_animHideOxygenProxy == value)
				{
					return;
				}
				_animHideOxygenProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("currentOxygen")] 
		public CFloat CurrentOxygen
		{
			get
			{
				if (_currentOxygen == null)
				{
					_currentOxygen = (CFloat) CR2WTypeManager.Create("Float", "currentOxygen", cr2w, this);
				}
				return _currentOxygen;
			}
			set
			{
				if (_currentOxygen == value)
				{
					return;
				}
				_currentOxygen = value;
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
		[RED("currentSwimmingState")] 
		public CEnum<gamePSMSwimming> CurrentSwimmingState
		{
			get
			{
				if (_currentSwimmingState == null)
				{
					_currentSwimmingState = (CEnum<gamePSMSwimming>) CR2WTypeManager.Create("gamePSMSwimming", "currentSwimmingState", cr2w, this);
				}
				return _currentSwimmingState;
			}
			set
			{
				if (_currentSwimmingState == value)
				{
					return;
				}
				_currentSwimmingState = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("oxygenListener")] 
		public CHandle<OxygenListener> OxygenListener
		{
			get
			{
				if (_oxygenListener == null)
				{
					_oxygenListener = (CHandle<OxygenListener>) CR2WTypeManager.Create("handle:OxygenListener", "oxygenListener", cr2w, this);
				}
				return _oxygenListener;
			}
			set
			{
				if (_oxygenListener == value)
				{
					return;
				}
				_oxygenListener = value;
				PropertySet(this);
			}
		}

		public OxygenbarWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
