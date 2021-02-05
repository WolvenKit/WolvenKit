using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiProgramsGridGenRule : gameuiMinigameGenerationRule
	{
		[Ordinal(0)]  [RED("blackboardSystem")] public CHandle<gameBlackboardSystem> BlackboardSystem { get; set; }
		[Ordinal(1)]  [RED("entity")] public wCHandle<entEntity> Entity { get; set; }
		[Ordinal(2)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(3)]  [RED("minigameRecord")] public wCHandle<gamedataMinigame_Def_Record> MinigameRecord { get; set; }
		[Ordinal(4)]  [RED("bufferSize")] public CInt32 BufferSize { get; set; }
		[Ordinal(5)]  [RED("isItemBreach")] public CBool IsItemBreach { get; set; }

		public gameuiProgramsGridGenRule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
