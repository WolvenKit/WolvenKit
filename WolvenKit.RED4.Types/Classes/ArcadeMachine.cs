using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ArcadeMachine : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(98)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(99)] 
		[RED("currentGame")] 
		public redResourceReferenceScriptToken CurrentGame
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(100)] 
		[RED("currentGameAudio")] 
		public CName CurrentGameAudio
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(101)] 
		[RED("currentGameAudioStop")] 
		public CName CurrentGameAudioStop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(102)] 
		[RED("meshAppearanceOn")] 
		public CName MeshAppearanceOn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(103)] 
		[RED("meshAppearanceOff")] 
		public CName MeshAppearanceOff
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ArcadeMachine()
		{
			ControllerTypeName = "ArcadeMachineController";
			ShortGlitchDelayID = new();
			CurrentGame = new();
		}
	}
}
