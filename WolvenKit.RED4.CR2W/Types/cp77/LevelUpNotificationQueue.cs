using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LevelUpNotificationQueue : gameuiGenericNotificationGameController
	{
		private CFloat _duration;
		private CHandle<gameIBlackboard> _levelUpBlackboard;
		private CUInt32 _playerLevelUpListener;
		private wCHandle<gameObject> _playerObject;
		private CEnum<gamePSMCombat> _combatModePSM;
		private CUInt32 _combatModeListener;

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
		[RED("levelUpBlackboard")] 
		public CHandle<gameIBlackboard> LevelUpBlackboard
		{
			get
			{
				if (_levelUpBlackboard == null)
				{
					_levelUpBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "levelUpBlackboard", cr2w, this);
				}
				return _levelUpBlackboard;
			}
			set
			{
				if (_levelUpBlackboard == value)
				{
					return;
				}
				_levelUpBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playerLevelUpListener")] 
		public CUInt32 PlayerLevelUpListener
		{
			get
			{
				if (_playerLevelUpListener == null)
				{
					_playerLevelUpListener = (CUInt32) CR2WTypeManager.Create("Uint32", "playerLevelUpListener", cr2w, this);
				}
				return _playerLevelUpListener;
			}
			set
			{
				if (_playerLevelUpListener == value)
				{
					return;
				}
				_playerLevelUpListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		public LevelUpNotificationQueue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
