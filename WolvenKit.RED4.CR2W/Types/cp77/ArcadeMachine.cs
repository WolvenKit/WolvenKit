using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ArcadeMachine : InteractiveDevice
	{
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;
		private redResourceReferenceScriptToken _currentGame;
		private CName _currentGameAudio;
		private CName _currentGameAudioStop;
		private CName _meshAppearanceOn;
		private CName _meshAppearanceOff;

		[Ordinal(97)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(98)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}

		[Ordinal(99)] 
		[RED("currentGame")] 
		public redResourceReferenceScriptToken CurrentGame
		{
			get => GetProperty(ref _currentGame);
			set => SetProperty(ref _currentGame, value);
		}

		[Ordinal(100)] 
		[RED("currentGameAudio")] 
		public CName CurrentGameAudio
		{
			get => GetProperty(ref _currentGameAudio);
			set => SetProperty(ref _currentGameAudio, value);
		}

		[Ordinal(101)] 
		[RED("currentGameAudioStop")] 
		public CName CurrentGameAudioStop
		{
			get => GetProperty(ref _currentGameAudioStop);
			set => SetProperty(ref _currentGameAudioStop, value);
		}

		[Ordinal(102)] 
		[RED("meshAppearanceOn")] 
		public CName MeshAppearanceOn
		{
			get => GetProperty(ref _meshAppearanceOn);
			set => SetProperty(ref _meshAppearanceOn, value);
		}

		[Ordinal(103)] 
		[RED("meshAppearanceOff")] 
		public CName MeshAppearanceOff
		{
			get => GetProperty(ref _meshAppearanceOff);
			set => SetProperty(ref _meshAppearanceOff, value);
		}

		public ArcadeMachine(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
