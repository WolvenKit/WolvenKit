using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSystemVariableExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CEnum<AIbehaviorSystemVariableExpressionTypes> _variable;

		[Ordinal(0)] 
		[RED("variable")] 
		public CEnum<AIbehaviorSystemVariableExpressionTypes> Variable
		{
			get
			{
				if (_variable == null)
				{
					_variable = (CEnum<AIbehaviorSystemVariableExpressionTypes>) CR2WTypeManager.Create("AIbehaviorSystemVariableExpressionTypes", "variable", cr2w, this);
				}
				return _variable;
			}
			set
			{
				if (_variable == value)
				{
					return;
				}
				_variable = value;
				PropertySet(this);
			}
		}

		public AIbehaviorSystemVariableExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
