using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindLaneTaskDefinition : AIbehaviorTaskDefinition
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

		public AIbehaviorFindLaneTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
