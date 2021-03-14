using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatProvider : IScriptable
	{
		private wCHandle<gameItemData> _gameItemData;
		private gameInnerItemData _partData;
		private InventoryItemData _inventoryItemData;
		private CEnum<gameEStatProviderDataSource> _dataSource;

		[Ordinal(0)] 
		[RED("GameItemData")] 
		public wCHandle<gameItemData> GameItemData
		{
			get
			{
				if (_gameItemData == null)
				{
					_gameItemData = (wCHandle<gameItemData>) CR2WTypeManager.Create("whandle:gameItemData", "GameItemData", cr2w, this);
				}
				return _gameItemData;
			}
			set
			{
				if (_gameItemData == value)
				{
					return;
				}
				_gameItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("PartData")] 
		public gameInnerItemData PartData
		{
			get
			{
				if (_partData == null)
				{
					_partData = (gameInnerItemData) CR2WTypeManager.Create("gameInnerItemData", "PartData", cr2w, this);
				}
				return _partData;
			}
			set
			{
				if (_partData == value)
				{
					return;
				}
				_partData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("InventoryItemData")] 
		public InventoryItemData InventoryItemData
		{
			get
			{
				if (_inventoryItemData == null)
				{
					_inventoryItemData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "InventoryItemData", cr2w, this);
				}
				return _inventoryItemData;
			}
			set
			{
				if (_inventoryItemData == value)
				{
					return;
				}
				_inventoryItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("dataSource")] 
		public CEnum<gameEStatProviderDataSource> DataSource
		{
			get
			{
				if (_dataSource == null)
				{
					_dataSource = (CEnum<gameEStatProviderDataSource>) CR2WTypeManager.Create("gameEStatProviderDataSource", "dataSource", cr2w, this);
				}
				return _dataSource;
			}
			set
			{
				if (_dataSource == value)
				{
					return;
				}
				_dataSource = value;
				PropertySet(this);
			}
		}

		public StatProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
