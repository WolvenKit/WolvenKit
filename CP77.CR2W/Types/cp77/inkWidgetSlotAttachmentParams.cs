using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkWidgetSlotAttachmentParams : CVariable
	{
		[Ordinal(0)]  [RED("slotID")] public CName SlotID { get; set; }
		[Ordinal(1)]  [RED("useSlotLayout")] public CBool UseSlotLayout { get; set; }
		[Ordinal(2)]  [RED("layoutOverride")] public inkWidgetLayout LayoutOverride { get; set; }

		public inkWidgetSlotAttachmentParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
