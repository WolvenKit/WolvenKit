using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AttachmentSlotCacheData : CVariable
	{
		[Ordinal(0)] [RED("empty")] public CBool Empty { get; set; }
		[Ordinal(1)] [RED("attachmentSlotRecord")] public wCHandle<gamedataAttachmentSlot_Record> AttachmentSlotRecord { get; set; }
		[Ordinal(2)] [RED("shouldBeAvailable")] public CBool ShouldBeAvailable { get; set; }
		[Ordinal(3)] [RED("slotId")] public TweakDBID SlotId { get; set; }

		public AttachmentSlotCacheData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
