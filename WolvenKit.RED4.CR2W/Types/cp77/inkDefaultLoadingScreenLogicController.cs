using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkDefaultLoadingScreenLogicController : inkILoadingLogicController
	{
		[Ordinal(1)] [RED("progressBarRoot")] public inkWidgetReference ProgressBarRoot { get; set; }
		[Ordinal(2)] [RED("progressBarController")] public wCHandle<LoadingScreenProgressBarController> ProgressBarController { get; set; }

		public inkDefaultLoadingScreenLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
