using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkDefaultLoadingScreenLogicController : inkILoadingLogicController
	{
		[Ordinal(0)]  [RED("progressBarController")] public wCHandle<LoadingScreenProgressBarController> ProgressBarController { get; set; }
		[Ordinal(1)]  [RED("progressBarRoot")] public inkWidgetReference ProgressBarRoot { get; set; }

		public inkDefaultLoadingScreenLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
