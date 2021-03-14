using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LootingGameController : gameuiWidgetGameController
	{
		private CHandle<InventoryDataManagerV2> _dataManager;
		private wCHandle<gameIBlackboard> _bbInteractions;
		private wCHandle<gameIBlackboard> _bbEquipmentData;
		private CHandle<UIInteractionsDef> _bbInteractionsDefinition;
		private CHandle<UI_EquipmentDataDef> _bbEquipmentDefinition;
		private CUInt32 _dataListenerId;
		private CUInt32 _activeListenerId;
		private CUInt32 _activeHubListenerId;
		private CUInt32 _weaponDataListenerId;
		private CHandle<LootingController> _controller;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<inkanimProxy> _introAnim;
		private CHandle<inkanimProxy> _outroAnim;
		private gameSlotWeaponData _lastActiveWeapon;
		private InventoryItemData _lastActiveWeaponData;
		private gameinteractionsvisLootData _previousData;

		[Ordinal(2)] 
		[RED("dataManager")] 
		public CHandle<InventoryDataManagerV2> DataManager
		{
			get
			{
				if (_dataManager == null)
				{
					_dataManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "dataManager", cr2w, this);
				}
				return _dataManager;
			}
			set
			{
				if (_dataManager == value)
				{
					return;
				}
				_dataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("bbInteractions")] 
		public wCHandle<gameIBlackboard> BbInteractions
		{
			get
			{
				if (_bbInteractions == null)
				{
					_bbInteractions = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "bbInteractions", cr2w, this);
				}
				return _bbInteractions;
			}
			set
			{
				if (_bbInteractions == value)
				{
					return;
				}
				_bbInteractions = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bbEquipmentData")] 
		public wCHandle<gameIBlackboard> BbEquipmentData
		{
			get
			{
				if (_bbEquipmentData == null)
				{
					_bbEquipmentData = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "bbEquipmentData", cr2w, this);
				}
				return _bbEquipmentData;
			}
			set
			{
				if (_bbEquipmentData == value)
				{
					return;
				}
				_bbEquipmentData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("bbInteractionsDefinition")] 
		public CHandle<UIInteractionsDef> BbInteractionsDefinition
		{
			get
			{
				if (_bbInteractionsDefinition == null)
				{
					_bbInteractionsDefinition = (CHandle<UIInteractionsDef>) CR2WTypeManager.Create("handle:UIInteractionsDef", "bbInteractionsDefinition", cr2w, this);
				}
				return _bbInteractionsDefinition;
			}
			set
			{
				if (_bbInteractionsDefinition == value)
				{
					return;
				}
				_bbInteractionsDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("bbEquipmentDefinition")] 
		public CHandle<UI_EquipmentDataDef> BbEquipmentDefinition
		{
			get
			{
				if (_bbEquipmentDefinition == null)
				{
					_bbEquipmentDefinition = (CHandle<UI_EquipmentDataDef>) CR2WTypeManager.Create("handle:UI_EquipmentDataDef", "bbEquipmentDefinition", cr2w, this);
				}
				return _bbEquipmentDefinition;
			}
			set
			{
				if (_bbEquipmentDefinition == value)
				{
					return;
				}
				_bbEquipmentDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("dataListenerId")] 
		public CUInt32 DataListenerId
		{
			get
			{
				if (_dataListenerId == null)
				{
					_dataListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "dataListenerId", cr2w, this);
				}
				return _dataListenerId;
			}
			set
			{
				if (_dataListenerId == value)
				{
					return;
				}
				_dataListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("activeListenerId")] 
		public CUInt32 ActiveListenerId
		{
			get
			{
				if (_activeListenerId == null)
				{
					_activeListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "activeListenerId", cr2w, this);
				}
				return _activeListenerId;
			}
			set
			{
				if (_activeListenerId == value)
				{
					return;
				}
				_activeListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("activeHubListenerId")] 
		public CUInt32 ActiveHubListenerId
		{
			get
			{
				if (_activeHubListenerId == null)
				{
					_activeHubListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "activeHubListenerId", cr2w, this);
				}
				return _activeHubListenerId;
			}
			set
			{
				if (_activeHubListenerId == value)
				{
					return;
				}
				_activeHubListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("weaponDataListenerId")] 
		public CUInt32 WeaponDataListenerId
		{
			get
			{
				if (_weaponDataListenerId == null)
				{
					_weaponDataListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "weaponDataListenerId", cr2w, this);
				}
				return _weaponDataListenerId;
			}
			set
			{
				if (_weaponDataListenerId == value)
				{
					return;
				}
				_weaponDataListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("controller")] 
		public CHandle<LootingController> Controller
		{
			get
			{
				if (_controller == null)
				{
					_controller = (CHandle<LootingController>) CR2WTypeManager.Create("handle:LootingController", "controller", cr2w, this);
				}
				return _controller;
			}
			set
			{
				if (_controller == value)
				{
					return;
				}
				_controller = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
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

		[Ordinal(13)] 
		[RED("introAnim")] 
		public CHandle<inkanimProxy> IntroAnim
		{
			get
			{
				if (_introAnim == null)
				{
					_introAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "introAnim", cr2w, this);
				}
				return _introAnim;
			}
			set
			{
				if (_introAnim == value)
				{
					return;
				}
				_introAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("outroAnim")] 
		public CHandle<inkanimProxy> OutroAnim
		{
			get
			{
				if (_outroAnim == null)
				{
					_outroAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "outroAnim", cr2w, this);
				}
				return _outroAnim;
			}
			set
			{
				if (_outroAnim == value)
				{
					return;
				}
				_outroAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("lastActiveWeapon")] 
		public gameSlotWeaponData LastActiveWeapon
		{
			get
			{
				if (_lastActiveWeapon == null)
				{
					_lastActiveWeapon = (gameSlotWeaponData) CR2WTypeManager.Create("gameSlotWeaponData", "lastActiveWeapon", cr2w, this);
				}
				return _lastActiveWeapon;
			}
			set
			{
				if (_lastActiveWeapon == value)
				{
					return;
				}
				_lastActiveWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("lastActiveWeaponData")] 
		public InventoryItemData LastActiveWeaponData
		{
			get
			{
				if (_lastActiveWeaponData == null)
				{
					_lastActiveWeaponData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "lastActiveWeaponData", cr2w, this);
				}
				return _lastActiveWeaponData;
			}
			set
			{
				if (_lastActiveWeaponData == value)
				{
					return;
				}
				_lastActiveWeaponData = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("previousData")] 
		public gameinteractionsvisLootData PreviousData
		{
			get
			{
				if (_previousData == null)
				{
					_previousData = (gameinteractionsvisLootData) CR2WTypeManager.Create("gameinteractionsvisLootData", "previousData", cr2w, this);
				}
				return _previousData;
			}
			set
			{
				if (_previousData == value)
				{
					return;
				}
				_previousData = value;
				PropertySet(this);
			}
		}

		public LootingGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
