using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NewTurnMinigameData : CVariable
	{
		[Ordinal(0)]  [RED("basicAccessCompletionState")] public ProgramProgressData BasicAccessCompletionState { get; set; }
		[Ordinal(1)]  [RED("doConsume")] public CBool DoConsume { get; set; }
		[Ordinal(2)]  [RED("doRegenerateGrid")] public CBool DoRegenerateGrid { get; set; }
		[Ordinal(3)]  [RED("enemyProgramsChange")] public CBool EnemyProgramsChange { get; set; }
		[Ordinal(4)]  [RED("enemyProgramsCompletionState")] public CArray<ProgramProgressData> EnemyProgramsCompletionState { get; set; }
		[Ordinal(5)]  [RED("enemyprogramsAdded")] public CArray<ProgramData> EnemyprogramsAdded { get; set; }
		[Ordinal(6)]  [RED("enemyprogramsRemoved")] public CArray<ProgramData> EnemyprogramsRemoved { get; set; }
		[Ordinal(7)]  [RED("newEnemyBufferContent")] public CArray<ElementData> NewEnemyBufferContent { get; set; }
		[Ordinal(8)]  [RED("newPlayerBufferContent")] public CArray<ElementData> NewPlayerBufferContent { get; set; }
		[Ordinal(9)]  [RED("nextHighlightMode")] public CEnum<HighlightMode> NextHighlightMode { get; set; }
		[Ordinal(10)]  [RED("playerProgramsAdded")] public CArray<ProgramData> PlayerProgramsAdded { get; set; }
		[Ordinal(11)]  [RED("playerProgramsChange")] public CBool PlayerProgramsChange { get; set; }
		[Ordinal(12)]  [RED("playerProgramsCompletionState")] public CArray<ProgramProgressData> PlayerProgramsCompletionState { get; set; }
		[Ordinal(13)]  [RED("playerProgramsRemoved")] public CArray<ProgramData> PlayerProgramsRemoved { get; set; }
		[Ordinal(14)]  [RED("position")] public Vector2 Position { get; set; }
		[Ordinal(15)]  [RED("regeneratedGridData")] public CArray<CellData> RegeneratedGridData { get; set; }

		public NewTurnMinigameData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
