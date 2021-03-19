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

		public scnCheckPlayerTargetNodeDistanceReturnConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
