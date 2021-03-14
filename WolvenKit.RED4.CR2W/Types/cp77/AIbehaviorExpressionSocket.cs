using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorExpressionSocket : ISerializable
	{
		private AIbehaviorTypeRef _typeHint;
		private CHandle<AIbehaviorPassiveExpressionDefinition> _expression;

		[Ordinal(0)] 
		[RED("typeHint")] 
		public AIbehaviorTypeRef TypeHint
		{
			get
			{
				if (_typeHint == null)
				{
					_typeHint = (AIbehaviorTypeRef) CR2WTypeManager.Create("AIbehaviorTypeRef", "typeHint", cr2w, this);
				}
				return _typeHint;
			}
			set
			{
				if (_typeHint == value)
				{
					return;
				}
				_typeHint = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("expression")] 
		public CHandle<AIbehaviorPassiveExpressionDefinition> Expression
		{
			get
			{
				if (_expression == null)
				{
					_expression = (CHandle<AIbehaviorPassiveExpressionDefinition>) CR2WTypeManager.Create("handle:AIbehaviorPassiveExpressionDefinition", "expression", cr2w, this);
				}
				return _expression;
			}
			set
			{
				if (_expression == value)
				{
					return;
				}
				_expression = value;
				PropertySet(this);
			}
		}

		public AIbehaviorExpressionSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
