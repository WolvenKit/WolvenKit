using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GOGProfileGameController : gameuiBaseGOGProfileController
	{
		[Ordinal(0)]  [RED("canRetry")] public CBool CanRetry { get; set; }
		[Ordinal(1)]  [RED("isFirstLogin")] public CBool IsFirstLogin { get; set; }
		[Ordinal(2)]  [RED("parentContainerWidget")] public inkWidgetReference ParentContainerWidget { get; set; }
		[Ordinal(3)]  [RED("retryButton")] public inkWidgetReference RetryButton { get; set; }
		[Ordinal(4)]  [RED("showingFirstLogin")] public CBool ShowingFirstLogin { get; set; }

		public GOGProfileGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
