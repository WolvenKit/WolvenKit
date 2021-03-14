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
			get
			{
				if (_empty == null)
				{
					_empty = (CBool) CR2WTypeManager.Create("Bool", "empty", cr2w, this);
				}
				return _empty;
			}
			set
			{
				if (_empty == value)
				{
					return;
				}
				_empty = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("attachmentSlotRecord")] 
		public wCHandle<gamedataAttachmentSlot_Record> AttachmentSlotRecord
		{
			get
			{
				if (_attachmentSlotRecord == null)
				{
					_attachmentSlotRecord = (wCHandle<gamedataAttachmentSlot_Record>) CR2WTypeManager.Create("whandle:gamedataAttachmentSlot_Record", "attachmentSlotRecord", cr2w, this);
				}
				return _attachmentSlotRecord;
			}
			set
			{
				if (_attachmentSlotRecord == value)
				{
					return;
				}
				_attachmentSlotRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("shouldBeAvailable")] 
		public CBool ShouldBeAvailable
		{
			get
			{
				if (_shouldBeAvailable == null)
				{
					_shouldBeAvailable = (CBool) CR2WTypeManager.Create("Bool", "shouldBeAvailable", cr2w, this);
				}
				return _shouldBeAvailable;
			}
			set
			{
				if (_shouldBeAvailable == value)
				{
					return;
				}
				_shouldBeAvailable = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get
			{
				if (_slotId == null)
				{
					_slotId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotId", cr2w, this);
				}
				return _slotId;
			}
			set
			{
				if (_slotId == value)
				{
					return;
				}
				_slotId = value;
				PropertySet(this);
			}
		}

		public AttachmentSlotCacheData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
