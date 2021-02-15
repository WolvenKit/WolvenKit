using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RadialSlot : IScriptable
	{
		[Ordinal(0)] [RED("slotAnchorRef")] public inkWidgetReference SlotAnchorRef { get; set; }
		[Ordinal(1)] [RED("libraryRef")] public inkWidgetLibraryReference LibraryRef { get; set; }
		[Ordinal(2)] [RED("slotType")] public CEnum<SlotType> SlotType { get; set; }
		[Ordinal(3)] [RED("animData")] public RadialAnimData AnimData { get; set; }
		[Ordinal(4)] [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }
		[Ordinal(5)] [RED("targetAngle")] public CFloat TargetAngle { get; set; }
		[Ordinal(6)] [RED("active")] public CString Active { get; set; }
		[Ordinal(7)] [RED("inactive")] public CString Inactive { get; set; }
		[Ordinal(8)] [RED("blocked")] public CString Blocked { get; set; }

		public RadialSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
