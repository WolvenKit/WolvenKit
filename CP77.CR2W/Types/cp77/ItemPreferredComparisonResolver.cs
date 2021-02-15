using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemPreferredComparisonResolver : IScriptable
	{
		[Ordinal(0)] [RED("cacheadAreaItems")] public CArray<CHandle<ItemPreferredAreaItems>> CacheadAreaItems { get; set; }
		[Ordinal(1)] [RED("cachedComparableTypes")] public CArray<CHandle<ItemComparableTypesCache>> CachedComparableTypes { get; set; }
		[Ordinal(2)] [RED("typeComparableItemsCache")] public CArray<CHandle<TypeComparableItemsCache>> TypeComparableItemsCache { get; set; }
		[Ordinal(3)] [RED("dataManager")] public CHandle<InventoryDataManagerV2> DataManager { get; set; }
		[Ordinal(4)] [RED("forcedCompareItem")] public InventoryItemData ForcedCompareItem { get; set; }
		[Ordinal(5)] [RED("useForceCompare")] public CBool UseForceCompare { get; set; }

		public ItemPreferredComparisonResolver(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
