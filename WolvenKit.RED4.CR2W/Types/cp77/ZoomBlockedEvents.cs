using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ZoomBlockedEvents : ZoomEventsTransition
	{
		[Ordinal(0)] [RED("previousCameraPerspective")] public CEnum<vehicleCameraPerspective> PreviousCameraPerspective { get; set; }
		[Ordinal(1)] [RED("previousCameraPerspectiveValid")] public CBool PreviousCameraPerspectiveValid { get; set; }

		public ZoomBlockedEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
