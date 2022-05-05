using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkSplashScreenLoadingScreenLogicController : inkILoadingLogicController
	{
		[Ordinal(1)] 
		[RED("logoTrainWBBink")] 
		public CResourceAsyncReference<Bink> LogoTrainWBBink
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(2)] 
		[RED("logoTrainNamcoBink")] 
		public CResourceAsyncReference<Bink> LogoTrainNamcoBink
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(3)] 
		[RED("logoTrainStadiaBink")] 
		public CResourceAsyncReference<Bink> LogoTrainStadiaBink
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(4)] 
		[RED("logoTrainNoRTXBink")] 
		public CResourceAsyncReference<Bink> LogoTrainNoRTXBink
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(5)] 
		[RED("logoTrainRTXBink")] 
		public CResourceAsyncReference<Bink> LogoTrainRTXBink
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(6)] 
		[RED("introMessageBink")] 
		public inkLocalizedBink IntroMessageBink
		{
			get => GetPropertyValue<inkLocalizedBink>();
			set => SetPropertyValue<inkLocalizedBink>(value);
		}

		[Ordinal(7)] 
		[RED("trailerBink")] 
		public CResourceAsyncReference<Bink> TrailerBink
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(8)] 
		[RED("logosTrainAnimation")] 
		public CName LogosTrainAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("localizedMessageAnimation")] 
		public CName LocalizedMessageAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("gameIntroAnimation")] 
		public CName GameIntroAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("longLogosTrainAnimation")] 
		public CName LongLogosTrainAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("stopIntroAudioEventName")] 
		public CName StopIntroAudioEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("afterSkipAnimation")] 
		public CName AfterSkipAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("videoPlayer")] 
		public inkVideoWidgetReference VideoPlayer
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("skipButtonPanel")] 
		public inkCompoundWidgetReference SkipButtonPanel
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public inkSplashScreenLoadingScreenLogicController()
		{
			IntroMessageBink = new() { Binks = new() };
			VideoPlayer = new();
			SkipButtonPanel = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
