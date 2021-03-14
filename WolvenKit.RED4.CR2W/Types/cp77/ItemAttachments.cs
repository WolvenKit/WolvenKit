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
			get
			{
				if (_itemID == null)
				{
					_itemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("attachmentSlotID")] 
		public TweakDBID AttachmentSlotID
		{
			get
			{
				if (_attachmentSlotID == null)
				{
					_attachmentSlotID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "attachmentSlotID", cr2w, this);
				}
				return _attachmentSlotID;
			}
			set
			{
				if (_attachmentSlotID == value)
				{
					return;
				}
				_attachmentSlotID = value;
				PropertySet(this);
			}
		}

		public ItemAttachments(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
