using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessengerContactItemVirtualController : inkVirtualCompoundItemController
	{
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _msgPreview;
		private inkTextWidgetReference _msgCounter;
		private inkWidgetReference _msgIndicator;
		private inkWidgetReference _replyAlertIcon;
		private inkWidgetReference _collapseIcon;
		private inkImageWidgetReference _image;
		private CHandle<ContactData> _contactData;
		private CHandle<VirutalNestedListData> _nestedListData;
		private CEnum<MessengerContactType> _type;
		private wCHandle<MessengerContactSyncData> _activeItemSync;
		private CBool _isContactActive;
		private CBool _isItemHovered;
		private CBool _isItemToggled;

		[Ordinal(15)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("msgPreview")] 
		public inkTextWidgetReference MsgPreview
		{
			get
			{
				if (_msgPreview == null)
				{
					_msgPreview = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "msgPreview", cr2w, this);
				}
				return _msgPreview;
			}
			set
			{
				if (_msgPreview == value)
				{
					return;
				}
				_msgPreview = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("msgCounter")] 
		public inkTextWidgetReference MsgCounter
		{
			get
			{
				if (_msgCounter == null)
				{
					_msgCounter = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "msgCounter", cr2w, this);
				}
				return _msgCounter;
			}
			set
			{
				if (_msgCounter == value)
				{
					return;
				}
				_msgCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("msgIndicator")] 
		public inkWidgetReference MsgIndicator
		{
			get
			{
				if (_msgIndicator == null)
				{
					_msgIndicator = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "msgIndicator", cr2w, this);
				}
				return _msgIndicator;
			}
			set
			{
				if (_msgIndicator == value)
				{
					return;
				}
				_msgIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("replyAlertIcon")] 
		public inkWidgetReference ReplyAlertIcon
		{
			get
			{
				if (_replyAlertIcon == null)
				{
					_replyAlertIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "replyAlertIcon", cr2w, this);
				}
				return _replyAlertIcon;
			}
			set
			{
				if (_replyAlertIcon == value)
				{
					return;
				}
				_replyAlertIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("collapseIcon")] 
		public inkWidgetReference CollapseIcon
		{
			get
			{
				if (_collapseIcon == null)
				{
					_collapseIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "collapseIcon", cr2w, this);
				}
				return _collapseIcon;
			}
			set
			{
				if (_collapseIcon == value)
				{
					return;
				}
				_collapseIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get
			{
				if (_image == null)
				{
					_image = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "image", cr2w, this);
				}
				return _image;
			}
			set
			{
				if (_image == value)
				{
					return;
				}
				_image = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("contactData")] 
		public CHandle<ContactData> ContactData
		{
			get
			{
				if (_contactData == null)
				{
					_contactData = (CHandle<ContactData>) CR2WTypeManager.Create("handle:ContactData", "contactData", cr2w, this);
				}
				return _contactData;
			}
			set
			{
				if (_contactData == value)
				{
					return;
				}
				_contactData = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("nestedListData")] 
		public CHandle<VirutalNestedListData> NestedListData
		{
			get
			{
				if (_nestedListData == null)
				{
					_nestedListData = (CHandle<VirutalNestedListData>) CR2WTypeManager.Create("handle:VirutalNestedListData", "nestedListData", cr2w, this);
				}
				return _nestedListData;
			}
			set
			{
				if (_nestedListData == value)
				{
					return;
				}
				_nestedListData = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("type")] 
		public CEnum<MessengerContactType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<MessengerContactType>) CR2WTypeManager.Create("MessengerContactType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("activeItemSync")] 
		public wCHandle<MessengerContactSyncData> ActiveItemSync
		{
			get
			{
				if (_activeItemSync == null)
				{
					_activeItemSync = (wCHandle<MessengerContactSyncData>) CR2WTypeManager.Create("whandle:MessengerContactSyncData", "activeItemSync", cr2w, this);
				}
				return _activeItemSync;
			}
			set
			{
				if (_activeItemSync == value)
				{
					return;
				}
				_activeItemSync = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("isContactActive")] 
		public CBool IsContactActive
		{
			get
			{
				if (_isContactActive == null)
				{
					_isContactActive = (CBool) CR2WTypeManager.Create("Bool", "isContactActive", cr2w, this);
				}
				return _isContactActive;
			}
			set
			{
				if (_isContactActive == value)
				{
					return;
				}
				_isContactActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("isItemHovered")] 
		public CBool IsItemHovered
		{
			get
			{
				if (_isItemHovered == null)
				{
					_isItemHovered = (CBool) CR2WTypeManager.Create("Bool", "isItemHovered", cr2w, this);
				}
				return _isItemHovered;
			}
			set
			{
				if (_isItemHovered == value)
				{
					return;
				}
				_isItemHovered = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("isItemToggled")] 
		public CBool IsItemToggled
		{
			get
			{
				if (_isItemToggled == null)
				{
					_isItemToggled = (CBool) CR2WTypeManager.Create("Bool", "isItemToggled", cr2w, this);
				}
				return _isItemToggled;
			}
			set
			{
				if (_isItemToggled == value)
				{
					return;
				}
				_isItemToggled = value;
				PropertySet(this);
			}
		}

		public MessengerContactItemVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
