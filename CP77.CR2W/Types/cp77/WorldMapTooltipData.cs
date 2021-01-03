using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WorldMapTooltipData : CVariable
	{
		[Ordinal(0)]  [RED("collectionCount")] public CInt32 CollectionCount { get; set; }
		[Ordinal(1)]  [RED("controller")] public wCHandle<gameuiBaseWorldMapMappinController> Controller { get; set; }
		[Ordinal(2)]  [RED("district")] public CEnum<gamedataDistrict> District { get; set; }
		[Ordinal(3)]  [RED("fastTravelEnabled")] public CBool FastTravelEnabled { get; set; }
		[Ordinal(4)]  [RED("isCollection")] public CBool IsCollection { get; set; }
		[Ordinal(5)]  [RED("journalEntry")] public wCHandle<gameJournalEntry> JournalEntry { get; set; }
		[Ordinal(6)]  [RED("mappin")] public wCHandle<gamemappinsIMappin> Mappin { get; set; }
		[Ordinal(7)]  [RED("readJournal")] public CBool ReadJournal { get; set; }

		public WorldMapTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
