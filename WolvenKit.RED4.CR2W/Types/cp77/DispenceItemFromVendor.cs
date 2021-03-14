using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DispenceItemFromVendor : ActionBool
	{
		private gameItemID _itemID;
		private CInt32 _price;
		private CName _atlasTexture;

		[Ordinal(25)] 
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

		[Ordinal(26)] 
		[RED("price")] 
		public CInt32 Price
		{
			get
			{
				if (_price == null)
				{
					_price = (CInt32) CR2WTypeManager.Create("Int32", "price", cr2w, this);
				}
				return _price;
			}
			set
			{
				if (_price == value)
				{
					return;
				}
				_price = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("atlasTexture")] 
		public CName AtlasTexture
		{
			get
			{
				if (_atlasTexture == null)
				{
					_atlasTexture = (CName) CR2WTypeManager.Create("CName", "atlasTexture", cr2w, this);
				}
				return _atlasTexture;
			}
			set
			{
				if (_atlasTexture == value)
				{
					return;
				}
				_atlasTexture = value;
				PropertySet(this);
			}
		}

		public DispenceItemFromVendor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
