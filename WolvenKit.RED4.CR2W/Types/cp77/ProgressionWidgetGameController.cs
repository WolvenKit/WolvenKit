using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgressionWidgetGameController : gameuiGenericNotificationGameController
	{
		private CFloat _duration;
		private CHandle<gameIBlackboard> _playerStatsBlackboard;
		private CHandle<PlayerDevelopmentSystem> _playerDevelopmentSystem;
		private CEnum<gamePSMCombat> _combatModePSM;
		private CUInt32 _combatModeListener;
		private wCHandle<gameObject> _playerObject;
		private ScriptGameInstance _gameInstance;

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("playerStatsBlackboard")] 
		public CHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get
			{
				if (_playerStatsBlackboard == null)
				{
					_playerStatsBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "playerStatsBlackboard", cr2w, this);
				}
				return _playerStatsBlackboard;
			}
			set
			{
				if (_playerStatsBlackboard == value)
				{
					return;
				}
				_playerStatsBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playerDevelopmentSystem")] 
		public CHandle<PlayerDevelopmentSystem> PlayerDevelopmentSystem
		{
			get
			{
				if (_playerDevelopmentSystem == null)
				{
					_playerDevelopmentSystem = (CHandle<PlayerDevelopmentSystem>) CR2WTypeManager.Create("handle:PlayerDevelopmentSystem", "playerDevelopmentSystem", cr2w, this);
				}
				return _playerDevelopmentSystem;
			}
			set
			{
				if (_playerDevelopmentSystem == value)
				{
					return;
				}
				_playerDevelopmentSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("combatModePSM")] 
		public CEnum<gamePSMCombat> CombatModePSM
		{
			get
			{
				if (_combatModePSM == null)
				{
					_combatModePSM = (CEnum<gamePSMCombat>) CR2WTypeManager.Create("gamePSMCombat", "combatModePSM", cr2w, this);
				}
				return _combatModePSM;
			}
			set
			{
				if (_combatModePSM == value)
				{
					return;
				}
				_combatModePSM = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("combatModeListener")] 
		public CUInt32 CombatModeListener
		{
			get
			{
				if (_combatModeListener == null)
				{
					_combatModeListener = (CUInt32) CR2WTypeManager.Create("Uint32", "combatModeListener", cr2w, this);
				}
				return _combatModeListener;
			}
			set
			{
				if (_combatModeListener == value)
				{
					return;
				}
				_combatModeListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("playerObject")] 
		public wCHandle<gameObject> PlayerObject
		{
			get
			{
				if (_playerObject == null)
				{
					_playerObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerObject", cr2w, this);
				}
				return _playerObject;
			}
			set
			{
				if (_playerObject == value)
				{
					return;
				}
				_playerObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get
			{
				if (_gameInstance == null)
				{
					_gameInstance = (ScriptGameInstance) CR2WTypeManager.Create("ScriptGameInstance", "gameInstance", cr2w, this);
				}
				return _gameInstance;
			}
			set
			{
				if (_gameInstance == value)
				{
					return;
				}
				_gameInstance = value;
				PropertySet(this);
			}
		}

		public ProgressionWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
