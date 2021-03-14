using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkToggleController : inkButtonController
	{
		private inkToggleChangedCallback _toggleChanged;
		private CBool _isToggled;
		private CBool _autoToggleOnInput;

		[Ordinal(10)] 
		[RED("ToggleChanged")] 
		public inkToggleChangedCallback ToggleChanged
		{
			get
			{
				if (_toggleChanged == null)
				{
					_toggleChanged = (inkToggleChangedCallback) CR2WTypeManager.Create("inkToggleChangedCallback", "ToggleChanged", cr2w, this);
				}
				return _toggleChanged;
			}
			set
			{
				if (_toggleChanged == value)
				{
					return;
				}
				_toggleChanged = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isToggled")] 
		public CBool IsToggled
		{
			get
			{
				if (_isToggled == null)
				{
					_isToggled = (CBool) CR2WTypeManager.Create("Bool", "isToggled", cr2w, this);
				}
				return _isToggled;
			}
			set
			{
				if (_isToggled == value)
				{
					return;
				}
				_isToggled = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("autoToggleOnInput")] 
		public CBool AutoToggleOnInput
		{
			get
			{
				if (_autoToggleOnInput == null)
				{
					_autoToggleOnInput = (CBool) CR2WTypeManager.Create("Bool", "autoToggleOnInput", cr2w, this);
				}
				return _autoToggleOnInput;
			}
			set
			{
				if (_autoToggleOnInput == value)
				{
					return;
				}
				_autoToggleOnInput = value;
				PropertySet(this);
			}
		}

		public inkToggleController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
