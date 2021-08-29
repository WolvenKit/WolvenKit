using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemAttachments : RedBaseClass
	{
		private gameItemID _itemID;
		private TweakDBID _attachmentSlotID;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("attachmentSlotID")] 
		public TweakDBID AttachmentSlotID
		{
			get => GetProperty(ref _attachmentSlotID);
			set => SetProperty(ref _attachmentSlotID, value);
		}
	}
}
