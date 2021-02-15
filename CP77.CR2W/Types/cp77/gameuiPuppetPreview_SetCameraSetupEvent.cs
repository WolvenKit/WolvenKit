using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreview_SetCameraSetupEvent : redEvent
	{
		[Ordinal(0)] [RED("setupIndex")] public CUInt32 SetupIndex { get; set; }
		[Ordinal(1)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(2)] [RED("delayed")] public CBool Delayed { get; set; }

		public gameuiPuppetPreview_SetCameraSetupEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
