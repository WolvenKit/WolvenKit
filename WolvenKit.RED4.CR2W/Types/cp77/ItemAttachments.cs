using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemAttachments : CVariable
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

		public ItemAttachments(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
