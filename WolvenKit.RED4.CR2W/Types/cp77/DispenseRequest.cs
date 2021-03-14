using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DispenseRequest : MarketSystemRequest
	{
		private Vector4 _position;
		private gameItemID _itemID;
		private CBool _shouldPay;

		[Ordinal(2)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("shouldPay")] 
		public CBool ShouldPay
		{
			get
			{
				if (_shouldPay == null)
				{
					_shouldPay = (CBool) CR2WTypeManager.Create("Bool", "shouldPay", cr2w, this);
				}
				return _shouldPay;
			}
			set
			{
				if (_shouldPay == value)
				{
					return;
				}
				_shouldPay = value;
				PropertySet(this);
			}
		}

		public DispenseRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
