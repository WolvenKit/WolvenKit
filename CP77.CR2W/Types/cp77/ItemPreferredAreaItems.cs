using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemPreferredAreaItems : IScriptable
	{
		[Ordinal(0)]  [RED("equipmentArea")] public CEnum<gamedataEquipmentArea> EquipmentArea { get; set; }
		[Ordinal(1)]  [RED("items")] public CArray<InventoryItemData> Items { get; set; }

		public ItemPreferredAreaItems(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
