using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkSplashScreenLoadingScreenLogicController : inkILoadingLogicController
	{
		[Ordinal(1)] [RED("logoTrainWBBink")] public raRef<Bink> LogoTrainWBBink { get; set; }
		[Ordinal(2)] [RED("logoTrainNamcoBink")] public raRef<Bink> LogoTrainNamcoBink { get; set; }
		[Ordinal(3)] [RED("logoTrainStadiaBink")] public raRef<Bink> LogoTrainStadiaBink { get; set; }
		[Ordinal(4)] [RED("logoTrainNoRTXBink")] public raRef<Bink> LogoTrainNoRTXBink { get; set; }
		[Ordinal(5)] [RED("logoTrainRTXBink")] public raRef<Bink> LogoTrainRTXBink { get; set; }
		[Ordinal(6)] [RED("introMessageBink")] public inkLocalizedBink IntroMessageBink { get; set; }
		[Ordinal(7)] [RED("trailerBink")] public raRef<Bink> TrailerBink { get; set; }
		[Ordinal(8)] [RED("logosTrainAnimation")] public CName LogosTrainAnimation { get; set; }
		[Ordinal(9)] [RED("localizedMessageAnimation")] public CName LocalizedMessageAnimation { get; set; }
		[Ordinal(10)] [RED("gameIntroAnimation")] public CName GameIntroAnimation { get; set; }
		[Ordinal(11)] [RED("longLogosTrainAnimation")] public CName LongLogosTrainAnimation { get; set; }
		[Ordinal(12)] [RED("stopIntroAudioEventName")] public CName StopIntroAudioEventName { get; set; }
		[Ordinal(13)] [RED("afterSkipAnimation")] public CName AfterSkipAnimation { get; set; }
		[Ordinal(14)] [RED("videoPlayer")] public inkVideoWidgetReference VideoPlayer { get; set; }
		[Ordinal(15)] [RED("skipButtonPanel")] public inkCompoundWidgetReference SkipButtonPanel { get; set; }

		public inkSplashScreenLoadingScreenLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
