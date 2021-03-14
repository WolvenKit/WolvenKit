using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkSplashScreenLoadingScreenLogicController : inkILoadingLogicController
	{
		private raRef<Bink> _logoTrainWBBink;
		private raRef<Bink> _logoTrainNamcoBink;
		private raRef<Bink> _logoTrainStadiaBink;
		private raRef<Bink> _logoTrainNoRTXBink;
		private raRef<Bink> _logoTrainRTXBink;
		private inkLocalizedBink _introMessageBink;
		private raRef<Bink> _trailerBink;
		private CName _logosTrainAnimation;
		private CName _localizedMessageAnimation;
		private CName _gameIntroAnimation;
		private CName _longLogosTrainAnimation;
		private CName _stopIntroAudioEventName;
		private CName _afterSkipAnimation;
		private inkVideoWidgetReference _videoPlayer;
		private inkCompoundWidgetReference _skipButtonPanel;

		[Ordinal(1)] 
		[RED("logoTrainWBBink")] 
		public raRef<Bink> LogoTrainWBBink
		{
			get
			{
				if (_logoTrainWBBink == null)
				{
					_logoTrainWBBink = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "logoTrainWBBink", cr2w, this);
				}
				return _logoTrainWBBink;
			}
			set
			{
				if (_logoTrainWBBink == value)
				{
					return;
				}
				_logoTrainWBBink = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("logoTrainNamcoBink")] 
		public raRef<Bink> LogoTrainNamcoBink
		{
			get
			{
				if (_logoTrainNamcoBink == null)
				{
					_logoTrainNamcoBink = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "logoTrainNamcoBink", cr2w, this);
				}
				return _logoTrainNamcoBink;
			}
			set
			{
				if (_logoTrainNamcoBink == value)
				{
					return;
				}
				_logoTrainNamcoBink = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("logoTrainStadiaBink")] 
		public raRef<Bink> LogoTrainStadiaBink
		{
			get
			{
				if (_logoTrainStadiaBink == null)
				{
					_logoTrainStadiaBink = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "logoTrainStadiaBink", cr2w, this);
				}
				return _logoTrainStadiaBink;
			}
			set
			{
				if (_logoTrainStadiaBink == value)
				{
					return;
				}
				_logoTrainStadiaBink = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("logoTrainNoRTXBink")] 
		public raRef<Bink> LogoTrainNoRTXBink
		{
			get
			{
				if (_logoTrainNoRTXBink == null)
				{
					_logoTrainNoRTXBink = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "logoTrainNoRTXBink", cr2w, this);
				}
				return _logoTrainNoRTXBink;
			}
			set
			{
				if (_logoTrainNoRTXBink == value)
				{
					return;
				}
				_logoTrainNoRTXBink = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("logoTrainRTXBink")] 
		public raRef<Bink> LogoTrainRTXBink
		{
			get
			{
				if (_logoTrainRTXBink == null)
				{
					_logoTrainRTXBink = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "logoTrainRTXBink", cr2w, this);
				}
				return _logoTrainRTXBink;
			}
			set
			{
				if (_logoTrainRTXBink == value)
				{
					return;
				}
				_logoTrainRTXBink = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("introMessageBink")] 
		public inkLocalizedBink IntroMessageBink
		{
			get
			{
				if (_introMessageBink == null)
				{
					_introMessageBink = (inkLocalizedBink) CR2WTypeManager.Create("inkLocalizedBink", "introMessageBink", cr2w, this);
				}
				return _introMessageBink;
			}
			set
			{
				if (_introMessageBink == value)
				{
					return;
				}
				_introMessageBink = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("trailerBink")] 
		public raRef<Bink> TrailerBink
		{
			get
			{
				if (_trailerBink == null)
				{
					_trailerBink = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "trailerBink", cr2w, this);
				}
				return _trailerBink;
			}
			set
			{
				if (_trailerBink == value)
				{
					return;
				}
				_trailerBink = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("logosTrainAnimation")] 
		public CName LogosTrainAnimation
		{
			get
			{
				if (_logosTrainAnimation == null)
				{
					_logosTrainAnimation = (CName) CR2WTypeManager.Create("CName", "logosTrainAnimation", cr2w, this);
				}
				return _logosTrainAnimation;
			}
			set
			{
				if (_logosTrainAnimation == value)
				{
					return;
				}
				_logosTrainAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("localizedMessageAnimation")] 
		public CName LocalizedMessageAnimation
		{
			get
			{
				if (_localizedMessageAnimation == null)
				{
					_localizedMessageAnimation = (CName) CR2WTypeManager.Create("CName", "localizedMessageAnimation", cr2w, this);
				}
				return _localizedMessageAnimation;
			}
			set
			{
				if (_localizedMessageAnimation == value)
				{
					return;
				}
				_localizedMessageAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("gameIntroAnimation")] 
		public CName GameIntroAnimation
		{
			get
			{
				if (_gameIntroAnimation == null)
				{
					_gameIntroAnimation = (CName) CR2WTypeManager.Create("CName", "gameIntroAnimation", cr2w, this);
				}
				return _gameIntroAnimation;
			}
			set
			{
				if (_gameIntroAnimation == value)
				{
					return;
				}
				_gameIntroAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("longLogosTrainAnimation")] 
		public CName LongLogosTrainAnimation
		{
			get
			{
				if (_longLogosTrainAnimation == null)
				{
					_longLogosTrainAnimation = (CName) CR2WTypeManager.Create("CName", "longLogosTrainAnimation", cr2w, this);
				}
				return _longLogosTrainAnimation;
			}
			set
			{
				if (_longLogosTrainAnimation == value)
				{
					return;
				}
				_longLogosTrainAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("stopIntroAudioEventName")] 
		public CName StopIntroAudioEventName
		{
			get
			{
				if (_stopIntroAudioEventName == null)
				{
					_stopIntroAudioEventName = (CName) CR2WTypeManager.Create("CName", "stopIntroAudioEventName", cr2w, this);
				}
				return _stopIntroAudioEventName;
			}
			set
			{
				if (_stopIntroAudioEventName == value)
				{
					return;
				}
				_stopIntroAudioEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("afterSkipAnimation")] 
		public CName AfterSkipAnimation
		{
			get
			{
				if (_afterSkipAnimation == null)
				{
					_afterSkipAnimation = (CName) CR2WTypeManager.Create("CName", "afterSkipAnimation", cr2w, this);
				}
				return _afterSkipAnimation;
			}
			set
			{
				if (_afterSkipAnimation == value)
				{
					return;
				}
				_afterSkipAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("videoPlayer")] 
		public inkVideoWidgetReference VideoPlayer
		{
			get
			{
				if (_videoPlayer == null)
				{
					_videoPlayer = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "videoPlayer", cr2w, this);
				}
				return _videoPlayer;
			}
			set
			{
				if (_videoPlayer == value)
				{
					return;
				}
				_videoPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("skipButtonPanel")] 
		public inkCompoundWidgetReference SkipButtonPanel
		{
			get
			{
				if (_skipButtonPanel == null)
				{
					_skipButtonPanel = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "skipButtonPanel", cr2w, this);
				}
				return _skipButtonPanel;
			}
			set
			{
				if (_skipButtonPanel == value)
				{
					return;
				}
				_skipButtonPanel = value;
				PropertySet(this);
			}
		}

		public inkSplashScreenLoadingScreenLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
