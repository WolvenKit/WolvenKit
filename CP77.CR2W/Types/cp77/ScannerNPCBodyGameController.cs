using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerNPCBodyGameController : BaseChunkGameController
	{
		[Ordinal(0)]  [RED("chunkBlackboard")] public CHandle<gameIBlackboard> ChunkBlackboard { get; set; }
		[Ordinal(1)]  [RED("chunkBlackboardDef")] public CHandle<UI_ScannerModulesDef> ChunkBlackboardDef { get; set; }
		[Ordinal(2)]  [RED("questClueBlackboardDef")] public CHandle<UI_ScannerDef> QuestClueBlackboardDef { get; set; }
		[Ordinal(3)]  [RED("factionText")] public inkTextWidgetReference FactionText { get; set; }
		[Ordinal(4)]  [RED("dataBaseWidgetHolder")] public inkWidgetReference DataBaseWidgetHolder { get; set; }
		[Ordinal(5)]  [RED("factionCallbackID")] public CUInt32 FactionCallbackID { get; set; }
		[Ordinal(6)]  [RED("rarityCallbackID")] public CUInt32 RarityCallbackID { get; set; }
		[Ordinal(7)]  [RED("isValidFaction")] public CBool IsValidFaction { get; set; }

		public ScannerNPCBodyGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
