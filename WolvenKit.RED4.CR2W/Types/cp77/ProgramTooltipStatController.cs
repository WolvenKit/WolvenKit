using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgramTooltipStatController : inkWidgetLogicController
	{
		private inkImageWidgetReference _arrow;
		private inkTextWidgetReference _value;
		private inkTextWidgetReference _diffValue;

		[Ordinal(1)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get
			{
				if (_arrow == null)
				{
					_arrow = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "arrow", cr2w, this);
				}
				return _arrow;
			}
			set
			{
				if (_arrow == value)
				{
					return;
				}
				_arrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get
			{
				if (_value == null)
				{
					_value = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("diffValue")] 
		public inkTextWidgetReference DiffValue
		{
			get
			{
				if (_diffValue == null)
				{
					_diffValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "diffValue", cr2w, this);
				}
				return _diffValue;
			}
			set
			{
				if (_diffValue == value)
				{
					return;
				}
				_diffValue = value;
				PropertySet(this);
			}
		}

		public ProgramTooltipStatController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
