using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksPointsDisplayController : inkWidgetLogicController
	{
		private inkTextWidgetReference _desc1Text;
		private inkTextWidgetReference _value1Text;
		private inkImageWidgetReference _icon1;
		private inkTextWidgetReference _desc2Text;
		private inkTextWidgetReference _value2Text;
		private inkImageWidgetReference _icon2;

		[Ordinal(1)] 
		[RED("desc1Text")] 
		public inkTextWidgetReference Desc1Text
		{
			get
			{
				if (_desc1Text == null)
				{
					_desc1Text = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "desc1Text", cr2w, this);
				}
				return _desc1Text;
			}
			set
			{
				if (_desc1Text == value)
				{
					return;
				}
				_desc1Text = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("value1Text")] 
		public inkTextWidgetReference Value1Text
		{
			get
			{
				if (_value1Text == null)
				{
					_value1Text = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "value1Text", cr2w, this);
				}
				return _value1Text;
			}
			set
			{
				if (_value1Text == value)
				{
					return;
				}
				_value1Text = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("icon1")] 
		public inkImageWidgetReference Icon1
		{
			get
			{
				if (_icon1 == null)
				{
					_icon1 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "icon1", cr2w, this);
				}
				return _icon1;
			}
			set
			{
				if (_icon1 == value)
				{
					return;
				}
				_icon1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("desc2Text")] 
		public inkTextWidgetReference Desc2Text
		{
			get
			{
				if (_desc2Text == null)
				{
					_desc2Text = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "desc2Text", cr2w, this);
				}
				return _desc2Text;
			}
			set
			{
				if (_desc2Text == value)
				{
					return;
				}
				_desc2Text = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("value2Text")] 
		public inkTextWidgetReference Value2Text
		{
			get
			{
				if (_value2Text == null)
				{
					_value2Text = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "value2Text", cr2w, this);
				}
				return _value2Text;
			}
			set
			{
				if (_value2Text == value)
				{
					return;
				}
				_value2Text = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("icon2")] 
		public inkImageWidgetReference Icon2
		{
			get
			{
				if (_icon2 == null)
				{
					_icon2 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "icon2", cr2w, this);
				}
				return _icon2;
			}
			set
			{
				if (_icon2 == value)
				{
					return;
				}
				_icon2 = value;
				PropertySet(this);
			}
		}

		public PerksPointsDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
