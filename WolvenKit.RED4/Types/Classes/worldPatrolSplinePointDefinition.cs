using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPatrolSplinePointDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("pointType")] 
		public CEnum<worldPatrolSplinePointTypes> PointType
		{
			get => GetPropertyValue<CEnum<worldPatrolSplinePointTypes>>();
			set => SetPropertyValue<CEnum<worldPatrolSplinePointTypes>>(value);
		}

		[Ordinal(1)] 
		[RED("node")] 
		public NodeRef Node
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(2)] 
		[RED("target")] 
		public gameEntityReference Target
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public worldPatrolSplinePointDefinition()
		{
			Target = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
