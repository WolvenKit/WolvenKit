using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsDetailListController : inkWidgetLogicController
	{
		private inkTextWidgetReference _statLabelRef;
		private inkCompoundWidgetReference _statsList;

		[Ordinal(1)] 
		[RED("StatLabelRef")] 
		public inkTextWidgetReference StatLabelRef
		{
			get
			{
				if (_statLabelRef == null)
				{
					_statLabelRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "StatLabelRef", cr2w, this);
				}
				return _statLabelRef;
			}
			set
			{
				if (_statLabelRef == value)
				{
					return;
				}
				_statLabelRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("statsList")] 
		public inkCompoundWidgetReference StatsList
		{
			get
			{
				if (_statsList == null)
				{
					_statsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "statsList", cr2w, this);
				}
				return _statsList;
			}
			set
			{
				if (_statsList == value)
				{
					return;
				}
				_statsList = value;
				PropertySet(this);
			}
		}

		public StatsDetailListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
