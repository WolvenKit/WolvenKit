using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCPredicateDefinition : CVariable
	{
		private CHandle<gameinteractionsIPredicateType> _predicateType;
		private CEnum<gameinteractionsEBinaryOperator> _binaryOperator;
		private CHandle<gameinteractionsCFunctorDefinition> _functor1DataDefinition;
		private CHandle<gameinteractionsCFunctorDefinition> _functor2DataDefinition;

		[Ordinal(0)] 
		[RED("predicateType")] 
		public CHandle<gameinteractionsIPredicateType> PredicateType
		{
			get
			{
				if (_predicateType == null)
				{
					_predicateType = (CHandle<gameinteractionsIPredicateType>) CR2WTypeManager.Create("handle:gameinteractionsIPredicateType", "predicateType", cr2w, this);
				}
				return _predicateType;
			}
			set
			{
				if (_predicateType == value)
				{
					return;
				}
				_predicateType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("binaryOperator")] 
		public CEnum<gameinteractionsEBinaryOperator> BinaryOperator
		{
			get
			{
				if (_binaryOperator == null)
				{
					_binaryOperator = (CEnum<gameinteractionsEBinaryOperator>) CR2WTypeManager.Create("gameinteractionsEBinaryOperator", "binaryOperator", cr2w, this);
				}
				return _binaryOperator;
			}
			set
			{
				if (_binaryOperator == value)
				{
					return;
				}
				_binaryOperator = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("functor1DataDefinition")] 
		public CHandle<gameinteractionsCFunctorDefinition> Functor1DataDefinition
		{
			get
			{
				if (_functor1DataDefinition == null)
				{
					_functor1DataDefinition = (CHandle<gameinteractionsCFunctorDefinition>) CR2WTypeManager.Create("handle:gameinteractionsCFunctorDefinition", "functor1DataDefinition", cr2w, this);
				}
				return _functor1DataDefinition;
			}
			set
			{
				if (_functor1DataDefinition == value)
				{
					return;
				}
				_functor1DataDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("functor2DataDefinition")] 
		public CHandle<gameinteractionsCFunctorDefinition> Functor2DataDefinition
		{
			get
			{
				if (_functor2DataDefinition == null)
				{
					_functor2DataDefinition = (CHandle<gameinteractionsCFunctorDefinition>) CR2WTypeManager.Create("handle:gameinteractionsCFunctorDefinition", "functor2DataDefinition", cr2w, this);
				}
				return _functor2DataDefinition;
			}
			set
			{
				if (_functor2DataDefinition == value)
				{
					return;
				}
				_functor2DataDefinition = value;
				PropertySet(this);
			}
		}

		public gameinteractionsCPredicateDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
