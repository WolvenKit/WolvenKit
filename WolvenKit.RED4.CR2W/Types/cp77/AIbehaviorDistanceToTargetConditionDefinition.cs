using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDistanceToTargetConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _distance;
		private CEnum<EComparisonType> _comparisonOperator;

		[Ordinal(1)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("distance")] 
		public CHandle<AIArgumentMapping> Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("comparisonOperator")] 
		public CEnum<EComparisonType> ComparisonOperator
		{
			get
			{
				if (_comparisonOperator == null)
				{
					_comparisonOperator = (CEnum<EComparisonType>) CR2WTypeManager.Create("EComparisonType", "comparisonOperator", cr2w, this);
				}
				return _comparisonOperator;
			}
			set
			{
				if (_comparisonOperator == value)
				{
					return;
				}
				_comparisonOperator = value;
				PropertySet(this);
			}
		}

		public AIbehaviorDistanceToTargetConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
