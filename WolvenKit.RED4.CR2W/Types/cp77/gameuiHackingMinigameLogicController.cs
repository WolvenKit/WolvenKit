using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHackingMinigameLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("grid")] public inkUniformGridWidgetReference Grid { get; set; }
		[Ordinal(2)] [RED("buffer")] public inkCompoundWidgetReference Buffer { get; set; }
		[Ordinal(3)] [RED("programs")] public inkCompoundWidgetReference Programs { get; set; }
		[Ordinal(4)] [RED("timer")] public inkTextWidgetReference Timer { get; set; }
		[Ordinal(5)] [RED("timerProgressBar")] public inkWidgetReference TimerProgressBar { get; set; }
		[Ordinal(6)] [RED("accessInformationText")] public inkTextWidgetReference AccessInformationText { get; set; }
		[Ordinal(7)] [RED("activatedTraps")] public inkCompoundWidgetReference ActivatedTraps { get; set; }
		[Ordinal(8)] [RED("gridVerticalHiglight")] public inkWidgetReference GridVerticalHiglight { get; set; }
		[Ordinal(9)] [RED("gridHorizontalHiglight")] public inkWidgetReference GridHorizontalHiglight { get; set; }
		[Ordinal(10)] [RED("programsColumnHiglight")] public inkWidgetReference ProgramsColumnHiglight { get; set; }
		[Ordinal(11)] [RED("successScreenWidget")] public inkCompoundWidgetReference SuccessScreenWidget { get; set; }
		[Ordinal(12)] [RED("failScreenWidget")] public inkCompoundWidgetReference FailScreenWidget { get; set; }
		[Ordinal(13)] [RED("successExitTerminalText")] public inkTextWidgetReference SuccessExitTerminalText { get; set; }
		[Ordinal(14)] [RED("failedExitTerminalText")] public inkTextWidgetReference FailedExitTerminalText { get; set; }
		[Ordinal(15)] [RED("successExitButton")] public inkWidgetReference SuccessExitButton { get; set; }
		[Ordinal(16)] [RED("failureExitButton")] public inkWidgetReference FailureExitButton { get; set; }
		[Ordinal(17)] [RED("resetButton")] public inkWidgetReference ResetButton { get; set; }
		[Ordinal(18)] [RED("introAnimName")] public CName IntroAnimName { get; set; }
		[Ordinal(19)] [RED("loopAnimName")] public CName LoopAnimName { get; set; }
		[Ordinal(20)] [RED("cursorAnimName")] public CName CursorAnimName { get; set; }
		[Ordinal(21)] [RED("higlightAnimName")] public CName HiglightAnimName { get; set; }
		[Ordinal(22)] [RED("gameWonAnimName")] public CName GameWonAnimName { get; set; }
		[Ordinal(23)] [RED("gameLostAnimName")] public CName GameLostAnimName { get; set; }
		[Ordinal(24)] [RED("terminalShutdownAnimName")] public CName TerminalShutdownAnimName { get; set; }
		[Ordinal(25)] [RED("trapActivatedAnimName")] public CName TrapActivatedAnimName { get; set; }
		[Ordinal(26)] [RED("programSucceedAnimName")] public CName ProgramSucceedAnimName { get; set; }
		[Ordinal(27)] [RED("programFailedAnimName")] public CName ProgramFailedAnimName { get; set; }
		[Ordinal(28)] [RED("programResetFromFailedAnimName")] public CName ProgramResetFromFailedAnimName { get; set; }
		[Ordinal(29)] [RED("gridCellHoverAnimName")] public CName GridCellHoverAnimName { get; set; }
		[Ordinal(30)] [RED("gridCellClickFlashAnimName")] public CName GridCellClickFlashAnimName { get; set; }
		[Ordinal(31)] [RED("bufferCellHoverAnimName")] public CName BufferCellHoverAnimName { get; set; }
		[Ordinal(32)] [RED("bufferCellClickFlashAnimName")] public CName BufferCellClickFlashAnimName { get; set; }
		[Ordinal(33)] [RED("programCellClickFlashAnimName")] public CName ProgramCellClickFlashAnimName { get; set; }
		[Ordinal(34)] [RED("activatedTrapIconLibraryName")] public CName ActivatedTrapIconLibraryName { get; set; }
		[Ordinal(35)] [RED("bufferCellLibraryName")] public CName BufferCellLibraryName { get; set; }
		[Ordinal(36)] [RED("programCellLibraryName")] public CName ProgramCellLibraryName { get; set; }
		[Ordinal(37)] [RED("gridCellLibraryName")] public CName GridCellLibraryName { get; set; }
		[Ordinal(38)] [RED("programEntryLibraryName")] public CName ProgramEntryLibraryName { get; set; }
		[Ordinal(39)] [RED("trapIconsContainerRelativePath")] public CName TrapIconsContainerRelativePath { get; set; }
		[Ordinal(40)] [RED("bufferCellTextWidgetRelativePath")] public CName BufferCellTextWidgetRelativePath { get; set; }
		[Ordinal(41)] [RED("programCellTextWidgetRelativePath")] public CName ProgramCellTextWidgetRelativePath { get; set; }
		[Ordinal(42)] [RED("gridCellTrapIconWidgetRelativePath")] public CName GridCellTrapIconWidgetRelativePath { get; set; }
		[Ordinal(43)] [RED("gridCellTrapIconContainerRelativePath")] public CName GridCellTrapIconContainerRelativePath { get; set; }
		[Ordinal(44)] [RED("gridCellTextWidgetRelativePath")] public CName GridCellTextWidgetRelativePath { get; set; }
		[Ordinal(45)] [RED("gridCellProgramHighlightRelativePath")] public CName GridCellProgramHighlightRelativePath { get; set; }
		[Ordinal(46)] [RED("programEntryTextWidgetRelativePath")] public CName ProgramEntryTextWidgetRelativePath { get; set; }
		[Ordinal(47)] [RED("programEntryNoteWidgetRelativePath")] public CName ProgramEntryNoteWidgetRelativePath { get; set; }
		[Ordinal(48)] [RED("programEntryInstructionContainerRelativePath")] public CName ProgramEntryInstructionContainerRelativePath { get; set; }
		[Ordinal(49)] [RED("programEntryIconPath")] public CName ProgramEntryIconPath { get; set; }
		[Ordinal(50)] [RED("cursorWidgetRelativePath")] public CName CursorWidgetRelativePath { get; set; }
		[Ordinal(51)] [RED("gridCellDefaultStateName")] public CName GridCellDefaultStateName { get; set; }
		[Ordinal(52)] [RED("gridCellHoveredStateName")] public CName GridCellHoveredStateName { get; set; }
		[Ordinal(53)] [RED("gridCellSelectedStateName")] public CName GridCellSelectedStateName { get; set; }
		[Ordinal(54)] [RED("gridCellDisabledStateName")] public CName GridCellDisabledStateName { get; set; }
		[Ordinal(55)] [RED("programSucceedStateName")] public CName ProgramSucceedStateName { get; set; }
		[Ordinal(56)] [RED("programFailedStateName")] public CName ProgramFailedStateName { get; set; }
		[Ordinal(57)] [RED("programCellReadyStateName")] public CName ProgramCellReadyStateName { get; set; }
		[Ordinal(58)] [RED("programCellHighlightStateName")] public CName ProgramCellHighlightStateName { get; set; }
		[Ordinal(59)] [RED("mainHiglightBarStateName")] public CName MainHiglightBarStateName { get; set; }
		[Ordinal(60)] [RED("secondaryHiglightBarStateName")] public CName SecondaryHiglightBarStateName { get; set; }
		[Ordinal(61)] [RED("inactiveHiglightBarStateName")] public CName InactiveHiglightBarStateName { get; set; }
		[Ordinal(62)] [RED("gridCellDisabledSymbol")] public CString GridCellDisabledSymbol { get; set; }

		public gameuiHackingMinigameLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
