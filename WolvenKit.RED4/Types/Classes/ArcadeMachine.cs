using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ArcadeMachine : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("arcadeMachineType")] 
		public CEnum<ArcadeMachineType> ArcadeMachineType
		{
			get => GetPropertyValue<CEnum<ArcadeMachineType>>();
			set => SetPropertyValue<CEnum<ArcadeMachineType>>(value);
		}

		[Ordinal(99)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(100)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(101)] 
		[RED("currentGameVideo")] 
		public redResourceReferenceScriptToken CurrentGameVideo
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(102)] 
		[RED("currentGameAudio")] 
		public CName CurrentGameAudio
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(103)] 
		[RED("currentGameAudioStop")] 
		public CName CurrentGameAudioStop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(104)] 
		[RED("meshAppearanceOn")] 
		public CName MeshAppearanceOn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(105)] 
		[RED("meshAppearanceOff")] 
		public CName MeshAppearanceOff
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(106)] 
		[RED("arcadeMinigameComponent")] 
		public CHandle<workWorkspotResourceComponent> ArcadeMinigameComponent
		{
			get => GetPropertyValue<CHandle<workWorkspotResourceComponent>>();
			set => SetPropertyValue<CHandle<workWorkspotResourceComponent>>(value);
		}

		[Ordinal(107)] 
		[RED("minigame")] 
		public CEnum<ArcadeMinigame> Minigame
		{
			get => GetPropertyValue<CEnum<ArcadeMinigame>>();
			set => SetPropertyValue<CEnum<ArcadeMinigame>>(value);
		}

		[Ordinal(108)] 
		[RED("combatStateListener")] 
		public CHandle<redCallbackObject> CombatStateListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public ArcadeMachine()
		{
			ControllerTypeName = "ArcadeMachineController";
			ShortGlitchDelayID = new gameDelayID();
			CurrentGameVideo = new redResourceReferenceScriptToken();
			MeshAppearanceOn = "default";
			MeshAppearanceOff = "default";
			Minigame = Enums.ArcadeMinigame.INVALID;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
