using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemComparableTypesCache : IScriptable
	{
		[Ordinal(0)] [RED("itemType")] public CEnum<gamedataItemType> ItemType { get; set; }
		[Ordinal(1)] [RED("itemTypeRecord")] public wCHandle<gamedataItemType_Record> ItemTypeRecord { get; set; }
		[Ordinal(2)] [RED("comparableTypes")] public CArray<CEnum<gamedataItemType>> ComparableTypes { get; set; }
		[Ordinal(3)] [RED("comparableRecordTypes")] public CArray<wCHandle<gamedataItemType_Record>> ComparableRecordTypes { get; set; }

		public ItemComparableTypesCache(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
