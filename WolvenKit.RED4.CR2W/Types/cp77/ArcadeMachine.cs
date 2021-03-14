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
			get
			{
				if (_isShortGlitchActive == null)
				{
					_isShortGlitchActive = (CBool) CR2WTypeManager.Create("Bool", "isShortGlitchActive", cr2w, this);
				}
				return _isShortGlitchActive;
			}
			set
			{
				if (_isShortGlitchActive == value)
				{
					return;
				}
				_isShortGlitchActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get
			{
				if (_shortGlitchDelayID == null)
				{
					_shortGlitchDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "shortGlitchDelayID", cr2w, this);
				}
				return _shortGlitchDelayID;
			}
			set
			{
				if (_shortGlitchDelayID == value)
				{
					return;
				}
				_shortGlitchDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("currentGame")] 
		public redResourceReferenceScriptToken CurrentGame
		{
			get
			{
				if (_currentGame == null)
				{
					_currentGame = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "currentGame", cr2w, this);
				}
				return _currentGame;
			}
			set
			{
				if (_currentGame == value)
				{
					return;
				}
				_currentGame = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("currentGameAudio")] 
		public CName CurrentGameAudio
		{
			get
			{
				if (_currentGameAudio == null)
				{
					_currentGameAudio = (CName) CR2WTypeManager.Create("CName", "currentGameAudio", cr2w, this);
				}
				return _currentGameAudio;
			}
			set
			{
				if (_currentGameAudio == value)
				{
					return;
				}
				_currentGameAudio = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("currentGameAudioStop")] 
		public CName CurrentGameAudioStop
		{
			get
			{
				if (_currentGameAudioStop == null)
				{
					_currentGameAudioStop = (CName) CR2WTypeManager.Create("CName", "currentGameAudioStop", cr2w, this);
				}
				return _currentGameAudioStop;
			}
			set
			{
				if (_currentGameAudioStop == value)
				{
					return;
				}
				_currentGameAudioStop = value;
				PropertySet(this);
			}
		}

		public ArcadeMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
