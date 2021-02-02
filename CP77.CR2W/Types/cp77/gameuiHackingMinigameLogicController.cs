using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiHackingMinigameLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("resetButton")] public inkWidgetReference ResetButton { get; set; }
		[Ordinal(1)]  [RED("grid")] public inkUniformGridWidgetReference Grid { get; set; }
		[Ordinal(2)]  [RED("buffer")] public inkCompoundWidgetReference Buffer { get; set; }
		[Ordinal(3)]  [RED("programs")] public inkCompoundWidgetReference Programs { get; set; }
		[Ordinal(4)]  [RED("activatedTraps")] public inkCompoundWidgetReference ActivatedTraps { get; set; }
		[Ordinal(5)]  [RED("failScreenWidget")] public inkCompoundWidgetReference FailScreenWidget { get; set; }
		[Ordinal(6)]  [RED("successScreenWidget")] public inkCompoundWidgetReference SuccessScreenWidget { get; set; }
		[Ordinal(7)]  [RED("timer")] public inkTextWidgetReference Timer { get; set; }
		[Ordinal(8)]  [RED("accessInformationText")] public inkTextWidgetReference AccessInformationText { get; set; }
		[Ordinal(9)]  [RED("successExitTerminalText")] public inkTextWidgetReference SuccessExitTerminalText { get; set; }
		[Ordinal(10)]  [RED("failedExitTerminalText")] public inkTextWidgetReference FailedExitTerminalText { get; set; }
		[Ordinal(11)]  [RED("gridVerticalHiglight")] public inkWidgetReference GridVerticalHiglight { get; set; }
		[Ordinal(12)]  [RED("gridHorizontalHiglight")] public inkWidgetReference GridHorizontalHiglight { get; set; }
		[Ordinal(13)]  [RED("programsColumnHiglight")] public inkWidgetReference ProgramsColumnHiglight { get; set; }
		[Ordinal(14)]  [RED("successExitButton")] public inkWidgetReference SuccessExitButton { get; set; }
		[Ordinal(15)]  [RED("failureExitButton")] public inkWidgetReference FailureExitButton { get; set; }
		[Ordinal(16)]  [RED("timerProgressBar")] public inkWidgetReference TimerProgressBar { get; set; }
		[Ordinal(17)]  [RED("introAnimName")] public CName IntroAnimName { get; set; }
		[Ordinal(18)]  [RED("loopAnimName")] public CName LoopAnimName { get; set; }
		[Ordinal(19)]  [RED("cursorAnimName")] public CName CursorAnimName { get; set; }
		[Ordinal(20)]  [RED("higlightAnimName")] public CName HiglightAnimName { get; set; }
		[Ordinal(21)]  [RED("gameWonAnimName")] public CName GameWonAnimName { get; set; }
		[Ordinal(22)]  [RED("gameLostAnimName")] public CName GameLostAnimName { get; set; }
		[Ordinal(23)]  [RED("terminalShutdownAnimName")] public CName TerminalShutdownAnimName { get; set; }
		[Ordinal(24)]  [RED("trapActivatedAnimName")] public CName TrapActivatedAnimName { get; set; }
		[Ordinal(25)]  [RED("programSucceedAnimName")] public CName ProgramSucceedAnimName { get; set; }
		[Ordinal(26)]  [RED("programFailedAnimName")] public CName ProgramFailedAnimName { get; set; }
		[Ordinal(27)]  [RED("programResetFromFailedAnimName")] public CName ProgramResetFromFailedAnimName { get; set; }
		[Ordinal(28)]  [RED("gridCellHoverAnimName")] public CName GridCellHoverAnimName { get; set; }
		[Ordinal(29)]  [RED("gridCellClickFlashAnimName")] public CName GridCellClickFlashAnimName { get; set; }
		[Ordinal(30)]  [RED("bufferCellHoverAnimName")] public CName BufferCellHoverAnimName { get; set; }
		[Ordinal(31)]  [RED("bufferCellClickFlashAnimName")] public CName BufferCellClickFlashAnimName { get; set; }
		[Ordinal(32)]  [RED("programCellClickFlashAnimName")] public CName ProgramCellClickFlashAnimName { get; set; }
		[Ordinal(33)]  [RED("cursorWidgetRelativePath")] public CName CursorWidgetRelativePath { get; set; }
		[Ordinal(34)]  [RED("activatedTrapIconLibraryName")] public CName ActivatedTrapIconLibraryName { get; set; }
		[Ordinal(35)]  [RED("trapIconsContainerRelativePath")] public CName TrapIconsContainerRelativePath { get; set; }
		[Ordinal(36)]  [RED("bufferCellLibraryName")] public CName BufferCellLibraryName { get; set; }
		[Ordinal(37)]  [RED("bufferCellTextWidgetRelativePath")] public CName BufferCellTextWidgetRelativePath { get; set; }
		[Ordinal(38)]  [RED("programCellLibraryName")] public CName ProgramCellLibraryName { get; set; }
		[Ordinal(39)]  [RED("programCellTextWidgetRelativePath")] public CName ProgramCellTextWidgetRelativePath { get; set; }
		[Ordinal(40)]  [RED("gridCellLibraryName")] public CName GridCellLibraryName { get; set; }
		[Ordinal(41)]  [RED("gridCellTextWidgetRelativePath")] public CName GridCellTextWidgetRelativePath { get; set; }
		[Ordinal(42)]  [RED("gridCellTrapIconWidgetRelativePath")] public CName GridCellTrapIconWidgetRelativePath { get; set; }
		[Ordinal(43)]  [RED("gridCellTrapIconContainerRelativePath")] public CName GridCellTrapIconContainerRelativePath { get; set; }
		[Ordinal(44)]  [RED("gridCellProgramHighlightRelativePath")] public CName GridCellProgramHighlightRelativePath { get; set; }
		[Ordinal(45)]  [RED("gridCellDefaultStateName")] public CName GridCellDefaultStateName { get; set; }
		[Ordinal(46)]  [RED("gridCellHoveredStateName")] public CName GridCellHoveredStateName { get; set; }
		[Ordinal(47)]  [RED("gridCellSelectedStateName")] public CName GridCellSelectedStateName { get; set; }
		[Ordinal(48)]  [RED("gridCellDisabledStateName")] public CName GridCellDisabledStateName { get; set; }
		[Ordinal(49)]  [RED("mainHiglightBarStateName")] public CName MainHiglightBarStateName { get; set; }
		[Ordinal(50)]  [RED("secondaryHiglightBarStateName")] public CName SecondaryHiglightBarStateName { get; set; }
		[Ordinal(51)]  [RED("inactiveHiglightBarStateName")] public CName InactiveHiglightBarStateName { get; set; }
		[Ordinal(52)]  [RED("gridCellDisabledSymbol")] public CString GridCellDisabledSymbol { get; set; }
		[Ordinal(53)]  [RED("programSucceedStateName")] public CName ProgramSucceedStateName { get; set; }
		[Ordinal(54)]  [RED("programCellReadyStateName")] public CName ProgramCellReadyStateName { get; set; }
		[Ordinal(55)]  [RED("programCellHighlightStateName")] public CName ProgramCellHighlightStateName { get; set; }
		[Ordinal(56)]  [RED("programFailedStateName")] public CName ProgramFailedStateName { get; set; }
		[Ordinal(57)]  [RED("programEntryLibraryName")] public CName ProgramEntryLibraryName { get; set; }
		[Ordinal(58)]  [RED("programEntryTextWidgetRelativePath")] public CName ProgramEntryTextWidgetRelativePath { get; set; }
		[Ordinal(59)]  [RED("programEntryNoteWidgetRelativePath")] public CName ProgramEntryNoteWidgetRelativePath { get; set; }
		[Ordinal(60)]  [RED("programEntryInstructionContainerRelativePath")] public CName ProgramEntryInstructionContainerRelativePath { get; set; }
		[Ordinal(61)]  [RED("programEntryIconPath")] public CName ProgramEntryIconPath { get; set; }

		public gameuiHackingMinigameLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
