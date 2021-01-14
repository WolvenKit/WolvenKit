using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TerminalControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("broadcastGlitchVideoPath")] public redResourceReferenceScriptToken BroadcastGlitchVideoPath { get; set; }
		[Ordinal(1)]  [RED("defaultGlitchVideoPath")] public redResourceReferenceScriptToken DefaultGlitchVideoPath { get; set; }
		[Ordinal(2)]  [RED("forcedElevatorArrowsState")] public CEnum<EForcedElevatorArrowsState> ForcedElevatorArrowsState { get; set; }
		[Ordinal(3)]  [RED("shouldShowTerminalTitle")] public CBool ShouldShowTerminalTitle { get; set; }
		[Ordinal(4)]  [RED("spawnedSystems")] public CArray<CHandle<VirtualSystemPS>> SpawnedSystems { get; set; }
		[Ordinal(5)]  [RED("state")] public CEnum<gameinteractionsReactionState> State { get; set; }
		[Ordinal(6)]  [RED("terminalSetup")] public TerminalSetup TerminalSetup { get; set; }
		[Ordinal(7)]  [RED("terminalSkillChecks")] public CHandle<HackEngContainer> TerminalSkillChecks { get; set; }
		[Ordinal(8)]  [RED("useKeyloggerHack")] public CBool UseKeyloggerHack { get; set; }

		public TerminalControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
