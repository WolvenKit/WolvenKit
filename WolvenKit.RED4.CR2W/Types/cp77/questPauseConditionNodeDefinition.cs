using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPauseConditionNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CHandle<questIBaseCondition> _condition;

		[Ordinal(2)] 
		[RED("condition")] 
		public CHandle<questIBaseCondition> Condition
		{
			get
			{
				if (_condition == null)
				{
					_condition = (CHandle<questIBaseCondition>) CR2WTypeManager.Create("handle:questIBaseCondition", "condition", cr2w, this);
				}
				return _condition;
			}
			set
			{
				if (_condition == value)
				{
					return;
				}
				_condition = value;
				PropertySet(this);
			}
		}

		public questPauseConditionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
