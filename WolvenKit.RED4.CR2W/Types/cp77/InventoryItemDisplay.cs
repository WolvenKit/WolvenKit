using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemDisplay : BaseButtonView
	{
		private inkWidgetReference _rarityRoot;
		private inkCompoundWidgetReference _modsRoot;
		private inkWidgetReference _rarityWrapper;
		private inkImageWidgetReference _iconImage;
		private inkImageWidgetReference _iconShadowImage;
		private inkImageWidgetReference _iconFallback;
		private inkImageWidgetReference _backgroundShape;
		private inkImageWidgetReference _backgroundHighlight;
		private inkImageWidgetReference _backgroundFrame;
		private inkTextWidgetReference _quantityText;
		private CName _modName;
		private inkWidgetReference _toggleHighlight;
		private inkWidgetReference _equippedIcon;
		private CString _defaultCategoryIconName;
		private InventoryItemData _itemData;
		private CArray<wCHandle<InventoryItemAttachmentDisplay>> _attachementsDisplay;
		private Vector2 _smallSize;
		private Vector2 _bigSize;
		private wCHandle<gameObject> _owner;

		[Ordinal(2)] 
		[RED("RarityRoot")] 
		public inkWidgetReference RarityRoot
		{
			get
			{
				if (_rarityRoot == null)
				{
					_rarityRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "RarityRoot", cr2w, this);
				}
				return _rarityRoot;
			}
			set
			{
				if (_rarityRoot == value)
				{
					return;
				}
				_rarityRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ModsRoot")] 
		public inkCompoundWidgetReference ModsRoot
		{
			get
			{
				if (_modsRoot == null)
				{
					_modsRoot = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "ModsRoot", cr2w, this);
				}
				return _modsRoot;
			}
			set
			{
				if (_modsRoot == value)
				{
					return;
				}
				_modsRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("RarityWrapper")] 
		public inkWidgetReference RarityWrapper
		{
			get
			{
				if (_rarityWrapper == null)
				{
					_rarityWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "RarityWrapper", cr2w, this);
				}
				return _rarityWrapper;
			}
			set
			{
				if (_rarityWrapper == value)
				{
					return;
				}
				_rarityWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("IconImage")] 
		public inkImageWidgetReference IconImage
		{
			get
			{
				if (_iconImage == null)
				{
					_iconImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "IconImage", cr2w, this);
				}
				return _iconImage;
			}
			set
			{
				if (_iconImage == value)
				{
					return;
				}
				_iconImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("IconShadowImage")] 
		public inkImageWidgetReference IconShadowImage
		{
			get
			{
				if (_iconShadowImage == null)
				{
					_iconShadowImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "IconShadowImage", cr2w, this);
				}
				return _iconShadowImage;
			}
			set
			{
				if (_iconShadowImage == value)
				{
					return;
				}
				_iconShadowImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("IconFallback")] 
		public inkImageWidgetReference IconFallback
		{
			get
			{
				if (_iconFallback == null)
				{
					_iconFallback = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "IconFallback", cr2w, this);
				}
				return _iconFallback;
			}
			set
			{
				if (_iconFallback == value)
				{
					return;
				}
				_iconFallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("BackgroundShape")] 
		public inkImageWidgetReference BackgroundShape
		{
			get
			{
				if (_backgroundShape == null)
				{
					_backgroundShape = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "BackgroundShape", cr2w, this);
				}
				return _backgroundShape;
			}
			set
			{
				if (_backgroundShape == value)
				{
					return;
				}
				_backgroundShape = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("BackgroundHighlight")] 
		public inkImageWidgetReference BackgroundHighlight
		{
			get
			{
				if (_backgroundHighlight == null)
				{
					_backgroundHighlight = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "BackgroundHighlight", cr2w, this);
				}
				return _backgroundHighlight;
			}
			set
			{
				if (_backgroundHighlight == value)
				{
					return;
				}
				_backgroundHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("BackgroundFrame")] 
		public inkImageWidgetReference BackgroundFrame
		{
			get
			{
				if (_backgroundFrame == null)
				{
					_backgroundFrame = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "BackgroundFrame", cr2w, this);
				}
				return _backgroundFrame;
			}
			set
			{
				if (_backgroundFrame == value)
				{
					return;
				}
				_backgroundFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("QuantityText")] 
		public inkTextWidgetReference QuantityText
		{
			get
			{
				if (_quantityText == null)
				{
					_quantityText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "QuantityText", cr2w, this);
				}
				return _quantityText;
			}
			set
			{
				if (_quantityText == value)
				{
					return;
				}
				_quantityText = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("ModName")] 
		public CName ModName
		{
			get
			{
				if (_modName == null)
				{
					_modName = (CName) CR2WTypeManager.Create("CName", "ModName", cr2w, this);
				}
				return _modName;
			}
			set
			{
				if (_modName == value)
				{
					return;
				}
				_modName = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("toggleHighlight")] 
		public inkWidgetReference ToggleHighlight
		{
			get
			{
				if (_toggleHighlight == null)
				{
					_toggleHighlight = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "toggleHighlight", cr2w, this);
				}
				return _toggleHighlight;
			}
			set
			{
				if (_toggleHighlight == value)
				{
					return;
				}
				_toggleHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("equippedIcon")] 
		public inkWidgetReference EquippedIcon
		{
			get
			{
				if (_equippedIcon == null)
				{
					_equippedIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "equippedIcon", cr2w, this);
				}
				return _equippedIcon;
			}
			set
			{
				if (_equippedIcon == value)
				{
					return;
				}
				_equippedIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("DefaultCategoryIconName")] 
		public CString DefaultCategoryIconName
		{
			get
			{
				if (_defaultCategoryIconName == null)
				{
					_defaultCategoryIconName = (CString) CR2WTypeManager.Create("String", "DefaultCategoryIconName", cr2w, this);
				}
				return _defaultCategoryIconName;
			}
			set
			{
				if (_defaultCategoryIconName == value)
				{
					return;
				}
				_defaultCategoryIconName = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("ItemData")] 
		public InventoryItemData ItemData
		{
			get
			{
				if (_itemData == null)
				{
					_itemData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "ItemData", cr2w, this);
				}
				return _itemData;
			}
			set
			{
				if (_itemData == value)
				{
					return;
				}
				_itemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("AttachementsDisplay")] 
		public CArray<wCHandle<InventoryItemAttachmentDisplay>> AttachementsDisplay
		{
			get
			{
				if (_attachementsDisplay == null)
				{
					_attachementsDisplay = (CArray<wCHandle<InventoryItemAttachmentDisplay>>) CR2WTypeManager.Create("array:whandle:InventoryItemAttachmentDisplay", "AttachementsDisplay", cr2w, this);
				}
				return _attachementsDisplay;
			}
			set
			{
				if (_attachementsDisplay == value)
				{
					return;
				}
				_attachementsDisplay = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("smallSize")] 
		public Vector2 SmallSize
		{
			get
			{
				if (_smallSize == null)
				{
					_smallSize = (Vector2) CR2WTypeManager.Create("Vector2", "smallSize", cr2w, this);
				}
				return _smallSize;
			}
			set
			{
				if (_smallSize == value)
				{
					return;
				}
				_smallSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("bigSize")] 
		public Vector2 BigSize
		{
			get
			{
				if (_bigSize == null)
				{
					_bigSize = (Vector2) CR2WTypeManager.Create("Vector2", "bigSize", cr2w, this);
				}
				return _bigSize;
			}
			set
			{
				if (_bigSize == value)
				{
					return;
				}
				_bigSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		public InventoryItemDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
