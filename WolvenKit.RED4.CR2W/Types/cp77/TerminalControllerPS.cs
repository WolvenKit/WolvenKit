using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TerminalControllerPS : MasterControllerPS
	{
		[Ordinal(104)] [RED("terminalSetup")] public TerminalSetup TerminalSetup { get; set; }
		[Ordinal(105)] [RED("terminalSkillChecks")] public CHandle<HackEngContainer> TerminalSkillChecks { get; set; }
		[Ordinal(106)] [RED("spawnedSystems")] public CArray<CHandle<VirtualSystemPS>> SpawnedSystems { get; set; }
		[Ordinal(107)] [RED("useKeyloggerHack")] public CBool UseKeyloggerHack { get; set; }
		[Ordinal(108)] [RED("shouldShowTerminalTitle")] public CBool ShouldShowTerminalTitle { get; set; }
		[Ordinal(109)] [RED("defaultGlitchVideoPath")] public redResourceReferenceScriptToken DefaultGlitchVideoPath { get; set; }
		[Ordinal(110)] [RED("broadcastGlitchVideoPath")] public redResourceReferenceScriptToken BroadcastGlitchVideoPath { get; set; }
		[Ordinal(111)] [RED("state")] public CEnum<gameinteractionsReactionState> State { get; set; }
		[Ordinal(112)] [RED("forcedElevatorArrowsState")] public CEnum<EForcedElevatorArrowsState> ForcedElevatorArrowsState { get; set; }

		public TerminalControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
