using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPatrolSplineNode : worldSplineNode
	{
		[Ordinal(9)] 
		[RED("patrolPointDefs")] 
		public CArray<CHandle<worldPatrolSplinePointDefinition>> PatrolPointDefs
		{
			get => GetPropertyValue<CArray<CHandle<worldPatrolSplinePointDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<worldPatrolSplinePointDefinition>>>(value);
		}

		[Ordinal(10)] 
		[RED("patrolPoints")] 
		public CArray<NodeRef> PatrolPoints
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(11)] 
		[RED("spots")] 
		public CArray<CHandle<worldTrafficSpotDefinition>> Spots
		{
			get => GetPropertyValue<CArray<CHandle<worldTrafficSpotDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<worldTrafficSpotDefinition>>>(value);
		}

		public worldPatrolSplineNode()
		{
			PatrolPointDefs = new();
			PatrolPoints = new();
			Spots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
