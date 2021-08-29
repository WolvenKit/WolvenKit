using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldPatrolSplineNode : worldSplineNode
	{
		private CArray<CHandle<worldPatrolSplinePointDefinition>> _patrolPointDefs;
		private CArray<NodeRef> _patrolPoints;
		private CArray<CHandle<worldTrafficSpotDefinition>> _spots;

		[Ordinal(9)] 
		[RED("patrolPointDefs")] 
		public CArray<CHandle<worldPatrolSplinePointDefinition>> PatrolPointDefs
		{
			get => GetProperty(ref _patrolPointDefs);
			set => SetProperty(ref _patrolPointDefs, value);
		}

		[Ordinal(10)] 
		[RED("patrolPoints")] 
		public CArray<NodeRef> PatrolPoints
		{
			get => GetProperty(ref _patrolPoints);
			set => SetProperty(ref _patrolPoints, value);
		}

		[Ordinal(11)] 
		[RED("spots")] 
		public CArray<CHandle<worldTrafficSpotDefinition>> Spots
		{
			get => GetProperty(ref _spots);
			set => SetProperty(ref _spots, value);
		}
	}
}
