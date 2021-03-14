using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinigameGenerationRule : IScriptable
	{
		private wCHandle<gameuiHackingMinigameGameController> _minigameController;
		private CHandle<gameBlackboardSystem> _blackboardSystem;
		private wCHandle<entEntity> _entity;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<gamedataMinigame_Def_Record> _minigameRecord;
		private CInt32 _bufferSize;
		private CBool _isItemBreach;

		[Ordinal(0)] 
		[RED("minigameController")] 
		public wCHandle<gameuiHackingMinigameGameController> MinigameController
		{
			get
			{
				if (_minigameController == null)
				{
					_minigameController = (wCHandle<gameuiHackingMinigameGameController>) CR2WTypeManager.Create("whandle:gameuiHackingMinigameGameController", "minigameController", cr2w, this);
				}
				return _minigameController;
			}
			set
			{
				if (_minigameController == value)
				{
					return;
				}
				_minigameController = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("blackboardSystem")] 
		public CHandle<gameBlackboardSystem> BlackboardSystem
		{
			get
			{
				if (_blackboardSystem == null)
				{
					_blackboardSystem = (CHandle<gameBlackboardSystem>) CR2WTypeManager.Create("handle:gameBlackboardSystem", "blackboardSystem", cr2w, this);
				}
				return _blackboardSystem;
			}
			set
			{
				if (_blackboardSystem == value)
				{
					return;
				}
				_blackboardSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "entity", cr2w, this);
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

		[Ordinal(3)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
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

		[Ordinal(4)] 
		[RED("minigameRecord")] 
		public wCHandle<gamedataMinigame_Def_Record> MinigameRecord
		{
			get
			{
				if (_minigameRecord == null)
				{
					_minigameRecord = (wCHandle<gamedataMinigame_Def_Record>) CR2WTypeManager.Create("whandle:gamedataMinigame_Def_Record", "minigameRecord", cr2w, this);
				}
				return _minigameRecord;
			}
			set
			{
				if (_minigameRecord == value)
				{
					return;
				}
				_minigameRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("bufferSize")] 
		public CInt32 BufferSize
		{
			get
			{
				if (_bufferSize == null)
				{
					_bufferSize = (CInt32) CR2WTypeManager.Create("Int32", "bufferSize", cr2w, this);
				}
				return _bufferSize;
			}
			set
			{
				if (_bufferSize == value)
				{
					return;
				}
				_bufferSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isItemBreach")] 
		public CBool IsItemBreach
		{
			get
			{
				if (_isItemBreach == null)
				{
					_isItemBreach = (CBool) CR2WTypeManager.Create("Bool", "isItemBreach", cr2w, this);
				}
				return _isItemBreach;
			}
			set
			{
				if (_isItemBreach == value)
				{
					return;
				}
				_isItemBreach = value;
				PropertySet(this);
			}
		}

		public gameuiMinigameGenerationRule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
