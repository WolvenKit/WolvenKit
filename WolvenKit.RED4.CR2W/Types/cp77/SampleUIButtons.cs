using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SampleUIButtons : inkWidgetLogicController
	{
		private inkWidgetReference _button;
		private inkWidgetReference _toggle1;
		private inkWidgetReference _toggle2;
		private inkWidgetReference _toggle3;
		private inkWidgetReference _radioGroup;
		private inkTextWidgetReference _text;

		[Ordinal(1)] 
		[RED("Button")] 
		public inkWidgetReference Button
		{
			get
			{
				if (_button == null)
				{
					_button = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "Button", cr2w, this);
				}
				return _button;
			}
			set
			{
				if (_button == value)
				{
					return;
				}
				_button = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Toggle1")] 
		public inkWidgetReference Toggle1
		{
			get
			{
				if (_toggle1 == null)
				{
					_toggle1 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "Toggle1", cr2w, this);
				}
				return _toggle1;
			}
			set
			{
				if (_toggle1 == value)
				{
					return;
				}
				_toggle1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Toggle2")] 
		public inkWidgetReference Toggle2
		{
			get
			{
				if (_toggle2 == null)
				{
					_toggle2 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "Toggle2", cr2w, this);
				}
				return _toggle2;
			}
			set
			{
				if (_toggle2 == value)
				{
					return;
				}
				_toggle2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("Toggle3")] 
		public inkWidgetReference Toggle3
		{
			get
			{
				if (_toggle3 == null)
				{
					_toggle3 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "Toggle3", cr2w, this);
				}
				return _toggle3;
			}
			set
			{
				if (_toggle3 == value)
				{
					return;
				}
				_toggle3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("RadioGroup")] 
		public inkWidgetReference RadioGroup
		{
			get
			{
				if (_radioGroup == null)
				{
					_radioGroup = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "RadioGroup", cr2w, this);
				}
				return _radioGroup;
			}
			set
			{
				if (_radioGroup == value)
				{
					return;
				}
				_radioGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("Text")] 
		public inkTextWidgetReference Text
		{
			get
			{
				if (_text == null)
				{
					_text = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "Text", cr2w, this);
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

		public SampleUIButtons(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
