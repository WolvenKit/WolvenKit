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
			get => GetProperty(ref _logoTrainWBBink);
			set => SetProperty(ref _logoTrainWBBink, value);
		}

		[Ordinal(2)] 
		[RED("logoTrainNamcoBink")] 
		public raRef<Bink> LogoTrainNamcoBink
		{
			get => GetProperty(ref _logoTrainNamcoBink);
			set => SetProperty(ref _logoTrainNamcoBink, value);
		}

		[Ordinal(3)] 
		[RED("logoTrainStadiaBink")] 
		public raRef<Bink> LogoTrainStadiaBink
		{
			get => GetProperty(ref _logoTrainStadiaBink);
			set => SetProperty(ref _logoTrainStadiaBink, value);
		}

		[Ordinal(4)] 
		[RED("logoTrainNoRTXBink")] 
		public raRef<Bink> LogoTrainNoRTXBink
		{
			get => GetProperty(ref _logoTrainNoRTXBink);
			set => SetProperty(ref _logoTrainNoRTXBink, value);
		}

		[Ordinal(5)] 
		[RED("logoTrainRTXBink")] 
		public raRef<Bink> LogoTrainRTXBink
		{
			get => GetProperty(ref _logoTrainRTXBink);
			set => SetProperty(ref _logoTrainRTXBink, value);
		}

		[Ordinal(6)] 
		[RED("introMessageBink")] 
		public inkLocalizedBink IntroMessageBink
		{
			get => GetProperty(ref _introMessageBink);
			set => SetProperty(ref _introMessageBink, value);
		}

		[Ordinal(7)] 
		[RED("trailerBink")] 
		public raRef<Bink> TrailerBink
		{
			get => GetProperty(ref _trailerBink);
			set => SetProperty(ref _trailerBink, value);
		}

		[Ordinal(8)] 
		[RED("logosTrainAnimation")] 
		public CName LogosTrainAnimation
		{
			get => GetProperty(ref _logosTrainAnimation);
			set => SetProperty(ref _logosTrainAnimation, value);
		}

		[Ordinal(9)] 
		[RED("localizedMessageAnimation")] 
		public CName LocalizedMessageAnimation
		{
			get => GetProperty(ref _localizedMessageAnimation);
			set => SetProperty(ref _localizedMessageAnimation, value);
		}

		[Ordinal(10)] 
		[RED("gameIntroAnimation")] 
		public CName GameIntroAnimation
		{
			get => GetProperty(ref _gameIntroAnimation);
			set => SetProperty(ref _gameIntroAnimation, value);
		}

		[Ordinal(11)] 
		[RED("longLogosTrainAnimation")] 
		public CName LongLogosTrainAnimation
		{
			get => GetProperty(ref _longLogosTrainAnimation);
			set => SetProperty(ref _longLogosTrainAnimation, value);
		}

		[Ordinal(12)] 
		[RED("stopIntroAudioEventName")] 
		public CName StopIntroAudioEventName
		{
			get => GetProperty(ref _stopIntroAudioEventName);
			set => SetProperty(ref _stopIntroAudioEventName, value);
		}

		[Ordinal(13)] 
		[RED("afterSkipAnimation")] 
		public CName AfterSkipAnimation
		{
			get => GetProperty(ref _afterSkipAnimation);
			set => SetProperty(ref _afterSkipAnimation, value);
		}

		[Ordinal(14)] 
		[RED("videoPlayer")] 
		public inkVideoWidgetReference VideoPlayer
		{
			get => GetProperty(ref _videoPlayer);
			set => SetProperty(ref _videoPlayer, value);
		}

		[Ordinal(15)] 
		[RED("skipButtonPanel")] 
		public inkCompoundWidgetReference SkipButtonPanel
		{
			get => GetProperty(ref _skipButtonPanel);
			set => SetProperty(ref _skipButtonPanel, value);
		}

		public inkSplashScreenLoadingScreenLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
