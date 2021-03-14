using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlotsScriptCallback : IScriptable
	{
		private TweakDBID _slotID;
		private gameItemID _itemID;

		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public gameAttachmentSlotsScriptCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
