using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KeypadDeviceController : DeviceWidgetControllerBase
	{
		private wCHandle<inkTextWidget> _enteredPasswordWidget;
		private wCHandle<inkTextWidget> _passwordStatusWidget;
		private wCHandle<inkWidget> _actionButton;
		private wCHandle<inkTextWidget> _actionText;
		private CArray<CName> _passwordsList;
		private CString _cardName;
		private CBool _isPasswordKnown;
		private wCHandle<inkHorizontalPanelWidget> _row1;
		private wCHandle<inkHorizontalPanelWidget> _row2;
		private wCHandle<inkHorizontalPanelWidget> _row3;
		private wCHandle<inkHorizontalPanelWidget> _row4;

		[Ordinal(10)] 
		[RED("enteredPasswordWidget")] 
		public wCHandle<inkTextWidget> EnteredPasswordWidget
		{
			get
			{
				if (_enteredPasswordWidget == null)
				{
					_enteredPasswordWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "enteredPasswordWidget", cr2w, this);
				}
				return _enteredPasswordWidget;
			}
			set
			{
				if (_enteredPasswordWidget == value)
				{
					return;
				}
				_enteredPasswordWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("passwordStatusWidget")] 
		public wCHandle<inkTextWidget> PasswordStatusWidget
		{
			get
			{
				if (_passwordStatusWidget == null)
				{
					_passwordStatusWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "passwordStatusWidget", cr2w, this);
				}
				return _passwordStatusWidget;
			}
			set
			{
				if (_passwordStatusWidget == value)
				{
					return;
				}
				_passwordStatusWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("actionButton")] 
		public wCHandle<inkWidget> ActionButton
		{
			get
			{
				if (_actionButton == null)
				{
					_actionButton = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "actionButton", cr2w, this);
				}
				return _actionButton;
			}
			set
			{
				if (_actionButton == value)
				{
					return;
				}
				_actionButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("ActionText")] 
		public wCHandle<inkTextWidget> ActionText
		{
			get
			{
				if (_actionText == null)
				{
					_actionText = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "ActionText", cr2w, this);
				}
				return _actionText;
			}
			set
			{
				if (_actionText == value)
				{
					return;
				}
				_actionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("passwordsList")] 
		public CArray<CName> PasswordsList
		{
			get
			{
				if (_passwordsList == null)
				{
					_passwordsList = (CArray<CName>) CR2WTypeManager.Create("array:CName", "passwordsList", cr2w, this);
				}
				return _passwordsList;
			}
			set
			{
				if (_passwordsList == value)
				{
					return;
				}
				_passwordsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("cardName")] 
		public CString CardName
		{
			get
			{
				if (_cardName == null)
				{
					_cardName = (CString) CR2WTypeManager.Create("String", "cardName", cr2w, this);
				}
				return _cardName;
			}
			set
			{
				if (_cardName == value)
				{
					return;
				}
				_cardName = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("isPasswordKnown")] 
		public CBool IsPasswordKnown
		{
			get
			{
				if (_isPasswordKnown == null)
				{
					_isPasswordKnown = (CBool) CR2WTypeManager.Create("Bool", "isPasswordKnown", cr2w, this);
				}
				return _isPasswordKnown;
			}
			set
			{
				if (_isPasswordKnown == value)
				{
					return;
				}
				_isPasswordKnown = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("row1")] 
		public wCHandle<inkHorizontalPanelWidget> Row1
		{
			get
			{
				if (_row1 == null)
				{
					_row1 = (wCHandle<inkHorizontalPanelWidget>) CR2WTypeManager.Create("whandle:inkHorizontalPanelWidget", "row1", cr2w, this);
				}
				return _row1;
			}
			set
			{
				if (_row1 == value)
				{
					return;
				}
				_row1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("row2")] 
		public wCHandle<inkHorizontalPanelWidget> Row2
		{
			get
			{
				if (_row2 == null)
				{
					_row2 = (wCHandle<inkHorizontalPanelWidget>) CR2WTypeManager.Create("whandle:inkHorizontalPanelWidget", "row2", cr2w, this);
				}
				return _row2;
			}
			set
			{
				if (_row2 == value)
				{
					return;
				}
				_row2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("row3")] 
		public wCHandle<inkHorizontalPanelWidget> Row3
		{
			get
			{
				if (_row3 == null)
				{
					_row3 = (wCHandle<inkHorizontalPanelWidget>) CR2WTypeManager.Create("whandle:inkHorizontalPanelWidget", "row3", cr2w, this);
				}
				return _row3;
			}
			set
			{
				if (_row3 == value)
				{
					return;
				}
				_row3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("row4")] 
		public wCHandle<inkHorizontalPanelWidget> Row4
		{
			get
			{
				if (_row4 == null)
				{
					_row4 = (wCHandle<inkHorizontalPanelWidget>) CR2WTypeManager.Create("whandle:inkHorizontalPanelWidget", "row4", cr2w, this);
				}
				return _row4;
			}
			set
			{
				if (_row4 == value)
				{
					return;
				}
				_row4 = value;
				PropertySet(this);
			}
		}

		public KeypadDeviceController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
