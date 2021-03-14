using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiShowCustomTooltipEvent : redEvent
	{
		private CString _text;
		private CString _inputAction;

		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (CString) CR2WTypeManager.Create("String", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("inputAction")] 
		public CString InputAction
		{
			get
			{
				if (_inputAction == null)
				{
					_inputAction = (CString) CR2WTypeManager.Create("String", "inputAction", cr2w, this);
				}
				return _inputAction;
			}
			set
			{
				if (_inputAction == value)
				{
					return;
				}
				_inputAction = value;
				PropertySet(this);
			}
		}

		public gameuiShowCustomTooltipEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
