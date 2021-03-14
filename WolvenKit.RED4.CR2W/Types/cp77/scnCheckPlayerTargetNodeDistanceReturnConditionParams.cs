using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCheckPlayerTargetNodeDistanceReturnConditionParams : CVariable
	{
		private CFloat _distance;
		private CEnum<EComparisonType> _comparisonType;
		private NodeRef _targetNode;

		[Ordinal(0)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CFloat) CR2WTypeManager.Create("Float", "distance", cr2w, this);
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

		[Ordinal(1)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get
			{
				if (_comparisonType == null)
				{
					_comparisonType = (CEnum<EComparisonType>) CR2WTypeManager.Create("EComparisonType", "comparisonType", cr2w, this);
				}
				return _comparisonType;
			}
			set
			{
				if (_comparisonType == value)
				{
					return;
				}
				_comparisonType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetNode")] 
		public NodeRef TargetNode
		{
			get
			{
				if (_targetNode == null)
				{
					_targetNode = (NodeRef) CR2WTypeManager.Create("NodeRef", "targetNode", cr2w, this);
				}
				return _targetNode;
			}
			set
			{
				if (_targetNode == value)
				{
					return;
				}
				_targetNode = value;
				PropertySet(this);
			}
		}

		public scnCheckPlayerTargetNodeDistanceReturnConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
