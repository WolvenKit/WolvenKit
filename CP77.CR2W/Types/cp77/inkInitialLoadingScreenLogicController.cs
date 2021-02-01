using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkInitialLoadingScreenLogicController : inkILoadingLogicController
	{
		[Ordinal(0)]  [RED("afterSkipAnimation")] public CName AfterSkipAnimation { get; set; }
		[Ordinal(1)]  [RED("loadingFinishedAudioStopEvent")] public CName LoadingFinishedAudioStopEvent { get; set; }
		[Ordinal(2)]  [RED("loadingPartsContainer")] public inkCompoundWidgetReference LoadingPartsContainer { get; set; }
		[Ordinal(3)]  [RED("progressBarController")] public wCHandle<LoadingScreenProgressBarController> ProgressBarController { get; set; }
		[Ordinal(4)]  [RED("progressBarRoot")] public inkWidgetReference ProgressBarRoot { get; set; }
		[Ordinal(5)]  [RED("skipButtonPanel")] public inkWidgetReference SkipButtonPanel { get; set; }

		public inkInitialLoadingScreenLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
