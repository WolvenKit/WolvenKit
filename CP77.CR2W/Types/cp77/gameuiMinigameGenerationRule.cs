using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMinigameGenerationRule : IScriptable
	{
		[Ordinal(0)] [RED("minigameController")] public wCHandle<gameuiHackingMinigameGameController> MinigameController { get; set; }
		[Ordinal(1)] [RED("blackboardSystem")] public CHandle<gameBlackboardSystem> BlackboardSystem { get; set; }
		[Ordinal(2)] [RED("entity")] public wCHandle<entEntity> Entity { get; set; }
		[Ordinal(3)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(4)] [RED("minigameRecord")] public wCHandle<gamedataMinigame_Def_Record> MinigameRecord { get; set; }
		[Ordinal(5)] [RED("bufferSize")] public CInt32 BufferSize { get; set; }
		[Ordinal(6)] [RED("isItemBreach")] public CBool IsItemBreach { get; set; }

		public gameuiMinigameGenerationRule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
