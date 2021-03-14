using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameInventoryPrereq : gameIComparisonPrereq
	{
		private gameItemID _itemID;
		private CUInt32 _amount;

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

		[Ordinal(2)] 
		[RED("amount")] 
		public CUInt32 Amount
		{
			get
			{
				if (_amount == null)
				{
					_amount = (CUInt32) CR2WTypeManager.Create("Uint32", "amount", cr2w, this);
				}
				return _amount;
			}
			set
			{
				if (_amount == value)
				{
					return;
				}
				_amount = value;
				PropertySet(this);
			}
		}

		public gameInventoryPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
