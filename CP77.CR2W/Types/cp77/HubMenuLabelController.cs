using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HubMenuLabelController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("container")] public inkCompoundWidgetReference Container { get; set; }
		[Ordinal(1)]  [RED("wrapper")] public wCHandle<inkWidget> Wrapper { get; set; }
		[Ordinal(2)]  [RED("wrapperNext")] public wCHandle<inkWidget> WrapperNext { get; set; }
		[Ordinal(3)]  [RED("wrapperController")] public wCHandle<HubMenuLabelContentContainer> WrapperController { get; set; }
		[Ordinal(4)]  [RED("wrapperNextController")] public wCHandle<HubMenuLabelContentContainer> WrapperNextController { get; set; }
		[Ordinal(5)]  [RED("data")] public MenuData Data { get; set; }
		[Ordinal(6)]  [RED("watchForSize")] public CBool WatchForSize { get; set; }
		[Ordinal(7)]  [RED("watchForInstatnSize")] public CBool WatchForInstatnSize { get; set; }
		[Ordinal(8)]  [RED("once")] public CBool Once { get; set; }
		[Ordinal(9)]  [RED("direction")] public CInt32 Direction { get; set; }

		public HubMenuLabelController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
