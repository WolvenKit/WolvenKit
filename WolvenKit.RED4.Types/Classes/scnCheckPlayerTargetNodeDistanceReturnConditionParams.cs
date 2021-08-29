using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCheckPlayerTargetNodeDistanceReturnConditionParams : RedBaseClass
	{
		private CFloat _distance;
		private CEnum<EComparisonType> _comparisonType;
		private NodeRef _targetNode;

		[Ordinal(0)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(1)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		[Ordinal(2)] 
		[RED("targetNode")] 
		public NodeRef TargetNode
		{
			get => GetProperty(ref _targetNode);
			set => SetProperty(ref _targetNode, value);
		}
	}
}
