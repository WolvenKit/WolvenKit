using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorNaryOperatorExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CEnum<AIbehaviorNaryExpressionOperators> _operator;
		private CArray<CHandle<AIbehaviorExpressionSocket>> _operands;

		[Ordinal(0)] 
		[RED("operator")] 
		public CEnum<AIbehaviorNaryExpressionOperators> Operator
		{
			get
			{
				if (_operator == null)
				{
					_operator = (CEnum<AIbehaviorNaryExpressionOperators>) CR2WTypeManager.Create("AIbehaviorNaryExpressionOperators", "operator", cr2w, this);
				}
				return _operator;
			}
			set
			{
				if (_operator == value)
				{
					return;
				}
				_operator = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("operands")] 
		public CArray<CHandle<AIbehaviorExpressionSocket>> Operands
		{
			get
			{
				if (_operands == null)
				{
					_operands = (CArray<CHandle<AIbehaviorExpressionSocket>>) CR2WTypeManager.Create("array:handle:AIbehaviorExpressionSocket", "operands", cr2w, this);
				}
				return _operands;
			}
			set
			{
				if (_operands == value)
				{
					return;
				}
				_operands = value;
				PropertySet(this);
			}
		}

		public AIbehaviorNaryOperatorExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
