using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkSplashScreenLoadingScreenLogicController : inkILoadingLogicController
	{
		[Ordinal(0)]  [RED("afterSkipAnimation")] public CName AfterSkipAnimation { get; set; }
		[Ordinal(1)]  [RED("gameIntroAnimation")] public CName GameIntroAnimation { get; set; }
		[Ordinal(2)]  [RED("introMessageBink")] public inkLocalizedBink IntroMessageBink { get; set; }
		[Ordinal(3)]  [RED("localizedMessageAnimation")] public CName LocalizedMessageAnimation { get; set; }
		[Ordinal(4)]  [RED("logoTrainNamcoBink")] public raRef<Bink> LogoTrainNamcoBink { get; set; }
		[Ordinal(5)]  [RED("logoTrainNoRTXBink")] public raRef<Bink> LogoTrainNoRTXBink { get; set; }
		[Ordinal(6)]  [RED("logoTrainRTXBink")] public raRef<Bink> LogoTrainRTXBink { get; set; }
		[Ordinal(7)]  [RED("logoTrainStadiaBink")] public raRef<Bink> LogoTrainStadiaBink { get; set; }
		[Ordinal(8)]  [RED("logoTrainWBBink")] public raRef<Bink> LogoTrainWBBink { get; set; }
		[Ordinal(9)]  [RED("logosTrainAnimation")] public CName LogosTrainAnimation { get; set; }
		[Ordinal(10)]  [RED("longLogosTrainAnimation")] public CName LongLogosTrainAnimation { get; set; }
		[Ordinal(11)]  [RED("skipButtonPanel")] public inkCompoundWidgetReference SkipButtonPanel { get; set; }
		[Ordinal(12)]  [RED("stopIntroAudioEventName")] public CName StopIntroAudioEventName { get; set; }
		[Ordinal(13)]  [RED("trailerBink")] public raRef<Bink> TrailerBink { get; set; }
		[Ordinal(14)]  [RED("videoPlayer")] public inkVideoWidgetReference VideoPlayer { get; set; }

		public inkSplashScreenLoadingScreenLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
