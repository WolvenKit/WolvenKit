using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AttachmentSlotCacheData : CVariable
	{
		private CBool _empty;
		private wCHandle<gamedataAttachmentSlot_Record> _attachmentSlotRecord;
		private CBool _shouldBeAvailable;
		private TweakDBID _slotId;

		[Ordinal(0)] 
		[RED("empty")] 
		public CBool Empty
		{
			get => GetProperty(ref _empty);
			set => SetProperty(ref _empty, value);
		}

		[Ordinal(1)] 
		[RED("attachmentSlotRecord")] 
		public wCHandle<gamedataAttachmentSlot_Record> AttachmentSlotRecord
		{
			get => GetProperty(ref _attachmentSlotRecord);
			set => SetProperty(ref _attachmentSlotRecord, value);
		}

		[Ordinal(2)] 
		[RED("shouldBeAvailable")] 
		public CBool ShouldBeAvailable
		{
			get => GetProperty(ref _shouldBeAvailable);
			set => SetProperty(ref _shouldBeAvailable, value);
		}

		[Ordinal(3)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		public AttachmentSlotCacheData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
