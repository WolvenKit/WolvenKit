using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AttachmentSlotCacheData : CVariable
	{
		[Ordinal(0)]  [RED("attachmentSlotRecord")] public wCHandle<gamedataAttachmentSlot_Record> AttachmentSlotRecord { get; set; }
		[Ordinal(1)]  [RED("empty")] public CBool Empty { get; set; }
		[Ordinal(2)]  [RED("shouldBeAvailable")] public CBool ShouldBeAvailable { get; set; }
		[Ordinal(3)]  [RED("slotId")] public TweakDBID SlotId { get; set; }

		public AttachmentSlotCacheData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
