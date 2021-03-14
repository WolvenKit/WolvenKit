using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HackingMinigameDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _minigameDefaults;
		private gamebbScriptID_Variant _nextMinigameData;
		private gamebbScriptID_Bool _skipSummaryScreen;
		private gamebbScriptID_Variant _playerPrograms;
		private gamebbScriptID_Variant _activePrograms;
		private gamebbScriptID_Variant _activeTraps;
		private gamebbScriptID_Int32 _state;
		private gamebbScriptID_Variant _entity;
		private gamebbScriptID_Bool _isJournalTarget;

		[Ordinal(0)] 
		[RED("MinigameDefaults")] 
		public gamebbScriptID_Variant MinigameDefaults
		{
			get
			{
				if (_minigameDefaults == null)
				{
					_minigameDefaults = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "MinigameDefaults", cr2w, this);
				}
				return _minigameDefaults;
			}
			set
			{
				if (_minigameDefaults == value)
				{
					return;
				}
				_minigameDefaults = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("NextMinigameData")] 
		public gamebbScriptID_Variant NextMinigameData
		{
			get
			{
				if (_nextMinigameData == null)
				{
					_nextMinigameData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "NextMinigameData", cr2w, this);
				}
				return _nextMinigameData;
			}
			set
			{
				if (_nextMinigameData == value)
				{
					return;
				}
				_nextMinigameData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("SkipSummaryScreen")] 
		public gamebbScriptID_Bool SkipSummaryScreen
		{
			get
			{
				if (_skipSummaryScreen == null)
				{
					_skipSummaryScreen = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "SkipSummaryScreen", cr2w, this);
				}
				return _skipSummaryScreen;
			}
			set
			{
				if (_skipSummaryScreen == value)
				{
					return;
				}
				_skipSummaryScreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("PlayerPrograms")] 
		public gamebbScriptID_Variant PlayerPrograms
		{
			get
			{
				if (_playerPrograms == null)
				{
					_playerPrograms = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "PlayerPrograms", cr2w, this);
				}
				return _playerPrograms;
			}
			set
			{
				if (_playerPrograms == value)
				{
					return;
				}
				_playerPrograms = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ActivePrograms")] 
		public gamebbScriptID_Variant ActivePrograms
		{
			get
			{
				if (_activePrograms == null)
				{
					_activePrograms = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ActivePrograms", cr2w, this);
				}
				return _activePrograms;
			}
			set
			{
				if (_activePrograms == value)
				{
					return;
				}
				_activePrograms = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ActiveTraps")] 
		public gamebbScriptID_Variant ActiveTraps
		{
			get
			{
				if (_activeTraps == null)
				{
					_activeTraps = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ActiveTraps", cr2w, this);
				}
				return _activeTraps;
			}
			set
			{
				if (_activeTraps == value)
				{
					return;
				}
				_activeTraps = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("State")] 
		public gamebbScriptID_Int32 State
		{
			get
			{
				if (_state == null)
				{
					_state = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "State", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("Entity")] 
		public gamebbScriptID_Variant Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "Entity", cr2w, this);
				}
				return _entity;
			}
			set
			{
				if (_entity == value)
				{
					return;
				}
				_entity = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("IsJournalTarget")] 
		public gamebbScriptID_Bool IsJournalTarget
		{
			get
			{
				if (_isJournalTarget == null)
				{
					_isJournalTarget = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsJournalTarget", cr2w, this);
				}
				return _isJournalTarget;
			}
			set
			{
				if (_isJournalTarget == value)
				{
					return;
				}
				_isJournalTarget = value;
				PropertySet(this);
			}
		}

		public HackingMinigameDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
