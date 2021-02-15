using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameFriendlyFireParams : IScriptable
	{
		[Ordinal(0)] [RED("attitude")] public wCHandle<gameAttitudeAgent> Attitude { get; set; }
		[Ordinal(1)] [RED("slots")] public wCHandle<entSlotComponent> Slots { get; set; }
		[Ordinal(2)] [RED("attachmentName")] public CName AttachmentName { get; set; }
		[Ordinal(3)] [RED("slotId")] public CInt32 SlotId { get; set; }
		[Ordinal(4)] [RED("spread")] public CFloat Spread { get; set; }
		[Ordinal(5)] [RED("maxRange")] public CFloat MaxRange { get; set; }

		public gameFriendlyFireParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
