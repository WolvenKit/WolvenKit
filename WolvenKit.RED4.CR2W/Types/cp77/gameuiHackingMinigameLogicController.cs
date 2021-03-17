using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHackingMinigameLogicController : inkWidgetLogicController
	{
		private inkUniformGridWidgetReference _grid;
		private inkCompoundWidgetReference _buffer;
		private inkCompoundWidgetReference _programs;
		private inkTextWidgetReference _timer;
		private inkWidgetReference _timerProgressBar;
		private inkTextWidgetReference _accessInformationText;
		private inkCompoundWidgetReference _activatedTraps;
		private inkWidgetReference _gridVerticalHiglight;
		private inkWidgetReference _gridHorizontalHiglight;
		private inkWidgetReference _programsColumnHiglight;
		private inkCompoundWidgetReference _successScreenWidget;
		private inkCompoundWidgetReference _failScreenWidget;
		private inkTextWidgetReference _successExitTerminalText;
		private inkTextWidgetReference _failedExitTerminalText;
		private inkWidgetReference _successExitButton;
		private inkWidgetReference _failureExitButton;
		private inkWidgetReference _resetButton;
		private CName _introAnimName;
		private CName _loopAnimName;
		private CName _cursorAnimName;
		private CName _higlightAnimName;
		private CName _gameWonAnimName;
		private CName _gameLostAnimName;
		private CName _terminalShutdownAnimName;
		private CName _trapActivatedAnimName;
		private CName _programSucceedAnimName;
		private CName _programFailedAnimName;
		private CName _programResetFromFailedAnimName;
		private CName _gridCellHoverAnimName;
		private CName _gridCellClickFlashAnimName;
		private CName _bufferCellHoverAnimName;
		private CName _bufferCellClickFlashAnimName;
		private CName _programCellClickFlashAnimName;
		private CName _activatedTrapIconLibraryName;
		private CName _bufferCellLibraryName;
		private CName _programCellLibraryName;
		private CName _gridCellLibraryName;
		private CName _programEntryLibraryName;
		private CName _trapIconsContainerRelativePath;
		private CName _bufferCellTextWidgetRelativePath;
		private CName _programCellTextWidgetRelativePath;
		private CName _gridCellTrapIconWidgetRelativePath;
		private CName _gridCellTrapIconContainerRelativePath;
		private CName _gridCellTextWidgetRelativePath;
		private CName _gridCellProgramHighlightRelativePath;
		private CName _programEntryTextWidgetRelativePath;
		private CName _programEntryNoteWidgetRelativePath;
		private CName _programEntryInstructionContainerRelativePath;
		private CName _programEntryIconPath;
		private CName _cursorWidgetRelativePath;
		private CName _gridCellDefaultStateName;
		private CName _gridCellHoveredStateName;
		private CName _gridCellSelectedStateName;
		private CName _gridCellDisabledStateName;
		private CName _programSucceedStateName;
		private CName _programFailedStateName;
		private CName _programCellReadyStateName;
		private CName _programCellHighlightStateName;
		private CName _mainHiglightBarStateName;
		private CName _secondaryHiglightBarStateName;
		private CName _inactiveHiglightBarStateName;
		private CString _gridCellDisabledSymbol;

		[Ordinal(1)] 
		[RED("grid")] 
		public inkUniformGridWidgetReference Grid
		{
			get => GetProperty(ref _grid);
			set => SetProperty(ref _grid, value);
		}

		[Ordinal(2)] 
		[RED("buffer")] 
		public inkCompoundWidgetReference Buffer
		{
			get => GetProperty(ref _buffer);
			set => SetProperty(ref _buffer, value);
		}

		[Ordinal(3)] 
		[RED("programs")] 
		public inkCompoundWidgetReference Programs
		{
			get => GetProperty(ref _programs);
			set => SetProperty(ref _programs, value);
		}

		[Ordinal(4)] 
		[RED("timer")] 
		public inkTextWidgetReference Timer
		{
			get => GetProperty(ref _timer);
			set => SetProperty(ref _timer, value);
		}

		[Ordinal(5)] 
		[RED("timerProgressBar")] 
		public inkWidgetReference TimerProgressBar
		{
			get => GetProperty(ref _timerProgressBar);
			set => SetProperty(ref _timerProgressBar, value);
		}

		[Ordinal(6)] 
		[RED("accessInformationText")] 
		public inkTextWidgetReference AccessInformationText
		{
			get => GetProperty(ref _accessInformationText);
			set => SetProperty(ref _accessInformationText, value);
		}

		[Ordinal(7)] 
		[RED("activatedTraps")] 
		public inkCompoundWidgetReference ActivatedTraps
		{
			get => GetProperty(ref _activatedTraps);
			set => SetProperty(ref _activatedTraps, value);
		}

		[Ordinal(8)] 
		[RED("gridVerticalHiglight")] 
		public inkWidgetReference GridVerticalHiglight
		{
			get => GetProperty(ref _gridVerticalHiglight);
			set => SetProperty(ref _gridVerticalHiglight, value);
		}

		[Ordinal(9)] 
		[RED("gridHorizontalHiglight")] 
		public inkWidgetReference GridHorizontalHiglight
		{
			get => GetProperty(ref _gridHorizontalHiglight);
			set => SetProperty(ref _gridHorizontalHiglight, value);
		}

		[Ordinal(10)] 
		[RED("programsColumnHiglight")] 
		public inkWidgetReference ProgramsColumnHiglight
		{
			get => GetProperty(ref _programsColumnHiglight);
			set => SetProperty(ref _programsColumnHiglight, value);
		}

		[Ordinal(11)] 
		[RED("successScreenWidget")] 
		public inkCompoundWidgetReference SuccessScreenWidget
		{
			get => GetProperty(ref _successScreenWidget);
			set => SetProperty(ref _successScreenWidget, value);
		}

		[Ordinal(12)] 
		[RED("failScreenWidget")] 
		public inkCompoundWidgetReference FailScreenWidget
		{
			get => GetProperty(ref _failScreenWidget);
			set => SetProperty(ref _failScreenWidget, value);
		}

		[Ordinal(13)] 
		[RED("successExitTerminalText")] 
		public inkTextWidgetReference SuccessExitTerminalText
		{
			get => GetProperty(ref _successExitTerminalText);
			set => SetProperty(ref _successExitTerminalText, value);
		}

		[Ordinal(14)] 
		[RED("failedExitTerminalText")] 
		public inkTextWidgetReference FailedExitTerminalText
		{
			get => GetProperty(ref _failedExitTerminalText);
			set => SetProperty(ref _failedExitTerminalText, value);
		}

		[Ordinal(15)] 
		[RED("successExitButton")] 
		public inkWidgetReference SuccessExitButton
		{
			get => GetProperty(ref _successExitButton);
			set => SetProperty(ref _successExitButton, value);
		}

		[Ordinal(16)] 
		[RED("failureExitButton")] 
		public inkWidgetReference FailureExitButton
		{
			get => GetProperty(ref _failureExitButton);
			set => SetProperty(ref _failureExitButton, value);
		}

		[Ordinal(17)] 
		[RED("resetButton")] 
		public inkWidgetReference ResetButton
		{
			get => GetProperty(ref _resetButton);
			set => SetProperty(ref _resetButton, value);
		}

		[Ordinal(18)] 
		[RED("introAnimName")] 
		public CName IntroAnimName
		{
			get => GetProperty(ref _introAnimName);
			set => SetProperty(ref _introAnimName, value);
		}

		[Ordinal(19)] 
		[RED("loopAnimName")] 
		public CName LoopAnimName
		{
			get => GetProperty(ref _loopAnimName);
			set => SetProperty(ref _loopAnimName, value);
		}

		[Ordinal(20)] 
		[RED("cursorAnimName")] 
		public CName CursorAnimName
		{
			get => GetProperty(ref _cursorAnimName);
			set => SetProperty(ref _cursorAnimName, value);
		}

		[Ordinal(21)] 
		[RED("higlightAnimName")] 
		public CName HiglightAnimName
		{
			get => GetProperty(ref _higlightAnimName);
			set => SetProperty(ref _higlightAnimName, value);
		}

		[Ordinal(22)] 
		[RED("gameWonAnimName")] 
		public CName GameWonAnimName
		{
			get => GetProperty(ref _gameWonAnimName);
			set => SetProperty(ref _gameWonAnimName, value);
		}

		[Ordinal(23)] 
		[RED("gameLostAnimName")] 
		public CName GameLostAnimName
		{
			get => GetProperty(ref _gameLostAnimName);
			set => SetProperty(ref _gameLostAnimName, value);
		}

		[Ordinal(24)] 
		[RED("terminalShutdownAnimName")] 
		public CName TerminalShutdownAnimName
		{
			get => GetProperty(ref _terminalShutdownAnimName);
			set => SetProperty(ref _terminalShutdownAnimName, value);
		}

		[Ordinal(25)] 
		[RED("trapActivatedAnimName")] 
		public CName TrapActivatedAnimName
		{
			get => GetProperty(ref _trapActivatedAnimName);
			set => SetProperty(ref _trapActivatedAnimName, value);
		}

		[Ordinal(26)] 
		[RED("programSucceedAnimName")] 
		public CName ProgramSucceedAnimName
		{
			get => GetProperty(ref _programSucceedAnimName);
			set => SetProperty(ref _programSucceedAnimName, value);
		}

		[Ordinal(27)] 
		[RED("programFailedAnimName")] 
		public CName ProgramFailedAnimName
		{
			get => GetProperty(ref _programFailedAnimName);
			set => SetProperty(ref _programFailedAnimName, value);
		}

		[Ordinal(28)] 
		[RED("programResetFromFailedAnimName")] 
		public CName ProgramResetFromFailedAnimName
		{
			get => GetProperty(ref _programResetFromFailedAnimName);
			set => SetProperty(ref _programResetFromFailedAnimName, value);
		}

		[Ordinal(29)] 
		[RED("gridCellHoverAnimName")] 
		public CName GridCellHoverAnimName
		{
			get => GetProperty(ref _gridCellHoverAnimName);
			set => SetProperty(ref _gridCellHoverAnimName, value);
		}

		[Ordinal(30)] 
		[RED("gridCellClickFlashAnimName")] 
		public CName GridCellClickFlashAnimName
		{
			get => GetProperty(ref _gridCellClickFlashAnimName);
			set => SetProperty(ref _gridCellClickFlashAnimName, value);
		}

		[Ordinal(31)] 
		[RED("bufferCellHoverAnimName")] 
		public CName BufferCellHoverAnimName
		{
			get => GetProperty(ref _bufferCellHoverAnimName);
			set => SetProperty(ref _bufferCellHoverAnimName, value);
		}

		[Ordinal(32)] 
		[RED("bufferCellClickFlashAnimName")] 
		public CName BufferCellClickFlashAnimName
		{
			get => GetProperty(ref _bufferCellClickFlashAnimName);
			set => SetProperty(ref _bufferCellClickFlashAnimName, value);
		}

		[Ordinal(33)] 
		[RED("programCellClickFlashAnimName")] 
		public CName ProgramCellClickFlashAnimName
		{
			get => GetProperty(ref _programCellClickFlashAnimName);
			set => SetProperty(ref _programCellClickFlashAnimName, value);
		}

		[Ordinal(34)] 
		[RED("activatedTrapIconLibraryName")] 
		public CName ActivatedTrapIconLibraryName
		{
			get => GetProperty(ref _activatedTrapIconLibraryName);
			set => SetProperty(ref _activatedTrapIconLibraryName, value);
		}

		[Ordinal(35)] 
		[RED("bufferCellLibraryName")] 
		public CName BufferCellLibraryName
		{
			get => GetProperty(ref _bufferCellLibraryName);
			set => SetProperty(ref _bufferCellLibraryName, value);
		}

		[Ordinal(36)] 
		[RED("programCellLibraryName")] 
		public CName ProgramCellLibraryName
		{
			get => GetProperty(ref _programCellLibraryName);
			set => SetProperty(ref _programCellLibraryName, value);
		}

		[Ordinal(37)] 
		[RED("gridCellLibraryName")] 
		public CName GridCellLibraryName
		{
			get => GetProperty(ref _gridCellLibraryName);
			set => SetProperty(ref _gridCellLibraryName, value);
		}

		[Ordinal(38)] 
		[RED("programEntryLibraryName")] 
		public CName ProgramEntryLibraryName
		{
			get => GetProperty(ref _programEntryLibraryName);
			set => SetProperty(ref _programEntryLibraryName, value);
		}

		[Ordinal(39)] 
		[RED("trapIconsContainerRelativePath")] 
		public CName TrapIconsContainerRelativePath
		{
			get => GetProperty(ref _trapIconsContainerRelativePath);
			set => SetProperty(ref _trapIconsContainerRelativePath, value);
		}

		[Ordinal(40)] 
		[RED("bufferCellTextWidgetRelativePath")] 
		public CName BufferCellTextWidgetRelativePath
		{
			get => GetProperty(ref _bufferCellTextWidgetRelativePath);
			set => SetProperty(ref _bufferCellTextWidgetRelativePath, value);
		}

		[Ordinal(41)] 
		[RED("programCellTextWidgetRelativePath")] 
		public CName ProgramCellTextWidgetRelativePath
		{
			get => GetProperty(ref _programCellTextWidgetRelativePath);
			set => SetProperty(ref _programCellTextWidgetRelativePath, value);
		}

		[Ordinal(42)] 
		[RED("gridCellTrapIconWidgetRelativePath")] 
		public CName GridCellTrapIconWidgetRelativePath
		{
			get => GetProperty(ref _gridCellTrapIconWidgetRelativePath);
			set => SetProperty(ref _gridCellTrapIconWidgetRelativePath, value);
		}

		[Ordinal(43)] 
		[RED("gridCellTrapIconContainerRelativePath")] 
		public CName GridCellTrapIconContainerRelativePath
		{
			get => GetProperty(ref _gridCellTrapIconContainerRelativePath);
			set => SetProperty(ref _gridCellTrapIconContainerRelativePath, value);
		}

		[Ordinal(44)] 
		[RED("gridCellTextWidgetRelativePath")] 
		public CName GridCellTextWidgetRelativePath
		{
			get => GetProperty(ref _gridCellTextWidgetRelativePath);
			set => SetProperty(ref _gridCellTextWidgetRelativePath, value);
		}

		[Ordinal(45)] 
		[RED("gridCellProgramHighlightRelativePath")] 
		public CName GridCellProgramHighlightRelativePath
		{
			get => GetProperty(ref _gridCellProgramHighlightRelativePath);
			set => SetProperty(ref _gridCellProgramHighlightRelativePath, value);
		}

		[Ordinal(46)] 
		[RED("programEntryTextWidgetRelativePath")] 
		public CName ProgramEntryTextWidgetRelativePath
		{
			get => GetProperty(ref _programEntryTextWidgetRelativePath);
			set => SetProperty(ref _programEntryTextWidgetRelativePath, value);
		}

		[Ordinal(47)] 
		[RED("programEntryNoteWidgetRelativePath")] 
		public CName ProgramEntryNoteWidgetRelativePath
		{
			get => GetProperty(ref _programEntryNoteWidgetRelativePath);
			set => SetProperty(ref _programEntryNoteWidgetRelativePath, value);
		}

		[Ordinal(48)] 
		[RED("programEntryInstructionContainerRelativePath")] 
		public CName ProgramEntryInstructionContainerRelativePath
		{
			get => GetProperty(ref _programEntryInstructionContainerRelativePath);
			set => SetProperty(ref _programEntryInstructionContainerRelativePath, value);
		}

		[Ordinal(49)] 
		[RED("programEntryIconPath")] 
		public CName ProgramEntryIconPath
		{
			get => GetProperty(ref _programEntryIconPath);
			set => SetProperty(ref _programEntryIconPath, value);
		}

		[Ordinal(50)] 
		[RED("cursorWidgetRelativePath")] 
		public CName CursorWidgetRelativePath
		{
			get => GetProperty(ref _cursorWidgetRelativePath);
			set => SetProperty(ref _cursorWidgetRelativePath, value);
		}

		[Ordinal(51)] 
		[RED("gridCellDefaultStateName")] 
		public CName GridCellDefaultStateName
		{
			get => GetProperty(ref _gridCellDefaultStateName);
			set => SetProperty(ref _gridCellDefaultStateName, value);
		}

		[Ordinal(52)] 
		[RED("gridCellHoveredStateName")] 
		public CName GridCellHoveredStateName
		{
			get => GetProperty(ref _gridCellHoveredStateName);
			set => SetProperty(ref _gridCellHoveredStateName, value);
		}

		[Ordinal(53)] 
		[RED("gridCellSelectedStateName")] 
		public CName GridCellSelectedStateName
		{
			get => GetProperty(ref _gridCellSelectedStateName);
			set => SetProperty(ref _gridCellSelectedStateName, value);
		}

		[Ordinal(54)] 
		[RED("gridCellDisabledStateName")] 
		public CName GridCellDisabledStateName
		{
			get => GetProperty(ref _gridCellDisabledStateName);
			set => SetProperty(ref _gridCellDisabledStateName, value);
		}

		[Ordinal(55)] 
		[RED("programSucceedStateName")] 
		public CName ProgramSucceedStateName
		{
			get => GetProperty(ref _programSucceedStateName);
			set => SetProperty(ref _programSucceedStateName, value);
		}

		[Ordinal(56)] 
		[RED("programFailedStateName")] 
		public CName ProgramFailedStateName
		{
			get => GetProperty(ref _programFailedStateName);
			set => SetProperty(ref _programFailedStateName, value);
		}

		[Ordinal(57)] 
		[RED("programCellReadyStateName")] 
		public CName ProgramCellReadyStateName
		{
			get => GetProperty(ref _programCellReadyStateName);
			set => SetProperty(ref _programCellReadyStateName, value);
		}

		[Ordinal(58)] 
		[RED("programCellHighlightStateName")] 
		public CName ProgramCellHighlightStateName
		{
			get => GetProperty(ref _programCellHighlightStateName);
			set => SetProperty(ref _programCellHighlightStateName, value);
		}

		[Ordinal(59)] 
		[RED("mainHiglightBarStateName")] 
		public CName MainHiglightBarStateName
		{
			get => GetProperty(ref _mainHiglightBarStateName);
			set => SetProperty(ref _mainHiglightBarStateName, value);
		}

		[Ordinal(60)] 
		[RED("secondaryHiglightBarStateName")] 
		public CName SecondaryHiglightBarStateName
		{
			get => GetProperty(ref _secondaryHiglightBarStateName);
			set => SetProperty(ref _secondaryHiglightBarStateName, value);
		}

		[Ordinal(61)] 
		[RED("inactiveHiglightBarStateName")] 
		public CName InactiveHiglightBarStateName
		{
			get => GetProperty(ref _inactiveHiglightBarStateName);
			set => SetProperty(ref _inactiveHiglightBarStateName, value);
		}

		[Ordinal(62)] 
		[RED("gridCellDisabledSymbol")] 
		public CString GridCellDisabledSymbol
		{
			get => GetProperty(ref _gridCellDisabledSymbol);
			set => SetProperty(ref _gridCellDisabledSymbol, value);
		}

		public gameuiHackingMinigameLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
