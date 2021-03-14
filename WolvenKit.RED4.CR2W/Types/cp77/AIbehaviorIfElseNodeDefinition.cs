using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorIfElseNodeDefinition : AIbehaviorCompositeTreeNodeDefinition
	{
		private CHandle<AIbehaviorExpressionSocket> _condition;

		[Ordinal(1)] 
		[RED("condition")] 
		public CHandle<AIbehaviorExpressionSocket> Condition
		{
			get
			{
				if (_condition == null)
				{
					_condition = (CHandle<AIbehaviorExpressionSocket>) CR2WTypeManager.Create("handle:AIbehaviorExpressionSocket", "condition", cr2w, this);
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

		public AIbehaviorIfElseNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
