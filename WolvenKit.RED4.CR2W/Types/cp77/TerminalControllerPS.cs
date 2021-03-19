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
			get => GetProperty(ref _terminalSetup);
			set => SetProperty(ref _terminalSetup, value);
		}

		[Ordinal(105)] 
		[RED("terminalSkillChecks")] 
		public CHandle<HackEngContainer> TerminalSkillChecks
		{
			get => GetProperty(ref _terminalSkillChecks);
			set => SetProperty(ref _terminalSkillChecks, value);
		}

		[Ordinal(106)] 
		[RED("spawnedSystems")] 
		public CArray<CHandle<VirtualSystemPS>> SpawnedSystems
		{
			get => GetProperty(ref _spawnedSystems);
			set => SetProperty(ref _spawnedSystems, value);
		}

		[Ordinal(107)] 
		[RED("useKeyloggerHack")] 
		public CBool UseKeyloggerHack
		{
			get => GetProperty(ref _useKeyloggerHack);
			set => SetProperty(ref _useKeyloggerHack, value);
		}

		[Ordinal(108)] 
		[RED("shouldShowTerminalTitle")] 
		public CBool ShouldShowTerminalTitle
		{
			get => GetProperty(ref _shouldShowTerminalTitle);
			set => SetProperty(ref _shouldShowTerminalTitle, value);
		}

		[Ordinal(109)] 
		[RED("defaultGlitchVideoPath")] 
		public redResourceReferenceScriptToken DefaultGlitchVideoPath
		{
			get => GetProperty(ref _defaultGlitchVideoPath);
			set => SetProperty(ref _defaultGlitchVideoPath, value);
		}

		[Ordinal(110)] 
		[RED("broadcastGlitchVideoPath")] 
		public redResourceReferenceScriptToken BroadcastGlitchVideoPath
		{
			get => GetProperty(ref _broadcastGlitchVideoPath);
			set => SetProperty(ref _broadcastGlitchVideoPath, value);
		}

		[Ordinal(111)] 
		[RED("state")] 
		public CEnum<gameinteractionsReactionState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(112)] 
		[RED("forcedElevatorArrowsState")] 
		public CEnum<EForcedElevatorArrowsState> ForcedElevatorArrowsState
		{
			get => GetProperty(ref _forcedElevatorArrowsState);
			set => SetProperty(ref _forcedElevatorArrowsState, value);
		}

		public TerminalControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
