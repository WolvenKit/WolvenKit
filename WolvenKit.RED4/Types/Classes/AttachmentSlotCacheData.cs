using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AttachmentSlotCacheData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("empty")] 
		public CBool Empty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("attachmentSlotRecord")] 
		public CWeakHandle<gamedataAttachmentSlot_Record> AttachmentSlotRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAttachmentSlot_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAttachmentSlot_Record>>(value);
		}

		[Ordinal(2)] 
		[RED("shouldBeAvailable")] 
		public CBool ShouldBeAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public AttachmentSlotCacheData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
