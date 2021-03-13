using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemPreferredAreaItems : IScriptable
	{
		[Ordinal(0)] [RED("equipmentArea")] public CEnum<gamedataEquipmentArea> EquipmentArea { get; set; }
		[Ordinal(1)] [RED("items")] public CArray<InventoryItemData> Items { get; set; }

		public ItemPreferredAreaItems(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
