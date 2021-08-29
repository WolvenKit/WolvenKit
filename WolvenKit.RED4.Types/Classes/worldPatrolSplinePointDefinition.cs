using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPatrolSplinePointDefinition : ISerializable
	{
		private CEnum<worldPatrolSplinePointTypes> _pointType;
		private NodeRef _node;
		private gameEntityReference _target;

		[Ordinal(0)] 
		[RED("pointType")] 
		public CEnum<worldPatrolSplinePointTypes> PointType
		{
			get => GetProperty(ref _pointType);
			set => SetProperty(ref _pointType, value);
		}

		[Ordinal(1)] 
		[RED("node")] 
		public NodeRef Node
		{
			get => GetProperty(ref _node);
			set => SetProperty(ref _node, value);
		}

		[Ordinal(2)] 
		[RED("target")] 
		public gameEntityReference Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}
	}
}
