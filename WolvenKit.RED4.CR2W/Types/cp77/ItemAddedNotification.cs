using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemAddedNotification : GenericNotificationController
	{
		private inkImageWidgetReference _itemImage;
		private inkWidgetReference _rarityBar;
		private CEnum<gameItemIconGender> _itemIconGender;
		private CName _animationName;

		[Ordinal(12)] 
		[RED("itemImage")] 
		public inkImageWidgetReference ItemImage
		{
			get
			{
				if (_itemImage == null)
				{
					_itemImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "itemImage", cr2w, this);
				}
				return _itemImage;
			}
			set
			{
				if (_itemImage == value)
				{
					return;
				}
				_itemImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("rarityBar")] 
		public inkWidgetReference RarityBar
		{
			get
			{
				if (_rarityBar == null)
				{
					_rarityBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rarityBar", cr2w, this);
				}
				return _rarityBar;
			}
			set
			{
				if (_rarityBar == value)
				{
					return;
				}
				_rarityBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("itemIconGender")] 
		public CEnum<gameItemIconGender> ItemIconGender
		{
			get
			{
				if (_itemIconGender == null)
				{
					_itemIconGender = (CEnum<gameItemIconGender>) CR2WTypeManager.Create("gameItemIconGender", "itemIconGender", cr2w, this);
				}
				return _itemIconGender;
			}
			set
			{
				if (_itemIconGender == value)
				{
					return;
				}
				_itemIconGender = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "animationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		public ItemAddedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
