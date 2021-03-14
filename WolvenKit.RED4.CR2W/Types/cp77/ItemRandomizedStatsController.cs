using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemRandomizedStatsController : inkWidgetLogicController
	{
		private inkTextWidgetReference _statName;

		[Ordinal(1)] 
		[RED("statName")] 
		public inkTextWidgetReference StatName
		{
			get
			{
				if (_statName == null)
				{
					_statName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "statName", cr2w, this);
				}
				return _statName;
			}
			set
			{
				if (_statName == value)
				{
					return;
				}
				_statName = value;
				PropertySet(this);
			}
		}

		public ItemRandomizedStatsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
