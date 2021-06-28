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
			get => GetProperty(ref _gameItemData);
			set => SetProperty(ref _gameItemData, value);
		}

		[Ordinal(1)] 
		[RED("PartData")] 
		public gameInnerItemData PartData
		{
			get => GetProperty(ref _partData);
			set => SetProperty(ref _partData, value);
		}

		[Ordinal(2)] 
		[RED("InventoryItemData")] 
		public InventoryItemData InventoryItemData
		{
			get => GetProperty(ref _inventoryItemData);
			set => SetProperty(ref _inventoryItemData, value);
		}

		[Ordinal(3)] 
		[RED("dataSource")] 
		public CEnum<gameEStatProviderDataSource> DataSource
		{
			get => GetProperty(ref _dataSource);
			set => SetProperty(ref _dataSource, value);
		}

		public StatProvider(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
