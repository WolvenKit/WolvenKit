using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreview_SetCameraSetupEvent : redEvent
	{
		[Ordinal(0)]  [RED("delayed")] public CBool Delayed { get; set; }
		[Ordinal(1)]  [RED("setupIndex")] public CUInt32 SetupIndex { get; set; }
		[Ordinal(2)]  [RED("slotName")] public CName SlotName { get; set; }

		public gameuiPuppetPreview_SetCameraSetupEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
