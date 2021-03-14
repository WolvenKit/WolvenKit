using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiItemAddedNotificationViewData : gameuiGenericNotificationViewData
	{
		private gameItemID _itemID;
		private CName _animation;
		private CName _itemRarity;

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("animation")] 
		public CName Animation
		{
			get
			{
				if (_animation == null)
				{
					_animation = (CName) CR2WTypeManager.Create("CName", "animation", cr2w, this);
				}
				return _animation;
			}
			set
			{
				if (_animation == value)
				{
					return;
				}
				_animation = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("itemRarity")] 
		public CName ItemRarity
		{
			get
			{
				if (_itemRarity == null)
				{
					_itemRarity = (CName) CR2WTypeManager.Create("CName", "itemRarity", cr2w, this);
				}
				return _itemRarity;
			}
			set
			{
				if (_itemRarity == value)
				{
					return;
				}
				_itemRarity = value;
				PropertySet(this);
			}
		}

		public gameuiItemAddedNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
