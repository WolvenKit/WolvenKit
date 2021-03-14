using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatisticDifferenceBarController : inkWidgetLogicController
	{
		private inkWidgetReference _filled;
		private inkWidgetReference _difference;
		private inkWidgetReference _empty;

		[Ordinal(1)] 
		[RED("filled")] 
		public inkWidgetReference Filled
		{
			get
			{
				if (_filled == null)
				{
					_filled = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "filled", cr2w, this);
				}
				return _filled;
			}
			set
			{
				if (_filled == value)
				{
					return;
				}
				_filled = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("difference")] 
		public inkWidgetReference Difference
		{
			get
			{
				if (_difference == null)
				{
					_difference = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "difference", cr2w, this);
				}
				return _difference;
			}
			set
			{
				if (_difference == value)
				{
					return;
				}
				_difference = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("empty")] 
		public inkWidgetReference Empty
		{
			get
			{
				if (_empty == null)
				{
					_empty = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "empty", cr2w, this);
				}
				return _empty;
			}
			set
			{
				if (_empty == value)
				{
					return;
				}
				_empty = value;
				PropertySet(this);
			}
		}

		public StatisticDifferenceBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
