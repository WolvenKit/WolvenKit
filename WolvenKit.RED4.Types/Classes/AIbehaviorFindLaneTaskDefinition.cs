using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorFindLaneTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _pointOnLane;
		private CEnum<worldFindLaneFilter> _filter;

		[Ordinal(1)] 
		[RED("pointOnLane")] 
		public CHandle<AIArgumentMapping> PointOnLane
		{
			get => GetProperty(ref _pointOnLane);
			set => SetProperty(ref _pointOnLane, value);
		}

		[Ordinal(2)] 
		[RED("filter")] 
		public CEnum<worldFindLaneFilter> Filter
		{
			get => GetProperty(ref _filter);
			set => SetProperty(ref _filter, value);
		}
	}
}
