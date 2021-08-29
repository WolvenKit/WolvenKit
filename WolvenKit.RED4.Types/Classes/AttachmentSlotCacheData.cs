using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AttachmentSlotCacheData : RedBaseClass
	{
		private CBool _empty;
		private CWeakHandle<gamedataAttachmentSlot_Record> _attachmentSlotRecord;
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
		public CWeakHandle<gamedataAttachmentSlot_Record> AttachmentSlotRecord
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
	}
}
