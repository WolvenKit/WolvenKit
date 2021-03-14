using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryDataManager : IScriptable
	{
		private ScriptGameInstance _gameInstance;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<gameTransactionSystem> _transactionSystem;
		private CHandle<EquipmentSystem> _equipmentSystem;
		private CHandle<gameStatsSystem> _statsSystem;
		private CHandle<UILocalizationMap> _locMgr;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get
			{
				if (_transactionSystem == null)
				{
					_transactionSystem = (CHandle<gameTransactionSystem>) CR2WTypeManager.Create("handle:gameTransactionSystem", "transactionSystem", cr2w, this);
				}
				return _transactionSystem;
			}
			set
			{
				if (_transactionSystem == value)
				{
					return;
				}
				_transactionSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("equipmentSystem")] 
		public CHandle<EquipmentSystem> EquipmentSystem
		{
			get
			{
				if (_equipmentSystem == null)
				{
					_equipmentSystem = (CHandle<EquipmentSystem>) CR2WTypeManager.Create("handle:EquipmentSystem", "equipmentSystem", cr2w, this);
				}
				return _equipmentSystem;
			}
			set
			{
				if (_equipmentSystem == value)
				{
					return;
				}
				_equipmentSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get
			{
				if (_statsSystem == null)
				{
					_statsSystem = (CHandle<gameStatsSystem>) CR2WTypeManager.Create("handle:gameStatsSystem", "statsSystem", cr2w, this);
				}
				return _statsSystem;
			}
			set
			{
				if (_statsSystem == value)
				{
					return;
				}
				_statsSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("locMgr")] 
		public CHandle<UILocalizationMap> LocMgr
		{
			get
			{
				if (_locMgr == null)
				{
					_locMgr = (CHandle<UILocalizationMap>) CR2WTypeManager.Create("handle:UILocalizationMap", "locMgr", cr2w, this);
				}
				return _locMgr;
			}
			set
			{
				if (_locMgr == value)
				{
					return;
				}
				_locMgr = value;
				PropertySet(this);
			}
		}

		public InventoryDataManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
