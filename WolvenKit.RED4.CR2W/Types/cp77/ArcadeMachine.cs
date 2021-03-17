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

		[Ordinal(93)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(94)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}

		[Ordinal(95)] 
		[RED("currentGame")] 
		public redResourceReferenceScriptToken CurrentGame
		{
			get => GetProperty(ref _currentGame);
			set => SetProperty(ref _currentGame, value);
		}

		[Ordinal(96)] 
		[RED("currentGameAudio")] 
		public CName CurrentGameAudio
		{
			get => GetProperty(ref _currentGameAudio);
			set => SetProperty(ref _currentGameAudio, value);
		}

		[Ordinal(97)] 
		[RED("currentGameAudioStop")] 
		public CName CurrentGameAudioStop
		{
			get => GetProperty(ref _currentGameAudioStop);
			set => SetProperty(ref _currentGameAudioStop, value);
		}

		public ArcadeMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
