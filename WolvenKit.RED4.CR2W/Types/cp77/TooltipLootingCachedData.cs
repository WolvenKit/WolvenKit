using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipLootingCachedData : IScriptable
	{
		[Ordinal(0)] [RED("externalItemData")] public wCHandle<gameItemData> ExternalItemData { get; set; }
		[Ordinal(1)] [RED("itemRecord")] public wCHandle<gamedataItem_Record> ItemRecord { get; set; }
		[Ordinal(2)] [RED("comparisionItemData")] public wCHandle<gameItemData> ComparisionItemData { get; set; }
		[Ordinal(3)] [RED("lootingData")] public CHandle<MinimalLootingListItemData> LootingData { get; set; }

		public TooltipLootingCachedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
