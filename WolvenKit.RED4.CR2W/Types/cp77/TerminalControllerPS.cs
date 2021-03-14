using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TerminalControllerPS : MasterControllerPS
	{
		private TerminalSetup _terminalSetup;
		private CHandle<HackEngContainer> _terminalSkillChecks;
		private CArray<CHandle<VirtualSystemPS>> _spawnedSystems;
		private CBool _useKeyloggerHack;
		private CBool _shouldShowTerminalTitle;
		private redResourceReferenceScriptToken _defaultGlitchVideoPath;
		private redResourceReferenceScriptToken _broadcastGlitchVideoPath;
		private CEnum<gameinteractionsReactionState> _state;
		private CEnum<EForcedElevatorArrowsState> _forcedElevatorArrowsState;

		[Ordinal(104)] 
		[RED("terminalSetup")] 
		public TerminalSetup TerminalSetup
		{
			get
			{
				if (_terminalSetup == null)
				{
					_terminalSetup = (TerminalSetup) CR2WTypeManager.Create("TerminalSetup", "terminalSetup", cr2w, this);
				}
				return _terminalSetup;
			}
			set
			{
				if (_terminalSetup == value)
				{
					return;
				}
				_terminalSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("terminalSkillChecks")] 
		public CHandle<HackEngContainer> TerminalSkillChecks
		{
			get
			{
				if (_terminalSkillChecks == null)
				{
					_terminalSkillChecks = (CHandle<HackEngContainer>) CR2WTypeManager.Create("handle:HackEngContainer", "terminalSkillChecks", cr2w, this);
				}
				return _terminalSkillChecks;
			}
			set
			{
				if (_terminalSkillChecks == value)
				{
					return;
				}
				_terminalSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("spawnedSystems")] 
		public CArray<CHandle<VirtualSystemPS>> SpawnedSystems
		{
			get
			{
				if (_spawnedSystems == null)
				{
					_spawnedSystems = (CArray<CHandle<VirtualSystemPS>>) CR2WTypeManager.Create("array:handle:VirtualSystemPS", "spawnedSystems", cr2w, this);
				}
				return _spawnedSystems;
			}
			set
			{
				if (_spawnedSystems == value)
				{
					return;
				}
				_spawnedSystems = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("useKeyloggerHack")] 
		public CBool UseKeyloggerHack
		{
			get
			{
				if (_useKeyloggerHack == null)
				{
					_useKeyloggerHack = (CBool) CR2WTypeManager.Create("Bool", "useKeyloggerHack", cr2w, this);
				}
				return _useKeyloggerHack;
			}
			set
			{
				if (_useKeyloggerHack == value)
				{
					return;
				}
				_useKeyloggerHack = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("shouldShowTerminalTitle")] 
		public CBool ShouldShowTerminalTitle
		{
			get
			{
				if (_shouldShowTerminalTitle == null)
				{
					_shouldShowTerminalTitle = (CBool) CR2WTypeManager.Create("Bool", "shouldShowTerminalTitle", cr2w, this);
				}
				return _shouldShowTerminalTitle;
			}
			set
			{
				if (_shouldShowTerminalTitle == value)
				{
					return;
				}
				_shouldShowTerminalTitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("defaultGlitchVideoPath")] 
		public redResourceReferenceScriptToken DefaultGlitchVideoPath
		{
			get
			{
				if (_defaultGlitchVideoPath == null)
				{
					_defaultGlitchVideoPath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "defaultGlitchVideoPath", cr2w, this);
				}
				return _defaultGlitchVideoPath;
			}
			set
			{
				if (_defaultGlitchVideoPath == value)
				{
					return;
				}
				_defaultGlitchVideoPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("broadcastGlitchVideoPath")] 
		public redResourceReferenceScriptToken BroadcastGlitchVideoPath
		{
			get
			{
				if (_broadcastGlitchVideoPath == null)
				{
					_broadcastGlitchVideoPath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "broadcastGlitchVideoPath", cr2w, this);
				}
				return _broadcastGlitchVideoPath;
			}
			set
			{
				if (_broadcastGlitchVideoPath == value)
				{
					return;
				}
				_broadcastGlitchVideoPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(111)] 
		[RED("state")] 
		public CEnum<gameinteractionsReactionState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gameinteractionsReactionState>) CR2WTypeManager.Create("gameinteractionsReactionState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("forcedElevatorArrowsState")] 
		public CEnum<EForcedElevatorArrowsState> ForcedElevatorArrowsState
		{
			get
			{
				if (_forcedElevatorArrowsState == null)
				{
					_forcedElevatorArrowsState = (CEnum<EForcedElevatorArrowsState>) CR2WTypeManager.Create("EForcedElevatorArrowsState", "forcedElevatorArrowsState", cr2w, this);
				}
				return _forcedElevatorArrowsState;
			}
			set
			{
				if (_forcedElevatorArrowsState == value)
				{
					return;
				}
				_forcedElevatorArrowsState = value;
				PropertySet(this);
			}
		}

		public TerminalControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
