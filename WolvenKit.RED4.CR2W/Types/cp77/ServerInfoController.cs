using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ServerInfoController : inkListItemController
	{
		private wCHandle<inkListController> _settingsListCtrl;
		private wCHandle<inkTextWidget> _number;
		private CName _numberPath;
		private wCHandle<inkTextWidget> _kind;
		private CName _kindPath;
		private wCHandle<inkTextWidget> _hostname;
		private CName _hostnamePath;
		private wCHandle<inkTextWidget> _address;
		private CName _addressPath;
		private wCHandle<inkTextWidget> _worldDescription;
		private CName _worldDescriptionPath;
		private wCHandle<inkImageWidget> _background;
		private CColor _c_selectionColor;
		private HDRColor _c_initialColor;
		private HDRColor _c_markColor;
		private CBool _marked;

		[Ordinal(16)] 
		[RED("settingsListCtrl")] 
		public wCHandle<inkListController> SettingsListCtrl
		{
			get
			{
				if (_settingsListCtrl == null)
				{
					_settingsListCtrl = (wCHandle<inkListController>) CR2WTypeManager.Create("whandle:inkListController", "settingsListCtrl", cr2w, this);
				}
				return _settingsListCtrl;
			}
			set
			{
				if (_settingsListCtrl == value)
				{
					return;
				}
				_settingsListCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("number")] 
		public wCHandle<inkTextWidget> Number
		{
			get
			{
				if (_number == null)
				{
					_number = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "number", cr2w, this);
				}
				return _number;
			}
			set
			{
				if (_number == value)
				{
					return;
				}
				_number = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("numberPath")] 
		public CName NumberPath
		{
			get
			{
				if (_numberPath == null)
				{
					_numberPath = (CName) CR2WTypeManager.Create("CName", "numberPath", cr2w, this);
				}
				return _numberPath;
			}
			set
			{
				if (_numberPath == value)
				{
					return;
				}
				_numberPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("kind")] 
		public wCHandle<inkTextWidget> Kind
		{
			get
			{
				if (_kind == null)
				{
					_kind = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "kind", cr2w, this);
				}
				return _kind;
			}
			set
			{
				if (_kind == value)
				{
					return;
				}
				_kind = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("kindPath")] 
		public CName KindPath
		{
			get
			{
				if (_kindPath == null)
				{
					_kindPath = (CName) CR2WTypeManager.Create("CName", "kindPath", cr2w, this);
				}
				return _kindPath;
			}
			set
			{
				if (_kindPath == value)
				{
					return;
				}
				_kindPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("hostname")] 
		public wCHandle<inkTextWidget> Hostname
		{
			get
			{
				if (_hostname == null)
				{
					_hostname = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "hostname", cr2w, this);
				}
				return _hostname;
			}
			set
			{
				if (_hostname == value)
				{
					return;
				}
				_hostname = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("hostnamePath")] 
		public CName HostnamePath
		{
			get
			{
				if (_hostnamePath == null)
				{
					_hostnamePath = (CName) CR2WTypeManager.Create("CName", "hostnamePath", cr2w, this);
				}
				return _hostnamePath;
			}
			set
			{
				if (_hostnamePath == value)
				{
					return;
				}
				_hostnamePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("address")] 
		public wCHandle<inkTextWidget> Address
		{
			get
			{
				if (_address == null)
				{
					_address = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "address", cr2w, this);
				}
				return _address;
			}
			set
			{
				if (_address == value)
				{
					return;
				}
				_address = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("addressPath")] 
		public CName AddressPath
		{
			get
			{
				if (_addressPath == null)
				{
					_addressPath = (CName) CR2WTypeManager.Create("CName", "addressPath", cr2w, this);
				}
				return _addressPath;
			}
			set
			{
				if (_addressPath == value)
				{
					return;
				}
				_addressPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("worldDescription")] 
		public wCHandle<inkTextWidget> WorldDescription
		{
			get
			{
				if (_worldDescription == null)
				{
					_worldDescription = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "worldDescription", cr2w, this);
				}
				return _worldDescription;
			}
			set
			{
				if (_worldDescription == value)
				{
					return;
				}
				_worldDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("worldDescriptionPath")] 
		public CName WorldDescriptionPath
		{
			get
			{
				if (_worldDescriptionPath == null)
				{
					_worldDescriptionPath = (CName) CR2WTypeManager.Create("CName", "worldDescriptionPath", cr2w, this);
				}
				return _worldDescriptionPath;
			}
			set
			{
				if (_worldDescriptionPath == value)
				{
					return;
				}
				_worldDescriptionPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("background")] 
		public wCHandle<inkImageWidget> Background
		{
			get
			{
				if (_background == null)
				{
					_background = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "background", cr2w, this);
				}
				return _background;
			}
			set
			{
				if (_background == value)
				{
					return;
				}
				_background = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("c_selectionColor")] 
		public CColor C_selectionColor
		{
			get
			{
				if (_c_selectionColor == null)
				{
					_c_selectionColor = (CColor) CR2WTypeManager.Create("Color", "c_selectionColor", cr2w, this);
				}
				return _c_selectionColor;
			}
			set
			{
				if (_c_selectionColor == value)
				{
					return;
				}
				_c_selectionColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("c_initialColor")] 
		public HDRColor C_initialColor
		{
			get
			{
				if (_c_initialColor == null)
				{
					_c_initialColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "c_initialColor", cr2w, this);
				}
				return _c_initialColor;
			}
			set
			{
				if (_c_initialColor == value)
				{
					return;
				}
				_c_initialColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("c_markColor")] 
		public HDRColor C_markColor
		{
			get
			{
				if (_c_markColor == null)
				{
					_c_markColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "c_markColor", cr2w, this);
				}
				return _c_markColor;
			}
			set
			{
				if (_c_markColor == value)
				{
					return;
				}
				_c_markColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("marked")] 
		public CBool Marked
		{
			get
			{
				if (_marked == null)
				{
					_marked = (CBool) CR2WTypeManager.Create("Bool", "marked", cr2w, this);
				}
				return _marked;
			}
			set
			{
				if (_marked == value)
				{
					return;
				}
				_marked = value;
				PropertySet(this);
			}
		}

		public ServerInfoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
