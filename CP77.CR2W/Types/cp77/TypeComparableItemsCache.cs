using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TypeComparableItemsCache : IScriptable
	{
		[Ordinal(0)] [RED("itemType")] public CEnum<gamedataItemType> ItemType { get; set; }
		[Ordinal(1)] [RED("cache")] public CHandle<ItemComparableTypesCache> Cache { get; set; }
		[Ordinal(2)] [RED("items")] public CArray<InventoryItemData> Items { get; set; }

		public TypeComparableItemsCache(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
