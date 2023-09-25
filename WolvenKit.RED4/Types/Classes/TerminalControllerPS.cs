using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TerminalControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("terminalSetup")] 
		public TerminalSetup TerminalSetup
		{
			get => GetPropertyValue<TerminalSetup>();
			set => SetPropertyValue<TerminalSetup>(value);
		}

		[Ordinal(109)] 
		[RED("terminalSkillChecks")] 
		public CHandle<HackEngContainer> TerminalSkillChecks
		{
			get => GetPropertyValue<CHandle<HackEngContainer>>();
			set => SetPropertyValue<CHandle<HackEngContainer>>(value);
		}

		[Ordinal(110)] 
		[RED("spawnedSystems")] 
		public CArray<CHandle<VirtualSystemPS>> SpawnedSystems
		{
			get => GetPropertyValue<CArray<CHandle<VirtualSystemPS>>>();
			set => SetPropertyValue<CArray<CHandle<VirtualSystemPS>>>(value);
		}

		[Ordinal(111)] 
		[RED("useKeyloggerHack")] 
		public CBool UseKeyloggerHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(112)] 
		[RED("shouldShowTerminalTitle")] 
		public CBool ShouldShowTerminalTitle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(113)] 
		[RED("defaultGlitchVideoPath")] 
		public redResourceReferenceScriptToken DefaultGlitchVideoPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(114)] 
		[RED("broadcastGlitchVideoPath")] 
		public redResourceReferenceScriptToken BroadcastGlitchVideoPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(115)] 
		[RED("state")] 
		public CEnum<gameinteractionsReactionState> State
		{
			get => GetPropertyValue<CEnum<gameinteractionsReactionState>>();
			set => SetPropertyValue<CEnum<gameinteractionsReactionState>>(value);
		}

		[Ordinal(116)] 
		[RED("forcedElevatorArrowsState")] 
		public CEnum<EForcedElevatorArrowsState> ForcedElevatorArrowsState
		{
			get => GetPropertyValue<CEnum<EForcedElevatorArrowsState>>();
			set => SetPropertyValue<CEnum<EForcedElevatorArrowsState>>(value);
		}

		public TerminalControllerPS()
		{
			DeviceName = "LocKey#112";
			TweakDBRecord = "Devices.Terminal";
			TweakDBDescriptionRecord = 123011726280;
			TerminalSetup = new TerminalSetup { MinClearance = 1, MaxClearance = 10, ShouldForceVirtualSystem = true };
			SpawnedSystems = new();
			DefaultGlitchVideoPath = new redResourceReferenceScriptToken();
			BroadcastGlitchVideoPath = new redResourceReferenceScriptToken();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
