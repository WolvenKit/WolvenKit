using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorComparisonExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CHandle<AIbehaviorExpressionSocket> _leftHandSide;
		private CEnum<EComparisonType> _operator;
		private CHandle<AIbehaviorExpressionSocket> _rightHandSide;

		[Ordinal(0)] 
		[RED("leftHandSide")] 
		public CHandle<AIbehaviorExpressionSocket> LeftHandSide
		{
			get
			{
				if (_leftHandSide == null)
				{
					_leftHandSide = (CHandle<AIbehaviorExpressionSocket>) CR2WTypeManager.Create("handle:AIbehaviorExpressionSocket", "leftHandSide", cr2w, this);
				}
				return _leftHandSide;
			}
			set
			{
				if (_leftHandSide == value)
				{
					return;
				}
				_leftHandSide = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("operator")] 
		public CEnum<EComparisonType> Operator
		{
			get
			{
				if (_operator == null)
				{
					_operator = (CEnum<EComparisonType>) CR2WTypeManager.Create("EComparisonType", "operator", cr2w, this);
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

		[Ordinal(2)] 
		[RED("rightHandSide")] 
		public CHandle<AIbehaviorExpressionSocket> RightHandSide
		{
			get
			{
				if (_rightHandSide == null)
				{
					_rightHandSide = (CHandle<AIbehaviorExpressionSocket>) CR2WTypeManager.Create("handle:AIbehaviorExpressionSocket", "rightHandSide", cr2w, this);
				}
				return _rightHandSide;
			}
			set
			{
				if (_rightHandSide == value)
				{
					return;
				}
				_rightHandSide = value;
				PropertySet(this);
			}
		}

		public AIbehaviorComparisonExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
