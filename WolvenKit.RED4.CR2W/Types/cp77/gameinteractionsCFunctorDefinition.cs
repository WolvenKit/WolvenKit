using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCFunctorDefinition : gameinteractionsIFunctorDefinition
	{
		private gameinteractionsCPredicateDefinition _predicate;
		private CEnum<gameinteractionsEUnaryOperator> _unaryOperator;

		[Ordinal(0)] 
		[RED("predicate")] 
		public gameinteractionsCPredicateDefinition Predicate
		{
			get
			{
				if (_predicate == null)
				{
					_predicate = (gameinteractionsCPredicateDefinition) CR2WTypeManager.Create("gameinteractionsCPredicateDefinition", "predicate", cr2w, this);
				}
				return _predicate;
			}
			set
			{
				if (_predicate == value)
				{
					return;
				}
				_predicate = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("unaryOperator")] 
		public CEnum<gameinteractionsEUnaryOperator> UnaryOperator
		{
			get
			{
				if (_unaryOperator == null)
				{
					_unaryOperator = (CEnum<gameinteractionsEUnaryOperator>) CR2WTypeManager.Create("gameinteractionsEUnaryOperator", "unaryOperator", cr2w, this);
				}
				return _unaryOperator;
			}
			set
			{
				if (_unaryOperator == value)
				{
					return;
				}
				_unaryOperator = value;
				PropertySet(this);
			}
		}

		public gameinteractionsCFunctorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
