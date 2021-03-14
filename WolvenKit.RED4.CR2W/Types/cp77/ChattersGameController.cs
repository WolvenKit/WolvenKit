using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChattersGameController : BaseSubtitlesGameController
	{
		private CFloat _c_DisplayRange;
		private CFloat _c_CloseDisplayRange;
		private CFloat _c_TimeToUnblockSec;
		private wCHandle<inkCompoundWidget> _rootWidget;
		private CArray<ChatterKeyValuePair> _allControllers;
		private CHandle<gametargetingTargetingSystem> _targetingSystem;
		private CArray<CRUID> _broadcastBlockingLines;
		private CBool _playerInDialogChoice;
		private EngineTime _lastBroadcastBlockingLineTime;
		private EngineTime _lastChoiceTime;
		private CUInt32 _bbPSceneTierEventId;
		private CInt32 _sceneTier;

		[Ordinal(28)] 
		[RED("c_DisplayRange")] 
		public CFloat C_DisplayRange
		{
			get
			{
				if (_c_DisplayRange == null)
				{
					_c_DisplayRange = (CFloat) CR2WTypeManager.Create("Float", "c_DisplayRange", cr2w, this);
				}
				return _c_DisplayRange;
			}
			set
			{
				if (_c_DisplayRange == value)
				{
					return;
				}
				_c_DisplayRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("c_CloseDisplayRange")] 
		public CFloat C_CloseDisplayRange
		{
			get
			{
				if (_c_CloseDisplayRange == null)
				{
					_c_CloseDisplayRange = (CFloat) CR2WTypeManager.Create("Float", "c_CloseDisplayRange", cr2w, this);
				}
				return _c_CloseDisplayRange;
			}
			set
			{
				if (_c_CloseDisplayRange == value)
				{
					return;
				}
				_c_CloseDisplayRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("c_TimeToUnblockSec")] 
		public CFloat C_TimeToUnblockSec
		{
			get
			{
				if (_c_TimeToUnblockSec == null)
				{
					_c_TimeToUnblockSec = (CFloat) CR2WTypeManager.Create("Float", "c_TimeToUnblockSec", cr2w, this);
				}
				return _c_TimeToUnblockSec;
			}
			set
			{
				if (_c_TimeToUnblockSec == value)
				{
					return;
				}
				_c_TimeToUnblockSec = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("rootWidget")] 
		public wCHandle<inkCompoundWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "rootWidget", cr2w, this);
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

		[Ordinal(32)] 
		[RED("AllControllers")] 
		public CArray<ChatterKeyValuePair> AllControllers
		{
			get
			{
				if (_allControllers == null)
				{
					_allControllers = (CArray<ChatterKeyValuePair>) CR2WTypeManager.Create("array:ChatterKeyValuePair", "AllControllers", cr2w, this);
				}
				return _allControllers;
			}
			set
			{
				if (_allControllers == value)
				{
					return;
				}
				_allControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("targetingSystem")] 
		public CHandle<gametargetingTargetingSystem> TargetingSystem
		{
			get
			{
				if (_targetingSystem == null)
				{
					_targetingSystem = (CHandle<gametargetingTargetingSystem>) CR2WTypeManager.Create("handle:gametargetingTargetingSystem", "targetingSystem", cr2w, this);
				}
				return _targetingSystem;
			}
			set
			{
				if (_targetingSystem == value)
				{
					return;
				}
				_targetingSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("broadcastBlockingLines")] 
		public CArray<CRUID> BroadcastBlockingLines
		{
			get
			{
				if (_broadcastBlockingLines == null)
				{
					_broadcastBlockingLines = (CArray<CRUID>) CR2WTypeManager.Create("array:CRUID", "broadcastBlockingLines", cr2w, this);
				}
				return _broadcastBlockingLines;
			}
			set
			{
				if (_broadcastBlockingLines == value)
				{
					return;
				}
				_broadcastBlockingLines = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("playerInDialogChoice")] 
		public CBool PlayerInDialogChoice
		{
			get
			{
				if (_playerInDialogChoice == null)
				{
					_playerInDialogChoice = (CBool) CR2WTypeManager.Create("Bool", "playerInDialogChoice", cr2w, this);
				}
				return _playerInDialogChoice;
			}
			set
			{
				if (_playerInDialogChoice == value)
				{
					return;
				}
				_playerInDialogChoice = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("lastBroadcastBlockingLineTime")] 
		public EngineTime LastBroadcastBlockingLineTime
		{
			get
			{
				if (_lastBroadcastBlockingLineTime == null)
				{
					_lastBroadcastBlockingLineTime = (EngineTime) CR2WTypeManager.Create("EngineTime", "lastBroadcastBlockingLineTime", cr2w, this);
				}
				return _lastBroadcastBlockingLineTime;
			}
			set
			{
				if (_lastBroadcastBlockingLineTime == value)
				{
					return;
				}
				_lastBroadcastBlockingLineTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("lastChoiceTime")] 
		public EngineTime LastChoiceTime
		{
			get
			{
				if (_lastChoiceTime == null)
				{
					_lastChoiceTime = (EngineTime) CR2WTypeManager.Create("EngineTime", "lastChoiceTime", cr2w, this);
				}
				return _lastChoiceTime;
			}
			set
			{
				if (_lastChoiceTime == value)
				{
					return;
				}
				_lastChoiceTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
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

		[Ordinal(39)] 
		[RED("sceneTier")] 
		public CInt32 SceneTier
		{
			get
			{
				if (_sceneTier == null)
				{
					_sceneTier = (CInt32) CR2WTypeManager.Create("Int32", "sceneTier", cr2w, this);
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

		public ChattersGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
