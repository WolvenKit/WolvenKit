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
			get
			{
				if (_grid == null)
				{
					_grid = (inkUniformGridWidgetReference) CR2WTypeManager.Create("inkUniformGridWidgetReference", "grid", cr2w, this);
				}
				return _grid;
			}
			set
			{
				if (_grid == value)
				{
					return;
				}
				_grid = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("buffer")] 
		public inkCompoundWidgetReference Buffer
		{
			get
			{
				if (_buffer == null)
				{
					_buffer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "buffer", cr2w, this);
				}
				return _buffer;
			}
			set
			{
				if (_buffer == value)
				{
					return;
				}
				_buffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("programs")] 
		public inkCompoundWidgetReference Programs
		{
			get
			{
				if (_programs == null)
				{
					_programs = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "programs", cr2w, this);
				}
				return _programs;
			}
			set
			{
				if (_programs == value)
				{
					return;
				}
				_programs = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("timer")] 
		public inkTextWidgetReference Timer
		{
			get
			{
				if (_timer == null)
				{
					_timer = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "timer", cr2w, this);
				}
				return _timer;
			}
			set
			{
				if (_timer == value)
				{
					return;
				}
				_timer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("timerProgressBar")] 
		public inkWidgetReference TimerProgressBar
		{
			get
			{
				if (_timerProgressBar == null)
				{
					_timerProgressBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "timerProgressBar", cr2w, this);
				}
				return _timerProgressBar;
			}
			set
			{
				if (_timerProgressBar == value)
				{
					return;
				}
				_timerProgressBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("accessInformationText")] 
		public inkTextWidgetReference AccessInformationText
		{
			get
			{
				if (_accessInformationText == null)
				{
					_accessInformationText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "accessInformationText", cr2w, this);
				}
				return _accessInformationText;
			}
			set
			{
				if (_accessInformationText == value)
				{
					return;
				}
				_accessInformationText = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("activatedTraps")] 
		public inkCompoundWidgetReference ActivatedTraps
		{
			get
			{
				if (_activatedTraps == null)
				{
					_activatedTraps = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "activatedTraps", cr2w, this);
				}
				return _activatedTraps;
			}
			set
			{
				if (_activatedTraps == value)
				{
					return;
				}
				_activatedTraps = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("gridVerticalHiglight")] 
		public inkWidgetReference GridVerticalHiglight
		{
			get
			{
				if (_gridVerticalHiglight == null)
				{
					_gridVerticalHiglight = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "gridVerticalHiglight", cr2w, this);
				}
				return _gridVerticalHiglight;
			}
			set
			{
				if (_gridVerticalHiglight == value)
				{
					return;
				}
				_gridVerticalHiglight = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("gridHorizontalHiglight")] 
		public inkWidgetReference GridHorizontalHiglight
		{
			get
			{
				if (_gridHorizontalHiglight == null)
				{
					_gridHorizontalHiglight = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "gridHorizontalHiglight", cr2w, this);
				}
				return _gridHorizontalHiglight;
			}
			set
			{
				if (_gridHorizontalHiglight == value)
				{
					return;
				}
				_gridHorizontalHiglight = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("programsColumnHiglight")] 
		public inkWidgetReference ProgramsColumnHiglight
		{
			get
			{
				if (_programsColumnHiglight == null)
				{
					_programsColumnHiglight = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "programsColumnHiglight", cr2w, this);
				}
				return _programsColumnHiglight;
			}
			set
			{
				if (_programsColumnHiglight == value)
				{
					return;
				}
				_programsColumnHiglight = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("successScreenWidget")] 
		public inkCompoundWidgetReference SuccessScreenWidget
		{
			get
			{
				if (_successScreenWidget == null)
				{
					_successScreenWidget = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "successScreenWidget", cr2w, this);
				}
				return _successScreenWidget;
			}
			set
			{
				if (_successScreenWidget == value)
				{
					return;
				}
				_successScreenWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("failScreenWidget")] 
		public inkCompoundWidgetReference FailScreenWidget
		{
			get
			{
				if (_failScreenWidget == null)
				{
					_failScreenWidget = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "failScreenWidget", cr2w, this);
				}
				return _failScreenWidget;
			}
			set
			{
				if (_failScreenWidget == value)
				{
					return;
				}
				_failScreenWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("successExitTerminalText")] 
		public inkTextWidgetReference SuccessExitTerminalText
		{
			get
			{
				if (_successExitTerminalText == null)
				{
					_successExitTerminalText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "successExitTerminalText", cr2w, this);
				}
				return _successExitTerminalText;
			}
			set
			{
				if (_successExitTerminalText == value)
				{
					return;
				}
				_successExitTerminalText = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("failedExitTerminalText")] 
		public inkTextWidgetReference FailedExitTerminalText
		{
			get
			{
				if (_failedExitTerminalText == null)
				{
					_failedExitTerminalText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "failedExitTerminalText", cr2w, this);
				}
				return _failedExitTerminalText;
			}
			set
			{
				if (_failedExitTerminalText == value)
				{
					return;
				}
				_failedExitTerminalText = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("successExitButton")] 
		public inkWidgetReference SuccessExitButton
		{
			get
			{
				if (_successExitButton == null)
				{
					_successExitButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "successExitButton", cr2w, this);
				}
				return _successExitButton;
			}
			set
			{
				if (_successExitButton == value)
				{
					return;
				}
				_successExitButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("failureExitButton")] 
		public inkWidgetReference FailureExitButton
		{
			get
			{
				if (_failureExitButton == null)
				{
					_failureExitButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "failureExitButton", cr2w, this);
				}
				return _failureExitButton;
			}
			set
			{
				if (_failureExitButton == value)
				{
					return;
				}
				_failureExitButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("resetButton")] 
		public inkWidgetReference ResetButton
		{
			get
			{
				if (_resetButton == null)
				{
					_resetButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "resetButton", cr2w, this);
				}
				return _resetButton;
			}
			set
			{
				if (_resetButton == value)
				{
					return;
				}
				_resetButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("introAnimName")] 
		public CName IntroAnimName
		{
			get
			{
				if (_introAnimName == null)
				{
					_introAnimName = (CName) CR2WTypeManager.Create("CName", "introAnimName", cr2w, this);
				}
				return _introAnimName;
			}
			set
			{
				if (_introAnimName == value)
				{
					return;
				}
				_introAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("loopAnimName")] 
		public CName LoopAnimName
		{
			get
			{
				if (_loopAnimName == null)
				{
					_loopAnimName = (CName) CR2WTypeManager.Create("CName", "loopAnimName", cr2w, this);
				}
				return _loopAnimName;
			}
			set
			{
				if (_loopAnimName == value)
				{
					return;
				}
				_loopAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("cursorAnimName")] 
		public CName CursorAnimName
		{
			get
			{
				if (_cursorAnimName == null)
				{
					_cursorAnimName = (CName) CR2WTypeManager.Create("CName", "cursorAnimName", cr2w, this);
				}
				return _cursorAnimName;
			}
			set
			{
				if (_cursorAnimName == value)
				{
					return;
				}
				_cursorAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("higlightAnimName")] 
		public CName HiglightAnimName
		{
			get
			{
				if (_higlightAnimName == null)
				{
					_higlightAnimName = (CName) CR2WTypeManager.Create("CName", "higlightAnimName", cr2w, this);
				}
				return _higlightAnimName;
			}
			set
			{
				if (_higlightAnimName == value)
				{
					return;
				}
				_higlightAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("gameWonAnimName")] 
		public CName GameWonAnimName
		{
			get
			{
				if (_gameWonAnimName == null)
				{
					_gameWonAnimName = (CName) CR2WTypeManager.Create("CName", "gameWonAnimName", cr2w, this);
				}
				return _gameWonAnimName;
			}
			set
			{
				if (_gameWonAnimName == value)
				{
					return;
				}
				_gameWonAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("gameLostAnimName")] 
		public CName GameLostAnimName
		{
			get
			{
				if (_gameLostAnimName == null)
				{
					_gameLostAnimName = (CName) CR2WTypeManager.Create("CName", "gameLostAnimName", cr2w, this);
				}
				return _gameLostAnimName;
			}
			set
			{
				if (_gameLostAnimName == value)
				{
					return;
				}
				_gameLostAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("terminalShutdownAnimName")] 
		public CName TerminalShutdownAnimName
		{
			get
			{
				if (_terminalShutdownAnimName == null)
				{
					_terminalShutdownAnimName = (CName) CR2WTypeManager.Create("CName", "terminalShutdownAnimName", cr2w, this);
				}
				return _terminalShutdownAnimName;
			}
			set
			{
				if (_terminalShutdownAnimName == value)
				{
					return;
				}
				_terminalShutdownAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("trapActivatedAnimName")] 
		public CName TrapActivatedAnimName
		{
			get
			{
				if (_trapActivatedAnimName == null)
				{
					_trapActivatedAnimName = (CName) CR2WTypeManager.Create("CName", "trapActivatedAnimName", cr2w, this);
				}
				return _trapActivatedAnimName;
			}
			set
			{
				if (_trapActivatedAnimName == value)
				{
					return;
				}
				_trapActivatedAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("programSucceedAnimName")] 
		public CName ProgramSucceedAnimName
		{
			get
			{
				if (_programSucceedAnimName == null)
				{
					_programSucceedAnimName = (CName) CR2WTypeManager.Create("CName", "programSucceedAnimName", cr2w, this);
				}
				return _programSucceedAnimName;
			}
			set
			{
				if (_programSucceedAnimName == value)
				{
					return;
				}
				_programSucceedAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("programFailedAnimName")] 
		public CName ProgramFailedAnimName
		{
			get
			{
				if (_programFailedAnimName == null)
				{
					_programFailedAnimName = (CName) CR2WTypeManager.Create("CName", "programFailedAnimName", cr2w, this);
				}
				return _programFailedAnimName;
			}
			set
			{
				if (_programFailedAnimName == value)
				{
					return;
				}
				_programFailedAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("programResetFromFailedAnimName")] 
		public CName ProgramResetFromFailedAnimName
		{
			get
			{
				if (_programResetFromFailedAnimName == null)
				{
					_programResetFromFailedAnimName = (CName) CR2WTypeManager.Create("CName", "programResetFromFailedAnimName", cr2w, this);
				}
				return _programResetFromFailedAnimName;
			}
			set
			{
				if (_programResetFromFailedAnimName == value)
				{
					return;
				}
				_programResetFromFailedAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("gridCellHoverAnimName")] 
		public CName GridCellHoverAnimName
		{
			get
			{
				if (_gridCellHoverAnimName == null)
				{
					_gridCellHoverAnimName = (CName) CR2WTypeManager.Create("CName", "gridCellHoverAnimName", cr2w, this);
				}
				return _gridCellHoverAnimName;
			}
			set
			{
				if (_gridCellHoverAnimName == value)
				{
					return;
				}
				_gridCellHoverAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("gridCellClickFlashAnimName")] 
		public CName GridCellClickFlashAnimName
		{
			get
			{
				if (_gridCellClickFlashAnimName == null)
				{
					_gridCellClickFlashAnimName = (CName) CR2WTypeManager.Create("CName", "gridCellClickFlashAnimName", cr2w, this);
				}
				return _gridCellClickFlashAnimName;
			}
			set
			{
				if (_gridCellClickFlashAnimName == value)
				{
					return;
				}
				_gridCellClickFlashAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("bufferCellHoverAnimName")] 
		public CName BufferCellHoverAnimName
		{
			get
			{
				if (_bufferCellHoverAnimName == null)
				{
					_bufferCellHoverAnimName = (CName) CR2WTypeManager.Create("CName", "bufferCellHoverAnimName", cr2w, this);
				}
				return _bufferCellHoverAnimName;
			}
			set
			{
				if (_bufferCellHoverAnimName == value)
				{
					return;
				}
				_bufferCellHoverAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("bufferCellClickFlashAnimName")] 
		public CName BufferCellClickFlashAnimName
		{
			get
			{
				if (_bufferCellClickFlashAnimName == null)
				{
					_bufferCellClickFlashAnimName = (CName) CR2WTypeManager.Create("CName", "bufferCellClickFlashAnimName", cr2w, this);
				}
				return _bufferCellClickFlashAnimName;
			}
			set
			{
				if (_bufferCellClickFlashAnimName == value)
				{
					return;
				}
				_bufferCellClickFlashAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("programCellClickFlashAnimName")] 
		public CName ProgramCellClickFlashAnimName
		{
			get
			{
				if (_programCellClickFlashAnimName == null)
				{
					_programCellClickFlashAnimName = (CName) CR2WTypeManager.Create("CName", "programCellClickFlashAnimName", cr2w, this);
				}
				return _programCellClickFlashAnimName;
			}
			set
			{
				if (_programCellClickFlashAnimName == value)
				{
					return;
				}
				_programCellClickFlashAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("activatedTrapIconLibraryName")] 
		public CName ActivatedTrapIconLibraryName
		{
			get
			{
				if (_activatedTrapIconLibraryName == null)
				{
					_activatedTrapIconLibraryName = (CName) CR2WTypeManager.Create("CName", "activatedTrapIconLibraryName", cr2w, this);
				}
				return _activatedTrapIconLibraryName;
			}
			set
			{
				if (_activatedTrapIconLibraryName == value)
				{
					return;
				}
				_activatedTrapIconLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("bufferCellLibraryName")] 
		public CName BufferCellLibraryName
		{
			get
			{
				if (_bufferCellLibraryName == null)
				{
					_bufferCellLibraryName = (CName) CR2WTypeManager.Create("CName", "bufferCellLibraryName", cr2w, this);
				}
				return _bufferCellLibraryName;
			}
			set
			{
				if (_bufferCellLibraryName == value)
				{
					return;
				}
				_bufferCellLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("programCellLibraryName")] 
		public CName ProgramCellLibraryName
		{
			get
			{
				if (_programCellLibraryName == null)
				{
					_programCellLibraryName = (CName) CR2WTypeManager.Create("CName", "programCellLibraryName", cr2w, this);
				}
				return _programCellLibraryName;
			}
			set
			{
				if (_programCellLibraryName == value)
				{
					return;
				}
				_programCellLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("gridCellLibraryName")] 
		public CName GridCellLibraryName
		{
			get
			{
				if (_gridCellLibraryName == null)
				{
					_gridCellLibraryName = (CName) CR2WTypeManager.Create("CName", "gridCellLibraryName", cr2w, this);
				}
				return _gridCellLibraryName;
			}
			set
			{
				if (_gridCellLibraryName == value)
				{
					return;
				}
				_gridCellLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("programEntryLibraryName")] 
		public CName ProgramEntryLibraryName
		{
			get
			{
				if (_programEntryLibraryName == null)
				{
					_programEntryLibraryName = (CName) CR2WTypeManager.Create("CName", "programEntryLibraryName", cr2w, this);
				}
				return _programEntryLibraryName;
			}
			set
			{
				if (_programEntryLibraryName == value)
				{
					return;
				}
				_programEntryLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("trapIconsContainerRelativePath")] 
		public CName TrapIconsContainerRelativePath
		{
			get
			{
				if (_trapIconsContainerRelativePath == null)
				{
					_trapIconsContainerRelativePath = (CName) CR2WTypeManager.Create("CName", "trapIconsContainerRelativePath", cr2w, this);
				}
				return _trapIconsContainerRelativePath;
			}
			set
			{
				if (_trapIconsContainerRelativePath == value)
				{
					return;
				}
				_trapIconsContainerRelativePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("bufferCellTextWidgetRelativePath")] 
		public CName BufferCellTextWidgetRelativePath
		{
			get
			{
				if (_bufferCellTextWidgetRelativePath == null)
				{
					_bufferCellTextWidgetRelativePath = (CName) CR2WTypeManager.Create("CName", "bufferCellTextWidgetRelativePath", cr2w, this);
				}
				return _bufferCellTextWidgetRelativePath;
			}
			set
			{
				if (_bufferCellTextWidgetRelativePath == value)
				{
					return;
				}
				_bufferCellTextWidgetRelativePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("programCellTextWidgetRelativePath")] 
		public CName ProgramCellTextWidgetRelativePath
		{
			get
			{
				if (_programCellTextWidgetRelativePath == null)
				{
					_programCellTextWidgetRelativePath = (CName) CR2WTypeManager.Create("CName", "programCellTextWidgetRelativePath", cr2w, this);
				}
				return _programCellTextWidgetRelativePath;
			}
			set
			{
				if (_programCellTextWidgetRelativePath == value)
				{
					return;
				}
				_programCellTextWidgetRelativePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("gridCellTrapIconWidgetRelativePath")] 
		public CName GridCellTrapIconWidgetRelativePath
		{
			get
			{
				if (_gridCellTrapIconWidgetRelativePath == null)
				{
					_gridCellTrapIconWidgetRelativePath = (CName) CR2WTypeManager.Create("CName", "gridCellTrapIconWidgetRelativePath", cr2w, this);
				}
				return _gridCellTrapIconWidgetRelativePath;
			}
			set
			{
				if (_gridCellTrapIconWidgetRelativePath == value)
				{
					return;
				}
				_gridCellTrapIconWidgetRelativePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("gridCellTrapIconContainerRelativePath")] 
		public CName GridCellTrapIconContainerRelativePath
		{
			get
			{
				if (_gridCellTrapIconContainerRelativePath == null)
				{
					_gridCellTrapIconContainerRelativePath = (CName) CR2WTypeManager.Create("CName", "gridCellTrapIconContainerRelativePath", cr2w, this);
				}
				return _gridCellTrapIconContainerRelativePath;
			}
			set
			{
				if (_gridCellTrapIconContainerRelativePath == value)
				{
					return;
				}
				_gridCellTrapIconContainerRelativePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("gridCellTextWidgetRelativePath")] 
		public CName GridCellTextWidgetRelativePath
		{
			get
			{
				if (_gridCellTextWidgetRelativePath == null)
				{
					_gridCellTextWidgetRelativePath = (CName) CR2WTypeManager.Create("CName", "gridCellTextWidgetRelativePath", cr2w, this);
				}
				return _gridCellTextWidgetRelativePath;
			}
			set
			{
				if (_gridCellTextWidgetRelativePath == value)
				{
					return;
				}
				_gridCellTextWidgetRelativePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("gridCellProgramHighlightRelativePath")] 
		public CName GridCellProgramHighlightRelativePath
		{
			get
			{
				if (_gridCellProgramHighlightRelativePath == null)
				{
					_gridCellProgramHighlightRelativePath = (CName) CR2WTypeManager.Create("CName", "gridCellProgramHighlightRelativePath", cr2w, this);
				}
				return _gridCellProgramHighlightRelativePath;
			}
			set
			{
				if (_gridCellProgramHighlightRelativePath == value)
				{
					return;
				}
				_gridCellProgramHighlightRelativePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("programEntryTextWidgetRelativePath")] 
		public CName ProgramEntryTextWidgetRelativePath
		{
			get
			{
				if (_programEntryTextWidgetRelativePath == null)
				{
					_programEntryTextWidgetRelativePath = (CName) CR2WTypeManager.Create("CName", "programEntryTextWidgetRelativePath", cr2w, this);
				}
				return _programEntryTextWidgetRelativePath;
			}
			set
			{
				if (_programEntryTextWidgetRelativePath == value)
				{
					return;
				}
				_programEntryTextWidgetRelativePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("programEntryNoteWidgetRelativePath")] 
		public CName ProgramEntryNoteWidgetRelativePath
		{
			get
			{
				if (_programEntryNoteWidgetRelativePath == null)
				{
					_programEntryNoteWidgetRelativePath = (CName) CR2WTypeManager.Create("CName", "programEntryNoteWidgetRelativePath", cr2w, this);
				}
				return _programEntryNoteWidgetRelativePath;
			}
			set
			{
				if (_programEntryNoteWidgetRelativePath == value)
				{
					return;
				}
				_programEntryNoteWidgetRelativePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("programEntryInstructionContainerRelativePath")] 
		public CName ProgramEntryInstructionContainerRelativePath
		{
			get
			{
				if (_programEntryInstructionContainerRelativePath == null)
				{
					_programEntryInstructionContainerRelativePath = (CName) CR2WTypeManager.Create("CName", "programEntryInstructionContainerRelativePath", cr2w, this);
				}
				return _programEntryInstructionContainerRelativePath;
			}
			set
			{
				if (_programEntryInstructionContainerRelativePath == value)
				{
					return;
				}
				_programEntryInstructionContainerRelativePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("programEntryIconPath")] 
		public CName ProgramEntryIconPath
		{
			get
			{
				if (_programEntryIconPath == null)
				{
					_programEntryIconPath = (CName) CR2WTypeManager.Create("CName", "programEntryIconPath", cr2w, this);
				}
				return _programEntryIconPath;
			}
			set
			{
				if (_programEntryIconPath == value)
				{
					return;
				}
				_programEntryIconPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("cursorWidgetRelativePath")] 
		public CName CursorWidgetRelativePath
		{
			get
			{
				if (_cursorWidgetRelativePath == null)
				{
					_cursorWidgetRelativePath = (CName) CR2WTypeManager.Create("CName", "cursorWidgetRelativePath", cr2w, this);
				}
				return _cursorWidgetRelativePath;
			}
			set
			{
				if (_cursorWidgetRelativePath == value)
				{
					return;
				}
				_cursorWidgetRelativePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("gridCellDefaultStateName")] 
		public CName GridCellDefaultStateName
		{
			get
			{
				if (_gridCellDefaultStateName == null)
				{
					_gridCellDefaultStateName = (CName) CR2WTypeManager.Create("CName", "gridCellDefaultStateName", cr2w, this);
				}
				return _gridCellDefaultStateName;
			}
			set
			{
				if (_gridCellDefaultStateName == value)
				{
					return;
				}
				_gridCellDefaultStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("gridCellHoveredStateName")] 
		public CName GridCellHoveredStateName
		{
			get
			{
				if (_gridCellHoveredStateName == null)
				{
					_gridCellHoveredStateName = (CName) CR2WTypeManager.Create("CName", "gridCellHoveredStateName", cr2w, this);
				}
				return _gridCellHoveredStateName;
			}
			set
			{
				if (_gridCellHoveredStateName == value)
				{
					return;
				}
				_gridCellHoveredStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("gridCellSelectedStateName")] 
		public CName GridCellSelectedStateName
		{
			get
			{
				if (_gridCellSelectedStateName == null)
				{
					_gridCellSelectedStateName = (CName) CR2WTypeManager.Create("CName", "gridCellSelectedStateName", cr2w, this);
				}
				return _gridCellSelectedStateName;
			}
			set
			{
				if (_gridCellSelectedStateName == value)
				{
					return;
				}
				_gridCellSelectedStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("gridCellDisabledStateName")] 
		public CName GridCellDisabledStateName
		{
			get
			{
				if (_gridCellDisabledStateName == null)
				{
					_gridCellDisabledStateName = (CName) CR2WTypeManager.Create("CName", "gridCellDisabledStateName", cr2w, this);
				}
				return _gridCellDisabledStateName;
			}
			set
			{
				if (_gridCellDisabledStateName == value)
				{
					return;
				}
				_gridCellDisabledStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("programSucceedStateName")] 
		public CName ProgramSucceedStateName
		{
			get
			{
				if (_programSucceedStateName == null)
				{
					_programSucceedStateName = (CName) CR2WTypeManager.Create("CName", "programSucceedStateName", cr2w, this);
				}
				return _programSucceedStateName;
			}
			set
			{
				if (_programSucceedStateName == value)
				{
					return;
				}
				_programSucceedStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("programFailedStateName")] 
		public CName ProgramFailedStateName
		{
			get
			{
				if (_programFailedStateName == null)
				{
					_programFailedStateName = (CName) CR2WTypeManager.Create("CName", "programFailedStateName", cr2w, this);
				}
				return _programFailedStateName;
			}
			set
			{
				if (_programFailedStateName == value)
				{
					return;
				}
				_programFailedStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("programCellReadyStateName")] 
		public CName ProgramCellReadyStateName
		{
			get
			{
				if (_programCellReadyStateName == null)
				{
					_programCellReadyStateName = (CName) CR2WTypeManager.Create("CName", "programCellReadyStateName", cr2w, this);
				}
				return _programCellReadyStateName;
			}
			set
			{
				if (_programCellReadyStateName == value)
				{
					return;
				}
				_programCellReadyStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("programCellHighlightStateName")] 
		public CName ProgramCellHighlightStateName
		{
			get
			{
				if (_programCellHighlightStateName == null)
				{
					_programCellHighlightStateName = (CName) CR2WTypeManager.Create("CName", "programCellHighlightStateName", cr2w, this);
				}
				return _programCellHighlightStateName;
			}
			set
			{
				if (_programCellHighlightStateName == value)
				{
					return;
				}
				_programCellHighlightStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("mainHiglightBarStateName")] 
		public CName MainHiglightBarStateName
		{
			get
			{
				if (_mainHiglightBarStateName == null)
				{
					_mainHiglightBarStateName = (CName) CR2WTypeManager.Create("CName", "mainHiglightBarStateName", cr2w, this);
				}
				return _mainHiglightBarStateName;
			}
			set
			{
				if (_mainHiglightBarStateName == value)
				{
					return;
				}
				_mainHiglightBarStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("secondaryHiglightBarStateName")] 
		public CName SecondaryHiglightBarStateName
		{
			get
			{
				if (_secondaryHiglightBarStateName == null)
				{
					_secondaryHiglightBarStateName = (CName) CR2WTypeManager.Create("CName", "secondaryHiglightBarStateName", cr2w, this);
				}
				return _secondaryHiglightBarStateName;
			}
			set
			{
				if (_secondaryHiglightBarStateName == value)
				{
					return;
				}
				_secondaryHiglightBarStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("inactiveHiglightBarStateName")] 
		public CName InactiveHiglightBarStateName
		{
			get
			{
				if (_inactiveHiglightBarStateName == null)
				{
					_inactiveHiglightBarStateName = (CName) CR2WTypeManager.Create("CName", "inactiveHiglightBarStateName", cr2w, this);
				}
				return _inactiveHiglightBarStateName;
			}
			set
			{
				if (_inactiveHiglightBarStateName == value)
				{
					return;
				}
				_inactiveHiglightBarStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("gridCellDisabledSymbol")] 
		public CString GridCellDisabledSymbol
		{
			get
			{
				if (_gridCellDisabledSymbol == null)
				{
					_gridCellDisabledSymbol = (CString) CR2WTypeManager.Create("String", "gridCellDisabledSymbol", cr2w, this);
				}
				return _gridCellDisabledSymbol;
			}
			set
			{
				if (_gridCellDisabledSymbol == value)
				{
					return;
				}
				_gridCellDisabledSymbol = value;
				PropertySet(this);
			}
		}

		public gameuiHackingMinigameLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
