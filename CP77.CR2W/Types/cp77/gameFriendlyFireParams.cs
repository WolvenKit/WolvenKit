using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameFriendlyFireParams : IScriptable
	{
		[Ordinal(0)]  [RED("attachmentName")] public CName AttachmentName { get; set; }
		[Ordinal(1)]  [RED("attitude")] public wCHandle<gameAttitudeAgent> Attitude { get; set; }
		[Ordinal(2)]  [RED("maxRange")] public CFloat MaxRange { get; set; }
		[Ordinal(3)]  [RED("slotId")] public CInt32 SlotId { get; set; }
		[Ordinal(4)]  [RED("slots")] public wCHandle<entSlotComponent> Slots { get; set; }
		[Ordinal(5)]  [RED("spread")] public CFloat Spread { get; set; }

		public gameFriendlyFireParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
