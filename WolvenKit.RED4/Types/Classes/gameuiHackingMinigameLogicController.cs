using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiHackingMinigameLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("grid")] 
		public inkUniformGridWidgetReference Grid
		{
			get => GetPropertyValue<inkUniformGridWidgetReference>();
			set => SetPropertyValue<inkUniformGridWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("buffer")] 
		public inkCompoundWidgetReference Buffer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("programs")] 
		public inkCompoundWidgetReference Programs
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("timer")] 
		public inkTextWidgetReference Timer
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("timerProgressBar")] 
		public inkWidgetReference TimerProgressBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("accessInformationText")] 
		public inkTextWidgetReference AccessInformationText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("activatedTraps")] 
		public inkCompoundWidgetReference ActivatedTraps
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("gridVerticalHiglight")] 
		public inkWidgetReference GridVerticalHiglight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("gridHorizontalHiglight")] 
		public inkWidgetReference GridHorizontalHiglight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("programsColumnHiglight")] 
		public inkWidgetReference ProgramsColumnHiglight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("successScreenWidget")] 
		public inkCompoundWidgetReference SuccessScreenWidget
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("failScreenWidget")] 
		public inkCompoundWidgetReference FailScreenWidget
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("successExitTerminalText")] 
		public inkTextWidgetReference SuccessExitTerminalText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("failedExitTerminalText")] 
		public inkTextWidgetReference FailedExitTerminalText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("successExitButton")] 
		public inkWidgetReference SuccessExitButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("failureExitButton")] 
		public inkWidgetReference FailureExitButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("resetButton")] 
		public inkWidgetReference ResetButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("introAnimName")] 
		public CName IntroAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("loopAnimName")] 
		public CName LoopAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("cursorAnimName")] 
		public CName CursorAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("higlightAnimName")] 
		public CName HiglightAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("gameWonAnimName")] 
		public CName GameWonAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("gameLostAnimName")] 
		public CName GameLostAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("terminalShutdownAnimName")] 
		public CName TerminalShutdownAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("trapActivatedAnimName")] 
		public CName TrapActivatedAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(26)] 
		[RED("programSucceedAnimName")] 
		public CName ProgramSucceedAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(27)] 
		[RED("programFailedAnimName")] 
		public CName ProgramFailedAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(28)] 
		[RED("programResetFromFailedAnimName")] 
		public CName ProgramResetFromFailedAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(29)] 
		[RED("gridCellHoverAnimName")] 
		public CName GridCellHoverAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("gridCellClickFlashAnimName")] 
		public CName GridCellClickFlashAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(31)] 
		[RED("bufferCellHoverAnimName")] 
		public CName BufferCellHoverAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(32)] 
		[RED("bufferCellClickFlashAnimName")] 
		public CName BufferCellClickFlashAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(33)] 
		[RED("programCellClickFlashAnimName")] 
		public CName ProgramCellClickFlashAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(34)] 
		[RED("activatedTrapIconLibraryName")] 
		public CName ActivatedTrapIconLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(35)] 
		[RED("bufferCellLibraryName")] 
		public CName BufferCellLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(36)] 
		[RED("programCellLibraryName")] 
		public CName ProgramCellLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(37)] 
		[RED("gridCellLibraryName")] 
		public CName GridCellLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(38)] 
		[RED("programEntryLibraryName")] 
		public CName ProgramEntryLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(39)] 
		[RED("trapIconsContainerRelativePath")] 
		public CName TrapIconsContainerRelativePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(40)] 
		[RED("bufferCellTextWidgetRelativePath")] 
		public CName BufferCellTextWidgetRelativePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(41)] 
		[RED("programCellTextWidgetRelativePath")] 
		public CName ProgramCellTextWidgetRelativePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(42)] 
		[RED("gridCellTrapIconWidgetRelativePath")] 
		public CName GridCellTrapIconWidgetRelativePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(43)] 
		[RED("gridCellTrapIconContainerRelativePath")] 
		public CName GridCellTrapIconContainerRelativePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(44)] 
		[RED("gridCellTextWidgetRelativePath")] 
		public CName GridCellTextWidgetRelativePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(45)] 
		[RED("gridCellProgramHighlightRelativePath")] 
		public CName GridCellProgramHighlightRelativePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(46)] 
		[RED("programEntryTextWidgetRelativePath")] 
		public CName ProgramEntryTextWidgetRelativePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(47)] 
		[RED("programEntryNoteWidgetRelativePath")] 
		public CName ProgramEntryNoteWidgetRelativePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(48)] 
		[RED("programEntryInstructionContainerRelativePath")] 
		public CName ProgramEntryInstructionContainerRelativePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(49)] 
		[RED("programEntryIconPath")] 
		public CName ProgramEntryIconPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(50)] 
		[RED("cursorWidgetRelativePath")] 
		public CName CursorWidgetRelativePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(51)] 
		[RED("gridCellDefaultStateName")] 
		public CName GridCellDefaultStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(52)] 
		[RED("gridCellHoveredStateName")] 
		public CName GridCellHoveredStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(53)] 
		[RED("gridCellSelectedStateName")] 
		public CName GridCellSelectedStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(54)] 
		[RED("gridCellDisabledStateName")] 
		public CName GridCellDisabledStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(55)] 
		[RED("programSucceedStateName")] 
		public CName ProgramSucceedStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(56)] 
		[RED("programFailedStateName")] 
		public CName ProgramFailedStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(57)] 
		[RED("programCellReadyStateName")] 
		public CName ProgramCellReadyStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(58)] 
		[RED("programCellHighlightStateName")] 
		public CName ProgramCellHighlightStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(59)] 
		[RED("mainHiglightBarStateName")] 
		public CName MainHiglightBarStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(60)] 
		[RED("secondaryHiglightBarStateName")] 
		public CName SecondaryHiglightBarStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(61)] 
		[RED("inactiveHiglightBarStateName")] 
		public CName InactiveHiglightBarStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(62)] 
		[RED("gridCellDisabledSymbol")] 
		public CString GridCellDisabledSymbol
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gameuiHackingMinigameLogicController()
		{
			Grid = new();
			Buffer = new();
			Programs = new();
			Timer = new();
			TimerProgressBar = new();
			AccessInformationText = new();
			ActivatedTraps = new();
			GridVerticalHiglight = new();
			GridHorizontalHiglight = new();
			ProgramsColumnHiglight = new();
			SuccessScreenWidget = new();
			FailScreenWidget = new();
			SuccessExitTerminalText = new();
			FailedExitTerminalText = new();
			SuccessExitButton = new();
			FailureExitButton = new();
			ResetButton = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
