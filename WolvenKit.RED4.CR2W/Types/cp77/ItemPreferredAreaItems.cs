using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemPreferredAreaItems : IScriptable
	{
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CArray<InventoryItemData> _items;

		[Ordinal(0)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetProperty(ref _equipmentArea);
			set => SetProperty(ref _equipmentArea, value);
		}

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<InventoryItemData> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		public ItemPreferredAreaItems(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
