using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkButtonController : inkWidgetLogicController
	{
		private inkButtonClickCallback _buttonClick;
		private inkButtonHoldCompleteCallback _buttonHoldComplete;
		private inkButtonStateChangeCallback _buttonStateChanged;
		private inkButtonSelectionCallback _buttonSelectionChanged;
		private inkButtonProgressChangedCallback _buttonHoldProgressChanged;
		private CBool _canHold;
		private CBool _selectable;
		private CBool _selected;
		private CBool _autoUpdateWidgetState;

		[Ordinal(1)] 
		[RED("ButtonClick")] 
		public inkButtonClickCallback ButtonClick
		{
			get
			{
				if (_buttonClick == null)
				{
					_buttonClick = (inkButtonClickCallback) CR2WTypeManager.Create("inkButtonClickCallback", "ButtonClick", cr2w, this);
				}
				return _buttonClick;
			}
			set
			{
				if (_buttonClick == value)
				{
					return;
				}
				_buttonClick = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ButtonHoldComplete")] 
		public inkButtonHoldCompleteCallback ButtonHoldComplete
		{
			get
			{
				if (_buttonHoldComplete == null)
				{
					_buttonHoldComplete = (inkButtonHoldCompleteCallback) CR2WTypeManager.Create("inkButtonHoldCompleteCallback", "ButtonHoldComplete", cr2w, this);
				}
				return _buttonHoldComplete;
			}
			set
			{
				if (_buttonHoldComplete == value)
				{
					return;
				}
				_buttonHoldComplete = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ButtonStateChanged")] 
		public inkButtonStateChangeCallback ButtonStateChanged
		{
			get
			{
				if (_buttonStateChanged == null)
				{
					_buttonStateChanged = (inkButtonStateChangeCallback) CR2WTypeManager.Create("inkButtonStateChangeCallback", "ButtonStateChanged", cr2w, this);
				}
				return _buttonStateChanged;
			}
			set
			{
				if (_buttonStateChanged == value)
				{
					return;
				}
				_buttonStateChanged = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ButtonSelectionChanged")] 
		public inkButtonSelectionCallback ButtonSelectionChanged
		{
			get
			{
				if (_buttonSelectionChanged == null)
				{
					_buttonSelectionChanged = (inkButtonSelectionCallback) CR2WTypeManager.Create("inkButtonSelectionCallback", "ButtonSelectionChanged", cr2w, this);
				}
				return _buttonSelectionChanged;
			}
			set
			{
				if (_buttonSelectionChanged == value)
				{
					return;
				}
				_buttonSelectionChanged = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ButtonHoldProgressChanged")] 
		public inkButtonProgressChangedCallback ButtonHoldProgressChanged
		{
			get
			{
				if (_buttonHoldProgressChanged == null)
				{
					_buttonHoldProgressChanged = (inkButtonProgressChangedCallback) CR2WTypeManager.Create("inkButtonProgressChangedCallback", "ButtonHoldProgressChanged", cr2w, this);
				}
				return _buttonHoldProgressChanged;
			}
			set
			{
				if (_buttonHoldProgressChanged == value)
				{
					return;
				}
				_buttonHoldProgressChanged = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("canHold")] 
		public CBool CanHold
		{
			get
			{
				if (_canHold == null)
				{
					_canHold = (CBool) CR2WTypeManager.Create("Bool", "canHold", cr2w, this);
				}
				return _canHold;
			}
			set
			{
				if (_canHold == value)
				{
					return;
				}
				_canHold = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("selectable")] 
		public CBool Selectable
		{
			get
			{
				if (_selectable == null)
				{
					_selectable = (CBool) CR2WTypeManager.Create("Bool", "selectable", cr2w, this);
				}
				return _selectable;
			}
			set
			{
				if (_selectable == value)
				{
					return;
				}
				_selectable = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("selected")] 
		public CBool Selected
		{
			get
			{
				if (_selected == null)
				{
					_selected = (CBool) CR2WTypeManager.Create("Bool", "selected", cr2w, this);
				}
				return _selected;
			}
			set
			{
				if (_selected == value)
				{
					return;
				}
				_selected = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("autoUpdateWidgetState")] 
		public CBool AutoUpdateWidgetState
		{
			get
			{
				if (_autoUpdateWidgetState == null)
				{
					_autoUpdateWidgetState = (CBool) CR2WTypeManager.Create("Bool", "autoUpdateWidgetState", cr2w, this);
				}
				return _autoUpdateWidgetState;
			}
			set
			{
				if (_autoUpdateWidgetState == value)
				{
					return;
				}
				_autoUpdateWidgetState = value;
				PropertySet(this);
			}
		}

		public inkButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
