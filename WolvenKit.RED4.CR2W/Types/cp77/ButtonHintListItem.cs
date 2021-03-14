using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ButtonHintListItem : inkWidgetLogicController
	{
		private inkWidgetReference _inputDisplay;
		private inkTextWidgetReference _label;
		private wCHandle<inkInputDisplayController> _buttonHint;
		private CName _actionName;

		[Ordinal(1)] 
		[RED("inputDisplay")] 
		public inkWidgetReference InputDisplay
		{
			get
			{
				if (_inputDisplay == null)
				{
					_inputDisplay = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "inputDisplay", cr2w, this);
				}
				return _inputDisplay;
			}
			set
			{
				if (_inputDisplay == value)
				{
					return;
				}
				_inputDisplay = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("buttonHint")] 
		public wCHandle<inkInputDisplayController> ButtonHint
		{
			get
			{
				if (_buttonHint == null)
				{
					_buttonHint = (wCHandle<inkInputDisplayController>) CR2WTypeManager.Create("whandle:inkInputDisplayController", "buttonHint", cr2w, this);
				}
				return _buttonHint;
			}
			set
			{
				if (_buttonHint == value)
				{
					return;
				}
				_buttonHint = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get
			{
				if (_actionName == null)
				{
					_actionName = (CName) CR2WTypeManager.Create("CName", "actionName", cr2w, this);
				}
				return _actionName;
			}
			set
			{
				if (_actionName == value)
				{
					return;
				}
				_actionName = value;
				PropertySet(this);
			}
		}

		public ButtonHintListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
