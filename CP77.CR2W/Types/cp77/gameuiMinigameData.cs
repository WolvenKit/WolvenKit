using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMinigameData : CVariable
	{
		[Ordinal(0)] [RED("timeLimit")] public CFloat TimeLimit { get; set; }
		[Ordinal(1)] [RED("trapSpawnProbability")] public CFloat TrapSpawnProbability { get; set; }
		[Ordinal(2)] [RED("gridSize")] public CUInt32 GridSize { get; set; }
		[Ordinal(3)] [RED("bufferSize")] public CUInt32 BufferSize { get; set; }
		[Ordinal(4)] [RED("timerWaitsForInteraction")] public CBool TimerWaitsForInteraction { get; set; }
		[Ordinal(5)] [RED("acceptableTraps")] public CArray<CHandle<gamedataMiniGame_Trap_Record>> AcceptableTraps { get; set; }
		[Ordinal(6)] [RED("symbolsToUse")] public CHandle<gamedataMiniGame_AllSymbols_Record> SymbolsToUse { get; set; }
		[Ordinal(7)] [RED("rules")] public CArray<CHandle<gameuiMinigameGenerationRule>> Rules { get; set; }

		public gameuiMinigameData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
