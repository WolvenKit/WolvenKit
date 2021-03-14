using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEquippedPrereq : gameIPrereq
	{
		private gameItemID _itemID;
		private TweakDBID _slot;

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
		[RED("slot")] 
		public TweakDBID Slot
		{
			get
			{
				if (_slot == null)
				{
					_slot = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slot", cr2w, this);
				}
				return _slot;
			}
			set
			{
				if (_slot == value)
				{
					return;
				}
				_slot = value;
				PropertySet(this);
			}
		}

		public gameEquippedPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
