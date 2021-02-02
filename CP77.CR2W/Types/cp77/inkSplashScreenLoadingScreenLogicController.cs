using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkSplashScreenLoadingScreenLogicController : inkILoadingLogicController
	{
		[Ordinal(0)]  [RED("unk180")] public raRef<Bink> Unk180 { get; set; }
		[Ordinal(1)]  [RED("unk188")] public raRef<Bink> Unk188 { get; set; }
		[Ordinal(2)]  [RED("unk190")] public raRef<Bink> Unk190 { get; set; }
		[Ordinal(3)]  [RED("unk198")] public raRef<Bink> Unk198 { get; set; }
		[Ordinal(4)]  [RED("unk1A0")] public raRef<Bink> Unk1A0 { get; set; }
		[Ordinal(5)]  [RED("unk1A8")] public inkLocalizedBink Unk1A8 { get; set; }
		[Ordinal(6)]  [RED("trailerBink")] public raRef<Bink> TrailerBink { get; set; }
		[Ordinal(7)]  [RED("skipButtonPanel")] public inkCompoundWidgetReference SkipButtonPanel { get; set; }
		[Ordinal(8)]  [RED("videoPlayer")] public inkVideoWidgetReference VideoPlayer { get; set; }
		[Ordinal(9)]  [RED("logosTrainAnimation")] public CName LogosTrainAnimation { get; set; }
		[Ordinal(10)]  [RED("longLogosTrainAnimation")] public CName LongLogosTrainAnimation { get; set; }
		[Ordinal(11)]  [RED("localizedMessageAnimation")] public CName LocalizedMessageAnimation { get; set; }
		[Ordinal(12)]  [RED("gameIntroAnimation")] public CName GameIntroAnimation { get; set; }
		[Ordinal(13)]  [RED("stopIntroAudioEventName")] public CName StopIntroAudioEventName { get; set; }
		[Ordinal(14)]  [RED("afterSkipAnimation")] public CName AfterSkipAnimation { get; set; }

		public inkSplashScreenLoadingScreenLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
