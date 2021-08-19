using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackpackCraftingMaterialItemCallbackData : IScriptable
	{
		private InventoryItemData _itemData;

		[Ordinal(0)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		public BackpackCraftingMaterialItemCallbackData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
