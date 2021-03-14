using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericMessageNotification : gameuiWidgetGameController
	{
		private inkTextWidgetReference _title;
		private inkTextWidgetReference _message;
		private inkWidgetReference _buttonConfirm;
		private inkWidgetReference _buttonCancel;
		private inkWidgetReference _buttonOk;
		private inkWidgetReference _buttonYes;
		private inkWidgetReference _buttonNo;
		private inkWidgetReference _root;
		private inkWidgetReference _background;
		private inkWidgetReference _buttonHintsRoot;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CHandle<GenericMessageNotificationData> _data;
		private CBool _isNegativeHovered;
		private CBool _isPositiveHovered;
		private inkWidgetLibraryReference _libraryPath;
		private CHandle<GenericMessageNotificationCloseData> _closeData;

		[Ordinal(2)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get
			{
				if (_title == null)
				{
					_title = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("message")] 
		public inkTextWidgetReference Message
		{
			get
			{
				if (_message == null)
				{
					_message = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "message", cr2w, this);
				}
				return _message;
			}
			set
			{
				if (_message == value)
				{
					return;
				}
				_message = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("buttonConfirm")] 
		public inkWidgetReference ButtonConfirm
		{
			get
			{
				if (_buttonConfirm == null)
				{
					_buttonConfirm = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonConfirm", cr2w, this);
				}
				return _buttonConfirm;
			}
			set
			{
				if (_buttonConfirm == value)
				{
					return;
				}
				_buttonConfirm = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("buttonCancel")] 
		public inkWidgetReference ButtonCancel
		{
			get
			{
				if (_buttonCancel == null)
				{
					_buttonCancel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonCancel", cr2w, this);
				}
				return _buttonCancel;
			}
			set
			{
				if (_buttonCancel == value)
				{
					return;
				}
				_buttonCancel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("buttonOk")] 
		public inkWidgetReference ButtonOk
		{
			get
			{
				if (_buttonOk == null)
				{
					_buttonOk = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonOk", cr2w, this);
				}
				return _buttonOk;
			}
			set
			{
				if (_buttonOk == value)
				{
					return;
				}
				_buttonOk = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("buttonYes")] 
		public inkWidgetReference ButtonYes
		{
			get
			{
				if (_buttonYes == null)
				{
					_buttonYes = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonYes", cr2w, this);
				}
				return _buttonYes;
			}
			set
			{
				if (_buttonYes == value)
				{
					return;
				}
				_buttonYes = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("buttonNo")] 
		public inkWidgetReference ButtonNo
		{
			get
			{
				if (_buttonNo == null)
				{
					_buttonNo = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonNo", cr2w, this);
				}
				return _buttonNo;
			}
			set
			{
				if (_buttonNo == value)
				{
					return;
				}
				_buttonNo = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get
			{
				if (_root == null)
				{
					_root = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get
			{
				if (_background == null)
				{
					_background = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "background", cr2w, this);
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

		[Ordinal(11)] 
		[RED("buttonHintsRoot")] 
		public inkWidgetReference ButtonHintsRoot
		{
			get
			{
				if (_buttonHintsRoot == null)
				{
					_buttonHintsRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsRoot", cr2w, this);
				}
				return _buttonHintsRoot;
			}
			set
			{
				if (_buttonHintsRoot == value)
				{
					return;
				}
				_buttonHintsRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get
			{
				if (_buttonHintsController == null)
				{
					_buttonHintsController = (wCHandle<ButtonHints>) CR2WTypeManager.Create("whandle:ButtonHints", "buttonHintsController", cr2w, this);
				}
				return _buttonHintsController;
			}
			set
			{
				if (_buttonHintsController == value)
				{
					return;
				}
				_buttonHintsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("data")] 
		public CHandle<GenericMessageNotificationData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<GenericMessageNotificationData>) CR2WTypeManager.Create("handle:GenericMessageNotificationData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("isNegativeHovered")] 
		public CBool IsNegativeHovered
		{
			get
			{
				if (_isNegativeHovered == null)
				{
					_isNegativeHovered = (CBool) CR2WTypeManager.Create("Bool", "isNegativeHovered", cr2w, this);
				}
				return _isNegativeHovered;
			}
			set
			{
				if (_isNegativeHovered == value)
				{
					return;
				}
				_isNegativeHovered = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("isPositiveHovered")] 
		public CBool IsPositiveHovered
		{
			get
			{
				if (_isPositiveHovered == null)
				{
					_isPositiveHovered = (CBool) CR2WTypeManager.Create("Bool", "isPositiveHovered", cr2w, this);
				}
				return _isPositiveHovered;
			}
			set
			{
				if (_isPositiveHovered == value)
				{
					return;
				}
				_isPositiveHovered = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get
			{
				if (_libraryPath == null)
				{
					_libraryPath = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "libraryPath", cr2w, this);
				}
				return _libraryPath;
			}
			set
			{
				if (_libraryPath == value)
				{
					return;
				}
				_libraryPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("closeData")] 
		public CHandle<GenericMessageNotificationCloseData> CloseData
		{
			get
			{
				if (_closeData == null)
				{
					_closeData = (CHandle<GenericMessageNotificationCloseData>) CR2WTypeManager.Create("handle:GenericMessageNotificationCloseData", "closeData", cr2w, this);
				}
				return _closeData;
			}
			set
			{
				if (_closeData == value)
				{
					return;
				}
				_closeData = value;
				PropertySet(this);
			}
		}

		public GenericMessageNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
